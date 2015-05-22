using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTFSTools.IO
{
    public class GTFS
    {
        protected void PopulateJunctions()
        {
            this.DataSet.blocks.Clear();
            foreach (var block_id in this.DataSet._trips_txt.GroupBy(item => item.block_id).Select(group => group.Key))
            {
                this.DataSet.blocks.AddblocksRow(block_id);
            }
            this.DataSet.paths.Clear();
            foreach (var shape_id in this.DataSet._shapes_txt.GroupBy(item => item.shape_id).Select(group => group.Key))
            {
                this.DataSet.paths.AddpathsRow(shape_id);
            }
        }
        public GTFS()
        {
            this.DataSet = new GTFSDataSet();
        }
        public GTFS(System.IO.DirectoryInfo directoryInfo)
        {
            this.DataSet = new GTFSDataSet();
            this.Read(directoryInfo);
        }
        public GTFS(System.IO.Compression.ZipArchive zipArchive)
        {
            this.DataSet = new GTFSDataSet();
            this.Read(zipArchive);
        }
        public GTFS(String path)
        {
            this.DataSet = new GTFSDataSet();
            this.Read(path);
        }
        public void Read(System.IO.DirectoryInfo directoryInfo)
        {
            this.DataSet.Tables.OfType<System.Data.DataTable>().ToList().ForEach(table => table.BeginLoadData());
            foreach (var source in directoryInfo.GetFiles())
            {
                if (this.DataSet.Tables.Contains(source.Name))
                {
                    this.DataSet.Tables[source.Name].ReadCSV(source.OpenRead());
                }
            }
            PopulateJunctions();
            this.DataSet.Tables.OfType<System.Data.DataTable>().ToList().ForEach(table => table.EndLoadData());
        }
        public void Read(System.IO.Compression.ZipArchive zipArchive)
        {
            this.DataSet.Tables.OfType<System.Data.DataTable>().ToList().ForEach(table => table.BeginLoadData());
            foreach (var source in zipArchive.Entries)
            {
                if (this.DataSet.Tables.Contains(source.Name))
                {
                    this.DataSet.Tables[source.Name].ReadCSV(source.Open());
                }
            }
            PopulateJunctions();
            this.DataSet.Tables.OfType<System.Data.DataTable>().ToList().ForEach(table => table.EndLoadData());
        }
        public void Read(String path)
        {
            if (System.IO.Path.GetExtension(path).ToLower().Equals(".zip"))
            {
                var fileInfo = new System.IO.FileInfo(path);
                if (fileInfo.Exists)
                {
                    var zipArchive = new System.IO.Compression.ZipArchive(fileInfo.OpenRead(), System.IO.Compression.ZipArchiveMode.Read);
                    this.Read(zipArchive);
                }
            }
            else
            {
                var directoryInfo = new System.IO.DirectoryInfo(path);
                if (directoryInfo.Exists)
                {
                    this.Read(directoryInfo);
                }
            }
        }
        public void Write(System.IO.DirectoryInfo directoryInfo)
        {
            if (!directoryInfo.Exists)
                directoryInfo.Create();
            foreach (System.Data.DataTable table in this.DataSet.Tables)
            {
                if (table.TableName.EndsWith(".txt") && table.Rows.Count > 0)
                {
                    using (var destination = System.IO.File.Create(System.IO.Path.Combine(directoryInfo.FullName, table.TableName)))
                    {
                        table.WriteCSV(destination);
                    }
                }
            }
        }
        public void Write(System.IO.Compression.ZipArchive zipArchive)
        {
            foreach (System.Data.DataTable table in this.DataSet.Tables)
            {
                if (table.TableName.EndsWith(".txt") && table.Rows.Count > 0)
                {
                    var destination = zipArchive.CreateEntry(table.TableName);
                    table.WriteCSV(destination.Open());
                }
            }
        }
        public void Write(String path)
        {
            if (System.IO.Path.GetExtension(path).ToLower().Equals(".zip"))
            {
                var fileInfo = new System.IO.FileInfo(path);
                using (var zipArchive = new System.IO.Compression.ZipArchive(fileInfo.Create(), System.IO.Compression.ZipArchiveMode.Create))
                {
                    this.Write(zipArchive);
                }
            }
            else
            {
                var directoryInfo = new System.IO.DirectoryInfo(path);
                this.Write(directoryInfo);
            }
        }
        public GTFSDataSet DataSet { get; set; }
    }
}
