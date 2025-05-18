namespace ModernThemeCreator
{
    partial class Form3
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
            this.dataGridViewThemes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThemes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewThemes
            // 
            this.dataGridViewThemes.AllowUserToDeleteRows = false;
            this.dataGridViewThemes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewThemes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewThemes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewThemes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThemes.Location = new System.Drawing.Point(26, 26);
            this.dataGridViewThemes.MultiSelect = false;
            this.dataGridViewThemes.Name = "dataGridViewThemes";
            this.dataGridViewThemes.Size = new System.Drawing.Size(534, 309);
            this.dataGridViewThemes.TabIndex = 0;
            this.dataGridViewThemes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewThemes_CellClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 377);
            this.Controls.Add(this.dataGridViewThemes);
            this.Name = "Form3";
            this.Text = "Select classic theme for image";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThemes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewThemes;
    }
}