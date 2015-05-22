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
            var gtfs = new GTFSTools.IO.GTFS("test.zip");
            foreach (var block in gtfs.DataSet.blocks)
            {
                Console.WriteLine("{0}", block.block_id);
                foreach (var trip in block._Gettrips_txtRows().OrderBy(item => item._Getstop_times_txtRows().Where(stop_time => !stop_time.Isarrival_timeNull()).Min(stop_time => stop_time.arrival_time)))
                {
                    Console.WriteLine("\t{0}, {1}", trip.trip_id, trip._Getstop_times_txtRows().Count());
                    foreach (var stop_time in trip._Getstop_times_txtRows())
                    {
                        Console.WriteLine("\t\t{0}, {1}", stop_time.stop_sequence, stop_time.Isarrival_timeNull() ? (TimeSpan?)null : stop_time.arrival_time);
                    }
                    foreach (var path in trip.pathsRow._Getshapes_txtRows())
                    {
                        Console.WriteLine("\t\t{0}, {1}, {2}", path.shape_pt_sequence, path.shape_pt_lat, path.shape_pt_lon);
                    }
                }
            }
            //foreach (var trip in gtfs.DataSet._trips_txt)
            //{
            //    //Console.WriteLine("{0}, {1}", trip.trip_id, trip._Getstop_times_txtRows().Count());
            //    //foreach (var stop_time in trip._Getstop_times_txtRows())
            //    //{
            //    //    Console.WriteLine("{0}, {1}", stop_time.stop_sequence, stop_time.Isarrival_timeNull() ? (TimeSpan?)null : stop_time.arrival_time);
            //    //}
            //    //foreach (var path in trip.pathsRow._Getshapes_txtRows())
            //    //{
            //    //    Console.WriteLine("{0}, {1}, {2}", path.shape_pt_sequence, path.shape_pt_lat, path.shape_pt_lon);
            //    //}
            //}
            gtfs.Write("test2.zip");
        }
    }
}
