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
            foreach (var trip in gtfs.DataSet._trips_txt)
            {
                Console.WriteLine("{0}, {1}", trip.trip_id, trip._Getstop_times_txtRows().Count());
                //foreach (var stop_time in trip._Getstop_times_txtRows())
                //{
                //    Console.WriteLine("{0}, {1}", stop_time.stop_sequence, stop_time.Isarrival_timeNull() ? (TimeSpan?)null : stop_time.arrival_time);
                //}
            }
            gtfs.Write("test2.zip");
        }
    }
}
