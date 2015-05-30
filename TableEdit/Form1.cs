using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableEdit
{
    public partial class Form1 : Form
    {
        protected GTFSTools.IO.GTFS gtfs = new GTFSTools.IO.GTFS();

        protected void BindDataGridViews()
        {
            foreach (var bindingSource in new BindingSource[]{
                agencyBindingSource,
                stopsBindingSource,
                routesBindingSource,
                tripsBindingSource,
                stop_timesBindingSource,
                calendarBindingSource,
                calendar_dateBindingSource,
                fare_attributesDindingSource,
                fare_rulesBindingSource,
                shapesBindingSource,
                frequenciesBindingSource,
                transfersBindingSource,
                feed_infoBindingSource,
                pathsBindingSource
            }) { bindingSource.DataSource = gtfs.DataSet; }
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItemImportZip_Click(object sender, EventArgs e)
        {
            var result = openFileDialogGTFS.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var previousCursor = this.Cursor;
                this.Cursor = Cursors.WaitCursor;
                gtfs = new GTFSTools.IO.GTFS(openFileDialogGTFS.FileName);
                BindDataGridViews();
                this.Cursor = previousCursor;
            }
        }

        private void toolStripMenuItemImportFolder_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var previousCursor = this.Cursor;
                this.Cursor = Cursors.WaitCursor;
                gtfs = new GTFSTools.IO.GTFS(folderBrowserDialog1.SelectedPath);
                BindDataGridViews();
                this.Cursor = previousCursor;
            }
        }

        private void toolStripMenuItemExportZip_Click(object sender, EventArgs e)
        {
            var result = saveFileDialogGTFS.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var previousCursor = this.Cursor;
                this.Cursor = Cursors.WaitCursor;
                gtfs.Write(saveFileDialogGTFS.FileName);
                this.Cursor = previousCursor;
                MessageBox.Show("GTFS file exported", "Export Complete", MessageBoxButtons.OK);
            }
        }

        private void toolStripMenuItemExportFolder_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var previousCursor = this.Cursor;
                this.Cursor = Cursors.WaitCursor;
                gtfs.Write(folderBrowserDialog1.SelectedPath);
                this.Cursor = previousCursor;
                MessageBox.Show("GTFS folder exported", "Export Complete", MessageBoxButtons.OK);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //gtfs.DataSet.Relations.Remove("FK_blocks_trips.txt");
            //gtfs.DataSet.Relations.Remove("FK_paths_shapes.txt");
            //gtfs.DataSet.Relations.Remove("FK_paths_trips.txt");
            //gtfs.DataSet._shapes_txt.Constraints.Remove("FK_paths_shapes.txt");
            //gtfs.DataSet._trips_txt.Constraints.Remove("FK_blocks_trips.txt");
            //gtfs.DataSet._trips_txt.Constraints.Remove("FK_paths_trips.txt");

            var lookupTables = new GTFSTools.IO.LookupTables();
            time_zoneBindingSource.DataSource = lookupTables.time_zones;
            languageBindingSource.DataSource = lookupTables.languages;
            location_typeBindingSource.DataSource = lookupTables.location_types;
            wheelchair_boardingBindingSource.DataSource = lookupTables.wheelchair_boardings;
            pickup_typeBindingSource.DataSource = lookupTables.pickup_types;
            drop_off_typeBindingSource.DataSource = lookupTables.drop_off_types;
            wheelchair_accessibleBindingSource.DataSource = lookupTables.wheelchair_accessible;
            bikes_allowedBindingSource.DataSource = lookupTables.bikes_allowed;
            exception_typeBindingSource.DataSource = lookupTables.exception_types;
            route_typesBindingSource.DataSource = lookupTables.route_types;
            BindDataGridViews();
        }

        private void dataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var dataGridView = (DataGridView)sender;
            var bindingSource = (BindingSource)dataGridView.DataSource;
            var gtfsDataSet = (GTFSTools.IO.GTFSDataSet)bindingSource.DataSource;
            var dataTable = gtfsDataSet.Tables[bindingSource.DataMember];
            var dataColumn = dataTable.Columns[e.ColumnIndex];
            if (!dataColumn.AllowDBNull && e.FormattedValue.ToString() == String.Empty && dataGridView.IsCurrentRowDirty)
            {
                dataGridView[e.ColumnIndex, e.RowIndex].ErrorText = "Mandatory";
                e.Cancel = true;
            }
            else
            {
                dataGridView[e.ColumnIndex, e.RowIndex].ErrorText = null;
            }
        }

        private void toolStripMenuItemExportShapesCSV_Click(object sender, EventArgs e)
        {
            saveFileDialogGIS.DefaultExt = "csv";
            saveFileDialogGIS.Filter = "Well Known Text|*.csv";
            var result = saveFileDialogGIS.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var previousCursor = this.Cursor;
                this.Cursor = Cursors.WaitCursor;
                var shapes = new GTFSTools.GIS.Shapes(gtfs.DataSet._shapes_txt);
                try
                {
                    using (var stream = System.IO.File.Create(saveFileDialogGIS.FileName))
                    {
                        GTFSTools.IO.Extensions.WriteCSV(shapes.DataTable, stream);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Export Error", MessageBoxButtons.OK);
                }
                this.Cursor = previousCursor;
            }
        }

        private void toolStripMenuItemImportShapesCSV_Click(object sender, EventArgs e)
        {
            openFileDialogShapes.DefaultExt = "csv";
            openFileDialogShapes.Filter = "Well Known Text|*.csv";
            var result = openFileDialogShapes.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var previousCursor = this.Cursor;
                this.Cursor = Cursors.WaitCursor;
                var shapes = new GTFSTools.GIS.Shapes();
                using (var stream = System.IO.File.OpenRead(openFileDialogShapes.FileName))
                {
                    GTFSTools.IO.Extensions.ReadCSV(shapes.DataTable, stream);
                }
                shapes.Update(gtfs.DataSet._shapes_txt);
                BindDataGridViews();
                this.Cursor = previousCursor;
            }
        }

        private void toolStripMenuItemExportShapesSQLite_Click(object sender, EventArgs e)
        {
            
            saveFileDialogGIS.DefaultExt = "sqlite";
            saveFileDialogGIS.Filter = "SQLite|*.sqlite";
            var result = saveFileDialogGIS.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var previousCursor = this.Cursor;
                this.Cursor = Cursors.WaitCursor;
                var shapes = new GTFSTools.GIS.Shapes(gtfs.DataSet._shapes_txt);
                try
                {
                    shapes.ToSQLite(saveFileDialogGIS.FileName);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Export Error", MessageBoxButtons.OK);

                }
                this.Cursor = previousCursor;
            }
        }

        private void toolStripMenuItemImportShapesSQLite_Click(object sender, EventArgs e)
        {
            openFileDialogShapes.DefaultExt = "sqlite";
            openFileDialogShapes.Filter = "SQLite|*.sqlite";
            var result = openFileDialogShapes.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var previousCursor = this.Cursor;
                this.Cursor = Cursors.WaitCursor;
                var shapes = new GTFSTools.GIS.Shapes();
                try
                {
                    shapes.FromSQLite(openFileDialogShapes.FileName);
                    shapes.Update(gtfs.DataSet._shapes_txt);
                    BindDataGridViews();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Import Error", MessageBoxButtons.OK);
                }
                this.Cursor = previousCursor;
            }
        }

        private void toolStripMenuItemExportStopsCSV_Click(object sender, EventArgs e)
        {
            saveFileDialogGIS.DefaultExt = "csv";
            saveFileDialogGIS.Filter = "Well Known Text|*.csv";
            var result = saveFileDialogGIS.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var previousCursor = this.Cursor;
                this.Cursor = Cursors.WaitCursor;
                var stops = new GTFSTools.GIS.Stops(gtfs.DataSet._stops_txt);
                try
                {
                    using (var stream = System.IO.File.Create(saveFileDialogGIS.FileName))
                    {
                        GTFSTools.IO.Extensions.WriteCSV(stops.DataTable, stream);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Export Error", MessageBoxButtons.OK);
                }
                this.Cursor = previousCursor;
            }
        }
        private void toolStripMenuItemImportStopsCSV_Click(object sender, EventArgs e)
        {
            openFileDialogShapes.DefaultExt = "csv";
            openFileDialogShapes.Filter = "Well Known Text|*.csv";
            var result = openFileDialogShapes.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var previousCursor = this.Cursor;
                this.Cursor = Cursors.WaitCursor;
                var stops = new GTFSTools.GIS.Stops();
                using (var stream = System.IO.File.OpenRead(openFileDialogShapes.FileName))
                {
                    GTFSTools.IO.Extensions.ReadCSV(stops.DataTable, stream);
                }
                stops.Update(gtfs.DataSet._stops_txt);
                BindDataGridViews();
                this.Cursor = previousCursor;
            }
        }
        private void toolStripMenuItemExportStopsSQLite_Click(object sender, EventArgs e)
        {

            saveFileDialogGIS.DefaultExt = "sqlite";
            saveFileDialogGIS.Filter = "SQLite|*.sqlite";
            var result = saveFileDialogGIS.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var previousCursor = this.Cursor;
                this.Cursor = Cursors.WaitCursor;
                var stops = new GTFSTools.GIS.Stops(gtfs.DataSet._stops_txt);
                try
                {
                    stops.ToSQLite(saveFileDialogGIS.FileName);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Export Error", MessageBoxButtons.OK);
                }
                this.Cursor = previousCursor;
            }
        }

        private void toolStripMenuItemImportStopsSQLite_Click(object sender, EventArgs e)
        {
            openFileDialogShapes.DefaultExt = "sqlite";
            openFileDialogShapes.Filter = "SQLite|*.sqlite";
            var result = openFileDialogShapes.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var previousCursor = this.Cursor;
                this.Cursor = Cursors.WaitCursor;
                var stops = new GTFSTools.GIS.Stops();
                try
                {
                    stops.FromSQLite(openFileDialogShapes.FileName);
                    stops.Update(gtfs.DataSet._stops_txt);
                    BindDataGridViews();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Import Error", MessageBoxButtons.OK);
                }
                this.Cursor = previousCursor;
            }
        }
    }
}
