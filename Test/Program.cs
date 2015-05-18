using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var testFile = new System.IO.FileInfo("test.zip");
            if (testFile.Exists)
            {
                var inputArchive = new System.IO.Compression.ZipArchive(testFile.OpenRead(), System.IO.Compression.ZipArchiveMode.Read);
                var gtfs = new GTFSTools.IO.GTFS(inputArchive);
                foreach (var trip in gtfs.DataSet._trips_txt)
                {
                    Console.WriteLine("{0}, {1}", trip.trip_id, trip._Getstop_times_txtRows().Count());
                    //foreach (var stop_time in trip._Getstop_times_txtRows())
                    //{
                    //    Console.WriteLine("{0}, {1}", stop_time.stop_sequence, stop_time.Isarrival_timeNull() ? (TimeSpan?)null : stop_time.arrival_time);
                    //}
                }
                using (var outputFile = System.IO.File.Create("test2.zip"))
                {
                    using (var outputArchive = new System.IO.Compression.ZipArchive(outputFile, System.IO.Compression.ZipArchiveMode.Create))
                    {
                        gtfs.Write(outputArchive);
                    }
                }
            }
        }
    }
}
