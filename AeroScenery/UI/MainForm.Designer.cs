﻿namespace AeroScenery
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMap = new GMap.NET.WindowsForms.GMapControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.settingsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.mapTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.gridSquareLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openImageFolderToolstripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteImagesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.openInGoogleMapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInBingMApsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressTabPage = new System.Windows.Forms.TabPage();
            this.CurrentTaskLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.downloadThreadProgress4 = new AeroScenery.UI.DownloadThreadProgressControl();
            this.downloadThreadProgress3 = new AeroScenery.UI.DownloadThreadProgressControl();
            this.downloadThreadProgress2 = new AeroScenery.UI.DownloadThreadProgressControl();
            this.downloadThreadProgress1 = new AeroScenery.UI.DownloadThreadProgressControl();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.imagesTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.terrainTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.mapTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.progressTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.imagesTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.terrainTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMap
            // 
            this.mainMap.BackColor = System.Drawing.SystemColors.Control;
            this.mainMap.Bearing = 0F;
            this.mainMap.CanDragMap = true;
            this.mainMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.mainMap.GrayScaleMode = false;
            this.mainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mainMap.LevelsKeepInMemmory = 5;
            this.mainMap.Location = new System.Drawing.Point(3, 3);
            this.mainMap.MarkersEnabled = true;
            this.mainMap.MaxZoom = 2;
            this.mainMap.MinZoom = 2;
            this.mainMap.MouseWheelZoomEnabled = true;
            this.mainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mainMap.Name = "mainMap";
            this.mainMap.NegativeMode = false;
            this.mainMap.PolygonsEnabled = true;
            this.mainMap.RetryLoadTile = 0;
            this.mainMap.RoutesEnabled = true;
            this.mainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mainMap.ShowTileGridLines = false;
            this.mainMap.Size = new System.Drawing.Size(1034, 638);
            this.mainMap.TabIndex = 0;
            this.mainMap.Zoom = 0D;
            this.mainMap.DoubleClick += new System.EventHandler(this.mainMap_DoubleClick);
            this.mainMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainMap_MouseDown_1);
            this.mainMap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainMap_MouseUp_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 735);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1461, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsButton,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(12, 5, 0, 5);
            this.toolStrip1.Size = new System.Drawing.Size(1461, 42);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(69, 29);
            this.settingsButton.Text = "Settings";
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton2.Text = "Help";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(133, 22);
            this.toolStripButton3.Text = "Get AeroFly FS2 SDK";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.mapTabPage);
            this.mainTabControl.Controls.Add(this.progressTabPage);
            this.mainTabControl.Controls.Add(this.tabPage5);
            this.mainTabControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(401, 45);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1048, 674);
            this.mainTabControl.TabIndex = 6;
            // 
            // mapTabPage
            // 
            this.mapTabPage.Controls.Add(this.panel1);
            this.mapTabPage.Controls.Add(this.mainMap);
            this.mapTabPage.Location = new System.Drawing.Point(4, 26);
            this.mapTabPage.Name = "mapTabPage";
            this.mapTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mapTabPage.Size = new System.Drawing.Size(1040, 644);
            this.mapTabPage.TabIndex = 0;
            this.mapTabPage.Text = "Map";
            this.mapTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 30);
            this.panel1.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.gridSquareLabel,
            this.toolStripLabel2,
            this.toolStripButton6,
            this.toolStripSeparator1,
            this.openImageFolderToolstripButton,
            this.deleteImagesToolStripButton,
            this.toolStripSeparator2,
            this.toolStripDropDownButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1034, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(82, 22);
            this.toolStripLabel1.Text = "Grid Square:";
            // 
            // gridSquareLabel
            // 
            this.gridSquareLabel.AutoSize = false;
            this.gridSquareLabel.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.gridSquareLabel.Name = "gridSquareLabel";
            this.gridSquareLabel.Size = new System.Drawing.Size(125, 22);
            this.gridSquareLabel.Text = "map_09_xxxx_xxxx";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel2.Image")));
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(124, 22);
            this.toolStripLabel2.Text = "Not Downloaded";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(98, 22);
            this.toolStripButton6.Text = "Clear Selection";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // openImageFolderToolstripButton
            // 
            this.openImageFolderToolstripButton.Image = ((System.Drawing.Image)(resources.GetObject("openImageFolderToolstripButton.Image")));
            this.openImageFolderToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openImageFolderToolstripButton.Name = "openImageFolderToolstripButton";
            this.openImageFolderToolstripButton.Size = new System.Drawing.Size(141, 22);
            this.openImageFolderToolstripButton.Text = "Open Image Folder";
            this.openImageFolderToolstripButton.Click += new System.EventHandler(this.openImageFolderToolstripButton_Click);
            // 
            // deleteImagesToolStripButton
            // 
            this.deleteImagesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteImagesToolStripButton.Image")));
            this.deleteImagesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteImagesToolStripButton.Name = "deleteImagesToolStripButton";
            this.deleteImagesToolStripButton.Size = new System.Drawing.Size(111, 22);
            this.deleteImagesToolStripButton.Text = "Delete Images";
            this.deleteImagesToolStripButton.Click += new System.EventHandler(this.deleteImagesToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openInGoogleMapsToolStripMenuItem,
            this.openInBingMApsToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(188, 22);
            this.toolStripDropDownButton1.Text = "Open Grid Square In Map";
            // 
            // openInGoogleMapsToolStripMenuItem
            // 
            this.openInGoogleMapsToolStripMenuItem.Name = "openInGoogleMapsToolStripMenuItem";
            this.openInGoogleMapsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.openInGoogleMapsToolStripMenuItem.Text = "Open In Google Maps";
            this.openInGoogleMapsToolStripMenuItem.Click += new System.EventHandler(this.openInGoogleMapsToolStripMenuItem_Click);
            // 
            // openInBingMApsToolStripMenuItem
            // 
            this.openInBingMApsToolStripMenuItem.Name = "openInBingMApsToolStripMenuItem";
            this.openInBingMApsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.openInBingMApsToolStripMenuItem.Text = "Open In Bing Maps";
            this.openInBingMApsToolStripMenuItem.Click += new System.EventHandler(this.openInBingMApsToolStripMenuItem_Click);
            // 
            // progressTabPage
            // 
            this.progressTabPage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressTabPage.Controls.Add(this.CurrentTaskLabel);
            this.progressTabPage.Controls.Add(this.label7);
            this.progressTabPage.Controls.Add(this.groupBox1);
            this.progressTabPage.Controls.Add(this.label6);
            this.progressTabPage.Controls.Add(this.progressBar1);
            this.progressTabPage.Controls.Add(this.label5);
            this.progressTabPage.Location = new System.Drawing.Point(4, 26);
            this.progressTabPage.Name = "progressTabPage";
            this.progressTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.progressTabPage.Size = new System.Drawing.Size(1040, 661);
            this.progressTabPage.TabIndex = 1;
            this.progressTabPage.Text = "Progress";
            // 
            // CurrentTaskLabel
            // 
            this.CurrentTaskLabel.AutoSize = true;
            this.CurrentTaskLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTaskLabel.Location = new System.Drawing.Point(88, 55);
            this.CurrentTaskLabel.Name = "CurrentTaskLabel";
            this.CurrentTaskLabel.Size = new System.Drawing.Size(155, 17);
            this.CurrentTaskLabel.TabIndex = 6;
            this.CurrentTaskLabel.Text = "Downloading Image Tiles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Currently:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.downloadThreadProgress4);
            this.groupBox1.Controls.Add(this.downloadThreadProgress3);
            this.groupBox1.Controls.Add(this.downloadThreadProgress2);
            this.groupBox1.Controls.Add(this.downloadThreadProgress1);
            this.groupBox1.Location = new System.Drawing.Point(9, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1025, 501);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Downloaders";
            // 
            // downloadThreadProgress4
            // 
            this.downloadThreadProgress4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadThreadProgress4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.downloadThreadProgress4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.downloadThreadProgress4.Location = new System.Drawing.Point(7, 222);
            this.downloadThreadProgress4.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.downloadThreadProgress4.Name = "downloadThreadProgress4";
            this.downloadThreadProgress4.Size = new System.Drawing.Size(1012, 57);
            this.downloadThreadProgress4.TabIndex = 3;
            // 
            // downloadThreadProgress3
            // 
            this.downloadThreadProgress3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadThreadProgress3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.downloadThreadProgress3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.downloadThreadProgress3.Location = new System.Drawing.Point(7, 155);
            this.downloadThreadProgress3.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.downloadThreadProgress3.Name = "downloadThreadProgress3";
            this.downloadThreadProgress3.Size = new System.Drawing.Size(1012, 59);
            this.downloadThreadProgress3.TabIndex = 2;
            // 
            // downloadThreadProgress2
            // 
            this.downloadThreadProgress2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadThreadProgress2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.downloadThreadProgress2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.downloadThreadProgress2.Location = new System.Drawing.Point(7, 93);
            this.downloadThreadProgress2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.downloadThreadProgress2.Name = "downloadThreadProgress2";
            this.downloadThreadProgress2.Size = new System.Drawing.Size(1012, 53);
            this.downloadThreadProgress2.TabIndex = 1;
            // 
            // downloadThreadProgress1
            // 
            this.downloadThreadProgress1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadThreadProgress1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.downloadThreadProgress1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.downloadThreadProgress1.Location = new System.Drawing.Point(7, 31);
            this.downloadThreadProgress1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.downloadThreadProgress1.Name = "downloadThreadProgress1";
            this.downloadThreadProgress1.Size = new System.Drawing.Size(1012, 48);
            this.downloadThreadProgress1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Overall Progress";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(16, 120);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1004, 18);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Value = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Working On AFS2 Grid Tile 1 of 4";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.logTextBox);
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1040, 661);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Log";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // logTextBox
            // 
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTextBox.Location = new System.Drawing.Point(3, 3);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(1034, 655);
            this.logTextBox.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl2.Controls.Add(this.imagesTabPage);
            this.tabControl2.Controls.Add(this.terrainTabPage);
            this.tabControl2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(12, 45);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(379, 593);
            this.tabControl2.TabIndex = 7;
            // 
            // imagesTabPage
            // 
            this.imagesTabPage.Controls.Add(this.groupBox2);
            this.imagesTabPage.Controls.Add(this.label4);
            this.imagesTabPage.Controls.Add(this.checkedListBox1);
            this.imagesTabPage.Controls.Add(this.comboBox2);
            this.imagesTabPage.Controls.Add(this.label3);
            this.imagesTabPage.Controls.Add(this.label2);
            this.imagesTabPage.Controls.Add(this.comboBox1);
            this.imagesTabPage.Location = new System.Drawing.Point(4, 26);
            this.imagesTabPage.Name = "imagesTabPage";
            this.imagesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.imagesTabPage.Size = new System.Drawing.Size(371, 563);
            this.imagesTabPage.TabIndex = 0;
            this.imagesTabPage.Text = "Images";
            this.imagesTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(16, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 196);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(19, 162);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(167, 21);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Install Scenery Into AFS2";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(19, 135);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(160, 21);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Delete Stitched Images";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(19, 108);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(122, 21);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Run GeoConvert";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(19, 81);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(173, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Generate AID / TMC Files";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(19, 54);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(128, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Stitch Image Tiles";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(156, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Download Image Tiles";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Generate AFS2 Levels";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Level 0",
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4",
            "Level 5",
            "Level 6",
            "Level 7",
            "Level 8",
            "Level 9",
            "Level 10",
            "Level 11",
            "Level 12",
            "Level 13",
            "Level 14",
            "Level 15"});
            this.checkedListBox1.Location = new System.Drawing.Point(16, 331);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(339, 164);
            this.checkedListBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.comboBox2.Location = new System.Drawing.Point(112, 258);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(243, 25);
            this.comboBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Zoom Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Image Source";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bing",
            "Google (Coming Soon)",
            "USGS (Coming Soon)"});
            this.comboBox1.Location = new System.Drawing.Point(112, 220);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 25);
            this.comboBox1.TabIndex = 1;
            // 
            // terrainTabPage
            // 
            this.terrainTabPage.Controls.Add(this.label1);
            this.terrainTabPage.Location = new System.Drawing.Point(4, 26);
            this.terrainTabPage.Name = "terrainTabPage";
            this.terrainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.terrainTabPage.Size = new System.Drawing.Size(371, 580);
            this.terrainTabPage.TabIndex = 1;
            this.terrainTabPage.Text = "Terrain";
            this.terrainTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coming Soon";
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonStart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStart.Location = new System.Drawing.Point(12, 656);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(379, 63);
            this.ButtonStart.TabIndex = 3;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 757);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "AeroScenery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.mapTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.progressTabPage.ResumeLayout(false);
            this.progressTabPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.imagesTabPage.ResumeLayout(false);
            this.imagesTabPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.terrainTabPage.ResumeLayout(false);
            this.terrainTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mainMap;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton settingsButton;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage mapTabPage;
        private System.Windows.Forms.TabPage progressTabPage;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage imagesTabPage;
        private System.Windows.Forms.TabPage terrainTabPage;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CurrentTaskLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox logTextBox;
        private UI.DownloadThreadProgressControl downloadThreadProgress2;
        private UI.DownloadThreadProgressControl downloadThreadProgress1;
        private UI.DownloadThreadProgressControl downloadThreadProgress4;
        private UI.DownloadThreadProgressControl downloadThreadProgress3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton deleteImagesToolStripButton;
        private System.Windows.Forms.ToolStripButton openImageFolderToolstripButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel gridSquareLabel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripMenuItem openInGoogleMapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInBingMApsToolStripMenuItem;
    }
}

