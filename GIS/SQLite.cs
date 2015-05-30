using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTFSTools.GIS
{
    public enum GeometryType
    {
        Point = 1, LineString = 2
    }
    public class SQLite
    {
        public static void CreateFile(System.Data.DataTable DataTable, String FileName, GeometryType GeometryType)
        {
            System.Data.SQLite.SQLiteConnection.CreateFile(FileName);
            using (var sqliteConnection = new System.Data.SQLite.SQLiteConnection(String.Format("Data Source={0};Version=3;", FileName)))
            {
                var createGeometryColumns = new System.Data.SQLite.SQLiteCommand("create table geometry_columns (f_table_name varchar, f_geometry_column varchar, geometry_type integer, coord_dimension integer, srid integer, geometry_format varchar)", sqliteConnection);
                var createSpatialRefSys = new System.Data.SQLite.SQLiteCommand("create table spatial_ref_sys (srid integer, auth_name text, auth_srid text, srtext text)", sqliteConnection);
                var dataTableName = System.IO.Path.GetFileNameWithoutExtension(FileName);
                var dataTableColumns = "OGC_FID integer primary key, " + String.Join(", ", DataTable.Columns.OfType<System.Data.DataColumn>().Select(item => String.Format("{0} varchar", item.ColumnName)).ToArray());
                var populateGeometryColumns = new System.Data.SQLite.SQLiteCommand(String.Format("insert into geometry_columns (f_table_name, f_geometry_column, geometry_type, coord_dimension, srid, geometry_format) values ('{0}', 'WKT', {1}, 2, 4326, 'WKT')", dataTableName, (Int32)GeometryType), sqliteConnection);
                var createDataTable = new System.Data.SQLite.SQLiteCommand(String.Format("create table {0} ({1})", dataTableName, dataTableColumns), sqliteConnection);
                sqliteConnection.Open();
                using (var transaction = sqliteConnection.BeginTransaction())
                {
                    createGeometryColumns.ExecuteNonQuery();
                    populateGeometryColumns.ExecuteNonQuery();
                    createSpatialRefSys.ExecuteNonQuery();
                    createDataTable.ExecuteNonQuery();
                    var OGC_FID = 0;
                    foreach (System.Data.DataRow row in DataTable.Rows)
                    {
                        var dataTableValues = String.Join(", ", row.ItemArray.Select(item => "'" + item.ToString() + "'"));
                        var createRow = new System.Data.SQLite.SQLiteCommand(String.Format("insert into {0} VALUES ({1}, {2})", dataTableName, OGC_FID++, dataTableValues), sqliteConnection);
                        createRow.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
                sqliteConnection.Close();
            }
        }
        public static void ReadFile(System.Data.DataTable DataTable, String FileName)
        {
            using (var sqliteConnection = new System.Data.SQLite.SQLiteConnection(String.Format("Data Source={0};Version=3;", FileName)))
            {
                var dataTableName = System.IO.Path.GetFileNameWithoutExtension(FileName);
                var readDataTable = new System.Data.SQLite.SQLiteCommand(String.Format("select * from {0}", dataTableName), sqliteConnection);
                sqliteConnection.Open();
                var adapter = new System.Data.SQLite.SQLiteDataAdapter(readDataTable.CommandText, sqliteConnection);
                var table = new System.Data.DataTable();
                adapter.Fill(table);
                DataTable.Clear();
                foreach (System.Data.DataRow row in table.Rows)
                {
                    var newRow = DataTable.NewRow();
                    foreach (System.Data.DataColumn column in DataTable.Columns)
                    {
                        newRow[column.ColumnName] = row[column.ColumnName];
                    }
                    DataTable.Rows.Add(newRow);
                }
                sqliteConnection.Close();
            }
        }
    }
}
