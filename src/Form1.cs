using PublishContent.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublishContent
{
    public partial class Form1 : Form
    {
        //powershell objects
        RunspaceConfiguration rsc = null;
        Runspace rs = null;
        PowerShell ps = null;

        public Form1()
        {
            

            InitializeComponent();

            //setup the environment for using the 
            //citrix powershell cmdlets
            setupPowershellEnvironment();
            loadCitrixCmdlets();
            loadDeliveryGroups();
            //get all existing icons store in the broker
            //database
            loadBrokerIcons();
        }

        private void loadBrokerIcons()
        {
            //clear all images out of the imagelist control
            imageList1.Images.Clear();

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
                imageList1.Images.Add(appIcon);

                //add icon to list view with the UID as the text
                listView1.Items.Add(uidOfIcon.ToString(), imageList1.Images.Count - 1);
            }
        }
        private void loadDeliveryGroups()
        {
            //get the delivery groups

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

                //add the group to the combobox
                cbDeliveryGroup.Items.Add(dGroup);
            }
        }
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

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog iconDlg = new OpenFileDialog();
            //iconDlg.Filter = ""
            if (iconDlg.ShowDialog() == DialogResult.OK)
            {
                var icon = convertPngToIcon(iconDlg.FileName);

                var b64Icon = convertIcontoB64(icon);

                var uidOfIcon = addIconToBroker(b64Icon);

                imageList1.Images.Add(uidOfIcon.ToString(),icon);

                //add icon to list view
                listView1.Items.Add("", imageList1.Images.Count - 1);
            }
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            ps.Commands.Clear();

            ps.Commands.AddCommand("New-BrokerApplication");
            ps.AddParameter("ApplicationType", "PublishedContent");
            ps.AddParameter("Name", tbDisplayName.Text);
            ps.AddParameter("CommandLineExecutable",tbContentURL.Text);
            ps.AddParameter("Description", tbDescription.Text);
            ps.AddParameter("DesktopGroup", ((DeliveryGroup)(cbDeliveryGroup.SelectedItem)).Name);
            var newApp = ps.Invoke();

            if (listView1.SelectedItems != null)
            {
                ps.Commands.Clear();
                ps.AddCommand("Set-BrokerApplication");
                ps.AddParameter("Name", tbDisplayName.Text);
                ps.AddParameter("IconUid", listView1.SelectedItems[0].Text);

                ps.Invoke();
            }
        }
    }
}
