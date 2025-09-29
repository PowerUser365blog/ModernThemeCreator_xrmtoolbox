using McTools.Xrm.Connection;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using ModernThemeCreator.Helpers;
using ModernThemeCreator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Args;

namespace ModernThemeCreator
{
    public partial class ModernThemeCreatorControl : PluginControlBase
    {
        private Settings ModernThemeSettings;
        private ListViewItem[] listViewClassicThemes;
        public ModernThemeCreatorControl()
        {
            InitializeComponent();
        }
        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            if (!SettingsManager.Instance.TryLoad(GetType(), out ModernThemeSettings))
            {
                ModernThemeSettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
            ExecuteMethod(LoadSettings);
        }
        private List<Entity> data;
        private void LoadSettings()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Searching",
                Work = (worker, args) =>
                {
                    args.Result = GetData();
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    data = args.Result as List<Entity>;
                    if (data != null)
                    {
                        LoadData();
                    }
                }
            });
        }
        private List<Entity> GetData()
        {
            string appSettingName = "CustomThemeDefinition";
            Guid settingId = GetSettingId(appSettingName);
            EntityCollection settings = GetSetting(settingId, "appsetting");
            EntityCollection orgSettings = GetSetting(settingId, "organizationsetting");
            EntityCollection colorSettings = new EntityCollection();
            foreach (var setting in settings.Entities)
            {
                Entity entity = new Entity("combinedsetting");
                entity.Id = new Guid();
                entity["appid"] = setting.GetAttributeValue<EntityReference>("parentappmoduleid").Id;
                entity["value"] = setting.GetAttributeValue<string>("value");
                colorSettings.Entities.Add(entity);
            }
            ;
            foreach (var orgSetting in orgSettings.Entities)
            {
                Entity entity = new Entity("combinedsetting");
                entity.Id = new Guid();
                entity["appid"] = Guid.Empty;
                entity["value"] = orgSetting.GetAttributeValue<string>("value");
                colorSettings.Entities.Add(entity);

            }
            ;
            return colorSettings.Entities.ToList();

        }
        private void LoadData()
        {
            foreach (var colorSetting in data)
            {
                string webresourceName = colorSetting.GetAttributeValue<string>("value");
                Models.CustomTheme customTheme = GetXml(webresourceName);
                if (customTheme != null)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);
                    row.Cells[dataGridView1.Columns["basePaletteColor"].Index].Value = customTheme.basePaletteColor;
                    row.Cells[dataGridView1.Columns["vibrancy"].Index].Value = customTheme.vibrancy;
                    row.Cells[dataGridView1.Columns["hueTorsion"].Index].Value = customTheme.hueTorsion;
                    row.Cells[dataGridView1.Columns["font"].Index].Value = customTheme.font;
                    row.Cells[dataGridView1.Columns["webresourceId"].Index].Value = customTheme.id;
                    row.Cells[dataGridView1.Columns["appId"].Index].Value = colorSetting.GetAttributeValue<Guid>("appid").ToString();
                    if (customTheme.AppHeaderColors != null)
                    {
                        row.Cells[dataGridView1.Columns["background"].Index].Value = customTheme.AppHeaderColors.background;
                        row.Cells[dataGridView1.Columns["foreground"].Index].Value = customTheme.AppHeaderColors.foreground;
                        row.Cells[dataGridView1.Columns["backgroundHover"].Index].Value = customTheme.AppHeaderColors.backgroundHover;
                        row.Cells[dataGridView1.Columns["foregroundHover"].Index].Value = customTheme.AppHeaderColors.foregroundHover;
                        row.Cells[dataGridView1.Columns["backgroundPressed"].Index].Value = customTheme.AppHeaderColors.backgroundPressed;
                        row.Cells[dataGridView1.Columns["foregroundPressed"].Index].Value = customTheme.AppHeaderColors.foregroundPressed;
                        row.Cells[dataGridView1.Columns["backgroundSelected"].Index].Value = customTheme.AppHeaderColors.backgroundSelected;
                        row.Cells[dataGridView1.Columns["foregroundSelected"].Index].Value = customTheme.AppHeaderColors.foregroundSelected;
                    }
                    dataGridView1.Invoke(new Action(() => dataGridView1.Rows.Add(row)));
                }
            }
            ;
        }

        private Guid GetSettingId(string appSettingName)
        {
            Guid settingId = Guid.Empty;
            string fetchXml = @"<fetch>
                                  <entity name=""settingdefinition"">
                                    <filter>
                                      <condition attribute=""uniquename"" operator=""eq"" value=""" + appSettingName + @""" />
                                    </filter>
                                  </entity>
                                </fetch>";
            try
            {
                EntityCollection settings = Service.RetrieveMultiple(new FetchExpression(fetchXml));
                settingId = settings.Entities[0].GetAttributeValue<Guid>("settingdefinitionid");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            return settingId;
        }

        private EntityCollection GetSetting(Guid settingId, string entity)
        {
            EntityCollection settings = null;
            string fetchXml = @"<fetch>
                                  <entity name=""" + entity + @""">
                                    <filter>
                                        <condition attribute=""settingdefinitionid"" operator=""eq"" value=""" + settingId + @""" />
                                    </filter>
                                  </entity>
                                </fetch>";

            try
            {
                settings = Service.RetrieveMultiple(new FetchExpression(fetchXml));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return settings;
        }
        private Models.CustomTheme GetXml(string webResource)
        {
            EntityCollection webResources = null;
            string content = null;

            Models.CustomTheme customTheme = new Models.CustomTheme();
            string fetchXml = @"<fetch>
                                  <entity name=""webresource"">
                                    <attribute name=""content"" />
                                    <filter>
                                      <condition attribute=""name"" operator=""eq"" value=""" + webResource + @""" />
                                    </filter>
                                  </entity>
                                </fetch>";

            try
            {
                webResources = Service.RetrieveMultiple(new FetchExpression(fetchXml));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            if (webResources.Entities.Count > 0)
            {
                content = webResources.Entities[0].GetAttributeValue<string>("content");
                byte[] data = Convert.FromBase64String(content);
                content = System.Text.Encoding.UTF8.GetString(data);
                XmlSerializer serializer = new XmlSerializer(typeof(Models.CustomTheme));
                customTheme = serializer.Deserialize(new System.IO.StringReader(content)) as Models.CustomTheme;
                customTheme.id = webResources.Entities[0].Id.ToString();
                return customTheme;
            }
            else
            {
                return null;
            }

        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), ModernThemeSettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (ModernThemeSettings != null && detail != null)
            {
                ModernThemeSettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            txtApp.Clear();
            txtBasePaletteColor.Clear();
            txtVibrancy.Clear();
            txtHueTorsion.Clear();
            txtFont.Clear();
            txtBackground.Clear();
            txtForeground.Clear();
            txtBackgroundHover.Clear();
            txtBackgroundHover.Clear();
            txtForegroundHover.Clear();
            txtBackgroundPressed.Clear();
            txtForegroundPressed.Clear();
            txtBackgroundSelected.Clear();
            txtForegroundSelected.Clear();
            txtName.Clear();
            txtBasePaletteColor.BackColor = Color.White;
            txtBackground.BackColor = Color.White;
            txtForeground.BackColor = Color.White;
            txtBackgroundHover.BackColor = Color.White;
            txtForegroundHover.BackColor = Color.White;
            txtBackgroundPressed.BackColor = Color.White;
            txtForegroundPressed.BackColor = Color.White;
            txtBackgroundSelected.BackColor = Color.White;
            txtForegroundSelected.BackColor = Color.White;
            btn_editTheme.Enabled = false;
            btn_saveNew.Enabled = true;
        }

        private string ColorToHex(Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }
        private void CheckEmptyColor()
        {
            if(txtBasePaletteColor.Text== string.Empty) { txtBasePaletteColor.Text = "#FFFFFF"; }
            if (txtBackground.Text == string.Empty) { txtBackground.Text = "#FFFFFF"; }
            if (txtForeground.Text == string.Empty) { txtForeground.Text = "#FFFFFF"; }
            if (txtBackgroundHover.Text == string.Empty) { txtBackgroundHover.Text = "#FFFFFF"; }
            if (txtForegroundHover.Text == string.Empty) { txtForegroundHover.Text = "#FFFFFF"; }
            if (txtBackgroundPressed.Text == string.Empty) { txtBackgroundPressed.Text = "#FFFFFF"; }
            if (txtForegroundPressed.Text == string.Empty) { txtForegroundPressed.Text = "#FFFFFF"; }
            if (txtBackgroundSelected.Text == string.Empty) { txtBackgroundSelected.Text = "#FFFFFF"; }
            if (txtForegroundSelected.Text == string.Empty) { txtForegroundSelected.Text = "#FFFFFF"; }
        }
        private void colorPicker1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBackground.Text = ColorToHex(colorDialog1.Color);
            }
        }

        private void colorPicker2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtForeground.Text = ColorToHex(colorDialog1.Color);
            }
        }

        private void colorPicker3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBackgroundHover.Text = ColorToHex(colorDialog1.Color);
            }
        }

        private void colorPicker4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtForegroundHover.Text = ColorToHex(colorDialog1.Color);
            }
        }

        private void colorPicker5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBackgroundPressed.Text = ColorToHex(colorDialog1.Color);
            }
        }

        private void colorPicker6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtForegroundPressed.Text = ColorToHex(colorDialog1.Color);
            }
        }

        private void colorPicker7_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBackgroundSelected.Text = ColorToHex(colorDialog1.Color);
            }
        }

        private void colorPicker8_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtForegroundSelected.Text = ColorToHex(colorDialog1.Color);
            }
        }
        private void colorPicker9_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBasePaletteColor.Text = ColorToHex(colorDialog1.Color);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CheckEmptyColor();
            XmlDocument xmlTheme = createXlm();
            UpdateWebresource(Service, txtName.Text, xmlTheme);
            MessageBox.Show("Theme updated..!");
            this.dataGridView1.Rows.Clear();
            LoadSettings();
        }
        private XmlDocument createXlm()
        {
            XmlDocument xmlTheme = new XmlDocument();
            XmlElement customTheme = xmlTheme.CreateElement("CustomTheme");
            customTheme.SetAttribute("basePaletteColor", txtBasePaletteColor.Text);
            customTheme.SetAttribute("vibrancy", txtVibrancy.Text);
            customTheme.SetAttribute("hueTorsion", txtHueTorsion.Text);
            customTheme.SetAttribute("font", txtFont.Text);
            XmlElement appHeaderColors = xmlTheme.CreateElement("AppHeaderColors");
            appHeaderColors.SetAttribute("background", txtBackground.Text);
            appHeaderColors.SetAttribute("foreground", txtForeground.Text);
            appHeaderColors.SetAttribute("backgroundHover", txtBackgroundHover.Text);
            appHeaderColors.SetAttribute("foregroundHover", txtForegroundHover.Text);
            appHeaderColors.SetAttribute("backgroundPressed", txtBackgroundPressed.Text);
            appHeaderColors.SetAttribute("foregroundPressed", txtForegroundPressed.Text);
            appHeaderColors.SetAttribute("backgroundSelected", txtBackgroundSelected.Text);
            appHeaderColors.SetAttribute("foregroundSelected", txtForegroundSelected.Text);
            customTheme.AppendChild(appHeaderColors);
            xmlTheme.AppendChild(customTheme);
            return xmlTheme;
        }
        public void UpdateWebresource(IOrganizationService service, string webresourceId, XmlDocument xmlTheme)
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Updating and publishing webresource...",
                Work = async (worker, args) =>
                {
                    try
                    {
                        Guid wrId = Guid.Parse(webresourceId);

                        // Recuperar el recurso
                        Entity webResource;
                        try
                        {
                            webResource = service.Retrieve("webresource", wrId, new ColumnSet("content"));
                        }
                        catch (Exception ex)
                        {
                            throw new InvalidOperationException("Error retrieving webresource: " + ex.Message, ex);
                        }

                        // Actualizar el contenido
                        string xmlContent = xmlTheme.OuterXml;
                        webResource["content"] = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(xmlContent));

                        // Preparar requests
                        UpdateRequest updateRequest = new UpdateRequest { Target = webResource };
                        PublishXmlRequest publishRequest = new PublishXmlRequest
                        {
                            ParameterXml = $"<importexportxml><webresources><webresource>{wrId}</webresource></webresources></importexportxml>"
                        };

                        ExecuteMultipleRequest executeMultipleRequest = new ExecuteMultipleRequest
                        {
                            Settings = new ExecuteMultipleSettings
                            {
                                ContinueOnError = false,
                                ReturnResponses = true
                            },
                            Requests = new OrganizationRequestCollection { updateRequest, publishRequest }
                        };

                        // Ejecutar de manera asíncrona
                        await Task.Run(() => service.Execute(executeMultipleRequest));

                        args.Result = "Theme updated and published successfully.";
                    }
                    catch (Exception ex)
                    {
                        args.Result = ex;
                        args.Cancel = true;
                    }
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null || args.Result is Exception)
                    {
                        var ex = args.Result as Exception;
                        MessageBox.Show($"Error updating/publishing the webresource: {ex?.Message}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (args.Result != null)
                            MessageBox.Show(args.Result.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            });
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            SetTextBoxValue(txtApp, 0);
            SetTextBoxValueWithColor(txtBasePaletteColor, 1);
            SetTextBoxValue(txtVibrancy, 2);
            SetTextBoxValue(txtHueTorsion, 3);
            SetTextBoxValue(txtFont, 4);
            SetTextBoxValue(txtName, 9);
            SetTextBoxValueWithColor(txtBackground, 5);
            SetTextBoxValueWithColor(txtForeground, 6);
            SetTextBoxValueWithColor(txtBackgroundHover, 7);
            SetTextBoxValueWithColor(txtForegroundHover, 8);
            SetTextBoxValueWithColor(txtBackgroundPressed, 10);
            SetTextBoxValueWithColor(txtForegroundPressed, 11);
            SetTextBoxValueWithColor(txtBackgroundSelected, 12);
            SetTextBoxValueWithColor(txtForegroundSelected, 13);
            bool hasSelection = dataGridView1.SelectedRows.Count > 0;
            btn_editTheme.Enabled = hasSelection;
            btn_saveNew.Enabled = !hasSelection;
        }
        private void SetTextBoxValue(TextBox textBox, int columnIndex)
        {
            var cellValue = dataGridView1.CurrentRow?.Cells[columnIndex]?.Value;
            if (cellValue != null)
                textBox.Text = cellValue.ToString();
        }
        private void SetTextBoxValueWithColor(TextBox textBox, int columnIndex)
        {
            var cellValue = dataGridView1.CurrentRow?.Cells[columnIndex]?.Value;
            if (cellValue != null && !string.IsNullOrWhiteSpace(cellValue.ToString()))
            {
                string colorHex = cellValue.ToString();
                textBox.Text = colorHex;

                try
                {
                    Color backColor = ColorTranslator.FromHtml(colorHex);
                    textBox.BackColor = backColor;
                    textBox.ForeColor = GetContrastColor(backColor);
                }
                catch
                {
                    textBox.BackColor = SystemColors.Window;
                    textBox.ForeColor = SystemColors.WindowText;
                }
            }
            else
            {
                textBox.Text = string.Empty;
                textBox.BackColor = SystemColors.Window;
                textBox.ForeColor = SystemColors.WindowText;
            }
        }


        private bool IsValidHexColor(string hex)
        {
            return hex.Length == 7 && hex.StartsWith("#") &&
                   Regex.IsMatch(hex.Substring(1), "^[0-9A-Fa-f]{6}$");
        }

        private bool IsHexColor()
        {
            if (IsValidHexColor(txtBasePaletteColor.Text) ||
                IsValidHexColor(txtBackground.Text) || 
                IsValidHexColor(txtForeground.Text) || 
                IsValidHexColor(txtBackgroundHover.Text) ||
                IsValidHexColor(txtForegroundHover.Text) ||
                IsValidHexColor(txtBackgroundPressed.Text) ||
                IsValidHexColor(txtForegroundPressed.Text) ||
                IsValidHexColor(txtBackgroundSelected.Text) ||
                IsValidHexColor(txtForegroundSelected.Text)
                )
            {

                return true;
            }
            else
            {
                MessageBox.Show("One or more selected colors are invalid. Please check and try again.");
                return false;
            }
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            string webResourceName = string.Empty;
            string appId = txtApp.Text;
            string appUniqueName = string.Empty;
            if (!IsHexColor())
            {
                return;
            }
            if (form2.ShowDialog() == DialogResult.OK)
            {
                webResourceName = form2.webResourceName;
                CheckEmptyColor();
                XmlDocument xmlTheme = createXlm();
                Guid webResourceId = ExecuteCreateThemeWebResource(xmlTheme, webResourceName);
                if (appId != string.Empty)
                {
                    appUniqueName = GetAppUniqueName(appId);
                }
                PublishWebresource(appUniqueName, webResourceName);
                btn_saveNew.Enabled = false;
                if(appId != string.Empty) 
                {
                    PublishAppWithWorkAsync(appId);
                }
                this.dataGridView1.Rows.Clear();
                LoadSettings();
            }

        }

        public void PublishAppWithWorkAsync(string appId)
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Publishing the app...",
                Work = async (worker, args) =>
                {
                    try
                    {
                        await PublishApp(appId);
                        args.Result = "App published successfully.";
                    }
                    catch (Exception ex)
                    {
                        args.Result = ex;
                        args.Cancel = true;
                    }
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        var ex = args.Result as Exception;
                        MessageBox.Show($"Error publishing the app: {ex?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(args.Result.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            });
        }
        public async Task PublishApp(string appId)
        {
            OrganizationRequest request = new OrganizationRequest("PublishXml");
            request["ParameterXml"] = $"<importexportxml><appmodules><appmodule>{appId}</appmodule></appmodules></importexportxml>";
            try
            {
                OrganizationResponse response = ExecuteOrganizationRequestAsync(request).Result;
                //OrganizationResponse response = Service.Execute(request);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public async Task<OrganizationResponse> ExecuteOrganizationRequestAsync(OrganizationRequest request)
        {
            var organizationServiceContext = new OrganizationServiceContext(Service);
            return await Task.Run(() => organizationServiceContext.Execute(request));
        }
        private string GetAppUniqueName(string appId)
        {
            Entity app = new Entity();
            try
            {
                app = Service.Retrieve("appmodule", Guid.Parse(appId), new ColumnSet("uniquename"));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return app.GetAttributeValue<string>("uniquename");
        }

        private void PublishWebresource(string appUniqueName, string webResourceName)
        {
            OrganizationRequest request = null;
            if (appUniqueName != string.Empty)
            {
                request = new OrganizationRequest("SaveSettingValue");
                request["AppUniqueName"] = appUniqueName;
                request["SettingName"] = "CustomThemeDefinition";
                request["Value"] = webResourceName;
            }
            else
            {
                request = new OrganizationRequest("SaveSettingValue");
                request["SettingName"] = "CustomThemeDefinition";
                request["Value"] = webResourceName;
            }
            try
            {

                OrganizationResponse response = Service.Execute(request);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private Guid ExecuteCreateThemeWebResource(XmlDocument xmlTheme, string webResourceName)
        {
            string xmlContent = xmlTheme.OuterXml;
            Entity webResource = new Entity();
            Guid id = Guid.NewGuid();
            webResource.Id = Guid.NewGuid();
            webResource.LogicalName = "webresource";
            webResource["name"] = webResourceName;
            webResource["content"] = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(xmlContent));
            webResource["displayname"] = webResourceName;
            webResource["description"] = "Modern theme";
            webResource["webresourcetype"] = new OptionSetValue(3);
            try
            {

                id = Service.Create(webResource);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return id;
        }
        private Color GetContrastColor(Color backColor)
        {
            double luminance = (0.299 * backColor.R + 0.587 * backColor.G + 0.114 * backColor.B) / 255;

          
            return luminance < 0.5 ? Color.White : Color.Black;
        }
        private void ApplyColor(TextBox textBox)
        {
            if (textBox.Text.Length == 7 && textBox.Text.StartsWith("#"))
            {
                try
                {
                    Color backColor = ColorTranslator.FromHtml(textBox.Text);
                    textBox.BackColor = backColor;
                    textBox.ForeColor = GetContrastColor(backColor);
                }
                catch
                {
                    textBox.BackColor = SystemColors.Window;
                    textBox.ForeColor = SystemColors.WindowText;
                }
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox tb)
            {
                ApplyColor(tb);
            }
        }
    }
}