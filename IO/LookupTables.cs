using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTFSTools.IO
{
    public class LookupTables
    {
        private GTFSLookupTables lookupTables = new GTFSLookupTables();
        public LookupTables()
        {
            lookupTables.ReadXml("LookupTables.xml");
        }
        public GTFSLookupTables.time_zoneDataTable time_zones
        {
            get
            {
                return lookupTables.time_zone;
            }
        }
        public GTFSLookupTables.languageDataTable languages
        {
            get
            {
                return lookupTables.language;
            }
        }
        public GTFSLookupTables.location_typeDataTable location_types
        {
            get
            {
                return lookupTables.location_type;
            }
        }
        public  GTFSLookupTables.wheelchair_boardingDataTable wheelchair_boardings
        {
            get
            {
                return lookupTables.wheelchair_boarding;
            }
        }
        public GTFSLookupTables.pickup_typeDataTable pickup_types
        {
            get
            {
                return lookupTables.pickup_type;
            }
        }
        public GTFSLookupTables.drop_off_typeDataTable drop_off_types
        {
            get
            {
                return lookupTables.drop_off_type;
            }
        }
        public GTFSLookupTables.wheelchair_accessibleDataTable wheelchair_accessible
        {
            get
            {
                return lookupTables.wheelchair_accessible;
            }
        }
        public GTFSLookupTables.bikes_allowedDataTable bikes_allowed
        {
            get
            {
                return lookupTables.bikes_allowed;
            }
        }
        public GTFSLookupTables.exception_typeDataTable exception_types
        {
            get
            {
                return lookupTables.exception_type;
            }
        }
        public GTFSLookupTables.route_typeDataTable route_types
        {
            get
            {
                return lookupTables.route_type;
            }
        }
    }
}
