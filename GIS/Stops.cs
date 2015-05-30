using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTFSTools.GIS
{
    public class Stops
    {
        public GISDataSet._stops_csvDataTable DataTable = new GISDataSet._stops_csvDataTable();
        public Stops()
        {

        }
        public Stops(GTFSTools.IO.GTFSDataSet._stops_txtDataTable _stops_txt)
        {
            var precisionModel = new NetTopologySuite.Geometries.PrecisionModel();
            var geometryFactory = new NetTopologySuite.Geometries.GeometryFactory(precisionModel, 4326);
            foreach (var stop in _stops_txt)
            {
                var coordinate = new GeoAPI.Geometries.Coordinate(Convert.ToDouble(stop.stop_lon), Convert.ToDouble(stop.stop_lat));
                NetTopologySuite.Geometries.Point point = geometryFactory.CreatePoint(coordinate) as NetTopologySuite.Geometries.Point;
                var _stops_csvRow = DataTable.New_stops_csvRow();
                _stops_csvRow.stop_id = stop.stop_id;
                _stops_csvRow.stop_code = stop.stop_code;
                _stops_csvRow.stop_name = stop.stop_name;
                _stops_csvRow.stop_desc = stop.stop_desc;
                _stops_csvRow.zone_id = stop.zone_id;
                _stops_csvRow.stop_url = stop.stop_url;
                _stops_csvRow.location_type = stop.location_type;
                _stops_csvRow.parent_station = stop.parent_station;
                _stops_csvRow.stop_timezone = stop.stop_timezone;
                _stops_csvRow.wheelchair_boarding = stop.wheelchair_boarding;
                _stops_csvRow.WKT = point.ToText();
                DataTable.Add_stops_csvRow(_stops_csvRow);
            }
        }
        public void Update(GTFSTools.IO.GTFSDataSet._stops_txtDataTable _stops_txt)
        {
            var precisionModel = new NetTopologySuite.Geometries.PrecisionModel();
            var geometryFactory = new NetTopologySuite.Geometries.GeometryFactory(precisionModel, 4326);
            var wktReader = new NetTopologySuite.IO.WKTReader(geometryFactory);
            _stops_txt.Clear();
            foreach (GISDataSet._stops_csvRow row in DataTable.Rows)
            {
                var point = wktReader.Read(row.WKT);
                var _stops_txtRow = _stops_txt.New_stops_txtRow();
                _stops_txtRow.stop_id = row.stop_id;
                _stops_txtRow.stop_code = row.stop_code;
                _stops_txtRow.stop_name = row.stop_name;
                _stops_txtRow.stop_desc = row.stop_desc;
                _stops_txtRow.stop_lat = Convert.ToDecimal(point.Coordinate.Y);
                _stops_txtRow.stop_lon = Convert.ToDecimal(point.Coordinate.X);
                _stops_txtRow.zone_id = row.zone_id;
                _stops_txtRow.stop_url = row.stop_url;
                _stops_txtRow.location_type = row.location_type;
                _stops_txtRow.parent_station = row.parent_station;
                _stops_txtRow.stop_timezone = row.stop_timezone;
                _stops_txtRow.wheelchair_boarding = row.wheelchair_boarding;
                _stops_txt.Add_stops_txtRow(_stops_txtRow);
            }
        }
    }
}
