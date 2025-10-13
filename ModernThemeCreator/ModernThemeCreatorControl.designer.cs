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
            this.btn_newTheme = new System.Windows.Forms.ToolStripButton();
            this.btn_editTheme = new System.Windows.Forms.ToolStripButton();
            this.btn_saveNew = new System.Windows.Forms.ToolStripButton();
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFont = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHueTorsion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVibrancy = new System.Windows.Forms.TextBox();
            this.colorPicker9 = new System.Windows.Forms.Button();
            this.txtBasePaletteColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWR = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAppId = new System.Windows.Forms.Label();
            this.txtApp = new System.Windows.Forms.TextBox();
            this.groupBoxHeaders = new System.Windows.Forms.GroupBox();
            this.backgroundLabel = new System.Windows.Forms.Label();
            this.txtBackground = new System.Windows.Forms.TextBox();
            this.color2 = new System.Windows.Forms.Label();
            this.txtForeground = new System.Windows.Forms.TextBox();
            this.lblBackgroundHover = new System.Windows.Forms.Label();
            this.txtBackgroundHover = new System.Windows.Forms.TextBox();
            this.lblForegroundHover = new System.Windows.Forms.Label();
            this.txtForegroundHover = new System.Windows.Forms.TextBox();
            this.colorPicker1 = new System.Windows.Forms.Button();
            this.txtBackgroundPressed = new System.Windows.Forms.TextBox();
            this.colorPicker8 = new System.Windows.Forms.Button();
            this.txtForegroundPressed = new System.Windows.Forms.TextBox();
            this.colorPicker7 = new System.Windows.Forms.Button();
            this.txtBackgroundSelected = new System.Windows.Forms.TextBox();
            this.colorPicker6 = new System.Windows.Forms.Button();
            this.txtForegroundSelected = new System.Windows.Forms.TextBox();
            this.colorPicker5 = new System.Windows.Forms.Button();
            this.lblBackgroundPressed = new System.Windows.Forms.Label();
            this.colorPicker4 = new System.Windows.Forms.Button();
            this.lblForegroundPressed = new System.Windows.Forms.Label();
            this.colorPicker3 = new System.Windows.Forms.Button();
            this.lblBackgroundSelected = new System.Windows.Forms.Label();
            this.colorPicker2 = new System.Windows.Forms.Button();
            this.lblForegroundSelected = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basePaletteColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vibrancy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hueTorsion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.font = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.toolStripMenu.SuspendLayout();
            this.groupBoxForm.SuspendLayout();
            this.groupBoxHeaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.btn_newTheme,
            this.btn_editTheme,
            this.btn_saveNew});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1322, 27);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(86, 24);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_newTheme
            // 
            this.btn_newTheme.Image = ((System.Drawing.Image)(resources.GetObject("btn_newTheme.Image")));
            this.btn_newTheme.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_newTheme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_newTheme.Name = "btn_newTheme";
            this.btn_newTheme.Size = new System.Drawing.Size(91, 24);
            this.btn_newTheme.Text = "New Theme";
            this.btn_newTheme.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btn_editTheme
            // 
            this.btn_editTheme.Image = ((System.Drawing.Image)(resources.GetObject("btn_editTheme.Image")));
            this.btn_editTheme.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_editTheme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_editTheme.Name = "btn_editTheme";
            this.btn_editTheme.Size = new System.Drawing.Size(87, 24);
            this.btn_editTheme.Text = "Edit Theme";
            this.btn_editTheme.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btn_saveNew
            // 
            this.btn_saveNew.Image = ((System.Drawing.Image)(resources.GetObject("btn_saveNew.Image")));
            this.btn_saveNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_saveNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_saveNew.Name = "btn_saveNew";
            this.btn_saveNew.Size = new System.Drawing.Size(82, 24);
            this.btn_saveNew.Text = "Save New";
            this.btn_saveNew.ToolTipText = "Save New";
            this.btn_saveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxForm.AutoSize = true;
            this.groupBoxForm.Controls.Add(this.button1);
            this.groupBoxForm.Controls.Add(this.label5);
            this.groupBoxForm.Controls.Add(this.txtFont);
            this.groupBoxForm.Controls.Add(this.label4);
            this.groupBoxForm.Controls.Add(this.txtHueTorsion);
            this.groupBoxForm.Controls.Add(this.label3);
            this.groupBoxForm.Controls.Add(this.txtVibrancy);
            this.groupBoxForm.Controls.Add(this.colorPicker9);
            this.groupBoxForm.Controls.Add(this.label2);
            this.groupBoxForm.Controls.Add(this.txtBasePaletteColor);
            this.groupBoxForm.Controls.Add(this.lblWR);
            this.groupBoxForm.Controls.Add(this.txtName);
            this.groupBoxForm.Controls.Add(this.lblAppId);
            this.groupBoxForm.Controls.Add(this.txtApp);
            this.groupBoxForm.Controls.Add(this.groupBoxHeaders);
            this.groupBoxForm.Location = new System.Drawing.Point(726, 29);
            this.groupBoxForm.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxForm.Size = new System.Drawing.Size(570, 631);
            this.groupBoxForm.TabIndex = 6;
            this.groupBoxForm.TabStop = false;
            this.groupBoxForm.Text = "Form";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Add color in App Headers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowHeader_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Font";
            // 
            // txtFont
            // 
            this.txtFont.Location = new System.Drawing.Point(134, 211);
            this.txtFont.Margin = new System.Windows.Forms.Padding(2);
            this.txtFont.Name = "txtFont";
            this.txtFont.Size = new System.Drawing.Size(266, 20);
            this.txtFont.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Hue Torsion";
            // 
            // txtHueTorsion
            // 
            this.txtHueTorsion.Location = new System.Drawing.Point(134, 175);
            this.txtHueTorsion.Margin = new System.Windows.Forms.Padding(2);
            this.txtHueTorsion.Name = "txtHueTorsion";
            this.txtHueTorsion.Size = new System.Drawing.Size(266, 20);
            this.txtHueTorsion.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Vibrancy";
            // 
            // txtVibrancy
            // 
            this.txtVibrancy.Location = new System.Drawing.Point(134, 140);
            this.txtVibrancy.Margin = new System.Windows.Forms.Padding(2);
            this.txtVibrancy.Name = "txtVibrancy";
            this.txtVibrancy.Size = new System.Drawing.Size(266, 20);
            this.txtVibrancy.TabIndex = 41;
            // 
            // colorPicker9
            // 
            this.colorPicker9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker9.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker9.Image")));
            this.colorPicker9.Location = new System.Drawing.Point(414, 102);
            this.colorPicker9.Margin = new System.Windows.Forms.Padding(2);
            this.colorPicker9.Name = "colorPicker9";
            this.colorPicker9.Size = new System.Drawing.Size(27, 29);
            this.colorPicker9.TabIndex = 40;
            this.colorPicker9.Tag = this.txtBasePaletteColor;
            this.colorPicker9.UseVisualStyleBackColor = true;
            this.colorPicker9.Click += new System.EventHandler(this.ColorPicker_Click);
            // 
            // txtBasePaletteColor
            // 
            this.txtBasePaletteColor.Location = new System.Drawing.Point(134, 107);
            this.txtBasePaletteColor.Margin = new System.Windows.Forms.Padding(2);
            this.txtBasePaletteColor.Name = "txtBasePaletteColor";
            this.txtBasePaletteColor.Size = new System.Drawing.Size(266, 20);
            this.txtBasePaletteColor.TabIndex = 38;
            this.txtBasePaletteColor.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Base Palette Color";
            // 
            // lblWR
            // 
            this.lblWR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWR.AutoSize = true;
            this.lblWR.Enabled = false;
            this.lblWR.Location = new System.Drawing.Point(22, 26);
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
            this.txtName.Location = new System.Drawing.Point(134, 25);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(308, 20);
            this.txtName.TabIndex = 20;
            // 
            // lblAppId
            // 
            this.lblAppId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppId.AutoSize = true;
            this.lblAppId.Location = new System.Drawing.Point(22, 60);
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
            this.txtApp.Location = new System.Drawing.Point(134, 60);
            this.txtApp.Margin = new System.Windows.Forms.Padding(2);
            this.txtApp.Name = "txtApp";
            this.txtApp.Size = new System.Drawing.Size(308, 20);
            this.txtApp.TabIndex = 0;
            // 
            // groupBoxHeaders
            // 
            this.groupBoxHeaders.Controls.Add(this.backgroundLabel);
            this.groupBoxHeaders.Controls.Add(this.txtBackground);
            this.groupBoxHeaders.Controls.Add(this.color2);
            this.groupBoxHeaders.Controls.Add(this.txtForeground);
            this.groupBoxHeaders.Controls.Add(this.lblBackgroundHover);
            this.groupBoxHeaders.Controls.Add(this.txtBackgroundHover);
            this.groupBoxHeaders.Controls.Add(this.lblForegroundHover);
            this.groupBoxHeaders.Controls.Add(this.txtForegroundHover);
            this.groupBoxHeaders.Controls.Add(this.colorPicker1);
            this.groupBoxHeaders.Controls.Add(this.txtBackgroundPressed);
            this.groupBoxHeaders.Controls.Add(this.colorPicker8);
            this.groupBoxHeaders.Controls.Add(this.txtForegroundPressed);
            this.groupBoxHeaders.Controls.Add(this.colorPicker7);
            this.groupBoxHeaders.Controls.Add(this.txtBackgroundSelected);
            this.groupBoxHeaders.Controls.Add(this.colorPicker6);
            this.groupBoxHeaders.Controls.Add(this.txtForegroundSelected);
            this.groupBoxHeaders.Controls.Add(this.colorPicker5);
            this.groupBoxHeaders.Controls.Add(this.lblBackgroundPressed);
            this.groupBoxHeaders.Controls.Add(this.colorPicker4);
            this.groupBoxHeaders.Controls.Add(this.lblForegroundPressed);
            this.groupBoxHeaders.Controls.Add(this.colorPicker3);
            this.groupBoxHeaders.Controls.Add(this.lblBackgroundSelected);
            this.groupBoxHeaders.Controls.Add(this.colorPicker2);
            this.groupBoxHeaders.Controls.Add(this.lblForegroundSelected);
            this.groupBoxHeaders.Location = new System.Drawing.Point(25, 287);
            this.groupBoxHeaders.Name = "groupBoxHeaders";
            this.groupBoxHeaders.Size = new System.Drawing.Size(457, 326);
            this.groupBoxHeaders.TabIndex = 48;
            this.groupBoxHeaders.TabStop = false;
            // 
            // backgroundLabel
            // 
            this.backgroundLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundLabel.AutoSize = true;
            this.backgroundLabel.Location = new System.Drawing.Point(17, 16);
            this.backgroundLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.backgroundLabel.Name = "backgroundLabel";
            this.backgroundLabel.Size = new System.Drawing.Size(65, 13);
            this.backgroundLabel.TabIndex = 3;
            this.backgroundLabel.Text = "Background";
            // 
            // txtBackground
            // 
            this.txtBackground.Location = new System.Drawing.Point(129, 12);
            this.txtBackground.Margin = new System.Windows.Forms.Padding(2);
            this.txtBackground.Name = "txtBackground";
            this.txtBackground.Size = new System.Drawing.Size(266, 20);
            this.txtBackground.TabIndex = 2;
            this.txtBackground.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // color2
            // 
            this.color2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.color2.AutoSize = true;
            this.color2.Location = new System.Drawing.Point(17, 56);
            this.color2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(61, 13);
            this.color2.TabIndex = 4;
            this.color2.Text = "Foreground";
            // 
            // txtForeground
            // 
            this.txtForeground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtForeground.Location = new System.Drawing.Point(129, 51);
            this.txtForeground.Margin = new System.Windows.Forms.Padding(2);
            this.txtForeground.Name = "txtForeground";
            this.txtForeground.Size = new System.Drawing.Size(266, 20);
            this.txtForeground.TabIndex = 5;
            this.txtForeground.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // lblBackgroundHover
            // 
            this.lblBackgroundHover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBackgroundHover.AutoSize = true;
            this.lblBackgroundHover.Location = new System.Drawing.Point(17, 94);
            this.lblBackgroundHover.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBackgroundHover.Name = "lblBackgroundHover";
            this.lblBackgroundHover.Size = new System.Drawing.Size(97, 13);
            this.lblBackgroundHover.TabIndex = 6;
            this.lblBackgroundHover.Text = "Background Hover";
            // 
            // txtBackgroundHover
            // 
            this.txtBackgroundHover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackgroundHover.Location = new System.Drawing.Point(129, 90);
            this.txtBackgroundHover.Margin = new System.Windows.Forms.Padding(2);
            this.txtBackgroundHover.Name = "txtBackgroundHover";
            this.txtBackgroundHover.Size = new System.Drawing.Size(266, 20);
            this.txtBackgroundHover.TabIndex = 7;
            this.txtBackgroundHover.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // lblForegroundHover
            // 
            this.lblForegroundHover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblForegroundHover.AutoSize = true;
            this.lblForegroundHover.Location = new System.Drawing.Point(17, 131);
            this.lblForegroundHover.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForegroundHover.Name = "lblForegroundHover";
            this.lblForegroundHover.Size = new System.Drawing.Size(93, 13);
            this.lblForegroundHover.TabIndex = 8;
            this.lblForegroundHover.Text = "Foreground Hover";
            // 
            // txtForegroundHover
            // 
            this.txtForegroundHover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtForegroundHover.Location = new System.Drawing.Point(129, 127);
            this.txtForegroundHover.Margin = new System.Windows.Forms.Padding(2);
            this.txtForegroundHover.Name = "txtForegroundHover";
            this.txtForegroundHover.Size = new System.Drawing.Size(266, 20);
            this.txtForegroundHover.TabIndex = 9;
            this.txtForegroundHover.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // colorPicker1
            // 
            this.colorPicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker1.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker1.Image")));
            this.colorPicker1.Location = new System.Drawing.Point(409, 7);
            this.colorPicker1.Margin = new System.Windows.Forms.Padding(2);
            this.colorPicker1.Name = "colorPicker1";
            this.colorPicker1.Size = new System.Drawing.Size(27, 29);
            this.colorPicker1.TabIndex = 10;
            this.colorPicker1.Tag = txtBackground;
            this.colorPicker1.UseVisualStyleBackColor = true;
            this.colorPicker1.Click += new System.EventHandler(this.ColorPicker_Click);
            // 
            // txtBackgroundPressed
            // 
            this.txtBackgroundPressed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackgroundPressed.Location = new System.Drawing.Point(129, 165);
            this.txtBackgroundPressed.Margin = new System.Windows.Forms.Padding(2);
            this.txtBackgroundPressed.Name = "txtBackgroundPressed";
            this.txtBackgroundPressed.Size = new System.Drawing.Size(266, 20);
            this.txtBackgroundPressed.TabIndex = 16;
            this.txtBackgroundPressed.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // colorPicker8
            // 
            this.colorPicker8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker8.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker8.Image")));
            this.colorPicker8.Location = new System.Drawing.Point(409, 276);
            this.colorPicker8.Margin = new System.Windows.Forms.Padding(2);
            this.colorPicker8.Name = "colorPicker8";
            this.colorPicker8.Size = new System.Drawing.Size(27, 29);
            this.colorPicker8.TabIndex = 35;
            this.colorPicker8.Tag = txtForegroundSelected;
            this.colorPicker8.UseVisualStyleBackColor = true;
            this.colorPicker8.Click += new System.EventHandler(this.ColorPicker_Click);
            // 
            // txtForegroundPressed
            // 
            this.txtForegroundPressed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtForegroundPressed.Location = new System.Drawing.Point(129, 205);
            this.txtForegroundPressed.Margin = new System.Windows.Forms.Padding(2);
            this.txtForegroundPressed.Name = "txtForegroundPressed";
            this.txtForegroundPressed.Size = new System.Drawing.Size(266, 20);
            this.txtForegroundPressed.TabIndex = 17;
            this.txtForegroundPressed.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // colorPicker7
            // 
            this.colorPicker7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker7.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker7.Image")));
            this.colorPicker7.Location = new System.Drawing.Point(409, 237);
            this.colorPicker7.Margin = new System.Windows.Forms.Padding(2);
            this.colorPicker7.Name = "colorPicker7";
            this.colorPicker7.Size = new System.Drawing.Size(27, 29);
            this.colorPicker7.TabIndex = 34;
            this.colorPicker7.Tag = txtBackgroundSelected;
            this.colorPicker7.UseVisualStyleBackColor = true;
            this.colorPicker7.Click += new System.EventHandler(this.ColorPicker_Click);
            // 
            // txtBackgroundSelected
            // 
            this.txtBackgroundSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackgroundSelected.Location = new System.Drawing.Point(129, 244);
            this.txtBackgroundSelected.Margin = new System.Windows.Forms.Padding(2);
            this.txtBackgroundSelected.Name = "txtBackgroundSelected";
            this.txtBackgroundSelected.Size = new System.Drawing.Size(266, 20);
            this.txtBackgroundSelected.TabIndex = 18;
            this.txtBackgroundSelected.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // colorPicker6
            // 
            this.colorPicker6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker6.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker6.Image")));
            this.colorPicker6.Location = new System.Drawing.Point(409, 198);
            this.colorPicker6.Margin = new System.Windows.Forms.Padding(2);
            this.colorPicker6.Name = "colorPicker6";
            this.colorPicker6.Size = new System.Drawing.Size(27, 29);
            this.colorPicker6.TabIndex = 33;
            this.colorPicker6.Tag = txtForegroundPressed;
            this.colorPicker6.UseVisualStyleBackColor = true;
            this.colorPicker6.Click += new System.EventHandler(this.ColorPicker_Click);
            // 
            // txtForegroundSelected
            // 
            this.txtForegroundSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtForegroundSelected.Location = new System.Drawing.Point(129, 282);
            this.txtForegroundSelected.Margin = new System.Windows.Forms.Padding(2);
            this.txtForegroundSelected.Name = "txtForegroundSelected";
            this.txtForegroundSelected.Size = new System.Drawing.Size(266, 20);
            this.txtForegroundSelected.TabIndex = 19;
            this.txtForegroundSelected.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // colorPicker5
            // 
            this.colorPicker5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker5.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker5.Image")));
            this.colorPicker5.Location = new System.Drawing.Point(409, 159);
            this.colorPicker5.Margin = new System.Windows.Forms.Padding(2);
            this.colorPicker5.Name = "colorPicker5";
            this.colorPicker5.Size = new System.Drawing.Size(27, 29);
            this.colorPicker5.TabIndex = 32;
            this.colorPicker5.Tag = txtBackgroundPressed;
            this.colorPicker5.UseVisualStyleBackColor = true;
            this.colorPicker5.Click += new System.EventHandler(this.ColorPicker_Click);
            // 
            // lblBackgroundPressed
            // 
            this.lblBackgroundPressed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBackgroundPressed.AutoSize = true;
            this.lblBackgroundPressed.Location = new System.Drawing.Point(17, 169);
            this.lblBackgroundPressed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBackgroundPressed.Name = "lblBackgroundPressed";
            this.lblBackgroundPressed.Size = new System.Drawing.Size(106, 13);
            this.lblBackgroundPressed.TabIndex = 25;
            this.lblBackgroundPressed.Text = "Background Pressed";
            // 
            // colorPicker4
            // 
            this.colorPicker4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker4.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker4.Image")));
            this.colorPicker4.Location = new System.Drawing.Point(409, 122);
            this.colorPicker4.Margin = new System.Windows.Forms.Padding(2);
            this.colorPicker4.Name = "colorPicker4";
            this.colorPicker4.Size = new System.Drawing.Size(27, 29);
            this.colorPicker4.TabIndex = 31;
            this.colorPicker4.Tag = txtForegroundHover;
            this.colorPicker4.UseVisualStyleBackColor = true;
            this.colorPicker4.Click += new System.EventHandler(this.ColorPicker_Click);
            // 
            // lblForegroundPressed
            // 
            this.lblForegroundPressed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblForegroundPressed.AutoSize = true;
            this.lblForegroundPressed.Location = new System.Drawing.Point(17, 208);
            this.lblForegroundPressed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForegroundPressed.Name = "lblForegroundPressed";
            this.lblForegroundPressed.Size = new System.Drawing.Size(102, 13);
            this.lblForegroundPressed.TabIndex = 26;
            this.lblForegroundPressed.Text = "Foreground Pressed";
            // 
            // colorPicker3
            // 
            this.colorPicker3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker3.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker3.Image")));
            this.colorPicker3.Location = new System.Drawing.Point(409, 84);
            this.colorPicker3.Margin = new System.Windows.Forms.Padding(2);
            this.colorPicker3.Name = "colorPicker3";
            this.colorPicker3.Size = new System.Drawing.Size(27, 29);
            this.colorPicker3.TabIndex = 30;
            this.colorPicker3.Tag = txtBackgroundHover;
            this.colorPicker3.UseVisualStyleBackColor = true;
            this.colorPicker3.Click += new System.EventHandler(this.ColorPicker_Click);
            // 
            // lblBackgroundSelected
            // 
            this.lblBackgroundSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBackgroundSelected.AutoSize = true;
            this.lblBackgroundSelected.Location = new System.Drawing.Point(17, 246);
            this.lblBackgroundSelected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBackgroundSelected.Name = "lblBackgroundSelected";
            this.lblBackgroundSelected.Size = new System.Drawing.Size(110, 13);
            this.lblBackgroundSelected.TabIndex = 27;
            this.lblBackgroundSelected.Text = "Background Selected";
            // 
            // colorPicker2
            // 
            this.colorPicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker2.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker2.Image")));
            this.colorPicker2.Location = new System.Drawing.Point(409, 45);
            this.colorPicker2.Margin = new System.Windows.Forms.Padding(2);
            this.colorPicker2.Name = "colorPicker2";
            this.colorPicker2.Size = new System.Drawing.Size(27, 29);
            this.colorPicker2.TabIndex = 29;
            this.colorPicker2.Tag = txtForeground;
            this.colorPicker2.UseVisualStyleBackColor = true;
            this.colorPicker2.Click += new System.EventHandler(this.ColorPicker_Click);
            // 
            // lblForegroundSelected
            // 
            this.lblForegroundSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblForegroundSelected.AutoSize = true;
            this.lblForegroundSelected.Location = new System.Drawing.Point(17, 285);
            this.lblForegroundSelected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForegroundSelected.Name = "lblForegroundSelected";
            this.lblForegroundSelected.Size = new System.Drawing.Size(106, 13);
            this.lblForegroundSelected.TabIndex = 28;
            this.lblForegroundSelected.Text = "Foreground Selected";
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
            this.basePaletteColor,
            this.vibrancy,
            this.hueTorsion,
            this.font,
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
            this.dataGridView1.Size = new System.Drawing.Size(679, 632);
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
            // basePaletteColor
            // 
            this.basePaletteColor.HeaderText = "Base Palette Color";
            this.basePaletteColor.Name = "basePaletteColor";
            this.basePaletteColor.ReadOnly = true;
            // 
            // vibrancy
            // 
            this.vibrancy.HeaderText = "Vibrancy";
            this.vibrancy.Name = "vibrancy";
            this.vibrancy.ReadOnly = true;
            // 
            // hueTorsion
            // 
            this.hueTorsion.HeaderText = "Hue Torsion";
            this.hueTorsion.Name = "hueTorsion";
            this.hueTorsion.ReadOnly = true;
            // 
            // font
            // 
            this.font.HeaderText = "Font";
            this.font.Name = "font";
            this.font.ReadOnly = true;
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
            // ModernThemeCreatorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBoxForm);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "ModernThemeCreatorControl";
            this.Size = new System.Drawing.Size(1322, 678);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.groupBoxForm.ResumeLayout(false);
            this.groupBoxForm.PerformLayout();
            this.groupBoxHeaders.ResumeLayout(false);
            this.groupBoxHeaders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.GroupBox groupBoxForm;
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
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton btn_newTheme;
        private System.Windows.Forms.ToolStripButton btn_editTheme;
        private System.Windows.Forms.ToolStripButton btn_saveNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHueTorsion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVibrancy;
        private System.Windows.Forms.Button colorPicker9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBasePaletteColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFont;
        private System.Windows.Forms.DataGridViewTextBoxColumn appId;
        private System.Windows.Forms.DataGridViewTextBoxColumn basePaletteColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn vibrancy;
        private System.Windows.Forms.DataGridViewTextBoxColumn hueTorsion;
        private System.Windows.Forms.DataGridViewTextBoxColumn font;
        private System.Windows.Forms.DataGridViewTextBoxColumn background;
        private System.Windows.Forms.DataGridViewTextBoxColumn foreground;
        private System.Windows.Forms.DataGridViewTextBoxColumn backgroundHover;
        private System.Windows.Forms.DataGridViewTextBoxColumn foregroundHover;
        private System.Windows.Forms.DataGridViewTextBoxColumn webresourceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn backgroundPressed;
        private System.Windows.Forms.DataGridViewTextBoxColumn foregroundPressed;
        private System.Windows.Forms.DataGridViewTextBoxColumn backgroundSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn foregroundSelected;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxHeaders;
    }
}
