using System;
using System.Configuration;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using Reserver.Utils;
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
            labelVersion.Font = new Font(privateFontCollection.Families[0], 8, FontStyle.Regular);
            closeProgram.Font = new Font(privateFontCollection.Families[0], 11, FontStyle.Bold);
            minimizeProgram.Font = new Font(privateFontCollection.Families[0], 13, FontStyle.Bold);

            reserverNotifyIcon.Visible = false;
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

        #region Single Istance

        protected override void WndProc(ref Message message)
        {
            if (message.Msg == SingleInstance.WM_SHOWFIRSTINSTANCE)
            {
                ShowWindow();
            }
            base.WndProc(ref message);
        }

        public void ShowWindow()
        {
            if (reserverNotifyIcon.Visible)
            {
                reserverNotifyIcon.Visible = false;
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                WinApi.ShowToFront(this.Handle);
            }
        }

        #endregion Single Istance

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

        public string CurrentVersion
        {
            set { labelVersion.Text = value; }
            get { return labelVersion.Text; }
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

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
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
