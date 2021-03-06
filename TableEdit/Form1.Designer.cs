﻿namespace TableEdit
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
            this.toolStripMenuItemImportShapes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemImportShapesCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemImportShapesSQLite = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemImportStops = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemImportStopsCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemImportStopsSQLite = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExportZip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExportFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExportShapes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExportShapeCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExportShapesSQLite = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExportStops = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExportStopsCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExportStopsSQLite = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogGTFS = new System.Windows.Forms.OpenFileDialog();
            this.feed_info = new System.Windows.Forms.TabPage();
            this.dataGridViewFeedInfo = new System.Windows.Forms.DataGridView();
            this.transfers = new System.Windows.Forms.TabPage();
            this.dataGridViewTransfers = new System.Windows.Forms.DataGridView();
            this.frequencies = new System.Windows.Forms.TabPage();
            this.dataGridViewFrequencies = new System.Windows.Forms.DataGridView();
            this.shapes = new System.Windows.Forms.TabPage();
            this.dataGridViewShapes = new System.Windows.Forms.DataGridView();
            this.fare_rules = new System.Windows.Forms.TabPage();
            this.dataGridViewFareRules = new System.Windows.Forms.DataGridView();
            this.fare_attributes = new System.Windows.Forms.TabPage();
            this.dataGridViewFareAttributes = new System.Windows.Forms.DataGridView();
            this.calendar_dates = new System.Windows.Forms.TabPage();
            this.dataGridViewCalendarDates = new System.Windows.Forms.DataGridView();
            this.calendar = new System.Windows.Forms.TabPage();
            this.dataGridViewCalendar = new System.Windows.Forms.DataGridView();
            this.stop_times = new System.Windows.Forms.TabPage();
            this.dataGridViewStopTimes = new System.Windows.Forms.DataGridView();
            this.routes = new System.Windows.Forms.TabPage();
            this.dataGridViewRoutes = new System.Windows.Forms.DataGridView();
            this.stops = new System.Windows.Forms.TabPage();
            this.dataGridViewStops = new System.Windows.Forms.DataGridView();
            this.agency = new System.Windows.Forms.TabPage();
            this.dataGridViewAgency = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.trips = new System.Windows.Forms.TabPage();
            this.dataGridViewTrips = new System.Windows.Forms.DataGridView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialogGTFS = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogGIS = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogShapes = new System.Windows.Forms.OpenFileDialog();
            this.agencyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agencynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agencyurlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agencytimezoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.time_zoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agencylangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.languageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agencyphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agencyfareurlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._agency_txtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stopidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoplatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoplonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopurlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.location_typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parentstationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoptimezoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wheelchairboardingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wheelchair_boardingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._stops_txtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.routeshortnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routelongnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routedescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.route_typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routeurlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routecolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routetextcolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._routes_txtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routeidDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.serviceidDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this._calendar_txtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tripidDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tripheadsignDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tripshortnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.blockidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapeidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pathsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wheelchairaccessibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wheelchair_accessibleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bikesallowedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bikes_allowedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._trips_txtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tripidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.arrivaltimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departuretimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stopsequenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopheadsignDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickuptypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pickup_typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dropofftypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.drop_off_typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shapedisttraveledDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timepointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._stop_times_txtBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.serviceidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exceptiontypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.exception_typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._calendar_dates_txtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fareidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencytypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentmethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.payment_methodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transfersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.transfersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transferdurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._fare_attributes_txtDindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fareidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.originidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._fare_rules_txtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shapeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapeptlatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapeptlonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapeptsequenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapedisttraveledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._shapes_txtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tripidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headwaysecsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exacttimesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._frequencies_txtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._transfers_txtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._feed_info_txtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transfer_typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fromstopidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tostopidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.transfertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mintransfertimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedpublishernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedpublisherurlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedlangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.feedstartdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedenddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedversionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
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
            this.trips.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_zoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._agency_txtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.location_typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheelchair_boardingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._stops_txtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.route_typesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._routes_txtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._calendar_txtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheelchair_accessibleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikes_allowedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._trips_txtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickup_typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drop_off_typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._stop_times_txtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exception_typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._calendar_dates_txtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_methodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transfersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._fare_attributes_txtDindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._fare_rules_txtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._shapes_txtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._frequencies_txtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._transfers_txtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._feed_info_txtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transfer_typeBindingSource)).BeginInit();
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
            this.toolStripMenuItemImportFolder,
            this.toolStripMenuItemImportShapes,
            this.toolStripMenuItemImportStops});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "&Import";
            // 
            // toolStripMenuItemImportZip
            // 
            this.toolStripMenuItemImportZip.Name = "toolStripMenuItemImportZip";
            this.toolStripMenuItemImportZip.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItemImportZip.Text = "&Zip";
            this.toolStripMenuItemImportZip.Click += new System.EventHandler(this.toolStripMenuItemImportZip_Click);
            // 
            // toolStripMenuItemImportFolder
            // 
            this.toolStripMenuItemImportFolder.Name = "toolStripMenuItemImportFolder";
            this.toolStripMenuItemImportFolder.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItemImportFolder.Text = "&Folder";
            this.toolStripMenuItemImportFolder.Click += new System.EventHandler(this.toolStripMenuItemImportFolder_Click);
            // 
            // toolStripMenuItemImportShapes
            // 
            this.toolStripMenuItemImportShapes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemImportShapesCSV,
            this.toolStripMenuItemImportShapesSQLite});
            this.toolStripMenuItemImportShapes.Name = "toolStripMenuItemImportShapes";
            this.toolStripMenuItemImportShapes.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItemImportShapes.Text = "Shapes";
            // 
            // toolStripMenuItemImportShapesCSV
            // 
            this.toolStripMenuItemImportShapesCSV.Name = "toolStripMenuItemImportShapesCSV";
            this.toolStripMenuItemImportShapesCSV.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItemImportShapesCSV.Text = "CSV";
            this.toolStripMenuItemImportShapesCSV.Click += new System.EventHandler(this.toolStripMenuItemImportShapesCSV_Click);
            // 
            // toolStripMenuItemImportShapesSQLite
            // 
            this.toolStripMenuItemImportShapesSQLite.Name = "toolStripMenuItemImportShapesSQLite";
            this.toolStripMenuItemImportShapesSQLite.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItemImportShapesSQLite.Text = "SQLite";
            this.toolStripMenuItemImportShapesSQLite.Click += new System.EventHandler(this.toolStripMenuItemImportShapesSQLite_Click);
            // 
            // toolStripMenuItemImportStops
            // 
            this.toolStripMenuItemImportStops.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemImportStopsCSV,
            this.toolStripMenuItemImportStopsSQLite});
            this.toolStripMenuItemImportStops.Name = "toolStripMenuItemImportStops";
            this.toolStripMenuItemImportStops.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItemImportStops.Text = "Stops";
            // 
            // toolStripMenuItemImportStopsCSV
            // 
            this.toolStripMenuItemImportStopsCSV.Name = "toolStripMenuItemImportStopsCSV";
            this.toolStripMenuItemImportStopsCSV.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItemImportStopsCSV.Text = "CSV";
            this.toolStripMenuItemImportStopsCSV.Click += new System.EventHandler(this.toolStripMenuItemImportStopsCSV_Click);
            // 
            // toolStripMenuItemImportStopsSQLite
            // 
            this.toolStripMenuItemImportStopsSQLite.Name = "toolStripMenuItemImportStopsSQLite";
            this.toolStripMenuItemImportStopsSQLite.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItemImportStopsSQLite.Text = "SQLite";
            this.toolStripMenuItemImportStopsSQLite.Click += new System.EventHandler(this.toolStripMenuItemImportStopsSQLite_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExportZip,
            this.toolStripMenuItemExportFolder,
            this.toolStripMenuItemExportShapes,
            this.toolStripMenuItemExportStops});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "&Export";
            // 
            // toolStripMenuItemExportZip
            // 
            this.toolStripMenuItemExportZip.Name = "toolStripMenuItemExportZip";
            this.toolStripMenuItemExportZip.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItemExportZip.Text = "&Zip";
            this.toolStripMenuItemExportZip.Click += new System.EventHandler(this.toolStripMenuItemExportZip_Click);
            // 
            // toolStripMenuItemExportFolder
            // 
            this.toolStripMenuItemExportFolder.Name = "toolStripMenuItemExportFolder";
            this.toolStripMenuItemExportFolder.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItemExportFolder.Text = "&Folder";
            this.toolStripMenuItemExportFolder.Click += new System.EventHandler(this.toolStripMenuItemExportFolder_Click);
            // 
            // toolStripMenuItemExportShapes
            // 
            this.toolStripMenuItemExportShapes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExportShapeCSV,
            this.toolStripMenuItemExportShapesSQLite});
            this.toolStripMenuItemExportShapes.Name = "toolStripMenuItemExportShapes";
            this.toolStripMenuItemExportShapes.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItemExportShapes.Text = "Shapes";
            // 
            // toolStripMenuItemExportShapeCSV
            // 
            this.toolStripMenuItemExportShapeCSV.Name = "toolStripMenuItemExportShapeCSV";
            this.toolStripMenuItemExportShapeCSV.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItemExportShapeCSV.Text = "CSV";
            this.toolStripMenuItemExportShapeCSV.Click += new System.EventHandler(this.toolStripMenuItemExportShapesCSV_Click);
            // 
            // toolStripMenuItemExportShapesSQLite
            // 
            this.toolStripMenuItemExportShapesSQLite.Name = "toolStripMenuItemExportShapesSQLite";
            this.toolStripMenuItemExportShapesSQLite.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItemExportShapesSQLite.Text = "SQLite";
            this.toolStripMenuItemExportShapesSQLite.Click += new System.EventHandler(this.toolStripMenuItemExportShapesSQLite_Click);
            // 
            // toolStripMenuItemExportStops
            // 
            this.toolStripMenuItemExportStops.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExportStopsCSV,
            this.toolStripMenuItemExportStopsSQLite});
            this.toolStripMenuItemExportStops.Name = "toolStripMenuItemExportStops";
            this.toolStripMenuItemExportStops.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItemExportStops.Text = "Stops";
            // 
            // toolStripMenuItemExportStopsCSV
            // 
            this.toolStripMenuItemExportStopsCSV.Name = "toolStripMenuItemExportStopsCSV";
            this.toolStripMenuItemExportStopsCSV.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItemExportStopsCSV.Text = "CSV";
            this.toolStripMenuItemExportStopsCSV.Click += new System.EventHandler(this.toolStripMenuItemExportStopsCSV_Click);
            // 
            // toolStripMenuItemExportStopsSQLite
            // 
            this.toolStripMenuItemExportStopsSQLite.Name = "toolStripMenuItemExportStopsSQLite";
            this.toolStripMenuItemExportStopsSQLite.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItemExportStopsSQLite.Text = "SQLite";
            this.toolStripMenuItemExportStopsSQLite.Click += new System.EventHandler(this.toolStripMenuItemExportStopsSQLite_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialogGTFS
            // 
            this.openFileDialogGTFS.Filter = "Zip Files|*.zip";
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
            this.dataGridViewFeedInfo.DataSource = this._feed_info_txtBindingSource;
            this.dataGridViewFeedInfo.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewFeedInfo.Name = "dataGridViewFeedInfo";
            this.dataGridViewFeedInfo.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewFeedInfo.TabIndex = 11;
            this.dataGridViewFeedInfo.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
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
            this.dataGridViewTransfers.DataSource = this._transfers_txtBindingSource;
            this.dataGridViewTransfers.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewTransfers.Name = "dataGridViewTransfers";
            this.dataGridViewTransfers.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewTransfers.TabIndex = 10;
            this.dataGridViewTransfers.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
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
            this.dataGridViewFrequencies.DataSource = this._frequencies_txtBindingSource;
            this.dataGridViewFrequencies.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewFrequencies.Name = "dataGridViewFrequencies";
            this.dataGridViewFrequencies.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewFrequencies.TabIndex = 9;
            this.dataGridViewFrequencies.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
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
            this.dataGridViewShapes.DataSource = this._shapes_txtBindingSource;
            this.dataGridViewShapes.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewShapes.Name = "dataGridViewShapes";
            this.dataGridViewShapes.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewShapes.TabIndex = 8;
            this.dataGridViewShapes.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
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
            this.dataGridViewFareRules.DataSource = this._fare_rules_txtBindingSource;
            this.dataGridViewFareRules.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewFareRules.Name = "dataGridViewFareRules";
            this.dataGridViewFareRules.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewFareRules.TabIndex = 7;
            this.dataGridViewFareRules.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
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
            this.dataGridViewFareAttributes.DataSource = this._fare_attributes_txtDindingSource;
            this.dataGridViewFareAttributes.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewFareAttributes.Name = "dataGridViewFareAttributes";
            this.dataGridViewFareAttributes.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewFareAttributes.TabIndex = 6;
            this.dataGridViewFareAttributes.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
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
            this.dataGridViewCalendarDates.DataSource = this._calendar_dates_txtBindingSource;
            this.dataGridViewCalendarDates.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewCalendarDates.Name = "dataGridViewCalendarDates";
            this.dataGridViewCalendarDates.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewCalendarDates.TabIndex = 5;
            this.dataGridViewCalendarDates.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
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
            this.dataGridViewCalendar.DataSource = this._calendar_txtBindingSource;
            this.dataGridViewCalendar.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewCalendar.Name = "dataGridViewCalendar";
            this.dataGridViewCalendar.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewCalendar.TabIndex = 4;
            this.dataGridViewCalendar.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
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
            this.dataGridViewStopTimes.DataSource = this._stop_times_txtBindingSource;
            this.dataGridViewStopTimes.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewStopTimes.Name = "dataGridViewStopTimes";
            this.dataGridViewStopTimes.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewStopTimes.TabIndex = 3;
            this.dataGridViewStopTimes.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
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
            this.dataGridViewRoutes.DataSource = this._routes_txtBindingSource;
            this.dataGridViewRoutes.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewRoutes.Name = "dataGridViewRoutes";
            this.dataGridViewRoutes.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewRoutes.TabIndex = 2;
            this.dataGridViewRoutes.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
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
            this.stopidDataGridViewTextBoxColumn,
            this.stopcodeDataGridViewTextBoxColumn,
            this.stopnameDataGridViewTextBoxColumn,
            this.stopdescDataGridViewTextBoxColumn,
            this.stoplatDataGridViewTextBoxColumn,
            this.stoplonDataGridViewTextBoxColumn,
            this.zoneidDataGridViewTextBoxColumn,
            this.stopurlDataGridViewTextBoxColumn,
            this.locationtypeDataGridViewTextBoxColumn,
            this.parentstationDataGridViewTextBoxColumn,
            this.stoptimezoneDataGridViewTextBoxColumn,
            this.wheelchairboardingDataGridViewTextBoxColumn});
            this.dataGridViewStops.DataSource = this._stops_txtBindingSource;
            this.dataGridViewStops.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewStops.Name = "dataGridViewStops";
            this.dataGridViewStops.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewStops.TabIndex = 1;
            this.dataGridViewStops.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
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
            this.agencyidDataGridViewTextBoxColumn,
            this.agencynameDataGridViewTextBoxColumn,
            this.agencyurlDataGridViewTextBoxColumn,
            this.agencytimezoneDataGridViewTextBoxColumn,
            this.agencylangDataGridViewTextBoxColumn,
            this.agencyphoneDataGridViewTextBoxColumn,
            this.agencyfareurlDataGridViewTextBoxColumn});
            this.dataGridViewAgency.DataSource = this._agency_txtBindingSource;
            this.dataGridViewAgency.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewAgency.Name = "dataGridViewAgency";
            this.dataGridViewAgency.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewAgency.TabIndex = 0;
            this.dataGridViewAgency.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.agency);
            this.tabControl1.Controls.Add(this.stops);
            this.tabControl1.Controls.Add(this.routes);
            this.tabControl1.Controls.Add(this.trips);
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
            // trips
            // 
            this.trips.Controls.Add(this.dataGridViewTrips);
            this.trips.Location = new System.Drawing.Point(4, 22);
            this.trips.Name = "trips";
            this.trips.Size = new System.Drawing.Size(660, 182);
            this.trips.TabIndex = 12;
            this.trips.Text = "trips";
            this.trips.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTrips
            // 
            this.dataGridViewTrips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTrips.AutoGenerateColumns = false;
            this.dataGridViewTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routeidDataGridViewTextBoxColumn2,
            this.serviceidDataGridViewTextBoxColumn2,
            this.tripidDataGridViewTextBoxColumn2,
            this.tripheadsignDataGridViewTextBoxColumn,
            this.tripshortnameDataGridViewTextBoxColumn,
            this.directionidDataGridViewTextBoxColumn,
            this.blockidDataGridViewTextBoxColumn,
            this.shapeidDataGridViewTextBoxColumn1,
            this.wheelchairaccessibleDataGridViewTextBoxColumn,
            this.bikesallowedDataGridViewTextBoxColumn});
            this.dataGridViewTrips.DataSource = this._trips_txtBindingSource;
            this.dataGridViewTrips.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewTrips.Name = "dataGridViewTrips";
            this.dataGridViewTrips.Size = new System.Drawing.Size(648, 170);
            this.dataGridViewTrips.TabIndex = 3;
            // 
            // saveFileDialogGTFS
            // 
            this.saveFileDialogGTFS.DefaultExt = "zip";
            // 
            // agencyidDataGridViewTextBoxColumn
            // 
            this.agencyidDataGridViewTextBoxColumn.DataPropertyName = "agency_id";
            this.agencyidDataGridViewTextBoxColumn.HeaderText = "agency_id";
            this.agencyidDataGridViewTextBoxColumn.Name = "agencyidDataGridViewTextBoxColumn";
            // 
            // agencynameDataGridViewTextBoxColumn
            // 
            this.agencynameDataGridViewTextBoxColumn.DataPropertyName = "agency_name";
            this.agencynameDataGridViewTextBoxColumn.HeaderText = "agency_name";
            this.agencynameDataGridViewTextBoxColumn.Name = "agencynameDataGridViewTextBoxColumn";
            // 
            // agencyurlDataGridViewTextBoxColumn
            // 
            this.agencyurlDataGridViewTextBoxColumn.DataPropertyName = "agency_url";
            this.agencyurlDataGridViewTextBoxColumn.HeaderText = "agency_url";
            this.agencyurlDataGridViewTextBoxColumn.Name = "agencyurlDataGridViewTextBoxColumn";
            this.agencyurlDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // agencytimezoneDataGridViewTextBoxColumn
            // 
            this.agencytimezoneDataGridViewTextBoxColumn.DataPropertyName = "agency_timezone";
            this.agencytimezoneDataGridViewTextBoxColumn.DataSource = this.time_zoneBindingSource;
            this.agencytimezoneDataGridViewTextBoxColumn.DisplayMember = "TZ";
            this.agencytimezoneDataGridViewTextBoxColumn.HeaderText = "agency_timezone";
            this.agencytimezoneDataGridViewTextBoxColumn.Name = "agencytimezoneDataGridViewTextBoxColumn";
            this.agencytimezoneDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.agencytimezoneDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.agencytimezoneDataGridViewTextBoxColumn.ValueMember = "TZ";
            // 
            // time_zoneBindingSource
            // 
            this.time_zoneBindingSource.DataMember = "time_zone";
            this.time_zoneBindingSource.DataSource = typeof(GTFSTools.IO.GTFSLookupTables);
            // 
            // agencylangDataGridViewTextBoxColumn
            // 
            this.agencylangDataGridViewTextBoxColumn.DataPropertyName = "agency_lang";
            this.agencylangDataGridViewTextBoxColumn.DataSource = this.languageBindingSource;
            this.agencylangDataGridViewTextBoxColumn.DisplayMember = "English name of Language";
            this.agencylangDataGridViewTextBoxColumn.HeaderText = "agency_lang";
            this.agencylangDataGridViewTextBoxColumn.Name = "agencylangDataGridViewTextBoxColumn";
            this.agencylangDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.agencylangDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.agencylangDataGridViewTextBoxColumn.ValueMember = "ISO 639-1 Code";
            // 
            // languageBindingSource
            // 
            this.languageBindingSource.DataMember = "language";
            this.languageBindingSource.DataSource = typeof(GTFSTools.IO.GTFSLookupTables);
            // 
            // agencyphoneDataGridViewTextBoxColumn
            // 
            this.agencyphoneDataGridViewTextBoxColumn.DataPropertyName = "agency_phone";
            this.agencyphoneDataGridViewTextBoxColumn.HeaderText = "agency_phone";
            this.agencyphoneDataGridViewTextBoxColumn.Name = "agencyphoneDataGridViewTextBoxColumn";
            // 
            // agencyfareurlDataGridViewTextBoxColumn
            // 
            this.agencyfareurlDataGridViewTextBoxColumn.DataPropertyName = "agency_fare_url";
            this.agencyfareurlDataGridViewTextBoxColumn.HeaderText = "agency_fare_url";
            this.agencyfareurlDataGridViewTextBoxColumn.Name = "agencyfareurlDataGridViewTextBoxColumn";
            // 
            // _agency_txtBindingSource
            // 
            this._agency_txtBindingSource.DataMember = "agency.txt";
            this._agency_txtBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
            // 
            // stopidDataGridViewTextBoxColumn
            // 
            this.stopidDataGridViewTextBoxColumn.DataPropertyName = "stop_id";
            this.stopidDataGridViewTextBoxColumn.HeaderText = "stop_id";
            this.stopidDataGridViewTextBoxColumn.Name = "stopidDataGridViewTextBoxColumn";
            // 
            // stopcodeDataGridViewTextBoxColumn
            // 
            this.stopcodeDataGridViewTextBoxColumn.DataPropertyName = "stop_code";
            this.stopcodeDataGridViewTextBoxColumn.HeaderText = "stop_code";
            this.stopcodeDataGridViewTextBoxColumn.Name = "stopcodeDataGridViewTextBoxColumn";
            // 
            // stopnameDataGridViewTextBoxColumn
            // 
            this.stopnameDataGridViewTextBoxColumn.DataPropertyName = "stop_name";
            this.stopnameDataGridViewTextBoxColumn.HeaderText = "stop_name";
            this.stopnameDataGridViewTextBoxColumn.Name = "stopnameDataGridViewTextBoxColumn";
            // 
            // stopdescDataGridViewTextBoxColumn
            // 
            this.stopdescDataGridViewTextBoxColumn.DataPropertyName = "stop_desc";
            this.stopdescDataGridViewTextBoxColumn.HeaderText = "stop_desc";
            this.stopdescDataGridViewTextBoxColumn.Name = "stopdescDataGridViewTextBoxColumn";
            // 
            // stoplatDataGridViewTextBoxColumn
            // 
            this.stoplatDataGridViewTextBoxColumn.DataPropertyName = "stop_lat";
            this.stoplatDataGridViewTextBoxColumn.HeaderText = "stop_lat";
            this.stoplatDataGridViewTextBoxColumn.Name = "stoplatDataGridViewTextBoxColumn";
            // 
            // stoplonDataGridViewTextBoxColumn
            // 
            this.stoplonDataGridViewTextBoxColumn.DataPropertyName = "stop_lon";
            this.stoplonDataGridViewTextBoxColumn.HeaderText = "stop_lon";
            this.stoplonDataGridViewTextBoxColumn.Name = "stoplonDataGridViewTextBoxColumn";
            // 
            // zoneidDataGridViewTextBoxColumn
            // 
            this.zoneidDataGridViewTextBoxColumn.DataPropertyName = "zone_id";
            this.zoneidDataGridViewTextBoxColumn.HeaderText = "zone_id";
            this.zoneidDataGridViewTextBoxColumn.Name = "zoneidDataGridViewTextBoxColumn";
            // 
            // stopurlDataGridViewTextBoxColumn
            // 
            this.stopurlDataGridViewTextBoxColumn.DataPropertyName = "stop_url";
            this.stopurlDataGridViewTextBoxColumn.HeaderText = "stop_url";
            this.stopurlDataGridViewTextBoxColumn.Name = "stopurlDataGridViewTextBoxColumn";
            // 
            // locationtypeDataGridViewTextBoxColumn
            // 
            this.locationtypeDataGridViewTextBoxColumn.DataPropertyName = "location_type";
            this.locationtypeDataGridViewTextBoxColumn.DataSource = this.location_typeBindingSource;
            this.locationtypeDataGridViewTextBoxColumn.DisplayMember = "Display";
            this.locationtypeDataGridViewTextBoxColumn.HeaderText = "location_type";
            this.locationtypeDataGridViewTextBoxColumn.Name = "locationtypeDataGridViewTextBoxColumn";
            this.locationtypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.locationtypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.locationtypeDataGridViewTextBoxColumn.ValueMember = "Value";
            // 
            // location_typeBindingSource
            // 
            this.location_typeBindingSource.DataMember = "location_type";
            this.location_typeBindingSource.DataSource = typeof(GTFSTools.IO.GTFSLookupTables);
            // 
            // parentstationDataGridViewTextBoxColumn
            // 
            this.parentstationDataGridViewTextBoxColumn.DataPropertyName = "parent_station";
            this.parentstationDataGridViewTextBoxColumn.HeaderText = "parent_station";
            this.parentstationDataGridViewTextBoxColumn.Name = "parentstationDataGridViewTextBoxColumn";
            // 
            // stoptimezoneDataGridViewTextBoxColumn
            // 
            this.stoptimezoneDataGridViewTextBoxColumn.DataPropertyName = "stop_timezone";
            this.stoptimezoneDataGridViewTextBoxColumn.DataSource = this.time_zoneBindingSource;
            this.stoptimezoneDataGridViewTextBoxColumn.DisplayMember = "TZ";
            this.stoptimezoneDataGridViewTextBoxColumn.HeaderText = "stop_timezone";
            this.stoptimezoneDataGridViewTextBoxColumn.Name = "stoptimezoneDataGridViewTextBoxColumn";
            this.stoptimezoneDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stoptimezoneDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stoptimezoneDataGridViewTextBoxColumn.ValueMember = "TZ";
            // 
            // wheelchairboardingDataGridViewTextBoxColumn
            // 
            this.wheelchairboardingDataGridViewTextBoxColumn.DataPropertyName = "wheelchair_boarding";
            this.wheelchairboardingDataGridViewTextBoxColumn.DataSource = this.wheelchair_boardingBindingSource;
            this.wheelchairboardingDataGridViewTextBoxColumn.DisplayMember = "Display";
            this.wheelchairboardingDataGridViewTextBoxColumn.HeaderText = "wheelchair_boarding";
            this.wheelchairboardingDataGridViewTextBoxColumn.Name = "wheelchairboardingDataGridViewTextBoxColumn";
            this.wheelchairboardingDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wheelchairboardingDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wheelchairboardingDataGridViewTextBoxColumn.ValueMember = "Value";
            // 
            // wheelchair_boardingBindingSource
            // 
            this.wheelchair_boardingBindingSource.DataMember = "wheelchair_boarding";
            this.wheelchair_boardingBindingSource.DataSource = typeof(GTFSTools.IO.GTFSLookupTables);
            // 
            // _stops_txtBindingSource
            // 
            this._stops_txtBindingSource.DataMember = "stops.txt";
            this._stops_txtBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
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
            this.dataGridViewTextBoxColumn20.DataSource = this._agency_txtBindingSource;
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
            this.routetypeDataGridViewTextBoxColumn.DataSource = this.route_typesBindingSource;
            this.routetypeDataGridViewTextBoxColumn.DisplayMember = "Display";
            this.routetypeDataGridViewTextBoxColumn.HeaderText = "route_type";
            this.routetypeDataGridViewTextBoxColumn.Name = "routetypeDataGridViewTextBoxColumn";
            this.routetypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.routetypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.routetypeDataGridViewTextBoxColumn.ValueMember = "Value";
            // 
            // route_typesBindingSource
            // 
            this.route_typesBindingSource.DataMember = "route_type";
            this.route_typesBindingSource.DataSource = typeof(GTFSTools.IO.GTFSLookupTables);
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
            // _routes_txtBindingSource
            // 
            this._routes_txtBindingSource.DataMember = "routes.txt";
            this._routes_txtBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
            // 
            // routeidDataGridViewTextBoxColumn2
            // 
            this.routeidDataGridViewTextBoxColumn2.DataPropertyName = "route_id";
            this.routeidDataGridViewTextBoxColumn2.DataSource = this._routes_txtBindingSource;
            this.routeidDataGridViewTextBoxColumn2.DisplayMember = "route_short_name";
            this.routeidDataGridViewTextBoxColumn2.HeaderText = "route_id";
            this.routeidDataGridViewTextBoxColumn2.Name = "routeidDataGridViewTextBoxColumn2";
            this.routeidDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.routeidDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.routeidDataGridViewTextBoxColumn2.ValueMember = "route_id";
            // 
            // serviceidDataGridViewTextBoxColumn2
            // 
            this.serviceidDataGridViewTextBoxColumn2.DataPropertyName = "service_id";
            this.serviceidDataGridViewTextBoxColumn2.DataSource = this._calendar_txtBindingSource;
            this.serviceidDataGridViewTextBoxColumn2.DisplayMember = "service_id";
            this.serviceidDataGridViewTextBoxColumn2.HeaderText = "service_id";
            this.serviceidDataGridViewTextBoxColumn2.Name = "serviceidDataGridViewTextBoxColumn2";
            this.serviceidDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceidDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.serviceidDataGridViewTextBoxColumn2.ValueMember = "service_id";
            // 
            // _calendar_txtBindingSource
            // 
            this._calendar_txtBindingSource.DataMember = "calendar.txt";
            this._calendar_txtBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
            // 
            // tripidDataGridViewTextBoxColumn2
            // 
            this.tripidDataGridViewTextBoxColumn2.DataPropertyName = "trip_id";
            this.tripidDataGridViewTextBoxColumn2.HeaderText = "trip_id";
            this.tripidDataGridViewTextBoxColumn2.Name = "tripidDataGridViewTextBoxColumn2";
            // 
            // tripheadsignDataGridViewTextBoxColumn
            // 
            this.tripheadsignDataGridViewTextBoxColumn.DataPropertyName = "trip_headsign";
            this.tripheadsignDataGridViewTextBoxColumn.HeaderText = "trip_headsign";
            this.tripheadsignDataGridViewTextBoxColumn.Name = "tripheadsignDataGridViewTextBoxColumn";
            // 
            // tripshortnameDataGridViewTextBoxColumn
            // 
            this.tripshortnameDataGridViewTextBoxColumn.DataPropertyName = "trip_short_name";
            this.tripshortnameDataGridViewTextBoxColumn.HeaderText = "trip_short_name";
            this.tripshortnameDataGridViewTextBoxColumn.Name = "tripshortnameDataGridViewTextBoxColumn";
            // 
            // directionidDataGridViewTextBoxColumn
            // 
            this.directionidDataGridViewTextBoxColumn.DataPropertyName = "direction_id";
            this.directionidDataGridViewTextBoxColumn.HeaderText = "direction_id";
            this.directionidDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "0",
            "1"});
            this.directionidDataGridViewTextBoxColumn.Name = "directionidDataGridViewTextBoxColumn";
            this.directionidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.directionidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // blockidDataGridViewTextBoxColumn
            // 
            this.blockidDataGridViewTextBoxColumn.DataPropertyName = "block_id";
            this.blockidDataGridViewTextBoxColumn.HeaderText = "block_id";
            this.blockidDataGridViewTextBoxColumn.Name = "blockidDataGridViewTextBoxColumn";
            // 
            // shapeidDataGridViewTextBoxColumn1
            // 
            this.shapeidDataGridViewTextBoxColumn1.DataPropertyName = "shape_id";
            this.shapeidDataGridViewTextBoxColumn1.DataSource = this.pathsBindingSource;
            this.shapeidDataGridViewTextBoxColumn1.DisplayMember = "shape_id";
            this.shapeidDataGridViewTextBoxColumn1.HeaderText = "shape_id";
            this.shapeidDataGridViewTextBoxColumn1.Name = "shapeidDataGridViewTextBoxColumn1";
            this.shapeidDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shapeidDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shapeidDataGridViewTextBoxColumn1.ValueMember = "shape_id";
            // 
            // pathsBindingSource
            // 
            this.pathsBindingSource.DataMember = "paths";
            this.pathsBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
            // 
            // wheelchairaccessibleDataGridViewTextBoxColumn
            // 
            this.wheelchairaccessibleDataGridViewTextBoxColumn.DataPropertyName = "wheelchair_accessible";
            this.wheelchairaccessibleDataGridViewTextBoxColumn.DataSource = this.wheelchair_accessibleBindingSource;
            this.wheelchairaccessibleDataGridViewTextBoxColumn.DisplayMember = "Display";
            this.wheelchairaccessibleDataGridViewTextBoxColumn.HeaderText = "wheelchair_accessible";
            this.wheelchairaccessibleDataGridViewTextBoxColumn.Name = "wheelchairaccessibleDataGridViewTextBoxColumn";
            this.wheelchairaccessibleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wheelchairaccessibleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wheelchairaccessibleDataGridViewTextBoxColumn.ValueMember = "Value";
            // 
            // wheelchair_accessibleBindingSource
            // 
            this.wheelchair_accessibleBindingSource.DataMember = "wheelchair_accessible";
            this.wheelchair_accessibleBindingSource.DataSource = typeof(GTFSTools.IO.GTFSLookupTables);
            // 
            // bikesallowedDataGridViewTextBoxColumn
            // 
            this.bikesallowedDataGridViewTextBoxColumn.DataPropertyName = "bikes_allowed";
            this.bikesallowedDataGridViewTextBoxColumn.DataSource = this.bikes_allowedBindingSource;
            this.bikesallowedDataGridViewTextBoxColumn.DisplayMember = "Display";
            this.bikesallowedDataGridViewTextBoxColumn.HeaderText = "bikes_allowed";
            this.bikesallowedDataGridViewTextBoxColumn.Name = "bikesallowedDataGridViewTextBoxColumn";
            this.bikesallowedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bikesallowedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bikesallowedDataGridViewTextBoxColumn.ValueMember = "Value";
            // 
            // bikes_allowedBindingSource
            // 
            this.bikes_allowedBindingSource.DataMember = "bikes_allowed";
            this.bikes_allowedBindingSource.DataSource = typeof(GTFSTools.IO.GTFSLookupTables);
            // 
            // _trips_txtBindingSource
            // 
            this._trips_txtBindingSource.DataMember = "trips.txt";
            this._trips_txtBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
            // 
            // tripidDataGridViewTextBoxColumn1
            // 
            this.tripidDataGridViewTextBoxColumn1.DataPropertyName = "trip_id";
            this.tripidDataGridViewTextBoxColumn1.DataSource = this._trips_txtBindingSource;
            this.tripidDataGridViewTextBoxColumn1.DisplayMember = "trip_id";
            this.tripidDataGridViewTextBoxColumn1.HeaderText = "trip_id";
            this.tripidDataGridViewTextBoxColumn1.Name = "tripidDataGridViewTextBoxColumn1";
            this.tripidDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tripidDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tripidDataGridViewTextBoxColumn1.ValueMember = "trip_id";
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
            this.dataGridViewTextBoxColumn21.DataSource = this._stops_txtBindingSource;
            this.dataGridViewTextBoxColumn21.DisplayMember = "stop_name";
            this.dataGridViewTextBoxColumn21.HeaderText = "stop_id";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn21.ValueMember = "stop_id";
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
            this.pickuptypeDataGridViewTextBoxColumn.DataSource = this.pickup_typeBindingSource;
            this.pickuptypeDataGridViewTextBoxColumn.DisplayMember = "Display";
            this.pickuptypeDataGridViewTextBoxColumn.HeaderText = "pickup_type";
            this.pickuptypeDataGridViewTextBoxColumn.Name = "pickuptypeDataGridViewTextBoxColumn";
            this.pickuptypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pickuptypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pickuptypeDataGridViewTextBoxColumn.ValueMember = "Value";
            // 
            // pickup_typeBindingSource
            // 
            this.pickup_typeBindingSource.DataMember = "pickup_type";
            this.pickup_typeBindingSource.DataSource = typeof(GTFSTools.IO.GTFSLookupTables);
            // 
            // dropofftypeDataGridViewTextBoxColumn
            // 
            this.dropofftypeDataGridViewTextBoxColumn.DataPropertyName = "drop_off_type";
            this.dropofftypeDataGridViewTextBoxColumn.DataSource = this.drop_off_typeBindingSource;
            this.dropofftypeDataGridViewTextBoxColumn.DisplayMember = "Display";
            this.dropofftypeDataGridViewTextBoxColumn.HeaderText = "drop_off_type";
            this.dropofftypeDataGridViewTextBoxColumn.Name = "dropofftypeDataGridViewTextBoxColumn";
            this.dropofftypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dropofftypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dropofftypeDataGridViewTextBoxColumn.ValueMember = "Value";
            // 
            // drop_off_typeBindingSource
            // 
            this.drop_off_typeBindingSource.DataMember = "drop_off_type";
            this.drop_off_typeBindingSource.DataSource = typeof(GTFSTools.IO.GTFSLookupTables);
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
            // _stop_times_txtBindingSource
            // 
            this._stop_times_txtBindingSource.DataMember = "stop_times.txt";
            this._stop_times_txtBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
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
            this.exceptiontypeDataGridViewTextBoxColumn.DataSource = this.exception_typeBindingSource;
            this.exceptiontypeDataGridViewTextBoxColumn.DisplayMember = "Display";
            this.exceptiontypeDataGridViewTextBoxColumn.HeaderText = "exception_type";
            this.exceptiontypeDataGridViewTextBoxColumn.Name = "exceptiontypeDataGridViewTextBoxColumn";
            this.exceptiontypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.exceptiontypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.exceptiontypeDataGridViewTextBoxColumn.ValueMember = "Value";
            // 
            // exception_typeBindingSource
            // 
            this.exception_typeBindingSource.DataMember = "exception_type";
            this.exception_typeBindingSource.DataSource = typeof(GTFSTools.IO.GTFSLookupTables);
            // 
            // _calendar_dates_txtBindingSource
            // 
            this._calendar_dates_txtBindingSource.DataMember = "calendar_dates.txt";
            this._calendar_dates_txtBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
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
            this.paymentmethodDataGridViewTextBoxColumn.DataSource = this.payment_methodsBindingSource;
            this.paymentmethodDataGridViewTextBoxColumn.DisplayMember = "Display";
            this.paymentmethodDataGridViewTextBoxColumn.HeaderText = "payment_method";
            this.paymentmethodDataGridViewTextBoxColumn.Name = "paymentmethodDataGridViewTextBoxColumn";
            this.paymentmethodDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.paymentmethodDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.paymentmethodDataGridViewTextBoxColumn.ValueMember = "Value";
            // 
            // payment_methodsBindingSource
            // 
            this.payment_methodsBindingSource.DataMember = "payment_method";
            this.payment_methodsBindingSource.DataSource = typeof(GTFSTools.IO.GTFSLookupTables);
            // 
            // transfersDataGridViewTextBoxColumn
            // 
            this.transfersDataGridViewTextBoxColumn.DataPropertyName = "transfers";
            this.transfersDataGridViewTextBoxColumn.DataSource = this.transfersBindingSource;
            this.transfersDataGridViewTextBoxColumn.DisplayMember = "Display";
            this.transfersDataGridViewTextBoxColumn.HeaderText = "transfers";
            this.transfersDataGridViewTextBoxColumn.Name = "transfersDataGridViewTextBoxColumn";
            this.transfersDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.transfersDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.transfersDataGridViewTextBoxColumn.ValueMember = "Value";
            // 
            // transfersBindingSource
            // 
            this.transfersBindingSource.DataMember = "transfers";
            this.transfersBindingSource.DataSource = typeof(GTFSTools.IO.GTFSLookupTables);
            // 
            // transferdurationDataGridViewTextBoxColumn
            // 
            this.transferdurationDataGridViewTextBoxColumn.DataPropertyName = "transfer_duration";
            this.transferdurationDataGridViewTextBoxColumn.HeaderText = "transfer_duration";
            this.transferdurationDataGridViewTextBoxColumn.Name = "transferdurationDataGridViewTextBoxColumn";
            // 
            // _fare_attributes_txtDindingSource
            // 
            this._fare_attributes_txtDindingSource.DataMember = "fare_attributes.txt";
            this._fare_attributes_txtDindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
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
            this.routeidDataGridViewTextBoxColumn1.DataSource = this._routes_txtBindingSource;
            this.routeidDataGridViewTextBoxColumn1.DisplayMember = "route_short_name";
            this.routeidDataGridViewTextBoxColumn1.HeaderText = "route_id";
            this.routeidDataGridViewTextBoxColumn1.Name = "routeidDataGridViewTextBoxColumn1";
            this.routeidDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.routeidDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.routeidDataGridViewTextBoxColumn1.ValueMember = "route_id";
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
            // _fare_rules_txtBindingSource
            // 
            this._fare_rules_txtBindingSource.DataMember = "fare_rules.txt";
            this._fare_rules_txtBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
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
            // _shapes_txtBindingSource
            // 
            this._shapes_txtBindingSource.DataMember = "shapes.txt";
            this._shapes_txtBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
            // 
            // tripidDataGridViewTextBoxColumn
            // 
            this.tripidDataGridViewTextBoxColumn.DataPropertyName = "trip_id";
            this.tripidDataGridViewTextBoxColumn.DataSource = this._trips_txtBindingSource;
            this.tripidDataGridViewTextBoxColumn.DisplayMember = "trip_id";
            this.tripidDataGridViewTextBoxColumn.HeaderText = "trip_id";
            this.tripidDataGridViewTextBoxColumn.Name = "tripidDataGridViewTextBoxColumn";
            this.tripidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tripidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tripidDataGridViewTextBoxColumn.ValueMember = "trip_id";
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
            // _frequencies_txtBindingSource
            // 
            this._frequencies_txtBindingSource.DataMember = "frequencies.txt";
            this._frequencies_txtBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
            // 
            // _transfers_txtBindingSource
            // 
            this._transfers_txtBindingSource.DataMember = "transfers.txt";
            this._transfers_txtBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
            // 
            // _feed_info_txtBindingSource
            // 
            this._feed_info_txtBindingSource.DataMember = "feed_info.txt";
            this._feed_info_txtBindingSource.DataSource = typeof(GTFSTools.IO.GTFSDataSet);
            // 
            // transfer_typeBindingSource
            // 
            this.transfer_typeBindingSource.DataMember = "transfer_type";
            this.transfer_typeBindingSource.DataSource = typeof(GTFSTools.IO.GTFSLookupTables);
            // 
            // fromstopidDataGridViewTextBoxColumn
            // 
            this.fromstopidDataGridViewTextBoxColumn.DataPropertyName = "from_stop_id";
            this.fromstopidDataGridViewTextBoxColumn.DataSource = this._stops_txtBindingSource;
            this.fromstopidDataGridViewTextBoxColumn.DisplayMember = "stop_name";
            this.fromstopidDataGridViewTextBoxColumn.HeaderText = "from_stop_id";
            this.fromstopidDataGridViewTextBoxColumn.Name = "fromstopidDataGridViewTextBoxColumn";
            this.fromstopidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fromstopidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fromstopidDataGridViewTextBoxColumn.ValueMember = "stop_id";
            // 
            // tostopidDataGridViewTextBoxColumn
            // 
            this.tostopidDataGridViewTextBoxColumn.DataPropertyName = "to_stop_id";
            this.tostopidDataGridViewTextBoxColumn.DataSource = this._stops_txtBindingSource;
            this.tostopidDataGridViewTextBoxColumn.DisplayMember = "stop_name";
            this.tostopidDataGridViewTextBoxColumn.HeaderText = "to_stop_id";
            this.tostopidDataGridViewTextBoxColumn.Name = "tostopidDataGridViewTextBoxColumn";
            this.tostopidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tostopidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tostopidDataGridViewTextBoxColumn.ValueMember = "stop_id";
            // 
            // transfertypeDataGridViewTextBoxColumn
            // 
            this.transfertypeDataGridViewTextBoxColumn.DataPropertyName = "transfer_type";
            this.transfertypeDataGridViewTextBoxColumn.DataSource = this.transfer_typeBindingSource;
            this.transfertypeDataGridViewTextBoxColumn.DisplayMember = "Display";
            this.transfertypeDataGridViewTextBoxColumn.HeaderText = "transfer_type";
            this.transfertypeDataGridViewTextBoxColumn.Name = "transfertypeDataGridViewTextBoxColumn";
            this.transfertypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.transfertypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.transfertypeDataGridViewTextBoxColumn.ValueMember = "Value";
            // 
            // mintransfertimeDataGridViewTextBoxColumn
            // 
            this.mintransfertimeDataGridViewTextBoxColumn.DataPropertyName = "min_transfer_time";
            this.mintransfertimeDataGridViewTextBoxColumn.HeaderText = "min_transfer_time";
            this.mintransfertimeDataGridViewTextBoxColumn.Name = "mintransfertimeDataGridViewTextBoxColumn";
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
            this.feedlangDataGridViewTextBoxColumn.DataSource = this.languageBindingSource;
            this.feedlangDataGridViewTextBoxColumn.DisplayMember = "English name of Language";
            this.feedlangDataGridViewTextBoxColumn.HeaderText = "feed_lang";
            this.feedlangDataGridViewTextBoxColumn.Name = "feedlangDataGridViewTextBoxColumn";
            this.feedlangDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.feedlangDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.feedlangDataGridViewTextBoxColumn.ValueMember = "ISO 639-1 Code";
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
            this.trips.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_zoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._agency_txtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.location_typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheelchair_boardingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._stops_txtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.route_typesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._routes_txtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._calendar_txtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheelchair_accessibleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikes_allowedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._trips_txtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickup_typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drop_off_typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._stop_times_txtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exception_typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._calendar_dates_txtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_methodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transfersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._fare_attributes_txtDindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._fare_rules_txtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._shapes_txtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._frequencies_txtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._transfers_txtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._feed_info_txtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transfer_typeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogGTFS;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImportZip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImportFolder;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportZip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportFolder;
        private System.Windows.Forms.BindingSource _agency_txtBindingSource;
        private System.Windows.Forms.BindingSource _stops_txtBindingSource;
        private System.Windows.Forms.BindingSource _routes_txtBindingSource;
        private System.Windows.Forms.BindingSource _stop_times_txtBindingSource;
        private System.Windows.Forms.BindingSource _calendar_txtBindingSource;
        private System.Windows.Forms.BindingSource _calendar_dates_txtBindingSource;
        private System.Windows.Forms.BindingSource _fare_attributes_txtDindingSource;
        private System.Windows.Forms.BindingSource _fare_rules_txtBindingSource;
        private System.Windows.Forms.BindingSource _shapes_txtBindingSource;
        private System.Windows.Forms.BindingSource _frequencies_txtBindingSource;
        private System.Windows.Forms.BindingSource _transfers_txtBindingSource;
        private System.Windows.Forms.BindingSource _feed_info_txtBindingSource;
        private System.Windows.Forms.BindingSource location_typeBindingSource;
        private System.Windows.Forms.BindingSource time_zoneBindingSource;
        private System.Windows.Forms.BindingSource languageBindingSource;
        private System.Windows.Forms.BindingSource wheelchair_boardingBindingSource;
        private System.Windows.Forms.TabPage feed_info;
        private System.Windows.Forms.DataGridView dataGridViewFeedInfo;
        private System.Windows.Forms.TabPage transfers;
        private System.Windows.Forms.DataGridView dataGridViewTransfers;
        private System.Windows.Forms.TabPage frequencies;
        private System.Windows.Forms.DataGridView dataGridViewFrequencies;
        private System.Windows.Forms.TabPage shapes;
        private System.Windows.Forms.DataGridView dataGridViewShapes;
        private System.Windows.Forms.DataGridViewTextBoxColumn shapeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shapeptlatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shapeptlonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shapeptsequenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shapedisttraveledDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage fare_rules;
        private System.Windows.Forms.DataGridView dataGridViewFareRules;
        private System.Windows.Forms.TabPage fare_attributes;
        private System.Windows.Forms.DataGridView dataGridViewFareAttributes;
        private System.Windows.Forms.TabPage calendar_dates;
        private System.Windows.Forms.DataGridView dataGridViewCalendarDates;
        private System.Windows.Forms.TabPage calendar;
        private System.Windows.Forms.DataGridView dataGridViewCalendar;
        private System.Windows.Forms.TabPage stop_times;
        private System.Windows.Forms.DataGridView dataGridViewStopTimes;
        private System.Windows.Forms.TabPage routes;
        private System.Windows.Forms.DataGridView dataGridViewRoutes;
        private System.Windows.Forms.TabPage stops;
        private System.Windows.Forms.DataGridView dataGridViewStops;
        private System.Windows.Forms.TabPage agency;
        private System.Windows.Forms.DataGridView dataGridViewAgency;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage trips;
        private System.Windows.Forms.DataGridView dataGridViewTrips;
        private System.Windows.Forms.BindingSource _trips_txtBindingSource;
        private System.Windows.Forms.BindingSource pickup_typeBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn tripidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivaltimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departuretimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopsequenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopheadsignDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pickuptypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dropofftypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource drop_off_typeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn shapedisttraveledDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timepointDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.BindingSource wheelchair_accessibleBindingSource;
        private System.Windows.Forms.BindingSource bikes_allowedBindingSource;
        private System.Windows.Forms.BindingSource pathsBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn routeidDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn serviceidDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripidDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripheadsignDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripshortnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn directionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shapeidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn wheelchairaccessibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn bikesallowedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource exception_typeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn exceptiontypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialogGTFS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImportShapes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportShapes;
        private System.Windows.Forms.SaveFileDialog saveFileDialogGIS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportShapeCSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImportShapesCSV;
        private System.Windows.Forms.OpenFileDialog openFileDialogShapes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportShapesSQLite;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImportShapesSQLite;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportStops;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportStopsCSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportStopsSQLite;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImportStops;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImportStopsCSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImportStopsSQLite;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoplatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoplonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopurlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn locationtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentstationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn stoptimezoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wheelchairboardingDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource route_typesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeshortnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routelongnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routedescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn routetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeurlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routecolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routetextcolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agencyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agencynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agencyurlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn agencytimezoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn agencylangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agencyphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agencyfareurlDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource payment_methodsBindingSource;
        private System.Windows.Forms.BindingSource transfersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fareidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencytypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn paymentmethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn transfersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferdurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fareidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn routeidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn originidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn containsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tripidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headwaysecsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exacttimesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource transfer_typeBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn fromstopidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tostopidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn transfertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mintransfertimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedpublishernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedpublisherurlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn feedlangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedstartdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedenddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedversionDataGridViewTextBoxColumn;
    }
}