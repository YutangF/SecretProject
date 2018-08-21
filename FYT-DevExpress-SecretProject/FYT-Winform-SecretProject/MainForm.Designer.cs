namespace FYT_Winform_SecretProject
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
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.listItem_ClassifyTorrentsFiles = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.listItem_ChooseTorrents = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.listItem_GetDownloadLinks = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.listItem_DecompressFiles = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.container_Main = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.panel_4 = new System.Windows.Forms.Panel();
            this.label_RARFilesCount = new System.Windows.Forms.Label();
            this.label_Text = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_3 = new System.Windows.Forms.Panel();
            this.btn_GetDownloadLinks = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SetHandleTempPath = new System.Windows.Forms.Button();
            this.btn_ChooseCommonTorrents = new System.Windows.Forms.Button();
            this.btn_ChooseClassicTorrents = new System.Windows.Forms.Button();
            this.numericUpDown_GetTorrentsCount = new System.Windows.Forms.NumericUpDown();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.btn_ChooseiCloudPath = new System.Windows.Forms.Button();
            this.btn_ClassifyCommonTorrents = new System.Windows.Forms.Button();
            this.btn_ClassifyClassicTorrents = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_ClassifyFileName = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_TorrentsToDownload = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.container_Main.SuspendLayout();
            this.panel_4.SuspendLayout();
            this.panel_3.SuspendLayout();
            this.panel_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GetTorrentsCount)).BeginInit();
            this.panel_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.AnimationType = DevExpress.XtraBars.Navigation.AnimationType.Office2016;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.listItem_ClassifyTorrentsFiles,
            this.listItem_ChooseTorrents,
            this.listItem_GetDownloadLinks,
            this.listItem_DecompressFiles,
            this.accordionControlElement2,
            this.accordionControlElement3,
            this.accordionControlElement4,
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 45);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.NormalWidth = 289;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(433, 1225);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // listItem_ClassifyTorrentsFiles
            // 
            this.listItem_ClassifyTorrentsFiles.Appearance.Hovered.BackColor = System.Drawing.Color.LightCoral;
            this.listItem_ClassifyTorrentsFiles.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.listItem_ClassifyTorrentsFiles.Appearance.Hovered.Options.UseBackColor = true;
            this.listItem_ClassifyTorrentsFiles.Appearance.Hovered.Options.UseFont = true;
            this.listItem_ClassifyTorrentsFiles.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.listItem_ClassifyTorrentsFiles.Appearance.Pressed.Options.UseFont = true;
            this.listItem_ClassifyTorrentsFiles.Expanded = true;
            this.listItem_ClassifyTorrentsFiles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("listItem_ClassifyTorrentsFiles.ImageOptions.Image")));
            this.listItem_ClassifyTorrentsFiles.Name = "listItem_ClassifyTorrentsFiles";
            this.listItem_ClassifyTorrentsFiles.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.listItem_ClassifyTorrentsFiles.Text = "Classify Torrents Files";
            this.listItem_ClassifyTorrentsFiles.Click += new System.EventHandler(this.listItem_ClassifyTorrentsFiles_Click);
            // 
            // listItem_ChooseTorrents
            // 
            this.listItem_ChooseTorrents.Appearance.Hovered.BackColor = System.Drawing.Color.LightCoral;
            this.listItem_ChooseTorrents.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listItem_ChooseTorrents.Appearance.Hovered.Options.UseBackColor = true;
            this.listItem_ChooseTorrents.Appearance.Hovered.Options.UseFont = true;
            this.listItem_ChooseTorrents.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.listItem_ChooseTorrents.Appearance.Pressed.Options.UseFont = true;
            this.listItem_ChooseTorrents.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("listItem_ChooseTorrents.ImageOptions.Image")));
            this.listItem_ChooseTorrents.Name = "listItem_ChooseTorrents";
            this.listItem_ChooseTorrents.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.listItem_ChooseTorrents.Text = "Choose Torrents to Download";
            this.listItem_ChooseTorrents.Click += new System.EventHandler(this.listItem_ChooseTorrents_Click);
            // 
            // listItem_GetDownloadLinks
            // 
            this.listItem_GetDownloadLinks.Appearance.Hovered.BackColor = System.Drawing.Color.LightCoral;
            this.listItem_GetDownloadLinks.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.listItem_GetDownloadLinks.Appearance.Hovered.Options.UseBackColor = true;
            this.listItem_GetDownloadLinks.Appearance.Hovered.Options.UseFont = true;
            this.listItem_GetDownloadLinks.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.listItem_GetDownloadLinks.Appearance.Pressed.Options.UseFont = true;
            this.listItem_GetDownloadLinks.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("listItem_GetDownloadLinks.ImageOptions.Image")));
            this.listItem_GetDownloadLinks.Name = "listItem_GetDownloadLinks";
            this.listItem_GetDownloadLinks.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.listItem_GetDownloadLinks.Text = "Get Download Links";
            this.listItem_GetDownloadLinks.Click += new System.EventHandler(this.listItem_GetDownloadLinks_Click);
            // 
            // listItem_DecompressFiles
            // 
            this.listItem_DecompressFiles.Appearance.Hovered.BackColor = System.Drawing.Color.LightCoral;
            this.listItem_DecompressFiles.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.listItem_DecompressFiles.Appearance.Hovered.Options.UseBackColor = true;
            this.listItem_DecompressFiles.Appearance.Hovered.Options.UseFont = true;
            this.listItem_DecompressFiles.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.listItem_DecompressFiles.Appearance.Pressed.Options.UseFont = true;
            this.listItem_DecompressFiles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("listItem_DecompressFiles.ImageOptions.Image")));
            this.listItem_DecompressFiles.Name = "listItem_DecompressFiles";
            this.listItem_DecompressFiles.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.listItem_DecompressFiles.Text = "Decompress Files";
            this.listItem_DecompressFiles.Click += new System.EventHandler(this.listItem_DecompressFiles_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Appearance.Hovered.BackColor = System.Drawing.Color.LightCoral;
            this.accordionControlElement2.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.accordionControlElement2.Appearance.Hovered.Options.UseBackColor = true;
            this.accordionControlElement2.Appearance.Hovered.Options.UseFont = true;
            this.accordionControlElement2.ImageOptions.Image = global::FYT_Winform_SecretProject.Properties.Resources.iCloud32x32;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement2.Text = "Open iCloud Path";
            this.accordionControlElement2.Click += new System.EventHandler(this.accordionControlElement2_Click);
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Appearance.Hovered.BackColor = System.Drawing.Color.LightCoral;
            this.accordionControlElement3.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.accordionControlElement3.Appearance.Hovered.Options.UseBackColor = true;
            this.accordionControlElement3.Appearance.Hovered.Options.UseFont = true;
            this.accordionControlElement3.ImageOptions.Image = global::FYT_Winform_SecretProject.Properties.Resources.TorrentIcon32x32;
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Open Torrent Handle Path";
            this.accordionControlElement3.Click += new System.EventHandler(this.accordionControlElement3_Click);
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Appearance.Hovered.BackColor = System.Drawing.Color.LightCoral;
            this.accordionControlElement4.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.accordionControlElement4.Appearance.Hovered.Options.UseBackColor = true;
            this.accordionControlElement4.Appearance.Hovered.Options.UseFont = true;
            this.accordionControlElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement4.ImageOptions.Image")));
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Open RAR Files Path";
            this.accordionControlElement4.Click += new System.EventHandler(this.accordionControlElement4_Click);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Appearance.Hovered.BackColor = System.Drawing.Color.RoyalBlue;
            this.accordionControlElement1.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.accordionControlElement1.Appearance.Hovered.Options.UseBackColor = true;
            this.accordionControlElement1.Appearance.Hovered.Options.UseFont = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement1.Text = "Test Button";
            this.accordionControlElement1.Click += new System.EventHandler(this.accordionControlElement1_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1766, 45);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // container_Main
            // 
            this.container_Main.Appearance.BackColor = System.Drawing.Color.White;
            this.container_Main.Appearance.Options.UseBackColor = true;
            this.container_Main.AutoScroll = false;
            this.container_Main.Controls.Add(this.panel_2);
            this.container_Main.Controls.Add(this.panel_1);
            this.container_Main.Controls.Add(this.panel_4);
            this.container_Main.Controls.Add(this.panel_3);
            this.container_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_Main.Location = new System.Drawing.Point(433, 45);
            this.container_Main.Name = "container_Main";
            this.container_Main.Size = new System.Drawing.Size(1333, 1225);
            this.container_Main.TabIndex = 0;
            // 
            // panel_4
            // 
            this.panel_4.Controls.Add(this.label_RARFilesCount);
            this.panel_4.Controls.Add(this.label_Text);
            this.panel_4.Controls.Add(this.label4);
            this.panel_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_4.Location = new System.Drawing.Point(0, 0);
            this.panel_4.Name = "panel_4";
            this.panel_4.Size = new System.Drawing.Size(1333, 1225);
            this.panel_4.TabIndex = 13;
            // 
            // label_RARFilesCount
            // 
            this.label_RARFilesCount.AutoSize = true;
            this.label_RARFilesCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_RARFilesCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_RARFilesCount.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label_RARFilesCount.Location = new System.Drawing.Point(943, 291);
            this.label_RARFilesCount.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label_RARFilesCount.Name = "label_RARFilesCount";
            this.label_RARFilesCount.Size = new System.Drawing.Size(44, 50);
            this.label_RARFilesCount.TabIndex = 15;
            this.label_RARFilesCount.Text = "0";
            // 
            // label_Text
            // 
            this.label_Text.AutoSize = true;
            this.label_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Text.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Text.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label_Text.Location = new System.Drawing.Point(376, 291);
            this.label_Text.Name = "label_Text";
            this.label_Text.Size = new System.Drawing.Size(568, 50);
            this.label_Text.TabIndex = 14;
            this.label_Text.Text = "Completed RARFiles Number : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1106, 1069);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            // 
            // panel_3
            // 
            this.panel_3.Controls.Add(this.btn_GetDownloadLinks);
            this.panel_3.Controls.Add(this.label3);
            this.panel_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_3.Location = new System.Drawing.Point(0, 0);
            this.panel_3.Name = "panel_3";
            this.panel_3.Size = new System.Drawing.Size(1333, 1225);
            this.panel_3.TabIndex = 1;
            // 
            // btn_GetDownloadLinks
            // 
            this.btn_GetDownloadLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GetDownloadLinks.Location = new System.Drawing.Point(376, 473);
            this.btn_GetDownloadLinks.Name = "btn_GetDownloadLinks";
            this.btn_GetDownloadLinks.Size = new System.Drawing.Size(514, 241);
            this.btn_GetDownloadLinks.TabIndex = 10;
            this.btn_GetDownloadLinks.Text = "Get Download Links";
            this.btn_GetDownloadLinks.UseVisualStyleBackColor = true;
            this.btn_GetDownloadLinks.Click += new System.EventHandler(this.btn_GetDownloadLinks_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1102, 1108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // panel_2
            // 
            this.panel_2.Controls.Add(this.label6);
            this.panel_2.Controls.Add(this.txb_TorrentsToDownload);
            this.panel_2.Controls.Add(this.label2);
            this.panel_2.Controls.Add(this.btn_SetHandleTempPath);
            this.panel_2.Controls.Add(this.btn_ChooseCommonTorrents);
            this.panel_2.Controls.Add(this.btn_ChooseClassicTorrents);
            this.panel_2.Controls.Add(this.numericUpDown_GetTorrentsCount);
            this.panel_2.Location = new System.Drawing.Point(0, 0);
            this.panel_2.Name = "panel_2";
            this.panel_2.Size = new System.Drawing.Size(1320, 1228);
            this.panel_2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1114, 1114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // btn_SetHandleTempPath
            // 
            this.btn_SetHandleTempPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SetHandleTempPath.Location = new System.Drawing.Point(255, 279);
            this.btn_SetHandleTempPath.Name = "btn_SetHandleTempPath";
            this.btn_SetHandleTempPath.Size = new System.Drawing.Size(288, 116);
            this.btn_SetHandleTempPath.TabIndex = 9;
            this.btn_SetHandleTempPath.Text = "Set Torrents Temp Path";
            this.btn_SetHandleTempPath.UseVisualStyleBackColor = true;
            this.btn_SetHandleTempPath.Click += new System.EventHandler(this.btn_SetHandleTempPath_Click);
            // 
            // btn_ChooseCommonTorrents
            // 
            this.btn_ChooseCommonTorrents.Location = new System.Drawing.Point(47, 485);
            this.btn_ChooseCommonTorrents.Name = "btn_ChooseCommonTorrents";
            this.btn_ChooseCommonTorrents.Size = new System.Drawing.Size(275, 119);
            this.btn_ChooseCommonTorrents.TabIndex = 6;
            this.btn_ChooseCommonTorrents.Text = "Choose Common Torrents";
            this.btn_ChooseCommonTorrents.UseVisualStyleBackColor = true;
            this.btn_ChooseCommonTorrents.Click += new System.EventHandler(this.btn_ChooseCommonTorrents_Click);
            // 
            // btn_ChooseClassicTorrents
            // 
            this.btn_ChooseClassicTorrents.Location = new System.Drawing.Point(503, 485);
            this.btn_ChooseClassicTorrents.Name = "btn_ChooseClassicTorrents";
            this.btn_ChooseClassicTorrents.Size = new System.Drawing.Size(275, 119);
            this.btn_ChooseClassicTorrents.TabIndex = 7;
            this.btn_ChooseClassicTorrents.Text = "Choose Classic Torrents";
            this.btn_ChooseClassicTorrents.UseVisualStyleBackColor = true;
            this.btn_ChooseClassicTorrents.Click += new System.EventHandler(this.btn_ChooseClassicTorrents_Click);
            // 
            // numericUpDown_GetTorrentsCount
            // 
            this.numericUpDown_GetTorrentsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_GetTorrentsCount.Font = new System.Drawing.Font("Tahoma", 40F);
            this.numericUpDown_GetTorrentsCount.Location = new System.Drawing.Point(356, 493);
            this.numericUpDown_GetTorrentsCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_GetTorrentsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_GetTorrentsCount.Name = "numericUpDown_GetTorrentsCount";
            this.numericUpDown_GetTorrentsCount.Size = new System.Drawing.Size(130, 104);
            this.numericUpDown_GetTorrentsCount.TabIndex = 8;
            this.numericUpDown_GetTorrentsCount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_GetTorrentsCount.ValueChanged += new System.EventHandler(this.numericUpDown_GetTorrentsCount_ValueChanged);
            // 
            // panel_1
            // 
            this.panel_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_1.Controls.Add(this.label5);
            this.panel_1.Controls.Add(this.txb_ClassifyFileName);
            this.panel_1.Controls.Add(this.btn_ChooseiCloudPath);
            this.panel_1.Controls.Add(this.btn_ClassifyCommonTorrents);
            this.panel_1.Controls.Add(this.btn_ClassifyClassicTorrents);
            this.panel_1.Controls.Add(this.label1);
            this.panel_1.Location = new System.Drawing.Point(0, 0);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(1322, 1223);
            this.panel_1.TabIndex = 0;
            // 
            // btn_ChooseiCloudPath
            // 
            this.btn_ChooseiCloudPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ChooseiCloudPath.Location = new System.Drawing.Point(195, 179);
            this.btn_ChooseiCloudPath.Name = "btn_ChooseiCloudPath";
            this.btn_ChooseiCloudPath.Size = new System.Drawing.Size(278, 107);
            this.btn_ChooseiCloudPath.TabIndex = 3;
            this.btn_ChooseiCloudPath.Text = "Set iCloud Path";
            this.btn_ChooseiCloudPath.UseVisualStyleBackColor = true;
            this.btn_ChooseiCloudPath.Click += new System.EventHandler(this.btn_ChooseiCloudPath_Click);
            // 
            // btn_ClassifyCommonTorrents
            // 
            this.btn_ClassifyCommonTorrents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ClassifyCommonTorrents.Location = new System.Drawing.Point(198, 379);
            this.btn_ClassifyCommonTorrents.Name = "btn_ClassifyCommonTorrents";
            this.btn_ClassifyCommonTorrents.Size = new System.Drawing.Size(275, 119);
            this.btn_ClassifyCommonTorrents.TabIndex = 4;
            this.btn_ClassifyCommonTorrents.Text = "Classify Common Torrents";
            this.btn_ClassifyCommonTorrents.UseVisualStyleBackColor = true;
            this.btn_ClassifyCommonTorrents.Click += new System.EventHandler(this.btn_ClassifyCommonTorrents_Click);
            // 
            // btn_ClassifyClassicTorrents
            // 
            this.btn_ClassifyClassicTorrents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ClassifyClassicTorrents.Location = new System.Drawing.Point(198, 575);
            this.btn_ClassifyClassicTorrents.Name = "btn_ClassifyClassicTorrents";
            this.btn_ClassifyClassicTorrents.Size = new System.Drawing.Size(275, 119);
            this.btn_ClassifyClassicTorrents.TabIndex = 5;
            this.btn_ClassifyClassicTorrents.Text = "Classify Classic Torrents";
            this.btn_ClassifyClassicTorrents.UseVisualStyleBackColor = true;
            this.btn_ClassifyClassicTorrents.Click += new System.EventHandler(this.btn_ClassifyClassicTorrents_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1118, 1116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // txb_ClassifyFileName
            // 
            this.txb_ClassifyFileName.BackColor = System.Drawing.Color.DimGray;
            this.txb_ClassifyFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_ClassifyFileName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txb_ClassifyFileName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txb_ClassifyFileName.ForeColor = System.Drawing.Color.White;
            this.txb_ClassifyFileName.Location = new System.Drawing.Point(584, 179);
            this.txb_ClassifyFileName.Name = "txb_ClassifyFileName";
            this.txb_ClassifyFileName.ReadOnly = true;
            this.txb_ClassifyFileName.Size = new System.Drawing.Size(338, 523);
            this.txb_ClassifyFileName.TabIndex = 6;
            this.txb_ClassifyFileName.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(648, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 41);
            this.label5.TabIndex = 7;
            this.label5.Text = "移动文件监视";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(950, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 41);
            this.label6.TabIndex = 11;
            this.label6.Text = "提取文件监视";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txb_TorrentsToDownload
            // 
            this.txb_TorrentsToDownload.BackColor = System.Drawing.Color.DimGray;
            this.txb_TorrentsToDownload.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_TorrentsToDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txb_TorrentsToDownload.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txb_TorrentsToDownload.ForeColor = System.Drawing.Color.White;
            this.txb_TorrentsToDownload.Location = new System.Drawing.Point(886, 257);
            this.txb_TorrentsToDownload.Name = "txb_TorrentsToDownload";
            this.txb_TorrentsToDownload.ReadOnly = true;
            this.txb_TorrentsToDownload.Size = new System.Drawing.Size(338, 523);
            this.txb_TorrentsToDownload.TabIndex = 10;
            this.txb_TorrentsToDownload.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1766, 1270);
            this.ControlContainer = this.container_Main;
            this.Controls.Add(this.container_Main);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.NavigationControl = this.accordionControl1;
            this.Text = "YutangF-SecretProject";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.container_Main.ResumeLayout(false);
            this.panel_4.ResumeLayout(false);
            this.panel_4.PerformLayout();
            this.panel_3.ResumeLayout(false);
            this.panel_3.PerformLayout();
            this.panel_2.ResumeLayout(false);
            this.panel_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GetTorrentsCount)).EndInit();
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement listItem_ClassifyTorrentsFiles;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement listItem_ChooseTorrents;
        private DevExpress.XtraBars.Navigation.AccordionControlElement listItem_GetDownloadLinks;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container_Main;
        private System.Windows.Forms.Panel panel_1;
        private System.Windows.Forms.Panel panel_2;
        private System.Windows.Forms.Panel panel_3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ClassifyClassicTorrents;
        private System.Windows.Forms.Button btn_ClassifyCommonTorrents;
        private System.Windows.Forms.Button btn_ChooseiCloudPath;
        private System.Windows.Forms.Button btn_ChooseClassicTorrents;
        private System.Windows.Forms.Button btn_ChooseCommonTorrents;
        private System.Windows.Forms.NumericUpDown numericUpDown_GetTorrentsCount;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private System.Windows.Forms.Button btn_SetHandleTempPath;
        private System.Windows.Forms.Button btn_GetDownloadLinks;
        private DevExpress.XtraBars.Navigation.AccordionControlElement listItem_DecompressFiles;
        private System.Windows.Forms.Panel panel_4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Text;
        private System.Windows.Forms.Label label_RARFilesCount;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private System.Windows.Forms.RichTextBox txb_ClassifyFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txb_TorrentsToDownload;
    }
}

