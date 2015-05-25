namespace TableEdit
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemImportZip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemImportFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExportZip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExportFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.time_zoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.languageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.location_typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wheelchair_boardingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stop_timesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calendar_dateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fare_attributesDindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fare_rulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shapesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frequenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transfersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feed_infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feed_info = new System.Windows.Forms.TabPage();
            this.dataGridViewFeedInfo = new System.Windows.Forms.DataGridView();
            this.feedpublishernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedpublisherurlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedlangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedstartdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedenddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedversionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transfers = new System.Windows.Forms.TabPage();
            this.dataGridViewTransfers = new System.Windows.Forms.DataGridView();
            this.fromstopidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tostopidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transfertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mintransfertimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencies = new System.Windows.Forms.TabPage();
            this.dataGridViewFrequencies = new System.Windows.Forms.DataGridView();
            this.tripidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headwaysecsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exacttimesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapes = new System.Windows.Forms.TabPage();
            this.dataGridViewShapes = new System.Windows.Forms.DataGridView();
            this.shapeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapeptlatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapeptlonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapeptsequenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapedisttraveledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fare_rules = new System.Windows.Forms.TabPage();
            this.dataGridViewFareRules = new System.Windows.Forms.DataGridView();
            this.fareidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fare_attributes = new System.Windows.Forms.TabPage();
            this.dataGridViewFareAttributes = new System.Windows.Forms.DataGridView();
            this.fareidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencytypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentmethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transfersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transferdurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendar_dates = new System.Windows.Forms.TabPage();
            this.dataGridViewCalendarDates = new System.Windows.Forms.DataGridView();
            this.serviceidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exceptiontypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendar = new System.Windows.Forms.TabPage();
            this.dataGridViewCalendar = new System.Windows.Forms.DataGridView();
            this.serviceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mondayDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tuesdayDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.wednesdayDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.thursdayDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fridayDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.saturdayDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sundayDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stop_times = new System.Windows.Forms.TabPage();
            this.dataGridViewStopTimes = new System.Windows.Forms.DataGridView();
            this.tripidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivaltimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departuretimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopsequenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopheadsignDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickuptypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dropofftypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapedisttraveledDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timepointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routes = new System.Windows.Forms.TabPage();
            this.dataGridViewRoutes = new System.Windows.Forms.DataGridView();
            this.routeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.routeshortnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routelongnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routedescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeurlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routecolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routetextcolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stops = new System.Windows.Forms.TabPage();
            this.dataGridViewStops = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.agency = new System.Windows.Forms.TabPage();
            this.dataGridViewAgency = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.time_zoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.location_typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheelchair_boardingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop_timesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendar_dateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fare_attributesDindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fare_rulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transfersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feed_infoBindingSource)).BeginInit();
            this.feed_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeedInfo)).BeginInit();
            this.transfers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransfers)).BeginInit();
            this.frequencies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrequencies)).BeginInit();
            this.shapes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShapes)).BeginInit();
            this.fare_rules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFareRules)).BeginInit();
            this.fare_attributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFareAttributes)).BeginInit();
            this.calendar_dates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendarDates)).BeginInit();
            this.calendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendar)).BeginInit();
            this.stop_times.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStopTimes)).BeginInit();
            this.routes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoutes)).BeginInit();
            this.stops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStops)).BeginInit();
            this.agency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgency)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemImportZip,
            this.toolStripMenuItemImportFolder});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "&Import";
            // 
            // toolStripMenuItemImportZip
            // 
            this.toolStripMenuItemImportZip.Name = "toolStripMenuItemImportZip";
            this.toolStripMenuItemImportZip.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItemImportZip.Text = "&Zip";
            this.toolStripMenuItemImportZip.Click += new System.EventHandler(this.toolStripMenuItemImportZip_Click);
            // 
            // toolStripMenuItemImportFolder
            // 
            this.toolStripMenuItemImportFolder.Name = "toolStripMenuItemImportFolder";
            this.toolStripMenuItemImportFolder.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItemImportFolder.Text = "&Folder";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExportZip,
            this.toolStripMenuItemExportFolder});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "&Export";
            // 
            // toolStripMenuItemExportZip
            // 
            this.toolStripMenuItemExportZip.Name = "toolStripMenuItemExportZip";
            this.toolStripMenuItemExportZip.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItemExportZip.Text = "&Zip";
            // 
            // toolStripMenuItemExportFolder
            // 
            this.toolStripMenuItemExportFolder.Name = "toolStripMenuItemExportFolder";
            this.toolStripMenuItemExportFolder.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItemExportFolder.Text = "&Folder";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Zip Files|*.zip";
            // 
            // time_zoneBindingSource
            // 
            this.time_zoneBindingSource.DataMember = "time_zone";
            this.time_zoneBindingSource.DataSource = typeof(GTFSTools.IO.GTFSLookupTables);
            // 
            // languageBindingSource
            // 
            this.languageBindingSource.DataMember = "language";
            this.languageBindingSource.DataSource = typeof(GTFSTools.IO.GTFSLookupTables);
            // 
            // agencyBindingSource
            // 
            this.agencyBindingSource.DataMember = "agency.txt";
            this.agencyBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
            // 
            // location_typeBindingSource
            // 
            this.location_typeBindingSource.DataMember = "location_type";
            this.location_typeBindingSource.DataSource = typeof(GTFSTools.IO.GTFSLookupTables);
            // 
            // wheelchair_boardingBindingSource
            // 
            this.wheelchair_boardingBindingSource.DataMember = "wheelchair_boarding";
            this.wheelchair_boardingBindingSource.DataSource = typeof(GTFSTools.IO.GTFSLookupTables);
            // 
            // stopsBindingSource
            // 
            this.stopsBindingSource.DataMember = "stops.txt";
            this.stopsBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
            // 
            // routesBindingSource
            // 
            this.routesBindingSource.DataMember = "routes.txt";
            this.routesBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
            // 
            // stop_timesBindingSource
            // 
            this.stop_timesBindingSource.DataMember = "stop_times.txt";
            this.stop_timesBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
            // 
            // calendarBindingSource
            // 
            this.calendarBindingSource.DataMember = "calendar.txt";
            this.calendarBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
            // 
            // calendar_dateBindingSource
            // 
            this.calendar_dateBindingSource.DataMember = "calendar_dates.txt";
            this.calendar_dateBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
            // 
            // fare_attributesDindingSource
            // 
            this.fare_attributesDindingSource.DataMember = "fare_attributes.txt";
            this.fare_attributesDindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
            // 
            // fare_rulesBindingSource
            // 
            this.fare_rulesBindingSource.DataMember = "fare_rules.txt";
            this.fare_rulesBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
            // 
            // shapesBindingSource
            // 
            this.shapesBindingSource.DataMember = "shapes.txt";
            this.shapesBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
            // 
            // frequenciesBindingSource
            // 
            this.frequenciesBindingSource.DataMember = "frequencies.txt";
            this.frequenciesBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
            // 
            // transfersBindingSource
            // 
            this.transfersBindingSource.DataMember = "transfers.txt";
            this.transfersBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
            // 
            // feed_infoBindingSource
            // 
            this.feed_infoBindingSource.DataMember = "feed_info.txt";
            this.feed_infoBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
            // 
            // feed_info
            // 
            this.feed_info.Controls.Add(this.dataGridViewFeedInfo);
            this.feed_info.Location = new System.Drawing.Point(4, 22);
            this.feed_info.Name = "feed_info";
            this.feed_info.Size = new System.Drawing.Size(660, 182);
            this.feed_info.TabIndex = 11;
            this.feed_info.Text = "feed_info.txt";
            this.feed_info.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFeedInfo
            // 
            this.dataGridViewFeedInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFeedInfo.AutoGenerateColumns = false;
            this.dataGridViewFeedInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFeedInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.feedpublishernameDataGridViewTextBoxColumn,
            this.feedpublisherurlDataGridViewTextBoxColumn,
            this.feedlangDataGridViewTextBoxColumn,
            this.feedstartdateDataGridViewTextBoxColumn,
            this.feedenddateDataGridViewTextBoxColumn,
            this.feedversionDataGridViewTextBoxColumn});
            this.dataGridViewFeedInfo.DataSource = this.feed_infoBindingSource;
            this.dataGridViewFeedInfo.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewFeedInfo.Name = "dataGridViewFeedInfo";
            this.dataGridViewFeedInfo.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewFeedInfo.TabIndex = 11;
            this.dataGridViewFeedInfo.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            // 
            // feedpublishernameDataGridViewTextBoxColumn
            // 
            this.feedpublishernameDataGridViewTextBoxColumn.DataPropertyName = "feed_publisher_name";
            this.feedpublishernameDataGridViewTextBoxColumn.HeaderText = "feed_publisher_name";
            this.feedpublishernameDataGridViewTextBoxColumn.Name = "feedpublishernameDataGridViewTextBoxColumn";
            // 
            // feedpublisherurlDataGridViewTextBoxColumn
            // 
            this.feedpublisherurlDataGridViewTextBoxColumn.DataPropertyName = "feed_publisher_url";
            this.feedpublisherurlDataGridViewTextBoxColumn.HeaderText = "feed_publisher_url";
            this.feedpublisherurlDataGridViewTextBoxColumn.Name = "feedpublisherurlDataGridViewTextBoxColumn";
            // 
            // feedlangDataGridViewTextBoxColumn
            // 
            this.feedlangDataGridViewTextBoxColumn.DataPropertyName = "feed_lang";
            this.feedlangDataGridViewTextBoxColumn.HeaderText = "feed_lang";
            this.feedlangDataGridViewTextBoxColumn.Name = "feedlangDataGridViewTextBoxColumn";
            // 
            // feedstartdateDataGridViewTextBoxColumn
            // 
            this.feedstartdateDataGridViewTextBoxColumn.DataPropertyName = "feed_start_date";
            this.feedstartdateDataGridViewTextBoxColumn.HeaderText = "feed_start_date";
            this.feedstartdateDataGridViewTextBoxColumn.Name = "feedstartdateDataGridViewTextBoxColumn";
            // 
            // feedenddateDataGridViewTextBoxColumn
            // 
            this.feedenddateDataGridViewTextBoxColumn.DataPropertyName = "feed_end_date";
            this.feedenddateDataGridViewTextBoxColumn.HeaderText = "feed_end_date";
            this.feedenddateDataGridViewTextBoxColumn.Name = "feedenddateDataGridViewTextBoxColumn";
            // 
            // feedversionDataGridViewTextBoxColumn
            // 
            this.feedversionDataGridViewTextBoxColumn.DataPropertyName = "feed_version";
            this.feedversionDataGridViewTextBoxColumn.HeaderText = "feed_version";
            this.feedversionDataGridViewTextBoxColumn.Name = "feedversionDataGridViewTextBoxColumn";
            // 
            // transfers
            // 
            this.transfers.Controls.Add(this.dataGridViewTransfers);
            this.transfers.Location = new System.Drawing.Point(4, 22);
            this.transfers.Name = "transfers";
            this.transfers.Size = new System.Drawing.Size(660, 182);
            this.transfers.TabIndex = 10;
            this.transfers.Text = "transfers.txt";
            this.transfers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTransfers
            // 
            this.dataGridViewTransfers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTransfers.AutoGenerateColumns = false;
            this.dataGridViewTransfers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransfers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fromstopidDataGridViewTextBoxColumn,
            this.tostopidDataGridViewTextBoxColumn,
            this.transfertypeDataGridViewTextBoxColumn,
            this.mintransfertimeDataGridViewTextBoxColumn});
            this.dataGridViewTransfers.DataSource = this.transfersBindingSource;
            this.dataGridViewTransfers.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewTransfers.Name = "dataGridViewTransfers";
            this.dataGridViewTransfers.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewTransfers.TabIndex = 10;
            this.dataGridViewTransfers.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            // 
            // fromstopidDataGridViewTextBoxColumn
            // 
            this.fromstopidDataGridViewTextBoxColumn.DataPropertyName = "from_stop_id";
            this.fromstopidDataGridViewTextBoxColumn.HeaderText = "from_stop_id";
            this.fromstopidDataGridViewTextBoxColumn.Name = "fromstopidDataGridViewTextBoxColumn";
            // 
            // tostopidDataGridViewTextBoxColumn
            // 
            this.tostopidDataGridViewTextBoxColumn.DataPropertyName = "to_stop_id";
            this.tostopidDataGridViewTextBoxColumn.HeaderText = "to_stop_id";
            this.tostopidDataGridViewTextBoxColumn.Name = "tostopidDataGridViewTextBoxColumn";
            // 
            // transfertypeDataGridViewTextBoxColumn
            // 
            this.transfertypeDataGridViewTextBoxColumn.DataPropertyName = "transfer_type";
            this.transfertypeDataGridViewTextBoxColumn.HeaderText = "transfer_type";
            this.transfertypeDataGridViewTextBoxColumn.Name = "transfertypeDataGridViewTextBoxColumn";
            // 
            // mintransfertimeDataGridViewTextBoxColumn
            // 
            this.mintransfertimeDataGridViewTextBoxColumn.DataPropertyName = "min_transfer_time";
            this.mintransfertimeDataGridViewTextBoxColumn.HeaderText = "min_transfer_time";
            this.mintransfertimeDataGridViewTextBoxColumn.Name = "mintransfertimeDataGridViewTextBoxColumn";
            // 
            // frequencies
            // 
            this.frequencies.Controls.Add(this.dataGridViewFrequencies);
            this.frequencies.Location = new System.Drawing.Point(4, 22);
            this.frequencies.Name = "frequencies";
            this.frequencies.Size = new System.Drawing.Size(660, 182);
            this.frequencies.TabIndex = 9;
            this.frequencies.Text = "frequencies.txt";
            this.frequencies.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFrequencies
            // 
            this.dataGridViewFrequencies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFrequencies.AutoGenerateColumns = false;
            this.dataGridViewFrequencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFrequencies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tripidDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.endtimeDataGridViewTextBoxColumn,
            this.headwaysecsDataGridViewTextBoxColumn,
            this.exacttimesDataGridViewTextBoxColumn});
            this.dataGridViewFrequencies.DataSource = this.frequenciesBindingSource;
            this.dataGridViewFrequencies.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewFrequencies.Name = "dataGridViewFrequencies";
            this.dataGridViewFrequencies.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewFrequencies.TabIndex = 9;
            this.dataGridViewFrequencies.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            // 
            // tripidDataGridViewTextBoxColumn
            // 
            this.tripidDataGridViewTextBoxColumn.DataPropertyName = "trip_id";
            this.tripidDataGridViewTextBoxColumn.HeaderText = "trip_id";
            this.tripidDataGridViewTextBoxColumn.Name = "tripidDataGridViewTextBoxColumn";
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "start_time";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "start_time";
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            // 
            // endtimeDataGridViewTextBoxColumn
            // 
            this.endtimeDataGridViewTextBoxColumn.DataPropertyName = "end_time";
            this.endtimeDataGridViewTextBoxColumn.HeaderText = "end_time";
            this.endtimeDataGridViewTextBoxColumn.Name = "endtimeDataGridViewTextBoxColumn";
            // 
            // headwaysecsDataGridViewTextBoxColumn
            // 
            this.headwaysecsDataGridViewTextBoxColumn.DataPropertyName = "headway_secs";
            this.headwaysecsDataGridViewTextBoxColumn.HeaderText = "headway_secs";
            this.headwaysecsDataGridViewTextBoxColumn.Name = "headwaysecsDataGridViewTextBoxColumn";
            // 
            // exacttimesDataGridViewTextBoxColumn
            // 
            this.exacttimesDataGridViewTextBoxColumn.DataPropertyName = "exact_times";
            this.exacttimesDataGridViewTextBoxColumn.HeaderText = "exact_times";
            this.exacttimesDataGridViewTextBoxColumn.Name = "exacttimesDataGridViewTextBoxColumn";
            // 
            // shapes
            // 
            this.shapes.Controls.Add(this.dataGridViewShapes);
            this.shapes.Location = new System.Drawing.Point(4, 22);
            this.shapes.Name = "shapes";
            this.shapes.Size = new System.Drawing.Size(660, 182);
            this.shapes.TabIndex = 8;
            this.shapes.Text = "shapes.txt";
            this.shapes.UseVisualStyleBackColor = true;
            // 
            // dataGridViewShapes
            // 
            this.dataGridViewShapes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewShapes.AutoGenerateColumns = false;
            this.dataGridViewShapes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShapes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shapeidDataGridViewTextBoxColumn,
            this.shapeptlatDataGridViewTextBoxColumn,
            this.shapeptlonDataGridViewTextBoxColumn,
            this.shapeptsequenceDataGridViewTextBoxColumn,
            this.shapedisttraveledDataGridViewTextBoxColumn});
            this.dataGridViewShapes.DataSource = this.shapesBindingSource;
            this.dataGridViewShapes.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewShapes.Name = "dataGridViewShapes";
            this.dataGridViewShapes.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewShapes.TabIndex = 8;
            this.dataGridViewShapes.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            // 
            // shapeidDataGridViewTextBoxColumn
            // 
            this.shapeidDataGridViewTextBoxColumn.DataPropertyName = "shape_id";
            this.shapeidDataGridViewTextBoxColumn.HeaderText = "shape_id";
            this.shapeidDataGridViewTextBoxColumn.Name = "shapeidDataGridViewTextBoxColumn";
            // 
            // shapeptlatDataGridViewTextBoxColumn
            // 
            this.shapeptlatDataGridViewTextBoxColumn.DataPropertyName = "shape_pt_lat";
            this.shapeptlatDataGridViewTextBoxColumn.HeaderText = "shape_pt_lat";
            this.shapeptlatDataGridViewTextBoxColumn.Name = "shapeptlatDataGridViewTextBoxColumn";
            // 
            // shapeptlonDataGridViewTextBoxColumn
            // 
            this.shapeptlonDataGridViewTextBoxColumn.DataPropertyName = "shape_pt_lon";
            this.shapeptlonDataGridViewTextBoxColumn.HeaderText = "shape_pt_lon";
            this.shapeptlonDataGridViewTextBoxColumn.Name = "shapeptlonDataGridViewTextBoxColumn";
            // 
            // shapeptsequenceDataGridViewTextBoxColumn
            // 
            this.shapeptsequenceDataGridViewTextBoxColumn.DataPropertyName = "shape_pt_sequence";
            this.shapeptsequenceDataGridViewTextBoxColumn.HeaderText = "shape_pt_sequence";
            this.shapeptsequenceDataGridViewTextBoxColumn.Name = "shapeptsequenceDataGridViewTextBoxColumn";
            // 
            // shapedisttraveledDataGridViewTextBoxColumn
            // 
            this.shapedisttraveledDataGridViewTextBoxColumn.DataPropertyName = "shape_dist_traveled";
            this.shapedisttraveledDataGridViewTextBoxColumn.HeaderText = "shape_dist_traveled";
            this.shapedisttraveledDataGridViewTextBoxColumn.Name = "shapedisttraveledDataGridViewTextBoxColumn";
            // 
            // fare_rules
            // 
            this.fare_rules.Controls.Add(this.dataGridViewFareRules);
            this.fare_rules.Location = new System.Drawing.Point(4, 22);
            this.fare_rules.Name = "fare_rules";
            this.fare_rules.Size = new System.Drawing.Size(660, 182);
            this.fare_rules.TabIndex = 7;
            this.fare_rules.Text = "fare_rules.txt";
            this.fare_rules.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFareRules
            // 
            this.dataGridViewFareRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFareRules.AutoGenerateColumns = false;
            this.dataGridViewFareRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFareRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fareidDataGridViewTextBoxColumn1,
            this.routeidDataGridViewTextBoxColumn1,
            this.originidDataGridViewTextBoxColumn,
            this.destinationidDataGridViewTextBoxColumn,
            this.containsidDataGridViewTextBoxColumn});
            this.dataGridViewFareRules.DataSource = this.fare_rulesBindingSource;
            this.dataGridViewFareRules.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewFareRules.Name = "dataGridViewFareRules";
            this.dataGridViewFareRules.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewFareRules.TabIndex = 7;
            this.dataGridViewFareRules.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            // 
            // fareidDataGridViewTextBoxColumn1
            // 
            this.fareidDataGridViewTextBoxColumn1.DataPropertyName = "fare_id";
            this.fareidDataGridViewTextBoxColumn1.HeaderText = "fare_id";
            this.fareidDataGridViewTextBoxColumn1.Name = "fareidDataGridViewTextBoxColumn1";
            // 
            // routeidDataGridViewTextBoxColumn1
            // 
            this.routeidDataGridViewTextBoxColumn1.DataPropertyName = "route_id";
            this.routeidDataGridViewTextBoxColumn1.HeaderText = "route_id";
            this.routeidDataGridViewTextBoxColumn1.Name = "routeidDataGridViewTextBoxColumn1";
            // 
            // originidDataGridViewTextBoxColumn
            // 
            this.originidDataGridViewTextBoxColumn.DataPropertyName = "origin_id";
            this.originidDataGridViewTextBoxColumn.HeaderText = "origin_id";
            this.originidDataGridViewTextBoxColumn.Name = "originidDataGridViewTextBoxColumn";
            // 
            // destinationidDataGridViewTextBoxColumn
            // 
            this.destinationidDataGridViewTextBoxColumn.DataPropertyName = "destination_id";
            this.destinationidDataGridViewTextBoxColumn.HeaderText = "destination_id";
            this.destinationidDataGridViewTextBoxColumn.Name = "destinationidDataGridViewTextBoxColumn";
            // 
            // containsidDataGridViewTextBoxColumn
            // 
            this.containsidDataGridViewTextBoxColumn.DataPropertyName = "contains_id";
            this.containsidDataGridViewTextBoxColumn.HeaderText = "contains_id";
            this.containsidDataGridViewTextBoxColumn.Name = "containsidDataGridViewTextBoxColumn";
            // 
            // fare_attributes
            // 
            this.fare_attributes.Controls.Add(this.dataGridViewFareAttributes);
            this.fare_attributes.Location = new System.Drawing.Point(4, 22);
            this.fare_attributes.Name = "fare_attributes";
            this.fare_attributes.Size = new System.Drawing.Size(660, 182);
            this.fare_attributes.TabIndex = 6;
            this.fare_attributes.Text = "fare_attributes.txt";
            this.fare_attributes.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFareAttributes
            // 
            this.dataGridViewFareAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFareAttributes.AutoGenerateColumns = false;
            this.dataGridViewFareAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFareAttributes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fareidDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.currencytypeDataGridViewTextBoxColumn,
            this.paymentmethodDataGridViewTextBoxColumn,
            this.transfersDataGridViewTextBoxColumn,
            this.transferdurationDataGridViewTextBoxColumn});
            this.dataGridViewFareAttributes.DataSource = this.fare_attributesDindingSource;
            this.dataGridViewFareAttributes.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewFareAttributes.Name = "dataGridViewFareAttributes";
            this.dataGridViewFareAttributes.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewFareAttributes.TabIndex = 6;
            this.dataGridViewFareAttributes.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            // 
            // fareidDataGridViewTextBoxColumn
            // 
            this.fareidDataGridViewTextBoxColumn.DataPropertyName = "fare_id";
            this.fareidDataGridViewTextBoxColumn.HeaderText = "fare_id";
            this.fareidDataGridViewTextBoxColumn.Name = "fareidDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // currencytypeDataGridViewTextBoxColumn
            // 
            this.currencytypeDataGridViewTextBoxColumn.DataPropertyName = "currency_type";
            this.currencytypeDataGridViewTextBoxColumn.HeaderText = "currency_type";
            this.currencytypeDataGridViewTextBoxColumn.Name = "currencytypeDataGridViewTextBoxColumn";
            // 
            // paymentmethodDataGridViewTextBoxColumn
            // 
            this.paymentmethodDataGridViewTextBoxColumn.DataPropertyName = "payment_method";
            this.paymentmethodDataGridViewTextBoxColumn.HeaderText = "payment_method";
            this.paymentmethodDataGridViewTextBoxColumn.Name = "paymentmethodDataGridViewTextBoxColumn";
            // 
            // transfersDataGridViewTextBoxColumn
            // 
            this.transfersDataGridViewTextBoxColumn.DataPropertyName = "transfers";
            this.transfersDataGridViewTextBoxColumn.HeaderText = "transfers";
            this.transfersDataGridViewTextBoxColumn.Name = "transfersDataGridViewTextBoxColumn";
            // 
            // transferdurationDataGridViewTextBoxColumn
            // 
            this.transferdurationDataGridViewTextBoxColumn.DataPropertyName = "transfer_duration";
            this.transferdurationDataGridViewTextBoxColumn.HeaderText = "transfer_duration";
            this.transferdurationDataGridViewTextBoxColumn.Name = "transferdurationDataGridViewTextBoxColumn";
            // 
            // calendar_dates
            // 
            this.calendar_dates.Controls.Add(this.dataGridViewCalendarDates);
            this.calendar_dates.Location = new System.Drawing.Point(4, 22);
            this.calendar_dates.Name = "calendar_dates";
            this.calendar_dates.Size = new System.Drawing.Size(660, 182);
            this.calendar_dates.TabIndex = 5;
            this.calendar_dates.Text = "calendar_dates.txt";
            this.calendar_dates.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCalendarDates
            // 
            this.dataGridViewCalendarDates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCalendarDates.AutoGenerateColumns = false;
            this.dataGridViewCalendarDates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalendarDates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceidDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn,
            this.exceptiontypeDataGridViewTextBoxColumn});
            this.dataGridViewCalendarDates.DataSource = this.calendar_dateBindingSource;
            this.dataGridViewCalendarDates.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewCalendarDates.Name = "dataGridViewCalendarDates";
            this.dataGridViewCalendarDates.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewCalendarDates.TabIndex = 5;
            this.dataGridViewCalendarDates.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            // 
            // serviceidDataGridViewTextBoxColumn1
            // 
            this.serviceidDataGridViewTextBoxColumn1.DataPropertyName = "service_id";
            this.serviceidDataGridViewTextBoxColumn1.HeaderText = "service_id";
            this.serviceidDataGridViewTextBoxColumn1.Name = "serviceidDataGridViewTextBoxColumn1";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // exceptiontypeDataGridViewTextBoxColumn
            // 
            this.exceptiontypeDataGridViewTextBoxColumn.DataPropertyName = "exception_type";
            this.exceptiontypeDataGridViewTextBoxColumn.HeaderText = "exception_type";
            this.exceptiontypeDataGridViewTextBoxColumn.Name = "exceptiontypeDataGridViewTextBoxColumn";
            // 
            // calendar
            // 
            this.calendar.Controls.Add(this.dataGridViewCalendar);
            this.calendar.Location = new System.Drawing.Point(4, 22);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(660, 182);
            this.calendar.TabIndex = 4;
            this.calendar.Text = "calendar.txt";
            this.calendar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCalendar
            // 
            this.dataGridViewCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCalendar.AutoGenerateColumns = false;
            this.dataGridViewCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalendar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceidDataGridViewTextBoxColumn,
            this.mondayDataGridViewCheckBoxColumn,
            this.tuesdayDataGridViewCheckBoxColumn,
            this.wednesdayDataGridViewCheckBoxColumn,
            this.thursdayDataGridViewCheckBoxColumn,
            this.fridayDataGridViewCheckBoxColumn,
            this.saturdayDataGridViewCheckBoxColumn,
            this.sundayDataGridViewCheckBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.enddateDataGridViewTextBoxColumn});
            this.dataGridViewCalendar.DataSource = this.calendarBindingSource;
            this.dataGridViewCalendar.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewCalendar.Name = "dataGridViewCalendar";
            this.dataGridViewCalendar.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewCalendar.TabIndex = 4;
            this.dataGridViewCalendar.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            // 
            // serviceidDataGridViewTextBoxColumn
            // 
            this.serviceidDataGridViewTextBoxColumn.DataPropertyName = "service_id";
            this.serviceidDataGridViewTextBoxColumn.HeaderText = "service_id";
            this.serviceidDataGridViewTextBoxColumn.Name = "serviceidDataGridViewTextBoxColumn";
            // 
            // mondayDataGridViewCheckBoxColumn
            // 
            this.mondayDataGridViewCheckBoxColumn.DataPropertyName = "monday";
            this.mondayDataGridViewCheckBoxColumn.HeaderText = "monday";
            this.mondayDataGridViewCheckBoxColumn.Name = "mondayDataGridViewCheckBoxColumn";
            // 
            // tuesdayDataGridViewCheckBoxColumn
            // 
            this.tuesdayDataGridViewCheckBoxColumn.DataPropertyName = "tuesday";
            this.tuesdayDataGridViewCheckBoxColumn.HeaderText = "tuesday";
            this.tuesdayDataGridViewCheckBoxColumn.Name = "tuesdayDataGridViewCheckBoxColumn";
            // 
            // wednesdayDataGridViewCheckBoxColumn
            // 
            this.wednesdayDataGridViewCheckBoxColumn.DataPropertyName = "wednesday";
            this.wednesdayDataGridViewCheckBoxColumn.HeaderText = "wednesday";
            this.wednesdayDataGridViewCheckBoxColumn.Name = "wednesdayDataGridViewCheckBoxColumn";
            // 
            // thursdayDataGridViewCheckBoxColumn
            // 
            this.thursdayDataGridViewCheckBoxColumn.DataPropertyName = "thursday";
            this.thursdayDataGridViewCheckBoxColumn.HeaderText = "thursday";
            this.thursdayDataGridViewCheckBoxColumn.Name = "thursdayDataGridViewCheckBoxColumn";
            // 
            // fridayDataGridViewCheckBoxColumn
            // 
            this.fridayDataGridViewCheckBoxColumn.DataPropertyName = "friday";
            this.fridayDataGridViewCheckBoxColumn.HeaderText = "friday";
            this.fridayDataGridViewCheckBoxColumn.Name = "fridayDataGridViewCheckBoxColumn";
            // 
            // saturdayDataGridViewCheckBoxColumn
            // 
            this.saturdayDataGridViewCheckBoxColumn.DataPropertyName = "saturday";
            this.saturdayDataGridViewCheckBoxColumn.HeaderText = "saturday";
            this.saturdayDataGridViewCheckBoxColumn.Name = "saturdayDataGridViewCheckBoxColumn";
            // 
            // sundayDataGridViewCheckBoxColumn
            // 
            this.sundayDataGridViewCheckBoxColumn.DataPropertyName = "sunday";
            this.sundayDataGridViewCheckBoxColumn.HeaderText = "sunday";
            this.sundayDataGridViewCheckBoxColumn.Name = "sundayDataGridViewCheckBoxColumn";
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "start_date";
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            // 
            // enddateDataGridViewTextBoxColumn
            // 
            this.enddateDataGridViewTextBoxColumn.DataPropertyName = "end_date";
            this.enddateDataGridViewTextBoxColumn.HeaderText = "end_date";
            this.enddateDataGridViewTextBoxColumn.Name = "enddateDataGridViewTextBoxColumn";
            // 
            // stop_times
            // 
            this.stop_times.Controls.Add(this.dataGridViewStopTimes);
            this.stop_times.Location = new System.Drawing.Point(4, 22);
            this.stop_times.Name = "stop_times";
            this.stop_times.Size = new System.Drawing.Size(660, 182);
            this.stop_times.TabIndex = 3;
            this.stop_times.Text = "stop_times.txt";
            this.stop_times.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStopTimes
            // 
            this.dataGridViewStopTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStopTimes.AutoGenerateColumns = false;
            this.dataGridViewStopTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStopTimes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tripidDataGridViewTextBoxColumn1,
            this.arrivaltimeDataGridViewTextBoxColumn,
            this.departuretimeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn21,
            this.stopsequenceDataGridViewTextBoxColumn,
            this.stopheadsignDataGridViewTextBoxColumn,
            this.pickuptypeDataGridViewTextBoxColumn,
            this.dropofftypeDataGridViewTextBoxColumn,
            this.shapedisttraveledDataGridViewTextBoxColumn1,
            this.timepointDataGridViewTextBoxColumn});
            this.dataGridViewStopTimes.DataSource = this.stop_timesBindingSource;
            this.dataGridViewStopTimes.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewStopTimes.Name = "dataGridViewStopTimes";
            this.dataGridViewStopTimes.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewStopTimes.TabIndex = 3;
            this.dataGridViewStopTimes.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            // 
            // tripidDataGridViewTextBoxColumn1
            // 
            this.tripidDataGridViewTextBoxColumn1.DataPropertyName = "trip_id";
            this.tripidDataGridViewTextBoxColumn1.HeaderText = "trip_id";
            this.tripidDataGridViewTextBoxColumn1.Name = "tripidDataGridViewTextBoxColumn1";
            // 
            // arrivaltimeDataGridViewTextBoxColumn
            // 
            this.arrivaltimeDataGridViewTextBoxColumn.DataPropertyName = "arrival_time";
            this.arrivaltimeDataGridViewTextBoxColumn.HeaderText = "arrival_time";
            this.arrivaltimeDataGridViewTextBoxColumn.Name = "arrivaltimeDataGridViewTextBoxColumn";
            // 
            // departuretimeDataGridViewTextBoxColumn
            // 
            this.departuretimeDataGridViewTextBoxColumn.DataPropertyName = "departure_time";
            this.departuretimeDataGridViewTextBoxColumn.HeaderText = "departure_time";
            this.departuretimeDataGridViewTextBoxColumn.Name = "departuretimeDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "stop_id";
            this.dataGridViewTextBoxColumn21.HeaderText = "stop_id";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // stopsequenceDataGridViewTextBoxColumn
            // 
            this.stopsequenceDataGridViewTextBoxColumn.DataPropertyName = "stop_sequence";
            this.stopsequenceDataGridViewTextBoxColumn.HeaderText = "stop_sequence";
            this.stopsequenceDataGridViewTextBoxColumn.Name = "stopsequenceDataGridViewTextBoxColumn";
            // 
            // stopheadsignDataGridViewTextBoxColumn
            // 
            this.stopheadsignDataGridViewTextBoxColumn.DataPropertyName = "stop_headsign";
            this.stopheadsignDataGridViewTextBoxColumn.HeaderText = "stop_headsign";
            this.stopheadsignDataGridViewTextBoxColumn.Name = "stopheadsignDataGridViewTextBoxColumn";
            // 
            // pickuptypeDataGridViewTextBoxColumn
            // 
            this.pickuptypeDataGridViewTextBoxColumn.DataPropertyName = "pickup_type";
            this.pickuptypeDataGridViewTextBoxColumn.HeaderText = "pickup_type";
            this.pickuptypeDataGridViewTextBoxColumn.Name = "pickuptypeDataGridViewTextBoxColumn";
            // 
            // dropofftypeDataGridViewTextBoxColumn
            // 
            this.dropofftypeDataGridViewTextBoxColumn.DataPropertyName = "drop_off_type";
            this.dropofftypeDataGridViewTextBoxColumn.HeaderText = "drop_off_type";
            this.dropofftypeDataGridViewTextBoxColumn.Name = "dropofftypeDataGridViewTextBoxColumn";
            // 
            // shapedisttraveledDataGridViewTextBoxColumn1
            // 
            this.shapedisttraveledDataGridViewTextBoxColumn1.DataPropertyName = "shape_dist_traveled";
            this.shapedisttraveledDataGridViewTextBoxColumn1.HeaderText = "shape_dist_traveled";
            this.shapedisttraveledDataGridViewTextBoxColumn1.Name = "shapedisttraveledDataGridViewTextBoxColumn1";
            // 
            // timepointDataGridViewTextBoxColumn
            // 
            this.timepointDataGridViewTextBoxColumn.DataPropertyName = "timepoint";
            this.timepointDataGridViewTextBoxColumn.HeaderText = "timepoint";
            this.timepointDataGridViewTextBoxColumn.Name = "timepointDataGridViewTextBoxColumn";
            // 
            // routes
            // 
            this.routes.Controls.Add(this.dataGridViewRoutes);
            this.routes.Location = new System.Drawing.Point(4, 22);
            this.routes.Name = "routes";
            this.routes.Size = new System.Drawing.Size(660, 182);
            this.routes.TabIndex = 2;
            this.routes.Text = "routes.txt";
            this.routes.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRoutes
            // 
            this.dataGridViewRoutes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRoutes.AutoGenerateColumns = false;
            this.dataGridViewRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoutes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routeidDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn20,
            this.routeshortnameDataGridViewTextBoxColumn,
            this.routelongnameDataGridViewTextBoxColumn,
            this.routedescDataGridViewTextBoxColumn,
            this.routetypeDataGridViewTextBoxColumn,
            this.routeurlDataGridViewTextBoxColumn,
            this.routecolorDataGridViewTextBoxColumn,
            this.routetextcolorDataGridViewTextBoxColumn});
            this.dataGridViewRoutes.DataSource = this.routesBindingSource;
            this.dataGridViewRoutes.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewRoutes.Name = "dataGridViewRoutes";
            this.dataGridViewRoutes.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewRoutes.TabIndex = 2;
            this.dataGridViewRoutes.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            // 
            // routeidDataGridViewTextBoxColumn
            // 
            this.routeidDataGridViewTextBoxColumn.DataPropertyName = "route_id";
            this.routeidDataGridViewTextBoxColumn.HeaderText = "route_id";
            this.routeidDataGridViewTextBoxColumn.Name = "routeidDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "agency_id";
            this.dataGridViewTextBoxColumn20.DataSource = this.agencyBindingSource;
            this.dataGridViewTextBoxColumn20.DisplayMember = "agency_name";
            this.dataGridViewTextBoxColumn20.HeaderText = "agency_id";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn20.ValueMember = "agency_id";
            // 
            // routeshortnameDataGridViewTextBoxColumn
            // 
            this.routeshortnameDataGridViewTextBoxColumn.DataPropertyName = "route_short_name";
            this.routeshortnameDataGridViewTextBoxColumn.HeaderText = "route_short_name";
            this.routeshortnameDataGridViewTextBoxColumn.Name = "routeshortnameDataGridViewTextBoxColumn";
            // 
            // routelongnameDataGridViewTextBoxColumn
            // 
            this.routelongnameDataGridViewTextBoxColumn.DataPropertyName = "route_long_name";
            this.routelongnameDataGridViewTextBoxColumn.HeaderText = "route_long_name";
            this.routelongnameDataGridViewTextBoxColumn.Name = "routelongnameDataGridViewTextBoxColumn";
            // 
            // routedescDataGridViewTextBoxColumn
            // 
            this.routedescDataGridViewTextBoxColumn.DataPropertyName = "route_desc";
            this.routedescDataGridViewTextBoxColumn.HeaderText = "route_desc";
            this.routedescDataGridViewTextBoxColumn.Name = "routedescDataGridViewTextBoxColumn";
            // 
            // routetypeDataGridViewTextBoxColumn
            // 
            this.routetypeDataGridViewTextBoxColumn.DataPropertyName = "route_type";
            this.routetypeDataGridViewTextBoxColumn.HeaderText = "route_type";
            this.routetypeDataGridViewTextBoxColumn.Name = "routetypeDataGridViewTextBoxColumn";
            // 
            // routeurlDataGridViewTextBoxColumn
            // 
            this.routeurlDataGridViewTextBoxColumn.DataPropertyName = "route_url";
            this.routeurlDataGridViewTextBoxColumn.HeaderText = "route_url";
            this.routeurlDataGridViewTextBoxColumn.Name = "routeurlDataGridViewTextBoxColumn";
            // 
            // routecolorDataGridViewTextBoxColumn
            // 
            this.routecolorDataGridViewTextBoxColumn.DataPropertyName = "route_color";
            this.routecolorDataGridViewTextBoxColumn.HeaderText = "route_color";
            this.routecolorDataGridViewTextBoxColumn.Name = "routecolorDataGridViewTextBoxColumn";
            // 
            // routetextcolorDataGridViewTextBoxColumn
            // 
            this.routetextcolorDataGridViewTextBoxColumn.DataPropertyName = "route_text_color";
            this.routetextcolorDataGridViewTextBoxColumn.HeaderText = "route_text_color";
            this.routetextcolorDataGridViewTextBoxColumn.Name = "routetextcolorDataGridViewTextBoxColumn";
            // 
            // stops
            // 
            this.stops.Controls.Add(this.dataGridViewStops);
            this.stops.Location = new System.Drawing.Point(4, 22);
            this.stops.Name = "stops";
            this.stops.Padding = new System.Windows.Forms.Padding(3);
            this.stops.Size = new System.Drawing.Size(660, 182);
            this.stops.TabIndex = 1;
            this.stops.Text = "stops.txt";
            this.stops.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStops
            // 
            this.dataGridViewStops.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStops.AutoGenerateColumns = false;
            this.dataGridViewStops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStops.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataGridViewStops.DataSource = this.stopsBindingSource;
            this.dataGridViewStops.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewStops.Name = "dataGridViewStops";
            this.dataGridViewStops.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewStops.TabIndex = 1;
            this.dataGridViewStops.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "stop_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "stop_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "stop_code";
            this.dataGridViewTextBoxColumn2.HeaderText = "stop_code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "stop_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "stop_name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "stop_desc";
            this.dataGridViewTextBoxColumn4.HeaderText = "stop_desc";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "stop_lat";
            this.dataGridViewTextBoxColumn5.HeaderText = "stop_lat";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "stop_lon";
            this.dataGridViewTextBoxColumn6.HeaderText = "stop_lon";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "zone_id";
            this.dataGridViewTextBoxColumn7.HeaderText = "zone_id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "stop_url";
            this.dataGridViewTextBoxColumn8.HeaderText = "stop_url";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "location_type";
            this.dataGridViewTextBoxColumn9.DataSource = this.location_typeBindingSource;
            this.dataGridViewTextBoxColumn9.DisplayMember = "Display";
            this.dataGridViewTextBoxColumn9.HeaderText = "location_type";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.ValueMember = "Value";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "parent_station";
            this.dataGridViewTextBoxColumn10.HeaderText = "parent_station";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "stop_timezone";
            this.dataGridViewTextBoxColumn11.HeaderText = "stop_timezone";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "wheelchair_boarding";
            this.dataGridViewTextBoxColumn12.DataSource = this.wheelchair_boardingBindingSource;
            this.dataGridViewTextBoxColumn12.DisplayMember = "Display";
            this.dataGridViewTextBoxColumn12.HeaderText = "wheelchair_boarding";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn12.ValueMember = "Value";
            // 
            // agency
            // 
            this.agency.Controls.Add(this.dataGridViewAgency);
            this.agency.Location = new System.Drawing.Point(4, 22);
            this.agency.Name = "agency";
            this.agency.Padding = new System.Windows.Forms.Padding(3);
            this.agency.Size = new System.Drawing.Size(660, 182);
            this.agency.TabIndex = 0;
            this.agency.Text = "agency.txt";
            this.agency.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAgency
            // 
            this.dataGridViewAgency.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAgency.AutoGenerateColumns = false;
            this.dataGridViewAgency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.dataGridViewAgency.DataSource = this.agencyBindingSource;
            this.dataGridViewAgency.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewAgency.Name = "dataGridViewAgency";
            this.dataGridViewAgency.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewAgency.TabIndex = 0;
            this.dataGridViewAgency.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "agency_id";
            this.dataGridViewTextBoxColumn13.HeaderText = "agency_id";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "agency_name";
            this.dataGridViewTextBoxColumn14.HeaderText = "agency_name";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "agency_url";
            this.dataGridViewTextBoxColumn15.HeaderText = "agency_url";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "agency_timezone";
            this.dataGridViewTextBoxColumn16.DataSource = this.time_zoneBindingSource;
            this.dataGridViewTextBoxColumn16.DisplayMember = "TZ";
            this.dataGridViewTextBoxColumn16.HeaderText = "agency_timezone";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn16.ValueMember = "TZ";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "agency_lang";
            this.dataGridViewTextBoxColumn17.DataSource = this.languageBindingSource;
            this.dataGridViewTextBoxColumn17.DisplayMember = "English name of Language";
            this.dataGridViewTextBoxColumn17.HeaderText = "agency_lang";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn17.ValueMember = "ISO 639-1 Code";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "agency_phone";
            this.dataGridViewTextBoxColumn18.HeaderText = "agency_phone";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "agency_fare_url";
            this.dataGridViewTextBoxColumn19.HeaderText = "agency_fare_url";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.agency);
            this.tabControl1.Controls.Add(this.stops);
            this.tabControl1.Controls.Add(this.routes);
            this.tabControl1.Controls.Add(this.stop_times);
            this.tabControl1.Controls.Add(this.calendar);
            this.tabControl1.Controls.Add(this.calendar_dates);
            this.tabControl1.Controls.Add(this.fare_attributes);
            this.tabControl1.Controls.Add(this.fare_rules);
            this.tabControl1.Controls.Add(this.shapes);
            this.tabControl1.Controls.Add(this.frequencies);
            this.tabControl1.Controls.Add(this.transfers);
            this.tabControl1.Controls.Add(this.feed_info);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 208);
            this.tabControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 247);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.time_zoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.location_typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheelchair_boardingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop_timesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendar_dateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fare_attributesDindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fare_rulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transfersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feed_infoBindingSource)).EndInit();
            this.feed_info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeedInfo)).EndInit();
            this.transfers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransfers)).EndInit();
            this.frequencies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrequencies)).EndInit();
            this.shapes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShapes)).EndInit();
            this.fare_rules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFareRules)).EndInit();
            this.fare_attributes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFareAttributes)).EndInit();
            this.calendar_dates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendarDates)).EndInit();
            this.calendar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendar)).EndInit();
            this.stop_times.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStopTimes)).EndInit();
            this.routes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoutes)).EndInit();
            this.stops.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStops)).EndInit();
            this.agency.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgency)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImportZip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImportFolder;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportZip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn agencyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agencynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agencyurlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agencytimezoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agencylangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agencyphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agencyfareurlDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource agencyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoplatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoplonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopurlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentstationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoptimezoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wheelchairboardingDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stopsBindingSource;
        private System.Windows.Forms.BindingSource routesBindingSource;
        private System.Windows.Forms.BindingSource stop_timesBindingSource;
        private System.Windows.Forms.BindingSource calendarBindingSource;
        private System.Windows.Forms.BindingSource calendar_dateBindingSource;
        private System.Windows.Forms.BindingSource fare_attributesDindingSource;
        private System.Windows.Forms.BindingSource fare_rulesBindingSource;
        private System.Windows.Forms.BindingSource shapesBindingSource;
        private System.Windows.Forms.BindingSource frequenciesBindingSource;
        private System.Windows.Forms.BindingSource transfersBindingSource;
        private System.Windows.Forms.BindingSource feed_infoBindingSource;
        private System.Windows.Forms.BindingSource location_typeBindingSource;
        private System.Windows.Forms.BindingSource time_zoneBindingSource;
        private System.Windows.Forms.BindingSource languageBindingSource;
        private System.Windows.Forms.BindingSource wheelchair_boardingBindingSource;
        private System.Windows.Forms.TabPage feed_info;
        private System.Windows.Forms.DataGridView dataGridViewFeedInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedpublishernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedpublisherurlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedlangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedstartdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedenddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedversionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage transfers;
        private System.Windows.Forms.DataGridView dataGridViewTransfers;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromstopidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tostopidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transfertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mintransfertimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage frequencies;
        private System.Windows.Forms.DataGridView dataGridViewFrequencies;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headwaysecsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exacttimesDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage shapes;
        private System.Windows.Forms.DataGridView dataGridViewShapes;
        private System.Windows.Forms.DataGridViewTextBoxColumn shapeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shapeptlatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shapeptlonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shapeptsequenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shapedisttraveledDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage fare_rules;
        private System.Windows.Forms.DataGridView dataGridViewFareRules;
        private System.Windows.Forms.DataGridViewTextBoxColumn fareidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn originidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn containsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage fare_attributes;
        private System.Windows.Forms.DataGridView dataGridViewFareAttributes;
        private System.Windows.Forms.DataGridViewTextBoxColumn fareidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencytypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentmethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transfersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferdurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage calendar_dates;
        private System.Windows.Forms.DataGridView dataGridViewCalendarDates;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exceptiontypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage calendar;
        private System.Windows.Forms.DataGridView dataGridViewCalendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mondayDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tuesdayDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn wednesdayDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn thursdayDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fridayDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn saturdayDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sundayDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage stop_times;
        private System.Windows.Forms.DataGridView dataGridViewStopTimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivaltimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departuretimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopsequenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopheadsignDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickuptypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dropofftypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shapedisttraveledDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timepointDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage routes;
        private System.Windows.Forms.DataGridView dataGridViewRoutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeshortnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routelongnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routedescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeurlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routecolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routetextcolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage stops;
        private System.Windows.Forms.DataGridView dataGridViewStops;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.TabPage agency;
        private System.Windows.Forms.DataGridView dataGridViewAgency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.TabControl tabControl1;
    }
}