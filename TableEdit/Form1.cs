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
            agencyBindingSource.DataSource = gtfs.DataSet;
            stopsBindingSource.DataSource = gtfs.DataSet;
            routesBindingSource.DataSource = gtfs.DataSet;
            stop_timesBindingSource.DataSource = gtfs.DataSet;
            calendarBindingSource.DataSource = gtfs.DataSet;
            calendar_dateBindingSource.DataSource = gtfs.DataSet;
            fare_attributesDindingSource.DataSource = gtfs.DataSet;
            fare_rulesBindingSource.DataSource = gtfs.DataSet;
            shapesBindingSource.DataSource = gtfs.DataSet;
            frequenciesBindingSource.DataSource = gtfs.DataSet;
            transfersBindingSource.DataSource = gtfs.DataSet;
            feed_infoBindingSource.DataSource = gtfs.DataSet;
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
            time_zoneBindingSource.DataSource = GTFSTools.IO.LookupTables.time_zones;
            languageBindingSource.DataSource = GTFSTools.IO.LookupTables.languages;
            location_typeBindingSource.DataSource = GTFSTools.IO.LookupTables.location_types;
            wheelchair_boardingBindingSource.DataSource = GTFSTools.IO.LookupTables.wheelchair_boardings;
            BindDataGridViews();
        }

        private void dataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var dataGridView = (DataGridView)sender;
            var bindingSource = (BindingSource)dataGridView.DataSource;
            var gtfsDataSet = (GTFSTools.IO.GTFSDataSet)bindingSource.DataSource;
            var dataTable = gtfsDataSet.Tables[bindingSource.DataMember];
            var dataColumn = dataTable.Columns[e.ColumnIndex];
            if (!dataColumn.AllowDBNull && e.FormattedValue.ToString() == String.Empty)
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
