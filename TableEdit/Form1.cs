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
            foreach(var bindingSource in new BindingSource[]{
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
            var result = openFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var previousCursor = this.Cursor;
                this.Cursor = Cursors.WaitCursor;
                gtfs = new GTFSTools.IO.GTFS(openFileDialog1.FileName);
                BindDataGridViews();
                this.Cursor = previousCursor;
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
            time_zoneBindingSource.DataSource = GTFSTools.IO.LookupTables.time_zones;
            languageBindingSource.DataSource = GTFSTools.IO.LookupTables.languages;
            location_typeBindingSource.DataSource = GTFSTools.IO.LookupTables.location_types;
            wheelchair_boardingBindingSource.DataSource = GTFSTools.IO.LookupTables.wheelchair_boardings;
            pickup_typeBindingSource.DataSource = GTFSTools.IO.LookupTables.pickup_type;
            drop_off_typeBindingSource.DataSource = GTFSTools.IO.LookupTables.drop_off_type;
            wheelchair_accessibleBindingSource.DataSource = GTFSTools.IO.LookupTables.wheelchair_accessible;
            bikes_allowedBindingSource.DataSource = GTFSTools.IO.LookupTables.bikes_allowed;
            exception_typeBindingSource.DataSource = GTFSTools.IO.LookupTables.exception_type;
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
    }
}
