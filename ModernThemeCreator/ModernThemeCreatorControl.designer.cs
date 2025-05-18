namespace ModernThemeCreator
{
    partial class ModernThemeCreatorControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModernThemeCreatorControl));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btn_newTheme = new System.Windows.Forms.ToolStripButton();
            this.btn_editTheme = new System.Windows.Forms.ToolStripButton();
            this.btn_saveNew = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbox_imgId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorPicker8 = new System.Windows.Forms.Button();
            this.colorPicker7 = new System.Windows.Forms.Button();
            this.colorPicker6 = new System.Windows.Forms.Button();
            this.colorPicker5 = new System.Windows.Forms.Button();
            this.colorPicker4 = new System.Windows.Forms.Button();
            this.colorPicker3 = new System.Windows.Forms.Button();
            this.colorPicker2 = new System.Windows.Forms.Button();
            this.lblForegroundSelected = new System.Windows.Forms.Label();
            this.lblBackgroundSelected = new System.Windows.Forms.Label();
            this.lblForegroundPressed = new System.Windows.Forms.Label();
            this.lblBackgroundPressed = new System.Windows.Forms.Label();
            this.lblWR = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtForegroundSelected = new System.Windows.Forms.TextBox();
            this.txtBackgroundSelected = new System.Windows.Forms.TextBox();
            this.txtForegroundPressed = new System.Windows.Forms.TextBox();
            this.txtBackgroundPressed = new System.Windows.Forms.TextBox();
            this.colorPicker1 = new System.Windows.Forms.Button();
            this.txtForegroundHover = new System.Windows.Forms.TextBox();
            this.lblForegroundHover = new System.Windows.Forms.Label();
            this.txtBackgroundHover = new System.Windows.Forms.TextBox();
            this.lblBackgroundHover = new System.Windows.Forms.Label();
            this.txtForeground = new System.Windows.Forms.TextBox();
            this.color2 = new System.Windows.Forms.Label();
            this.backgroundLabel = new System.Windows.Forms.Label();
            this.txtBackground = new System.Windows.Forms.TextBox();
            this.lblAppId = new System.Windows.Forms.Label();
            this.txtApp = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.background = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foreground = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundHover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foregroundHover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webresourceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundPressed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foregroundPressed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundSelected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foregroundSelected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_selectImg = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.toolStripButton1,
            this.btn_newTheme,
            this.btn_editTheme,
            this.btn_saveNew,
            this.btn_selectImg});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1246, 27);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(86, 28);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(101, 24);
            this.toolStripButton1.Text = "Upload Image";
            this.toolStripButton1.ToolTipText = "Upload Image in SVG";
            this.toolStripButton1.Click += new System.EventHandler(this.UploadImg_Click);
            // 
            // btn_newTheme
            // 
            this.btn_newTheme.Image = ((System.Drawing.Image)(resources.GetObject("btn_newTheme.Image")));
            this.btn_newTheme.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_newTheme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_newTheme.Name = "btn_newTheme";
            this.btn_newTheme.Size = new System.Drawing.Size(91, 28);
            this.btn_newTheme.Text = "New Theme";
            this.btn_newTheme.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btn_editTheme
            // 
            this.btn_editTheme.Image = ((System.Drawing.Image)(resources.GetObject("btn_editTheme.Image")));
            this.btn_editTheme.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_editTheme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_editTheme.Name = "btn_editTheme";
            this.btn_editTheme.Size = new System.Drawing.Size(87, 28);
            this.btn_editTheme.Text = "Edit Theme";
            this.btn_editTheme.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btn_saveNew
            // 
            this.btn_saveNew.Image = ((System.Drawing.Image)(resources.GetObject("btn_saveNew.Image")));
            this.btn_saveNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_saveNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_saveNew.Name = "btn_saveNew";
            this.btn_saveNew.Size = new System.Drawing.Size(82, 28);
            this.btn_saveNew.Text = "Save New";
            this.btn_saveNew.ToolTipText = "Save New";
            this.btn_saveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txtbox_imgId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.colorPicker8);
            this.groupBox1.Controls.Add(this.colorPicker7);
            this.groupBox1.Controls.Add(this.colorPicker6);
            this.groupBox1.Controls.Add(this.colorPicker5);
            this.groupBox1.Controls.Add(this.colorPicker4);
            this.groupBox1.Controls.Add(this.colorPicker3);
            this.groupBox1.Controls.Add(this.colorPicker2);
            this.groupBox1.Controls.Add(this.lblForegroundSelected);
            this.groupBox1.Controls.Add(this.lblBackgroundSelected);
            this.groupBox1.Controls.Add(this.lblForegroundPressed);
            this.groupBox1.Controls.Add(this.lblBackgroundPressed);
            this.groupBox1.Controls.Add(this.lblWR);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtForegroundSelected);
            this.groupBox1.Controls.Add(this.txtBackgroundSelected);
            this.groupBox1.Controls.Add(this.txtForegroundPressed);
            this.groupBox1.Controls.Add(this.txtBackgroundPressed);
            this.groupBox1.Controls.Add(this.colorPicker1);
            this.groupBox1.Controls.Add(this.txtForegroundHover);
            this.groupBox1.Controls.Add(this.lblForegroundHover);
            this.groupBox1.Controls.Add(this.txtBackgroundHover);
            this.groupBox1.Controls.Add(this.lblBackgroundHover);
            this.groupBox1.Controls.Add(this.txtForeground);
            this.groupBox1.Controls.Add(this.color2);
            this.groupBox1.Controls.Add(this.backgroundLabel);
            this.groupBox1.Controls.Add(this.txtBackground);
            this.groupBox1.Controls.Add(this.lblAppId);
            this.groupBox1.Controls.Add(this.txtApp);
            this.groupBox1.Location = new System.Drawing.Point(649, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(570, 518);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form";
            // 
            // txtbox_imgId
            // 
            this.txtbox_imgId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_imgId.Enabled = false;
            this.txtbox_imgId.Location = new System.Drawing.Point(134, 64);
            this.txtbox_imgId.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_imgId.Name = "txtbox_imgId";
            this.txtbox_imgId.Size = new System.Drawing.Size(308, 20);
            this.txtbox_imgId.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(22, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Image Id";
            // 
            // colorPicker8
            // 
            this.colorPicker8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker8.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker8.Image")));
            this.colorPicker8.Location = new System.Drawing.Point(414, 431);
            this.colorPicker8.Margin = new System.Windows.Forms.Padding(2);
            this.colorPicker8.Name = "colorPicker8";
            this.colorPicker8.Size = new System.Drawing.Size(27, 29);
            this.colorPicker8.TabIndex = 35;
            this.colorPicker8.UseVisualStyleBackColor = true;
            this.colorPicker8.Click += new System.EventHandler(this.colorPicker8_Click);
            // 
            // colorPicker7
            // 
            this.colorPicker7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker7.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker7.Image")));
            this.colorPicker7.Location = new System.Drawing.Point(414, 389);
            this.colorPicker7.Margin = new System.Windows.Forms.Padding(2);
            this.colorPicker7.Name = "colorPicker7";
            this.colorPicker7.Size = new System.Drawing.Size(27, 29);
            this.colorPicker7.TabIndex = 34;
            this.colorPicker7.UseVisualStyleBackColor = true;
            this.colorPicker7.Click += new System.EventHandler(this.colorPicker7_Click);
            // 
            // colorPicker6
            // 
            this.colorPicker6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker6.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker6.Image")));
            this.colorPicker6.Location = new System.Drawing.Point(414, 346);
            this.colorPicker6.Margin = new System.Windows.Forms.Padding(2);
            this.colorPicker6.Name = "colorPicker6";
            this.colorPicker6.Size = new System.Drawing.Size(27, 29);
            this.colorPicker6.TabIndex = 33;
            this.colorPicker6.UseVisualStyleBackColor = true;
            this.colorPicker6.Click += new System.EventHandler(this.colorPicker6_Click);
            // 
            // colorPicker5
            // 
            this.colorPicker5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker5.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker5.Image")));
            this.colorPicker5.Location = new System.Drawing.Point(414, 304);
            this.colorPicker5.Margin = new System.Windows.Forms.Padding(2);
            this.colorPicker5.Name = "colorPicker5";
            this.colorPicker5.Size = new System.Drawing.Size(27, 29);
            this.colorPicker5.TabIndex = 32;
            this.colorPicker5.UseVisualStyleBackColor = true;
            this.colorPicker5.Click += new System.EventHandler(this.colorPicker5_Click);
            // 
            // colorPicker4
            // 
            this.colorPicker4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker4.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker4.Image")));
            this.colorPicker4.Location = new System.Drawing.Point(414, 262);
            this.colorPicker4.Margin = new System.Windows.Forms.Padding(2);
            this.colorPicker4.Name = "colorPicker4";
            this.colorPicker4.Size = new System.Drawing.Size(27, 29);
            this.colorPicker4.TabIndex = 31;
            this.colorPicker4.UseVisualStyleBackColor = true;
            this.colorPicker4.Click += new System.EventHandler(this.colorPicker4_Click);
            // 
            // colorPicker3
            // 
            this.colorPicker3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker3.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker3.Image")));
            this.colorPicker3.Location = new System.Drawing.Point(414, 219);
            this.colorPicker3.Margin = new System.Windows.Forms.Padding(2);
            this.colorPicker3.Name = "colorPicker3";
            this.colorPicker3.Size = new System.Drawing.Size(27, 29);
            this.colorPicker3.TabIndex = 30;
            this.colorPicker3.UseVisualStyleBackColor = true;
            this.colorPicker3.Click += new System.EventHandler(this.colorPicker3_Click);
            // 
            // colorPicker2
            // 
            this.colorPicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker2.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker2.Image")));
            this.colorPicker2.Location = new System.Drawing.Point(414, 176);
            this.colorPicker2.Margin = new System.Windows.Forms.Padding(2);
            this.colorPicker2.Name = "colorPicker2";
            this.colorPicker2.Size = new System.Drawing.Size(27, 29);
            this.colorPicker2.TabIndex = 29;
            this.colorPicker2.UseVisualStyleBackColor = true;
            this.colorPicker2.Click += new System.EventHandler(this.colorPicker2_Click);
            // 
            // lblForegroundSelected
            // 
            this.lblForegroundSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblForegroundSelected.AutoSize = true;
            this.lblForegroundSelected.Location = new System.Drawing.Point(22, 440);
            this.lblForegroundSelected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForegroundSelected.Name = "lblForegroundSelected";
            this.lblForegroundSelected.Size = new System.Drawing.Size(106, 13);
            this.lblForegroundSelected.TabIndex = 28;
            this.lblForegroundSelected.Text = "Foreground Selected";
            // 
            // lblBackgroundSelected
            // 
            this.lblBackgroundSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBackgroundSelected.AutoSize = true;
            this.lblBackgroundSelected.Location = new System.Drawing.Point(22, 398);
            this.lblBackgroundSelected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBackgroundSelected.Name = "lblBackgroundSelected";
            this.lblBackgroundSelected.Size = new System.Drawing.Size(110, 13);
            this.lblBackgroundSelected.TabIndex = 27;
            this.lblBackgroundSelected.Text = "Background Selected";
            // 
            // lblForegroundPressed
            // 
            this.lblForegroundPressed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblForegroundPressed.AutoSize = true;
            this.lblForegroundPressed.Location = new System.Drawing.Point(22, 356);
            this.lblForegroundPressed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForegroundPressed.Name = "lblForegroundPressed";
            this.lblForegroundPressed.Size = new System.Drawing.Size(102, 13);
            this.lblForegroundPressed.TabIndex = 26;
            this.lblForegroundPressed.Text = "Foreground Pressed";
            // 
            // lblBackgroundPressed
            // 
            this.lblBackgroundPressed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBackgroundPressed.AutoSize = true;
            this.lblBackgroundPressed.Location = new System.Drawing.Point(22, 314);
            this.lblBackgroundPressed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBackgroundPressed.Name = "lblBackgroundPressed";
            this.lblBackgroundPressed.Size = new System.Drawing.Size(106, 13);
            this.lblBackgroundPressed.TabIndex = 25;
            this.lblBackgroundPressed.Text = "Background Pressed";
            // 
            // lblWR
            // 
            this.lblWR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWR.AutoSize = true;
            this.lblWR.Enabled = false;
            this.lblWR.Location = new System.Drawing.Point(22, 31);
            this.lblWR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWR.Name = "lblWR";
            this.lblWR.Size = new System.Drawing.Size(83, 13);
            this.lblWR.TabIndex = 24;
            this.lblWR.Text = "Webresource Id";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(134, 30);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(308, 20);
            this.txtName.TabIndex = 20;
            // 
            // txtForegroundSelected
            // 
            this.txtForegroundSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtForegroundSelected.Location = new System.Drawing.Point(134, 437);
            this.txtForegroundSelected.Margin = new System.Windows.Forms.Padding(2);
            this.txtForegroundSelected.Name = "txtForegroundSelected";
            this.txtForegroundSelected.Size = new System.Drawing.Size(266, 20);
            this.txtForegroundSelected.TabIndex = 19;
            this.txtForegroundSelected.TextChanged += new System.EventHandler(this.txtForegroundSelected_TextChanged);
            // 
            // txtBackgroundSelected
            // 
            this.txtBackgroundSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackgroundSelected.Location = new System.Drawing.Point(134, 396);
            this.txtBackgroundSelected.Margin = new System.Windows.Forms.Padding(2);
            this.txtBackgroundSelected.Name = "txtBackgroundSelected";
            this.txtBackgroundSelected.Size = new System.Drawing.Size(266, 20);
            this.txtBackgroundSelected.TabIndex = 18;
            this.txtBackgroundSelected.TextChanged += new System.EventHandler(this.txtBackgroundSelected_TextChanged);
            // 
            // txtForegroundPressed
            // 
            this.txtForegroundPressed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtForegroundPressed.Location = new System.Drawing.Point(134, 353);
            this.txtForegroundPressed.Margin = new System.Windows.Forms.Padding(2);
            this.txtForegroundPressed.Name = "txtForegroundPressed";
            this.txtForegroundPressed.Size = new System.Drawing.Size(266, 20);
            this.txtForegroundPressed.TabIndex = 17;
            this.txtForegroundPressed.TextChanged += new System.EventHandler(this.txtForegroundPressed_TextChanged);
            // 
            // txtBackgroundPressed
            // 
            this.txtBackgroundPressed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackgroundPressed.Location = new System.Drawing.Point(134, 310);
            this.txtBackgroundPressed.Margin = new System.Windows.Forms.Padding(2);
            this.txtBackgroundPressed.Name = "txtBackgroundPressed";
            this.txtBackgroundPressed.Size = new System.Drawing.Size(266, 20);
            this.txtBackgroundPressed.TabIndex = 16;
            this.txtBackgroundPressed.TextChanged += new System.EventHandler(this.txtBackgroundPressed_TextChanged);
            // 
            // colorPicker1
            // 
            this.colorPicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker1.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker1.Image")));
            this.colorPicker1.Location = new System.Drawing.Point(414, 136);
            this.colorPicker1.Margin = new System.Windows.Forms.Padding(2);
            this.colorPicker1.Name = "colorPicker1";
            this.colorPicker1.Size = new System.Drawing.Size(27, 29);
            this.colorPicker1.TabIndex = 10;
            this.colorPicker1.UseVisualStyleBackColor = true;
            this.colorPicker1.Click += new System.EventHandler(this.colorPicker1_Click);
            // 
            // txtForegroundHover
            // 
            this.txtForegroundHover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtForegroundHover.Location = new System.Drawing.Point(134, 267);
            this.txtForegroundHover.Margin = new System.Windows.Forms.Padding(2);
            this.txtForegroundHover.Name = "txtForegroundHover";
            this.txtForegroundHover.Size = new System.Drawing.Size(266, 20);
            this.txtForegroundHover.TabIndex = 9;
            this.txtForegroundHover.TextChanged += new System.EventHandler(this.txtForegroundHover_TextChanged);
            // 
            // lblForegroundHover
            // 
            this.lblForegroundHover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblForegroundHover.AutoSize = true;
            this.lblForegroundHover.Location = new System.Drawing.Point(22, 271);
            this.lblForegroundHover.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForegroundHover.Name = "lblForegroundHover";
            this.lblForegroundHover.Size = new System.Drawing.Size(93, 13);
            this.lblForegroundHover.TabIndex = 8;
            this.lblForegroundHover.Text = "Foreground Hover";
            // 
            // txtBackgroundHover
            // 
            this.txtBackgroundHover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackgroundHover.Location = new System.Drawing.Point(134, 225);
            this.txtBackgroundHover.Margin = new System.Windows.Forms.Padding(2);
            this.txtBackgroundHover.Name = "txtBackgroundHover";
            this.txtBackgroundHover.Size = new System.Drawing.Size(266, 20);
            this.txtBackgroundHover.TabIndex = 7;
            this.txtBackgroundHover.TextChanged += new System.EventHandler(this.txtBackgroundHover_TextChanged);
            // 
            // lblBackgroundHover
            // 
            this.lblBackgroundHover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBackgroundHover.AutoSize = true;
            this.lblBackgroundHover.Location = new System.Drawing.Point(22, 229);
            this.lblBackgroundHover.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBackgroundHover.Name = "lblBackgroundHover";
            this.lblBackgroundHover.Size = new System.Drawing.Size(97, 13);
            this.lblBackgroundHover.TabIndex = 6;
            this.lblBackgroundHover.Text = "Background Hover";
            // 
            // txtForeground
            // 
            this.txtForeground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtForeground.Location = new System.Drawing.Point(134, 182);
            this.txtForeground.Margin = new System.Windows.Forms.Padding(2);
            this.txtForeground.Name = "txtForeground";
            this.txtForeground.Size = new System.Drawing.Size(266, 20);
            this.txtForeground.TabIndex = 5;
            this.txtForeground.TextChanged += new System.EventHandler(this.txtForeground_TextChanged);
            // 
            // color2
            // 
            this.color2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.color2.AutoSize = true;
            this.color2.Location = new System.Drawing.Point(22, 187);
            this.color2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(61, 13);
            this.color2.TabIndex = 4;
            this.color2.Text = "Foreground";
            // 
            // backgroundLabel
            // 
            this.backgroundLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundLabel.AutoSize = true;
            this.backgroundLabel.Location = new System.Drawing.Point(22, 145);
            this.backgroundLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.backgroundLabel.Name = "backgroundLabel";
            this.backgroundLabel.Size = new System.Drawing.Size(65, 13);
            this.backgroundLabel.TabIndex = 3;
            this.backgroundLabel.Text = "Background";
            // 
            // txtBackground
            // 
            this.txtBackground.Location = new System.Drawing.Point(134, 141);
            this.txtBackground.Margin = new System.Windows.Forms.Padding(2);
            this.txtBackground.Name = "txtBackground";
            this.txtBackground.Size = new System.Drawing.Size(266, 20);
            this.txtBackground.TabIndex = 2;
            this.txtBackground.TextChanged += new System.EventHandler(this.txtBackground_TextChanged);
            // 
            // lblAppId
            // 
            this.lblAppId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppId.AutoSize = true;
            this.lblAppId.Location = new System.Drawing.Point(22, 102);
            this.lblAppId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppId.Name = "lblAppId";
            this.lblAppId.Size = new System.Drawing.Size(38, 13);
            this.lblAppId.TabIndex = 1;
            this.lblAppId.Text = "App Id";
            // 
            // txtApp
            // 
            this.txtApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApp.Location = new System.Drawing.Point(134, 102);
            this.txtApp.Margin = new System.Windows.Forms.Padding(2);
            this.txtApp.Name = "txtApp";
            this.txtApp.Size = new System.Drawing.Size(308, 20);
            this.txtApp.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appId,
            this.background,
            this.foreground,
            this.backgroundHover,
            this.foregroundHover,
            this.webresourceId,
            this.backgroundPressed,
            this.foregroundPressed,
            this.backgroundSelected,
            this.foregroundSelected});
            this.dataGridView1.Location = new System.Drawing.Point(24, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(603, 518);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // appId
            // 
            this.appId.HeaderText = "App Id";
            this.appId.MinimumWidth = 6;
            this.appId.Name = "appId";
            this.appId.ReadOnly = true;
            // 
            // background
            // 
            this.background.HeaderText = "Background";
            this.background.MinimumWidth = 6;
            this.background.Name = "background";
            this.background.ReadOnly = true;
            // 
            // foreground
            // 
            this.foreground.HeaderText = "Foreground";
            this.foreground.MinimumWidth = 6;
            this.foreground.Name = "foreground";
            this.foreground.ReadOnly = true;
            // 
            // backgroundHover
            // 
            this.backgroundHover.HeaderText = "Background Hover";
            this.backgroundHover.MinimumWidth = 6;
            this.backgroundHover.Name = "backgroundHover";
            this.backgroundHover.ReadOnly = true;
            // 
            // foregroundHover
            // 
            this.foregroundHover.HeaderText = "Foreground Hover";
            this.foregroundHover.MinimumWidth = 6;
            this.foregroundHover.Name = "foregroundHover";
            this.foregroundHover.ReadOnly = true;
            // 
            // webresourceId
            // 
            this.webresourceId.HeaderText = "Webresource Id";
            this.webresourceId.MinimumWidth = 6;
            this.webresourceId.Name = "webresourceId";
            this.webresourceId.ReadOnly = true;
            this.webresourceId.Visible = false;
            // 
            // backgroundPressed
            // 
            this.backgroundPressed.HeaderText = "Background Pressed";
            this.backgroundPressed.MinimumWidth = 6;
            this.backgroundPressed.Name = "backgroundPressed";
            this.backgroundPressed.ReadOnly = true;
            // 
            // foregroundPressed
            // 
            this.foregroundPressed.HeaderText = "Foreground Pressed";
            this.foregroundPressed.MinimumWidth = 6;
            this.foregroundPressed.Name = "foregroundPressed";
            this.foregroundPressed.ReadOnly = true;
            // 
            // backgroundSelected
            // 
            this.backgroundSelected.HeaderText = "Background Selected";
            this.backgroundSelected.MinimumWidth = 6;
            this.backgroundSelected.Name = "backgroundSelected";
            this.backgroundSelected.ReadOnly = true;
            // 
            // foregroundSelected
            // 
            this.foregroundSelected.HeaderText = "Foreground Selected";
            this.foregroundSelected.MinimumWidth = 6;
            this.foregroundSelected.Name = "foregroundSelected";
            this.foregroundSelected.ReadOnly = true;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_selectImg
            // 
            this.btn_selectImg.Image = ((System.Drawing.Image)(resources.GetObject("btn_selectImg.Image")));
            this.btn_selectImg.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_selectImg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_selectImg.Name = "btn_selectImg";
            this.btn_selectImg.Size = new System.Drawing.Size(94, 24);
            this.btn_selectImg.Text = "Select Image";
            this.btn_selectImg.Click += new System.EventHandler(this.btn_selectImg_Click);
            // 
            // ModernThemeCreatorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "ModernThemeCreatorControl";
            this.Size = new System.Drawing.Size(1246, 551);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button colorPicker8;
        private System.Windows.Forms.Button colorPicker7;
        private System.Windows.Forms.Button colorPicker6;
        private System.Windows.Forms.Button colorPicker5;
        private System.Windows.Forms.Button colorPicker4;
        private System.Windows.Forms.Button colorPicker3;
        private System.Windows.Forms.Button colorPicker2;
        private System.Windows.Forms.Label lblForegroundSelected;
        private System.Windows.Forms.Label lblBackgroundSelected;
        private System.Windows.Forms.Label lblForegroundPressed;
        private System.Windows.Forms.Label lblBackgroundPressed;
        private System.Windows.Forms.Label lblWR;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtForegroundSelected;
        private System.Windows.Forms.TextBox txtBackgroundSelected;
        private System.Windows.Forms.TextBox txtForegroundPressed;
        private System.Windows.Forms.TextBox txtBackgroundPressed;
        private System.Windows.Forms.Button colorPicker1;
        private System.Windows.Forms.TextBox txtForegroundHover;
        private System.Windows.Forms.Label lblForegroundHover;
        private System.Windows.Forms.TextBox txtBackgroundHover;
        private System.Windows.Forms.Label lblBackgroundHover;
        private System.Windows.Forms.TextBox txtForeground;
        private System.Windows.Forms.Label color2;
        private System.Windows.Forms.Label backgroundLabel;
        private System.Windows.Forms.TextBox txtBackground;
        private System.Windows.Forms.Label lblAppId;
        private System.Windows.Forms.TextBox txtApp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appId;
        private System.Windows.Forms.DataGridViewTextBoxColumn background;
        private System.Windows.Forms.DataGridViewTextBoxColumn foreground;
        private System.Windows.Forms.DataGridViewTextBoxColumn backgroundHover;
        private System.Windows.Forms.DataGridViewTextBoxColumn foregroundHover;
        private System.Windows.Forms.DataGridViewTextBoxColumn webresourceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn backgroundPressed;
        private System.Windows.Forms.DataGridViewTextBoxColumn foregroundPressed;
        private System.Windows.Forms.DataGridViewTextBoxColumn backgroundSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn foregroundSelected;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btn_newTheme;
        private System.Windows.Forms.ToolStripButton btn_editTheme;
        private System.Windows.Forms.ToolStripButton btn_saveNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_imgId;
        private System.Windows.Forms.ToolStripButton btn_selectImg;
    }
}
