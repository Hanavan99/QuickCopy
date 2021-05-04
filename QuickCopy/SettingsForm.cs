using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickCopy
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            keepOnTopCB.Checked = Properties.Settings.Default.AlwaysOnTop;
            localStorageCB.Checked = Properties.Settings.Default.LocalSaveEnabled;
            uxRemoteStorageCB.Checked = Properties.Settings.Default.RemoteSaveEnabled;
            localStoragePath.Text = Properties.Settings.Default.LocalFilePath;
            uxSqlServerURL.Text = Properties.Settings.Default.SQLServerURL;
            uxSqlServerDatabase.Text = Properties.Settings.Default.SQLServerDatabase;
            uxSqlServerUsername.Text = Properties.Settings.Default.SQLServerUsername;
            uxSqlServerPassword.Text = Properties.Settings.Default.SQLServerPassword;
            uxQuickCopyUsername.Text = Properties.Settings.Default.QuickCopyUsername;
            uxQuickCopyPassword.Text = Properties.Settings.Default.QuickCopyPassword;
            uxAesKey.Text = Properties.Settings.Default.QuickCopyAesKey;

            // update UI
            LocalStorageCB_CheckedChanged(sender, e);
            RemoteStorageCB_CheckedChanged(sender, e);
        }

        private void LocalStorageCB_CheckedChanged(object sender, EventArgs e)
        {
            localStoragePath.Enabled = localStorageCB.Checked;
        }

        private void RemoteStorageCB_CheckedChanged(object sender, EventArgs e)
        {
            uxSqlServerURL.Enabled = uxRemoteStorageCB.Checked;
            uxSqlServerDatabase.Enabled = uxRemoteStorageCB.Checked;
            uxSqlServerUsername.Enabled = uxRemoteStorageCB.Checked;
            uxSqlServerPassword.Enabled = uxRemoteStorageCB.Checked;
            uxQuickCopyUsername.Enabled = uxRemoteStorageCB.Checked;
            uxQuickCopyPassword.Enabled = uxRemoteStorageCB.Checked;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AlwaysOnTop = keepOnTopCB.Checked;
            Properties.Settings.Default.LocalSaveEnabled = localStorageCB.Checked;
            Properties.Settings.Default.RemoteSaveEnabled = uxRemoteStorageCB.Checked;
            Properties.Settings.Default.LocalFilePath = localStoragePath.Text;
            Properties.Settings.Default.SQLServerURL = uxSqlServerURL.Text;
            Properties.Settings.Default.SQLServerDatabase = uxSqlServerDatabase.Text;
            Properties.Settings.Default.SQLServerUsername = uxSqlServerUsername.Text;
            Properties.Settings.Default.SQLServerPassword = uxSqlServerPassword.Text;
            Properties.Settings.Default.QuickCopyUsername = uxQuickCopyUsername.Text;
            Properties.Settings.Default.QuickCopyPassword = uxQuickCopyPassword.Text;
            Properties.Settings.Default.QuickCopyAesKey = uxAesKey.Text;
            Properties.Settings.Default.Save();
            Close();
        }

        private void uxGenerateKey_Click(object sender, EventArgs e)
        {
            byte[] key = new byte[16];
            RandomNumberGenerator.Create().GetBytes(key);
            uxAesKey.Text = Convert.ToBase64String(key);
        }
    }
}
