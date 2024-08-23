using McTools.Xrm.Connection;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using XrmToolBox.Extensibility;

namespace ModernThemeCreator
{
    public partial class ModernThemeCreatorControl : PluginControlBase
    {
        private Settings ModernThemeSettings;

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
        private void LoadSettings() {
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
            string appSettingName = "OverrideAppHeaderColor";
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
            };
            foreach (var orgSetting in orgSettings.Entities)
            {
                Entity entity = new Entity("combinedsetting");
                entity.Id = new Guid();
                entity["appid"] = Guid.Empty;
                entity["value"] = orgSetting.GetAttributeValue<string>("value");
                colorSettings.Entities.Add(entity);

            };
            return colorSettings.Entities.ToList();

        }
        private void LoadData()
        {
            foreach (var colorSetting in data)
            {
                string webresourceName = colorSetting.GetAttributeValue<string>("value");
                Models.AppHeaderColors appHeaderColors = GetXml(webresourceName);
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[dataGridView1.Columns["webresourceId"].Index].Value = appHeaderColors.id;
                row.Cells[dataGridView1.Columns["appId"].Index].Value = colorSetting.GetAttributeValue<Guid>("appid").ToString();
                row.Cells[dataGridView1.Columns["background"].Index].Value = appHeaderColors.background;
                row.Cells[dataGridView1.Columns["foreground"].Index].Value = appHeaderColors.foreground;
                row.Cells[dataGridView1.Columns["backgroundHover"].Index].Value = appHeaderColors.backgroundHover;
                row.Cells[dataGridView1.Columns["foregroundHover"].Index].Value = appHeaderColors.foregroundHover;
                row.Cells[dataGridView1.Columns["backgroundPressed"].Index].Value = appHeaderColors.backgroundPressed;
                row.Cells[dataGridView1.Columns["foregroundPressed"].Index].Value = appHeaderColors.foregroundPressed;
                row.Cells[dataGridView1.Columns["backgroundSelected"].Index].Value = appHeaderColors.backgroundSelected;
                row.Cells[dataGridView1.Columns["foregroundSelected"].Index].Value = appHeaderColors.foregroundSelected;
                dataGridView1.Invoke(new Action(() => dataGridView1.Rows.Add(row)));
            };
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
        private Models.AppHeaderColors GetXml(string webResource)
        {
            EntityCollection webResources = null;
            string content = null;

            Models.AppHeaderColors appHeaderColors = new Models.AppHeaderColors();
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


            content = webResources.Entities[0].GetAttributeValue<string>("content");
            byte[] data = Convert.FromBase64String(content);
            content = System.Text.Encoding.UTF8.GetString(data);
            XmlSerializer serializer = new XmlSerializer(typeof(Models.AppHeaderColors));
            appHeaderColors = serializer.Deserialize(new System.IO.StringReader(content)) as Models.AppHeaderColors;
            appHeaderColors.id = webResources.Entities[0].Id.ToString();

            return appHeaderColors;

        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        //private void tsbSample_Click(object sender, EventArgs e)
        //{
        //    // The ExecuteMethod method handles connecting to an
        //    // organization if XrmToolBox is not yet connected
        //    ExecuteMethod(GetAccounts);
        //}

        //private void GetAccounts()
        //{
        //    WorkAsync(new WorkAsyncInfo
        //    {
        //        Message = "Getting accounts",
        //        Work = (worker, args) =>
        //        {
        //            args.Result = Service.RetrieveMultiple(new QueryExpression("account")
        //            {
        //                TopCount = 50
        //            });
        //        },
        //        PostWorkCallBack = (args) =>
        //        {
        //            if (args.Error != null)
        //            {
        //                MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //            var result = args.Result as EntityCollection;
        //            if (result != null)
        //            {
        //                MessageBox.Show($"Found {result.Entities.Count} accounts");
        //            }
        //        }
        //    });
        //}

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
            txtBackground.BackColor = Color.White;
            txtForeground.BackColor = Color.White;
            txtBackgroundHover.BackColor = Color.White;
            txtForegroundHover.BackColor = Color.White;
            txtBackgroundPressed.BackColor = Color.White;
            txtForegroundPressed.BackColor = Color.White;
            txtBackgroundSelected.BackColor = Color.White;
            txtForegroundSelected.BackColor = Color.White;
            btnUpdate.Hide();
            btnSaveNew.Show();
            lblWait.Hide();
            lblProgress.Hide();
            progressBar.Hide();
        }

        private string ColorToHex(Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }
        private void CheckEmptyColor()
        {
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
            XmlElement appHeaderColors = xmlTheme.CreateElement("AppHeaderColors");
            appHeaderColors.SetAttribute("background", txtBackground.Text);
            appHeaderColors.SetAttribute("foreground", txtForeground.Text);
            appHeaderColors.SetAttribute("backgroundHover", txtBackgroundHover.Text);
            appHeaderColors.SetAttribute("foregroundHover", txtForegroundHover.Text);
            appHeaderColors.SetAttribute("backgroundPressed", txtBackgroundPressed.Text);
            appHeaderColors.SetAttribute("foregroundPressed", txtForegroundPressed.Text);
            appHeaderColors.SetAttribute("backgroundSelected", txtBackgroundSelected.Text);
            appHeaderColors.SetAttribute("foregroundSelected", txtForegroundSelected.Text);
            xmlTheme.AppendChild(appHeaderColors);
            return xmlTheme;
        }
        private void UpdateWebresource(IOrganizationService service, string webresourceId, XmlDocument xmlTheme)
        {
            Entity webResource = new Entity();
            Guid webResourceId = Guid.Parse(webresourceId);
            try
            {
                webResource = service.Retrieve("webresource", webResourceId, new ColumnSet("content"));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            string xmlContent = xmlTheme.OuterXml;
            webResource["content"] = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(xmlContent));
            PublishXmlRequest publishRequest = new PublishXmlRequest
            {
                ParameterXml = $"<importexportxml><webresources><webresource>{webResourceId}</webresource></webresources></importexportxml>"
            };
            UpdateRequest updaterequest = new UpdateRequest { Target = webResource };
            ExecuteMultipleRequest executemultiplerequest = new ExecuteMultipleRequest();
            executemultiplerequest.Settings = new ExecuteMultipleSettings();
            executemultiplerequest.Settings.ContinueOnError = false;
            executemultiplerequest.Settings.ReturnResponses = true;
            executemultiplerequest.Requests = new OrganizationRequestCollection();
            executemultiplerequest.Requests.Add(updaterequest);
            executemultiplerequest.Requests.Add(publishRequest);
            try
            {
                service.Execute(executemultiplerequest);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtApp.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBackground.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBackground.BackColor = ColorTranslator.FromHtml(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            txtName.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtForeground.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtForeground.BackColor = ColorTranslator.FromHtml(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            txtBackgroundHover.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtBackgroundHover.BackColor = ColorTranslator.FromHtml(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            txtForegroundHover.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtForegroundHover.BackColor = ColorTranslator.FromHtml(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            txtBackgroundPressed.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtBackgroundPressed.BackColor = ColorTranslator.FromHtml(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            txtForegroundPressed.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtForegroundPressed.BackColor = ColorTranslator.FromHtml(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            txtBackgroundSelected.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtBackgroundSelected.BackColor = ColorTranslator.FromHtml(dataGridView1.CurrentRow.Cells[8].Value.ToString());
            txtForegroundSelected.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtForegroundSelected.BackColor = ColorTranslator.FromHtml(dataGridView1.CurrentRow.Cells[9].Value.ToString());
            //comprueba si la fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnUpdate.Show();
                btnSaveNew.Hide();
                lblWait.Hide();
                lblProgress.Hide();
                progressBar.Hide();
            }
            else
            {
                btnUpdate.Hide();
                btnSaveNew.Show();
            }
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {

                Form2 form2 = new Form2();
                string webResourceName = string.Empty;
                string appId = txtApp.Text;
                string appUniqueName = string.Empty;
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
                    progressBar.Show();
                    lblProgress.Show();
                    lblWait.Show();
                    btnSaveNew.Hide();
                    backgroundWorker.RunWorkerAsync(appId);
                    this.dataGridView1.Rows.Clear();
            }
            
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string appId = e.Argument as string;
            for (int i = 0; i <= 50; i++)
            {
                System.Threading.Thread.Sleep(50);
                backgroundWorker.ReportProgress(i);
            }
            if (appId != string.Empty)
            {
                PublishApp(appId).Wait();
            }
            for (int i = 51; i <= 100; i++)
            {
                System.Threading.Thread.Sleep(50);
                backgroundWorker.ReportProgress(i);
            }

            this.Invoke(new Action(() => LoadSettings()));
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Invoke(new Action(() => progressBar.Value = e.ProgressPercentage));
            lblProgress.Invoke(new Action(() => lblProgress.Text = $"{e.ProgressPercentage}%"));
            if (e.ProgressPercentage == 100)
            {
                lblWait.Text = "Theme published..!";
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Error: " + e.Error.Message);
            }
            else if (e.Cancelled)
            {
                MessageBox.Show("Operation Cancelled.");
            }
            else
            {
                MessageBox.Show("Operation Completed.");
                dataGridView1.ClearSelection();
            }
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
                request["SettingName"] = "OverrideAppHeaderColor";
                request["Value"] = webResourceName;
            }
            else
            {
                request = new OrganizationRequest("SaveSettingValue");
                request["SettingName"] = "OverrideAppHeaderColor";
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
        private void txtBackground_TextChanged(object sender, EventArgs e)
        {
            txtBackground.BackColor = ColorTranslator.FromHtml(txtBackground.Text);
        }

        private void txtForeground_TextChanged(object sender, EventArgs e)
        {
            txtForeground.BackColor = ColorTranslator.FromHtml(txtForeground.Text);
        }

        private void txtBackgroundHover_TextChanged(object sender, EventArgs e)
        {
            txtBackgroundHover.BackColor = ColorTranslator.FromHtml(txtBackgroundHover.Text);
        }

        private void txtForegroundHover_TextChanged(object sender, EventArgs e)
        {
            txtForegroundHover.BackColor = ColorTranslator.FromHtml(txtForegroundHover.Text);
        }

        private void txtBackgroundPressed_TextChanged(object sender, EventArgs e)
        {
            txtBackgroundPressed.BackColor = ColorTranslator.FromHtml(txtBackgroundPressed.Text);
        }

        private void txtForegroundPressed_TextChanged(object sender, EventArgs e)
        {
            txtForegroundPressed.BackColor = ColorTranslator.FromHtml(txtForegroundPressed.Text);
        }

        private void txtBackgroundSelected_TextChanged(object sender, EventArgs e)
        {
            txtBackgroundSelected.BackColor = ColorTranslator.FromHtml(txtBackgroundSelected.Text);
        }

        private void txtForegroundSelected_TextChanged(object sender, EventArgs e)
        {
            txtForegroundSelected.BackColor = ColorTranslator.FromHtml(txtForegroundSelected.Text);
        }
    }
}