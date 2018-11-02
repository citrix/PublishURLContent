using PublishContent.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublishContent
{
    public partial class MainForm : Form
    {
        //powershell objects
        RunspaceConfiguration rsc = null;
        Runspace rs = null;
        PowerShell ps = null;
        List<Tuple<int, string>> appImages = new List<Tuple<int, string>>();
        List<DeliveryGroup> deliveryGroups = new List<DeliveryGroup>();


        public MainForm()
        {
            InitializeComponent();

            //setup the environment for using the 
            //citrix powershell cmdlets
            setupPowershellEnvironment();
            loadCitrixCmdlets();

            loadDeliveryGroups();


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbDeliveryGroup.DataSource = deliveryGroups;
            cbDeliveryGroup.DisplayMember = "Name";
            cbDeliveryGroup.ValueMember = "Uid";

            comboBox1.DataSource = deliveryGroups;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Uid";
        }

        #region Custom methods for loading citrix powershell cmdlets
        private void setupPowershellEnvironment()
        {
            //add the citrix powershell snapin
            rsc = RunspaceConfiguration.Create();

            rs = RunspaceFactory.CreateRunspace(rsc);
            rs.Open();

            ps = PowerShell.Create();
            ps.Runspace = rs;
        }

        private void loadCitrixCmdlets()
        {
            PSSnapInException psEx = null;

            //load all the citrix powershell snapins
            rsc.AddPSSnapIn("Citrix.ADIdentity.Admin.V2", out psEx);
            rsc.AddPSSnapIn("Citrix.Analytics.Admin.V1", out psEx);
            rsc.AddPSSnapIn("Citrix.AppLibrary.Admin.V1", out psEx);
            rsc.AddPSSnapIn("Citrix.AppV.Admin.V1", out psEx);
            rsc.AddPSSnapIn("Citrix.Broker.Admin.V2", out psEx);
            rsc.AddPSSnapIn("Citrix.Configuration.Admin.V2", out psEx);
            rsc.AddPSSnapIn("Citrix.ConfigurationLogging.Admin.V1", out psEx);
            rsc.AddPSSnapIn("Citrix.DelegatedAdmin.Admin.V1", out psEx);
            rsc.AddPSSnapIn("Citrix.EnvTest.Admin.V1", out psEx);
            rsc.AddPSSnapIn("Citrix.Host.Admin.V2", out psEx);
            rsc.AddPSSnapIn("Citrix.Licensing.Admin.V1", out psEx);
            rsc.AddPSSnapIn("Citrix.MachineCreation.Admin.V2", out psEx);
            rsc.AddPSSnapIn("Citrix.Monitor.Admin.V1", out psEx);
            rsc.AddPSSnapIn("Citrix.Orchestration.Admin.V1", out psEx);
            rsc.AddPSSnapIn("Citrix.Storefront.Admin.V1", out psEx);
            rsc.AddPSSnapIn("Citrix.Trust.Admin.V1", out psEx);
            rsc.AddPSSnapIn("Citrix.UserProfileManager.Admin.V1", out psEx);
        }
        #endregion

        #region custom helper methods
        private void enableNewContentControls()
        {

            loadBrokerIcons();
            cbDeliveryGroup.Enabled = true;
            tbContentURL.Enabled = true;
            tbDescription.Enabled = true;
            tbDisplayName.Enabled = true;
            lvBrokerIcons.Enabled = true;

        }
        private void disableNewContentControls()
        {
            cbDeliveryGroup.Enabled = false;
            tbContentURL.Enabled = false;
            tbDescription.Enabled = false;
            tbDisplayName.Enabled = false;
            lvBrokerIcons.Enabled = false;
        }
        private void loadBrokerIcons()
        {
            //clear all images out of the imagelist control
            ilImages.Images.Clear();
            lvBrokerIcons.Items.Clear();

            //clear all commands in the powershell object
            ps.Commands.Clear();
            ps.AddCommand("Get-BrokerIcon");
            //call the cmdlet
            var icons = ps.Invoke();

            //loop through each icon returned
            foreach (var icon in icons)
            {
                //get the b64 encoded icon
                var iconB64Data = icon.Properties["EncodedIconData"].Value;
                //get the UID value
                var uidOfIcon = icon.Properties["uid"].Value;

                //conver the base 64 icon into a actual icon
                var appIcon = convertB64ToIcon(iconB64Data.ToString());
                //add the icon into the imagelist
                ilImages.Images.Add(appIcon);

                //add icon to list view with the UID as the text
                lvBrokerIcons.Items.Add(uidOfIcon.ToString(), ilImages.Images.Count - 1);
            }
        }

        private Icon convertPngToIcon(string Filename)
        {
            //create new guid for icon filename
            var icoFilename = $@"{Application.StartupPath}\{Guid.NewGuid().ToString()}.ico";
            Classes.Helpers.ImageConverter.ConvertToIco(Filename, icoFilename, 64);

            var appIcon = Icon.ExtractAssociatedIcon(icoFilename);

            //delete the temp created icon
            File.Delete(icoFilename);

            return appIcon;
        }
        private int addIconToBroker(string IconBase64)
        {
            //add icon to the broker
            ps.Commands.Clear();
            ps.AddCommand("New-BrokerIcon");
            ps.AddParameter("EncodedIconData", IconBase64);

            var addedIcon = ps.Invoke();

            //get the objects uuid returned
            return Convert.ToInt32(addedIcon[0].Properties["uid"].Value);
        }
        private Icon convertB64ToIcon(string icon)
        {
            byte[] iconBytes = Convert.FromBase64String(icon);

            MemoryStream iconMs = new MemoryStream(iconBytes);

            return new Icon(iconMs);
        }
        private string convertIcontoB64(Icon AppIcon)
        {
            byte[] bytes;
            using (var ms = new MemoryStream())
            {
                AppIcon.Save(ms);
                bytes = ms.ToArray();
            }
            var base64String = Convert.ToBase64String(bytes);

            return base64String;
        }
        private void loadDeliveryGroups()
        {
            //cb.Items.Clear();

            //clear all the commands out of the powershell object
            ps.Commands.Clear();
            //add the cmdlet to the powershell obect
            ps.Commands.AddCommand("Get-BrokerDesktopGroup");
            //call the cmdlet
            var desktopGroups = ps.Invoke();

            //loop through each of the delivery groups returned
            foreach (var desktopGroup in desktopGroups)
            {
                //create a delivery group object
                DeliveryGroup dGroup = new DeliveryGroup();
                dGroup.Name = desktopGroup.Properties["Name"].Value.ToString();
                dGroup.PublishedName = desktopGroup.Properties["PublishedName"].Value.ToString();
                dGroup.Description = desktopGroup.Properties["Description"].Value.ToString();
                dGroup.UUID = Guid.Parse(desktopGroup.Properties["UUID"].Value.ToString());
                dGroup.Uid = Int32.Parse(desktopGroup.Properties["uid"].Value.ToString());

                deliveryGroups.Add(dGroup);
                //add the group to the combobox
                //cb.Items.Add(dGroup);
            }
        }

        #endregion

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            enableNewContentControls();
        }

        private void tsbUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog iconDlg = new OpenFileDialog();
            //iconDlg.Filter = ""
            if (iconDlg.ShowDialog() == DialogResult.OK)
            {
                var icon = convertPngToIcon(iconDlg.FileName);

                var b64Icon = convertIcontoB64(icon);

                var uidOfIcon = addIconToBroker(b64Icon);

                ilImages.Images.Add(uidOfIcon.ToString(), icon);

                //add icon to list view
                lvBrokerIcons.Items.Add("", ilImages.Images.Count - 1);
            }

        }

        private void tsbPublish_Click(object sender, EventArgs e)
        {
            ps.Commands.Clear();

            ps.Commands.AddCommand("New-BrokerApplication");
            ps.AddParameter("ApplicationType", "PublishedContent");
            ps.AddParameter("Name", tbDisplayName.Text);
            ps.AddParameter("CommandLineExecutable", tbContentURL.Text);
            ps.AddParameter("Description", tbDescription.Text);
            ps.AddParameter("DesktopGroup", ((DeliveryGroup)(cbDeliveryGroup.SelectedItem)).Name);
            try
            {
                var newApp = ps.Invoke();
            }
            catch ( System.Exception publishError )
            {
                MessageBox.Show(publishError.Message, "Publish Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (lvBrokerIcons.SelectedItems != null)
            {
                ps.Commands.Clear();
                ps.AddCommand("Set-BrokerApplication");
                ps.AddParameter("Name", tbDisplayName.Text);
                if (lvBrokerIcons.SelectedItems.Count > 0)
                {
                    ps.AddParameter("IconUid", lvBrokerIcons.SelectedItems[0].Text);
                }

                ps.Invoke();
            }

            disableNewContentControls();

        }

        private void tsbListContent_Click(object sender, EventArgs e)
        {
            loadDeliveryGroups();
            lbExistingContent.Items.Clear();
            //list of existing published content
            ps.Commands.Clear();

            ps.AddCommand("Get-BrokerIcon");

            var icons = ps.Invoke();
            foreach (var icon in icons)
            {
                appImages.Add(new Tuple<int, string>(
                    Convert.ToInt32(icon.Properties["Uid"].Value),
                    icon.Properties["EncodedIconData"].Value.ToString()))
                ;
            }

            ps.Commands.Clear();

            ps.AddCommand("Get-BrokerApplication");
            ps.AddParameter("ApplicationType", "PublishedContent");

            var existingApps = ps.Invoke();

            foreach (var app in existingApps)
            {
                PublishedContent listApp = new PublishedContent()
                {
                    name = app.Properties["Name"].Value.ToString(),
                    browsername = app.Properties["BrowserName"].Value.ToString(),
                    commandlineexec = app.Properties["CommandLineExecutable"].Value.ToString(),
                    commandlineargs = (app.Properties["CommandLineArguments"].Value == null) ? "" : app.Properties["CommandLineArguments"].Value.ToString(),
                    description = (app.Properties["Description"].Value == null) ? "" : app.Properties["Description"].Value.ToString(),
                    associateddesktopgroupuids = (app.Properties["AssociatedDesktopGroupUids"].Value == null) ? "" : app.Properties["AssociatedDesktopGroupUids"].Value.ToString(),
                    iconuid = (app.Properties["IconUid"].Value == null) ? 0 : Convert.ToInt32(app.Properties["IconUid"].Value)
                };

                var iconB64 = appImages.Where(a => a.Item1 == listApp.iconuid)
                    .FirstOrDefault().Item2;

                var icon = convertB64ToIcon(iconB64);
                listApp.icon = icon.ToBitmap();

                lbExistingContent.Items.Add(listApp);
                Console.WriteLine("");
            }
        }

        private void lbExistingContent_Click(object sender, EventArgs e)
        {
            
        }

        private void lbExistingContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            var publishedContent = (PublishedContent)lbExistingContent.SelectedItem;
            tbExistingContentURL.Text = publishedContent.commandlineexec;
            tbExistingDesc.Text = publishedContent.description;
            tbExistingDisplayName.Text = publishedContent.name;
            comboBox1.SelectedValue = publishedContent.associateddesktopgroupuids;
            pictureBox1.Image = publishedContent.icon;
        }

        private void btnAddNewImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog iconDlg = new OpenFileDialog();
            //iconDlg.Filter = ""
            if (iconDlg.ShowDialog() == DialogResult.OK)
            {
                var icon = convertPngToIcon(iconDlg.FileName);

                var b64Icon = convertIcontoB64(icon);

                var uidOfIcon = addIconToBroker(b64Icon);

                ilImages.Images.Add(uidOfIcon.ToString(), icon);

                //add icon to list view
                lvBrokerIcons.Items.Add("", ilImages.Images.Count - 1);
            }
        }
    }
}
