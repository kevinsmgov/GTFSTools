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
                var blankRow = gtfsLookupTables.time_zone.Newtime_zoneRow();
                gtfsLookupTables.time_zone.ReadCSV(System.IO.File.OpenRead("time_zones.csv"));
                gtfsLookupTables.time_zone.Rows.InsertAt(blankRow, 0);
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
                result.Addwheelchair_boardingRow("0", "Unknown");
                result.Addwheelchair_boardingRow("1", "Some Access");
                result.Addwheelchair_boardingRow("2", "No Access");
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
        public static GTFSLookupTables.wheelchair_accessibleDataTable wheelchair_accessible
        {
            get
            {
                var result = new GTFSLookupTables.wheelchair_accessibleDataTable();
                result.Addwheelchair_accessibleRow("", "Unknown (blank)");
                result.Addwheelchair_accessibleRow("0", "Unknown");
                result.Addwheelchair_accessibleRow("1", "At least one");
                result.Addwheelchair_accessibleRow("2", "No wheelchairs");
                return result;
            }
        }
        public static GTFSLookupTables.bikes_allowedDataTable bikes_allowed
        {
            get
            {
                var result = new GTFSLookupTables.bikes_allowedDataTable();
                result.Addbikes_allowedRow("", "Unknown (blank)");
                result.Addbikes_allowedRow("0", "Unknown");
                result.Addbikes_allowedRow("1", "At least one");
                result.Addbikes_allowedRow("2", "No bikes");
                return result;
            }
        }
        public static GTFSLookupTables.exception_typeDataTable exception_type
        {
            get
            {
                var result = new GTFSLookupTables.exception_typeDataTable();
                result.Addexception_typeRow("1", "Add");
                result.Addexception_typeRow("2", "Remove");
                return result;
            }
        }
    }
}
