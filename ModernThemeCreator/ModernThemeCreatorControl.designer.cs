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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.btnNew = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblWait = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtForegroundSelected = new System.Windows.Forms.TextBox();
            this.txtBackgroundSelected = new System.Windows.Forms.TextBox();
            this.txtForegroundPressed = new System.Windows.Forms.TextBox();
            this.txtBackgroundPressed = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
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
            this.tssSeparator1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(2333, 34);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(129, 29);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.lblProgress);
            this.groupBox1.Controls.Add(this.lblWait);
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtForegroundSelected);
            this.groupBox1.Controls.Add(this.txtBackgroundSelected);
            this.groupBox1.Controls.Add(this.txtForegroundPressed);
            this.groupBox1.Controls.Add(this.txtBackgroundPressed);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnSaveNew);
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
            this.groupBox1.Location = new System.Drawing.Point(1516, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(735, 1075);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form";
            // 
            // colorPicker8
            // 
            this.colorPicker8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker8.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker8.Image")));
            this.colorPicker8.Location = new System.Drawing.Point(501, 664);
            this.colorPicker8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colorPicker8.Name = "colorPicker8";
            this.colorPicker8.Size = new System.Drawing.Size(40, 45);
            this.colorPicker8.TabIndex = 35;
            this.colorPicker8.UseVisualStyleBackColor = true;
            this.colorPicker8.Click += new System.EventHandler(this.colorPicker8_Click);
            // 
            // colorPicker7
            // 
            this.colorPicker7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker7.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker7.Image")));
            this.colorPicker7.Location = new System.Drawing.Point(501, 599);
            this.colorPicker7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colorPicker7.Name = "colorPicker7";
            this.colorPicker7.Size = new System.Drawing.Size(40, 45);
            this.colorPicker7.TabIndex = 34;
            this.colorPicker7.UseVisualStyleBackColor = true;
            this.colorPicker7.Click += new System.EventHandler(this.colorPicker7_Click);
            // 
            // colorPicker6
            // 
            this.colorPicker6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker6.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker6.Image")));
            this.colorPicker6.Location = new System.Drawing.Point(501, 532);
            this.colorPicker6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colorPicker6.Name = "colorPicker6";
            this.colorPicker6.Size = new System.Drawing.Size(40, 45);
            this.colorPicker6.TabIndex = 33;
            this.colorPicker6.UseVisualStyleBackColor = true;
            this.colorPicker6.Click += new System.EventHandler(this.colorPicker6_Click);
            // 
            // colorPicker5
            // 
            this.colorPicker5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker5.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker5.Image")));
            this.colorPicker5.Location = new System.Drawing.Point(501, 468);
            this.colorPicker5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colorPicker5.Name = "colorPicker5";
            this.colorPicker5.Size = new System.Drawing.Size(40, 45);
            this.colorPicker5.TabIndex = 32;
            this.colorPicker5.UseVisualStyleBackColor = true;
            this.colorPicker5.Click += new System.EventHandler(this.colorPicker5_Click);
            // 
            // colorPicker4
            // 
            this.colorPicker4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker4.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker4.Image")));
            this.colorPicker4.Location = new System.Drawing.Point(501, 404);
            this.colorPicker4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colorPicker4.Name = "colorPicker4";
            this.colorPicker4.Size = new System.Drawing.Size(40, 45);
            this.colorPicker4.TabIndex = 31;
            this.colorPicker4.UseVisualStyleBackColor = true;
            this.colorPicker4.Click += new System.EventHandler(this.colorPicker4_Click);
            // 
            // colorPicker3
            // 
            this.colorPicker3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker3.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker3.Image")));
            this.colorPicker3.Location = new System.Drawing.Point(501, 338);
            this.colorPicker3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colorPicker3.Name = "colorPicker3";
            this.colorPicker3.Size = new System.Drawing.Size(40, 45);
            this.colorPicker3.TabIndex = 30;
            this.colorPicker3.UseVisualStyleBackColor = true;
            this.colorPicker3.Click += new System.EventHandler(this.colorPicker3_Click);
            // 
            // colorPicker2
            // 
            this.colorPicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker2.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker2.Image")));
            this.colorPicker2.Location = new System.Drawing.Point(501, 271);
            this.colorPicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colorPicker2.Name = "colorPicker2";
            this.colorPicker2.Size = new System.Drawing.Size(40, 45);
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
            this.lblForegroundSelected.Location = new System.Drawing.Point(33, 678);
            this.lblForegroundSelected.Name = "lblForegroundSelected";
            this.lblForegroundSelected.Size = new System.Drawing.Size(159, 20);
            this.lblForegroundSelected.TabIndex = 28;
            this.lblForegroundSelected.Text = "Foreground Selected";
            // 
            // lblBackgroundSelected
            // 
            this.lblBackgroundSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBackgroundSelected.AutoSize = true;
            this.lblBackgroundSelected.Location = new System.Drawing.Point(33, 612);
            this.lblBackgroundSelected.Name = "lblBackgroundSelected";
            this.lblBackgroundSelected.Size = new System.Drawing.Size(162, 20);
            this.lblBackgroundSelected.TabIndex = 27;
            this.lblBackgroundSelected.Text = "Background Selected";
            // 
            // lblForegroundPressed
            // 
            this.lblForegroundPressed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblForegroundPressed.AutoSize = true;
            this.lblForegroundPressed.Location = new System.Drawing.Point(33, 548);
            this.lblForegroundPressed.Name = "lblForegroundPressed";
            this.lblForegroundPressed.Size = new System.Drawing.Size(154, 20);
            this.lblForegroundPressed.TabIndex = 26;
            this.lblForegroundPressed.Text = "Foreground Pressed";
            // 
            // lblBackgroundPressed
            // 
            this.lblBackgroundPressed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBackgroundPressed.AutoSize = true;
            this.lblBackgroundPressed.Location = new System.Drawing.Point(33, 482);
            this.lblBackgroundPressed.Name = "lblBackgroundPressed";
            this.lblBackgroundPressed.Size = new System.Drawing.Size(157, 20);
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
            this.lblWR.Location = new System.Drawing.Point(33, 99);
            this.lblWR.Name = "lblWR";
            this.lblWR.Size = new System.Drawing.Size(122, 20);
            this.lblWR.TabIndex = 24;
            this.lblWR.Text = "Webresource Id";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(611, 26);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 49);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(259, 844);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(84, 20);
            this.lblProgress.TabIndex = 23;
            this.lblProgress.Text = "Progress...";
            this.lblProgress.Visible = false;
            // 
            // lblWait
            // 
            this.lblWait.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWait.AutoSize = true;
            this.lblWait.Location = new System.Drawing.Point(250, 756);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(101, 20);
            this.lblWait.TabIndex = 22;
            this.lblWait.Text = "Please wait...";
            this.lblWait.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(169, 795);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(309, 29);
            this.progressBar.TabIndex = 21;
            this.progressBar.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(200, 96);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(340, 26);
            this.txtName.TabIndex = 20;
            // 
            // txtForegroundSelected
            // 
            this.txtForegroundSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtForegroundSelected.Location = new System.Drawing.Point(200, 672);
            this.txtForegroundSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtForegroundSelected.Name = "txtForegroundSelected";
            this.txtForegroundSelected.Size = new System.Drawing.Size(277, 26);
            this.txtForegroundSelected.TabIndex = 19;
            this.txtForegroundSelected.TextChanged += new System.EventHandler(this.txtForegroundSelected_TextChanged);
            // 
            // txtBackgroundSelected
            // 
            this.txtBackgroundSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackgroundSelected.Location = new System.Drawing.Point(200, 609);
            this.txtBackgroundSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBackgroundSelected.Name = "txtBackgroundSelected";
            this.txtBackgroundSelected.Size = new System.Drawing.Size(277, 26);
            this.txtBackgroundSelected.TabIndex = 18;
            this.txtBackgroundSelected.TextChanged += new System.EventHandler(this.txtBackgroundSelected_TextChanged);
            // 
            // txtForegroundPressed
            // 
            this.txtForegroundPressed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtForegroundPressed.Location = new System.Drawing.Point(200, 544);
            this.txtForegroundPressed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtForegroundPressed.Name = "txtForegroundPressed";
            this.txtForegroundPressed.Size = new System.Drawing.Size(277, 26);
            this.txtForegroundPressed.TabIndex = 17;
            this.txtForegroundPressed.TextChanged += new System.EventHandler(this.txtForegroundPressed_TextChanged);
            // 
            // txtBackgroundPressed
            // 
            this.txtBackgroundPressed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackgroundPressed.Location = new System.Drawing.Point(200, 478);
            this.txtBackgroundPressed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBackgroundPressed.Name = "txtBackgroundPressed";
            this.txtBackgroundPressed.Size = new System.Drawing.Size(277, 26);
            this.txtBackgroundPressed.TabIndex = 16;
            this.txtBackgroundPressed.TextChanged += new System.EventHandler(this.txtBackgroundPressed_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(233, 728);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(184, 50);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNew.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveNew.Image")));
            this.btnSaveNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveNew.Location = new System.Drawing.Point(233, 728);
            this.btnSaveNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(184, 50);
            this.btnSaveNew.TabIndex = 13;
            this.btnSaveNew.Text = "Save new";
            this.btnSaveNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // colorPicker1
            // 
            this.colorPicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker1.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker1.Image")));
            this.colorPicker1.Location = new System.Drawing.Point(501, 209);
            this.colorPicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colorPicker1.Name = "colorPicker1";
            this.colorPicker1.Size = new System.Drawing.Size(40, 45);
            this.colorPicker1.TabIndex = 10;
            this.colorPicker1.UseVisualStyleBackColor = true;
            this.colorPicker1.Click += new System.EventHandler(this.colorPicker1_Click);
            // 
            // txtForegroundHover
            // 
            this.txtForegroundHover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtForegroundHover.Location = new System.Drawing.Point(200, 411);
            this.txtForegroundHover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtForegroundHover.Name = "txtForegroundHover";
            this.txtForegroundHover.Size = new System.Drawing.Size(277, 26);
            this.txtForegroundHover.TabIndex = 9;
            this.txtForegroundHover.TextChanged += new System.EventHandler(this.txtForegroundHover_TextChanged);
            // 
            // lblForegroundHover
            // 
            this.lblForegroundHover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblForegroundHover.AutoSize = true;
            this.lblForegroundHover.Location = new System.Drawing.Point(33, 418);
            this.lblForegroundHover.Name = "lblForegroundHover";
            this.lblForegroundHover.Size = new System.Drawing.Size(138, 20);
            this.lblForegroundHover.TabIndex = 8;
            this.lblForegroundHover.Text = "Foreground Hover";
            // 
            // txtBackgroundHover
            // 
            this.txtBackgroundHover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackgroundHover.Location = new System.Drawing.Point(200, 346);
            this.txtBackgroundHover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBackgroundHover.Name = "txtBackgroundHover";
            this.txtBackgroundHover.Size = new System.Drawing.Size(277, 26);
            this.txtBackgroundHover.TabIndex = 7;
            this.txtBackgroundHover.TextChanged += new System.EventHandler(this.txtBackgroundHover_TextChanged);
            // 
            // lblBackgroundHover
            // 
            this.lblBackgroundHover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBackgroundHover.AutoSize = true;
            this.lblBackgroundHover.Location = new System.Drawing.Point(33, 352);
            this.lblBackgroundHover.Name = "lblBackgroundHover";
            this.lblBackgroundHover.Size = new System.Drawing.Size(141, 20);
            this.lblBackgroundHover.TabIndex = 6;
            this.lblBackgroundHover.Text = "Background Hover";
            // 
            // txtForeground
            // 
            this.txtForeground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtForeground.Location = new System.Drawing.Point(200, 280);
            this.txtForeground.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtForeground.Name = "txtForeground";
            this.txtForeground.Size = new System.Drawing.Size(277, 26);
            this.txtForeground.TabIndex = 5;
            this.txtForeground.TextChanged += new System.EventHandler(this.txtForeground_TextChanged);
            // 
            // color2
            // 
            this.color2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.color2.AutoSize = true;
            this.color2.Location = new System.Drawing.Point(33, 288);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(92, 20);
            this.color2.TabIndex = 4;
            this.color2.Text = "Foreground";
            // 
            // backgroundLabel
            // 
            this.backgroundLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundLabel.AutoSize = true;
            this.backgroundLabel.Location = new System.Drawing.Point(33, 222);
            this.backgroundLabel.Name = "backgroundLabel";
            this.backgroundLabel.Size = new System.Drawing.Size(95, 20);
            this.backgroundLabel.TabIndex = 3;
            this.backgroundLabel.Text = "Background";
            // 
            // txtBackground
            // 
            this.txtBackground.Location = new System.Drawing.Point(200, 218);
            this.txtBackground.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBackground.Name = "txtBackground";
            this.txtBackground.Size = new System.Drawing.Size(277, 26);
            this.txtBackground.TabIndex = 2;
            this.txtBackground.TextChanged += new System.EventHandler(this.txtBackground_TextChanged);
            // 
            // lblAppId
            // 
            this.lblAppId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppId.AutoSize = true;
            this.lblAppId.Location = new System.Drawing.Point(33, 158);
            this.lblAppId.Name = "lblAppId";
            this.lblAppId.Size = new System.Drawing.Size(56, 20);
            this.lblAppId.TabIndex = 1;
            this.lblAppId.Text = "App Id";
            // 
            // txtApp
            // 
            this.txtApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApp.Location = new System.Drawing.Point(200, 158);
            this.txtApp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApp.Name = "txtApp";
            this.txtApp.Size = new System.Drawing.Size(340, 26);
            this.txtApp.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridView1.Location = new System.Drawing.Point(63, 105);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1346, 1075);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // appId
            // 
            this.appId.HeaderText = "App Id";
            this.appId.MinimumWidth = 6;
            this.appId.Name = "appId";
            this.appId.ReadOnly = true;
            this.appId.Width = 125;
            // 
            // background
            // 
            this.background.HeaderText = "Background";
            this.background.MinimumWidth = 6;
            this.background.Name = "background";
            this.background.ReadOnly = true;
            this.background.Width = 125;
            // 
            // foreground
            // 
            this.foreground.HeaderText = "Foreground";
            this.foreground.MinimumWidth = 6;
            this.foreground.Name = "foreground";
            this.foreground.ReadOnly = true;
            this.foreground.Width = 125;
            // 
            // backgroundHover
            // 
            this.backgroundHover.HeaderText = "Background Hover";
            this.backgroundHover.MinimumWidth = 6;
            this.backgroundHover.Name = "backgroundHover";
            this.backgroundHover.ReadOnly = true;
            this.backgroundHover.Width = 125;
            // 
            // foregroundHover
            // 
            this.foregroundHover.HeaderText = "Foreground Hover";
            this.foregroundHover.MinimumWidth = 6;
            this.foregroundHover.Name = "foregroundHover";
            this.foregroundHover.ReadOnly = true;
            this.foregroundHover.Width = 125;
            // 
            // webresourceId
            // 
            this.webresourceId.HeaderText = "Webresource Id";
            this.webresourceId.MinimumWidth = 6;
            this.webresourceId.Name = "webresourceId";
            this.webresourceId.ReadOnly = true;
            this.webresourceId.Visible = false;
            this.webresourceId.Width = 125;
            // 
            // backgroundPressed
            // 
            this.backgroundPressed.HeaderText = "Background Pressed";
            this.backgroundPressed.MinimumWidth = 6;
            this.backgroundPressed.Name = "backgroundPressed";
            this.backgroundPressed.ReadOnly = true;
            this.backgroundPressed.Width = 125;
            // 
            // foregroundPressed
            // 
            this.foregroundPressed.HeaderText = "Foreground Pressed";
            this.foregroundPressed.MinimumWidth = 6;
            this.foregroundPressed.Name = "foregroundPressed";
            this.foregroundPressed.ReadOnly = true;
            this.foregroundPressed.Width = 125;
            // 
            // backgroundSelected
            // 
            this.backgroundSelected.HeaderText = "Background Selected";
            this.backgroundSelected.MinimumWidth = 6;
            this.backgroundSelected.Name = "backgroundSelected";
            this.backgroundSelected.ReadOnly = true;
            this.backgroundSelected.Width = 125;
            // 
            // foregroundSelected
            // 
            this.foregroundSelected.HeaderText = "Foreground Selected";
            this.foregroundSelected.MinimumWidth = 6;
            this.foregroundSelected.Name = "foregroundSelected";
            this.foregroundSelected.ReadOnly = true;
            this.foregroundSelected.Width = 125;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // ModernThemeCreatorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ModernThemeCreatorControl";
            this.Size = new System.Drawing.Size(2333, 1208);
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
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtForegroundSelected;
        private System.Windows.Forms.TextBox txtBackgroundSelected;
        private System.Windows.Forms.TextBox txtForegroundPressed;
        private System.Windows.Forms.TextBox txtBackgroundPressed;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSaveNew;
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
    }
}
