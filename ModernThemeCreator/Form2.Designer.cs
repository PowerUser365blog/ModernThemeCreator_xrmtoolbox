namespace ModernThemeCreator
{
    partial class Form2
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
            this.btnSaveName = new System.Windows.Forms.Button();
            this.lblWebresourceName = new System.Windows.Forms.Label();
            this.txtWRName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnSaveName
            // 
            this.btnSaveName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveName.Location = new System.Drawing.Point(238, 163);
            this.btnSaveName.Name = "btnSaveName";
            this.btnSaveName.Size = new System.Drawing.Size(128, 58);
            this.btnSaveName.TabIndex = 5;
            this.btnSaveName.Text = "Save";
            this.btnSaveName.UseVisualStyleBackColor = true;
            this.btnSaveName.Click += new System.EventHandler(this.btnSaveName_Click);
            // 
            // lblWebresourceName
            // 
            this.lblWebresourceName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWebresourceName.AutoSize = true;
            this.lblWebresourceName.Location = new System.Drawing.Point(41, 57);
            this.lblWebresourceName.Name = "lblWebresourceName";
            this.lblWebresourceName.Size = new System.Drawing.Size(267, 16);
            this.lblWebresourceName.TabIndex = 4;
            this.lblWebresourceName.Text = "please, write the name of your web resource";
            // 
            // txtWRName
            // 
            this.txtWRName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWRName.Location = new System.Drawing.Point(44, 100);
            this.txtWRName.Name = "txtWRName";
            this.txtWRName.Size = new System.Drawing.Size(487, 22);
            this.txtWRName.TabIndex = 3;
            this.txtWRName.Text = "pwuser_/yourWebresourceName.xml";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 278);
            this.Controls.Add(this.btnSaveName);
            this.Controls.Add(this.lblWebresourceName);
            this.Controls.Add(this.txtWRName);
            this.Name = "Form2";
            this.Text = "Webresource name";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveName;
        private System.Windows.Forms.Label lblWebresourceName;
        private System.Windows.Forms.TextBox txtWRName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}