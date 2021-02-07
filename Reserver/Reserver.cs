using System;
using System.Configuration;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using Shell32;

namespace Reserver
{
    public partial class Reserver : Form
    {
        public string connectionStringExternalDB = ConfigurationManager.AppSettings["ConnectionString"];
        public bool startup = Convert.ToBoolean(ConfigurationManager.AppSettings["Startup"]);
        public bool logged = false;
        public int idutente = -1;
        public object emptySender = new object();
        
        PrivateFontCollection privateFontCollection;

        private Form activeForm;
        Forms.ServerStatusForm serverStatusForm;
        Forms.ReleaseHistoryForm releaseHistoryForm;
        Forms.AcceptanceTestsForm acceptanceTestsForm;
        Forms.LoginForm loginForm;

        Reserver reserver;

        public Reserver()
        {
            InitializeComponent();
            reserver = this;
            loginForm = new Forms.LoginForm(reserver);
            OpenChildForm(loginForm, emptySender);
            privateFontCollection = new PrivateFontCollection();
            privateFontCollection.AddFontFile(Directory.GetCurrentDirectory() + "\\font\\Quicksand-VariableFont_wght.ttf");
            btnSideMenuServerStatus.Font = new Font(privateFontCollection.Families[0], 15, FontStyle.Bold);
            btnSideMenuReleaseHistory.Font = new Font(privateFontCollection.Families[0], 15, FontStyle.Bold);
            btnSideMenuAcceptanceTests.Font = new Font(privateFontCollection.Families[0], 15, FontStyle.Bold);
            labelCurrentUserV2.Font = new Font(privateFontCollection.Families[0], 11, FontStyle.Regular);
            reserverNotifyIcon.Visible = true;
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + Application.ProductName + ".lnk";
            if (startup)
            {
                if (string.IsNullOrEmpty(GetShortcutTargetFile(fileName)))
                {
                    CreateStartupFolderShortcut();
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(GetShortcutTargetFile(fileName)))
                {
                    DeleteStartupFolderShortcuts(Application.ProductName + ".exe");
                }

            }
        }

        #region Getter and Setter

        public Reserver externalReserver
        {
            set { reserver = value; }
            get { return reserver; }
        }

        public string CurrentUserName
        {
            set { labelCurrentUserV2.Text = value; }
            get { return labelCurrentUserV2.Text; }
        }

        public int CurrentUserID
        {
            set { idutente = value; }
            get { return idutente; }
        }

        public bool IsLogged
        {
            set { logged = value; }
            get { return logged; }
        }

        public string ConnectionString
        {
            get { return connectionStringExternalDB; }
        }

        #endregion Getter and Setter

        #region Form Movement

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BntMinimize_Click(object sender, EventArgs e)
        {
            Hide();
            reserverNotifyIcon.Visible = true;
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            reserverNotifyIcon.Visible = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            reserverNotifyIcon.Visible = false;
            reserverNotifyIcon.Dispose();
            Application.Exit();
        }

        #endregion Form Movement

        #region Generic Methods

        private void OpenChildForm(Form childForm, object btnSender)
        {
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelPage.Controls.Add(childForm);
            this.panelPage.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void LoadPageAfterLogin(object sender, Reserver reserver)
        {
            serverStatusForm = new Forms.ServerStatusForm(reserver);
            releaseHistoryForm = new Forms.ReleaseHistoryForm(reserver);
            acceptanceTestsForm = new Forms.AcceptanceTestsForm(reserver);
            OpenChildForm(serverStatusForm, sender);
        }

        public void LoadPage(object sender, string buttonName)
        {
            switch (buttonName)
            {
                case "btnSideMenuServerStatus":
                    OpenChildForm(serverStatusForm, sender);
                    break;

                case "btnSideMenuReleaseHistory":
                    releaseHistoryForm.ReleaseHistoryGrid_Load();
                    OpenChildForm(releaseHistoryForm, sender);
                    break;

                case "btnSideMenuAcceptanceTests":
                    acceptanceTestsForm.AcceptanceTests_Load();
                    OpenChildForm(acceptanceTestsForm, sender);
                    break;

                default:
                    OpenChildForm(loginForm, sender);
                    break;
            }
        }

        #endregion Generic Methods

        #region Side Menu Behavior

        private void SideMenuButton_Click(object sender, EventArgs e)
        {
            if (logged)
            {
                string buttonName = ((Control)sender).Name;
                LoadPage(sender, buttonName);
                SideMenuButton_SetActivePage(buttonName);
            }
            else
            {
                MessageBox.Show("Per visualizzare la pagina è necessario effettuare il login", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        public void SideMenuButton_SetActivePage(string buttonName)
        {
            MetroFramework.Controls.MetroPanel metroPanelServerStatus = this.Controls.Find("panelSideMenuServerStatus", true).FirstOrDefault() as MetroFramework.Controls.MetroPanel;
            metroPanelServerStatus.BackColor = Color.FromArgb(142, 198, 189);
            MetroFramework.Controls.MetroPanel metroPanelHistory = this.Controls.Find("panelSideMenuReleaseHistory", true).FirstOrDefault() as MetroFramework.Controls.MetroPanel;
            metroPanelHistory.BackColor = Color.FromArgb(142, 198, 189);
            MetroFramework.Controls.MetroPanel metroPanelAcceptanceTests = this.Controls.Find("panelSideMenuAcceptanceTests", true).FirstOrDefault() as MetroFramework.Controls.MetroPanel;
            metroPanelAcceptanceTests.BackColor = Color.FromArgb(142, 198, 189);

            string panelName = "panel" + buttonName.Substring(3);
            MetroFramework.Controls.MetroPanel metroPanel = this.Controls.Find(panelName, true).FirstOrDefault() as MetroFramework.Controls.MetroPanel;
            metroPanel.BackColor = Color.FromArgb( 92, 162, 150);
        }

        #endregion Side Menu Behavior

        #region Startup
        public void CreateStartupFolderShortcut()
        {
            WshShellClass wshShell = new WshShellClass();
            IWshShortcut shortcut;
            string startUpFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            shortcut = (IWshShortcut)wshShell.CreateShortcut(startUpFolderPath + "\\" + Application.ProductName + ".lnk");
            shortcut.TargetPath = Application.ExecutablePath;
            shortcut.WorkingDirectory = Application.StartupPath;
            shortcut.Description = "Launch Reserver Application";
            shortcut.Save();
        }

        public string GetShortcutTargetFile(string shortcutFilename)
        {
            string pathOnly = Path.GetDirectoryName(shortcutFilename);
            string filenameOnly = Path.GetFileName(shortcutFilename);
            Shell shell = new ShellClass();
            Shell32.Folder folder = shell.NameSpace(pathOnly);
            FolderItem folderItem = folder.ParseName(filenameOnly);
            if (folderItem != null)
            {
                ShellLinkObject link = (ShellLinkObject)folderItem.GetLink;
                return link.Path;
            }
            return String.Empty; 
        }

        public void DeleteStartupFolderShortcuts(string targetExeName)
        {
            string startUpFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            DirectoryInfo di = new DirectoryInfo(startUpFolderPath);
            FileInfo[] files = di.GetFiles("*.lnk");
            foreach (FileInfo fi in files)
            {
                string shortcutTargetFile = GetShortcutTargetFile(fi.FullName);
                if (shortcutTargetFile.EndsWith(targetExeName, StringComparison.InvariantCultureIgnoreCase))
                {
                    System.IO.File.Delete(fi.FullName);
                }
            }
        }
        #endregion Startup
    }
}

// Vecchi colori scuro Color.FromArgb(39, 39, 58);  // test 32, 90, 255  // test2 6, 46, 96
// Vecchi colori chiaro Color.FromArgb(51, 51, 76); // test 17, 128, 255 // test2 7, 67, 125

//public void SetToolTip(string username)
//{
//    ToolTip toolTip = new ToolTip();
//    toolTip.SetToolTip(this.avatarBox, username);
//}

// Temporaneamente disabilitato in quanto creava gravi problemi prestazionali

/*

private void OpenChildForm(Form childForm, object btnSender)
{
    if (activeForm != null)
    {
        activeForm.Close();
    }
    activeForm = childForm;
    childForm.TopLevel = false;
    childForm.FormBorderStyle = FormBorderStyle.None;
    childForm.Dock = DockStyle.Fill;
    this.panelPage.Controls.Add(childForm);
    this.panelPage.Tag = childForm;
    childForm.BringToFront();
    childForm.Show();
}

public void LoadPage(object sender, string buttonName)
{
    switch (buttonName)
    {
        case "btnSideMenuServerStatus":
            OpenChildFormServerStatus(server, sender);
            break;

        case "btnSideMenuReleaseHistory":
            OpenChildForm(new Forms.ReleaseHistoryForm(this), sender);
            break;

        case "btnSideMenuAcceptanceTests":
            OpenChildForm(new Forms.AcceptanceTestsForm(this), sender);
            break;

        default:
            OpenChildForm(new Forms.LoginForm(this), sender);
            break;
    }
}
*/
