using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using ModernThemeCreator.Helpers;
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
using XrmToolBox.Extensibility;

namespace ModernThemeCreator
{
    public partial class Form3 : Form
    {
        private EntityCollection _themes;
        public Form3(EntityCollection themes)
        {
            InitializeComponent();
            _themes = themes;
            this.Load += Form3_Load;
        }
        public Guid imageId { get; set; }
        public bool isDefault { get; set; }
        //Obtener los temas clasicos
        private void Form3_Load(object sender, EventArgs e)
        {
            if (_themes != null && _themes.Entities != null && _themes.Entities.Any())
            {
                // Convertimos a una lista de objetos anónimos para mostrar en el DataGridView
                var themeList = _themes.Entities.Select(t => new
                {
                    ThemeId = t.Id,
                    Name = t.GetAttributeValue<string>("name"),
                    LogoTooltip = t.GetAttributeValue<string>("logotooltip"),
                    IsDefault = t.GetAttributeValue<bool?>("isdefaulttheme")
                }).ToList();

                dataGridViewThemes.DataSource = themeList;
            }
            else
            {
                MessageBox.Show("No themes received.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridViewThemes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) // Assuming the first column is the ThemeId
            {
                var selectedTheme = dataGridViewThemes.Rows[e.RowIndex].DataBoundItem as dynamic;
                if (selectedTheme != null)
                {
                    imageId = selectedTheme.ThemeId;
                    isDefault = selectedTheme.IsDefault;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}