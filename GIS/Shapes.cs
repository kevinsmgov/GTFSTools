using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTFSTools.GIS
{
    public class Shapes
    {
        public GISDataSet._shapes_csvDataTable DataTable = new GISDataSet._shapes_csvDataTable();
        public Shapes()
        {

        }
        public Shapes(GTFSTools.IO.GTFSDataSet._shapes_txtDataTable _shapes_txt)
        {
            var precisionModel = new NetTopologySuite.Geometries.PrecisionModel();
            var geometryFactory = new NetTopologySuite.Geometries.GeometryFactory(precisionModel, 4326);
            foreach (var shape in _shapes_txt.GroupBy(item => item.shape_id).Select(group => new { shape_id = group.Key, shape_pts = group.OrderBy(item => item.shape_pt_sequence) }))
            {
                var coordinateList = new NetTopologySuite.Geometries.CoordinateList();
                foreach (var shape_pt in shape.shape_pts)
                {
                    var coordinate = new GeoAPI.Geometries.Coordinate(Convert.ToDouble(shape_pt.shape_pt_lon), Convert.ToDouble(shape_pt.shape_pt_lat));
                    coordinateList.Add(coordinate, true);
                }
                NetTopologySuite.Geometries.LineString linestring = geometryFactory.CreateLineString(coordinateList.ToArray()) as NetTopologySuite.Geometries.LineString;
                var _shapes_csvRow = DataTable.New_shapes_csvRow();
                _shapes_csvRow.shape_id = shape.shape_id;
                _shapes_csvRow.WKT = linestring.ToText();
                DataTable.Add_shapes_csvRow(_shapes_csvRow);
            }
        }
        public void Update(GTFSTools.IO.GTFSDataSet._shapes_txtDataTable _shapes_txt)
        {
            var precisionModel = new NetTopologySuite.Geometries.PrecisionModel();
            var geometryFactory = new NetTopologySuite.Geometries.GeometryFactory(precisionModel, 4326);
            var wktReader = new NetTopologySuite.IO.WKTReader(geometryFactory);
            _shapes_txt.Clear();
            foreach (GISDataSet._shapes_csvRow row in DataTable.Rows)
            {
                var linestring = wktReader.Read(row.WKT);
                for (var index = 0; index < linestring.Coordinates.Count(); index++)
                {
                    var coordinate = linestring.Coordinates[index];
                    var _shapes_txtRow = _shapes_txt.New_shapes_txtRow();
                    _shapes_txtRow.shape_id = row.shape_id;
                    _shapes_txtRow.shape_pt_sequence = index + 1;
                    _shapes_txtRow.shape_pt_lat = Convert.ToDecimal(coordinate.Y);
                    _shapes_txtRow.shape_pt_lon = Convert.ToDecimal(coordinate.X);
                    _shapes_txt.Add_shapes_txtRow(_shapes_txtRow);
                }
            }
        }
        public void ToSQLite(String FileName)
        {
            GTFSTools.GIS.SQLite.CreateFile(DataTable, FileName, GeometryType.LineString);
        }
        public void FromSQLite(String FileName)
        {
            GTFSTools.GIS.SQLite.ReadFile(DataTable, FileName);
        }
    }
}
