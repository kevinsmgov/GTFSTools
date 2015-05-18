using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWin
{
    public partial class Form1 : Form
    {
        private SharpMap.Styles.VectorStyle GetPathStyle(SharpMap.Data.FeatureDataRow row)
        {
            var style = new SharpMap.Styles.VectorStyle();
            style.Line = new Pen(System.Drawing.Color.FromArgb(Convert.ToInt32("FF" + row["strokeColor"].ToString(), 16)), 2);
            return style;
        }
        private SharpMap.Styles.VectorStyle GetStopStyle(SharpMap.Data.FeatureDataRow row)
        {
            var style = new SharpMap.Styles.VectorStyle();
            style.PointColor = System.Drawing.Brushes.Blue;
            style.PointSize = 4;
            return style;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var testFile = new System.IO.FileInfo("test.zip");
            if (testFile.Exists)
            {
                var testArchive = new System.IO.Compression.ZipArchive(testFile.OpenRead());
                var gtfs = new IO.GTFS(testArchive);
                var layerStops = new SharpMap.Layers.VectorLayer("Stops");
                var layerPaths = new SharpMap.Layers.VectorLayer("Paths");

                var featurePath = new SharpMap.Data.FeatureDataTable();
                featurePath.Columns.Add("strokeColor");
                var featureStops = new SharpMap.Data.FeatureDataTable();

                var geometryFactory = new NetTopologySuite.Geometries.GeometryFactory();

                foreach (var path in gtfs.DataSet._shapes_txt.GroupBy(item => item.shape_id).Select(group => new { shape_id = group.Key, route_color = group.First()._Gettrips_txtRows().First()._routes_txtRow.Isroute_colorNull() ? "000000" : group.First()._Gettrips_txtRows().First()._routes_txtRow.route_color, points = group.OrderBy(item => item.shape_pt_sequence) }))
                {
                    var coordinates = new Collection<GeoAPI.Geometries.Coordinate>();
                    foreach (var point in path.points)
                    {
                        var coordinate = new GeoAPI.Geometries.Coordinate(Convert.ToDouble(point.shape_pt_lon), Convert.ToDouble(point.shape_pt_lat));
                        coordinates.Add(coordinate);
                    }
                    var newFeatureRow = featurePath.NewRow();
                    newFeatureRow.Geometry = geometryFactory.CreateLineString(coordinates.ToArray());
                    newFeatureRow.ItemArray = new Object[] { path.route_color };
                    featurePath.AddRow(newFeatureRow);
                }
                layerPaths.DataSource = new SharpMap.Data.Providers.GeometryFeatureProvider(featurePath);
                layerPaths.Theme = new SharpMap.Rendering.Thematics.CustomTheme(GetPathStyle);

                foreach (var stops_txt in gtfs.DataSet._stops_txt)
                {
                    var newFeatureRow = featureStops.NewRow();
                    newFeatureRow.Geometry = geometryFactory.CreatePoint(new GeoAPI.Geometries.Coordinate(Convert.ToDouble(stops_txt.stop_lon), Convert.ToDouble(stops_txt.stop_lat)));
                    featureStops.AddRow(newFeatureRow);
                }
                layerStops.DataSource = new SharpMap.Data.Providers.GeometryFeatureProvider(featureStops);
                layerStops.Theme = new SharpMap.Rendering.Thematics.CustomTheme(GetStopStyle);

                var ctFact = new ProjNet.CoordinateSystems.Transformations.CoordinateTransformationFactory();
                layerPaths.CoordinateTransformation = ctFact.CreateFromCoordinateSystems(ProjNet.CoordinateSystems.GeographicCoordinateSystem.WGS84, ProjNet.CoordinateSystems.ProjectedCoordinateSystem.WebMercator);
                layerPaths.ReverseCoordinateTransformation = ctFact.CreateFromCoordinateSystems(ProjNet.CoordinateSystems.ProjectedCoordinateSystem.WebMercator, ProjNet.CoordinateSystems.GeographicCoordinateSystem.WGS84);
                layerStops.CoordinateTransformation = ctFact.CreateFromCoordinateSystems(ProjNet.CoordinateSystems.GeographicCoordinateSystem.WGS84, ProjNet.CoordinateSystems.ProjectedCoordinateSystem.WebMercator);
                layerStops.ReverseCoordinateTransformation = ctFact.CreateFromCoordinateSystems(ProjNet.CoordinateSystems.ProjectedCoordinateSystem.WebMercator, ProjNet.CoordinateSystems.GeographicCoordinateSystem.WGS84);
                mapBox1.Map.Layers.Add(layerPaths);
                mapBox1.Map.Layers.Add(layerStops);
                mapBox1.Map.ZoomToExtents();
                mapBox1.Map.BackgroundLayer.Add(new SharpMap.Layers.TileAsyncLayer(new BruTile.Web.OsmTileSource(), "OSM"));
                mapBox1.Refresh();
                mapBox1.ActiveTool = SharpMap.Forms.MapBox.Tools.Pan;
            }
        }

        private void mapBox1_MouseDrag(GeoAPI.Geometries.Coordinate worldPos, MouseEventArgs imagePos)
        {

        }
    }
}
