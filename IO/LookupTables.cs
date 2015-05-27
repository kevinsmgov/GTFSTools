using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTFSTools.IO
{
    public class LookupTables
    {
        public static GTFSLookupTables.location_typeDataTable location_types
        {
            get
            {
                var result = new GTFSLookupTables.location_typeDataTable();
                result.Addlocation_typeRow("", "Stop (blank)");
                result.Addlocation_typeRow("0", "Stop");
                result.Addlocation_typeRow("1", "Station");
                return result;
            }
        }
        public static GTFSLookupTables.time_zoneDataTable time_zones
        {
            get
            {
                var gtfsLookupTables = new GTFSLookupTables();
                gtfsLookupTables.time_zone.ReadCSV(System.IO.File.OpenRead("time_zones.csv"));
                return gtfsLookupTables.time_zone;
            }
        }
        public static GTFSLookupTables.languageDataTable languages
        {
            get
            {
                var gtfsLookupTables = new GTFSLookupTables();
                gtfsLookupTables.language.ReadCSV(System.IO.File.OpenRead("languages.csv"));
                return gtfsLookupTables.language;
            }
        }
        public static GTFSLookupTables.wheelchair_boardingDataTable wheelchair_boardings
        {
            get
            {
                var result = new GTFSLookupTables.wheelchair_boardingDataTable();
                result.Addwheelchair_boardingRow("", "Unknown (blank)");
                result.Addwheelchair_boardingRow("0", "Some Access");
                result.Addwheelchair_boardingRow("1", "No Access");
                return result;
            }
        }
        public static GTFSLookupTables.pickup_typeDataTable pickup_type
        {
            get
            {
                var result = new GTFSLookupTables.pickup_typeDataTable();
                result.Addpickup_typeRow("", "Regularly scheduled pickup (blank)");
                result.Addpickup_typeRow("0", "Regularly scheduled pickup");
                result.Addpickup_typeRow("1", "No pickup available");
                result.Addpickup_typeRow("2", "Must phone agency to arrange pickup");
                result.Addpickup_typeRow("3", "Must coordinate with driver to arrange pickup");
                return result;
            }
        }
        public static GTFSLookupTables.drop_off_typeDataTable drop_off_type
        {
            get
            {
                var result = new GTFSLookupTables.drop_off_typeDataTable();
                result.Adddrop_off_typeRow("", "Regularly scheduled drop off (blank)");
                result.Adddrop_off_typeRow("0", "Regularly scheduled drop off");
                result.Adddrop_off_typeRow("1", "No drop off available");
                result.Adddrop_off_typeRow("2", "Must phone agency to arrange drop off");
                result.Adddrop_off_typeRow("3", "Must coordinate with driver to arrange drop off");
                return result;
            }
        }
    }
}
