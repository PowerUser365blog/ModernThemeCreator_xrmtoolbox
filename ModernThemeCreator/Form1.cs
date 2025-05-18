using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using System.Xml;

namespace ModernThemeCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Entity webResourceLogo { get; set; }

        private void buttonImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "SVG Files (*.svg)|*.svg",
                Title = "Select SVG Logo"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string extension = System.IO.Path.GetExtension(filePath);

                if (!extension.Equals(".svg", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Please select a valid SVG file.");
                    return;
                }

                string svgContent = System.IO.File.ReadAllText(filePath);
                string base64Content = Convert.ToBase64String(Encoding.UTF8.GetBytes(svgContent));

                Entity webResource = new Entity("webresource");
                webResource["name"] = txtboxName.Text.Trim();
                webResource["displayname"] = txtboxName.Text.Trim();
                webResource["description"] = "Logo";
                webResource["content"] = base64Content;
                webResource["webresourcetype"] = new OptionSetValue(11); // SVG

                // Guardar temporalmente o enviar directamente a CRM
                webResourceLogo = webResource;

                MessageBox.Show("SVG file loaded successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


    }
}
