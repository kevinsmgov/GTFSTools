using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTFSTools.IO
{
    public class GTFS
    {
        public GTFS()
        {
            this.DataSet = new GTFSDataSet();
        }
        public GTFS(System.IO.Compression.ZipArchive zipArchive)
        {
            this.DataSet = new GTFSDataSet();
            foreach (var entry in zipArchive.Entries)
            {
                if(this.DataSet.Tables.Contains(entry.Name))
                {
                    this.DataSet.Tables[entry.Name].ReadCSV(entry.Open());
                }
            }
        }
        public void Write(System.IO.Compression.ZipArchive zipArchive)
        {
            foreach(System.Data.DataTable table in this.DataSet.Tables)
            {
                if (table.Rows.Count > 0)
                {
                    var entry = zipArchive.CreateEntry(table.TableName);
                    table.WriteCSV(entry.Open());
                }
            }
        }
        public GTFSDataSet DataSet { get; set; }
    }
}
