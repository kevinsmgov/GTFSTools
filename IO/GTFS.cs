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
            foreach (var source in directoryInfo.GetFiles())
            {
                if (this.DataSet.Tables.Contains(source.Name))
                {
                    this.DataSet.Tables[source.Name].ReadCSV(source.OpenRead());
                }
            }
        }
        public void Read(System.IO.Compression.ZipArchive zipArchive)
        {
            foreach (var source in zipArchive.Entries)
            {
                if (this.DataSet.Tables.Contains(source.Name))
                {
                    this.DataSet.Tables[source.Name].ReadCSV(source.Open());
                }
            }
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
                if (table.Rows.Count > 0)
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
                if (table.Rows.Count > 0)
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
                var zipArchive = new System.IO.Compression.ZipArchive(fileInfo.Create(), System.IO.Compression.ZipArchiveMode.Create);
                this.Write(zipArchive);
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
