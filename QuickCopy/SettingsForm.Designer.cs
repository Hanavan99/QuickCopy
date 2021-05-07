namespace QuickCopy
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.preferenceTabs = new System.Windows.Forms.TabControl();
            this.generalTab = new System.Windows.Forms.TabPage();
            this.keepOnTopCB = new System.Windows.Forms.CheckBox();
            this.localStorageTab = new System.Windows.Forms.TabPage();
            this.localStoragePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.localStorageCB = new System.Windows.Forms.CheckBox();
            this.remoteStorageTab = new System.Windows.Forms.TabPage();
            this.uxQuickCopyPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uxQuickCopyUsername = new System.Windows.Forms.TextBox();
            this.uxSqlServerDatabase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxSqlServerPassword = new System.Windows.Forms.TextBox();
            this.uxSqlServerUsername = new System.Windows.Forms.TextBox();
            this.uxSqlServerURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxRemoteStorageCB = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.uxAesKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.uxGenerateKey = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.preferenceTabs.SuspendLayout();
            this.generalTab.SuspendLayout();
            this.localStorageTab.SuspendLayout();
            this.remoteStorageTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // preferenceTabs
            // 
            this.preferenceTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.preferenceTabs.Controls.Add(this.generalTab);
            this.preferenceTabs.Controls.Add(this.localStorageTab);
            this.preferenceTabs.Controls.Add(this.remoteStorageTab);
            this.preferenceTabs.Location = new System.Drawing.Point(12, 12);
            this.preferenceTabs.Name = "preferenceTabs";
            this.preferenceTabs.SelectedIndex = 0;
            this.preferenceTabs.Size = new System.Drawing.Size(560, 308);
            this.preferenceTabs.TabIndex = 0;
            // 
            // generalTab
            // 
            this.generalTab.Controls.Add(this.label9);
            this.generalTab.Controls.Add(this.uxGenerateKey);
            this.generalTab.Controls.Add(this.label8);
            this.generalTab.Controls.Add(this.uxAesKey);
            this.generalTab.Controls.Add(this.keepOnTopCB);
            this.generalTab.Location = new System.Drawing.Point(4, 22);
            this.generalTab.Name = "generalTab";
            this.generalTab.Padding = new System.Windows.Forms.Padding(3);
            this.generalTab.Size = new System.Drawing.Size(552, 282);
            this.generalTab.TabIndex = 2;
            this.generalTab.Text = "General";
            this.generalTab.UseVisualStyleBackColor = true;
            // 
            // keepOnTopCB
            // 
            this.keepOnTopCB.AutoSize = true;
            this.keepOnTopCB.Location = new System.Drawing.Point(6, 6);
            this.keepOnTopCB.Name = "keepOnTopCB";
            this.keepOnTopCB.Size = new System.Drawing.Size(174, 17);
            this.keepOnTopCB.TabIndex = 0;
            this.keepOnTopCB.Text = "Always keep QuickCopy on top";
            this.keepOnTopCB.UseVisualStyleBackColor = true;
            // 
            // localStorageTab
            // 
            this.localStorageTab.Controls.Add(this.localStoragePath);
            this.localStorageTab.Controls.Add(this.label4);
            this.localStorageTab.Controls.Add(this.localStorageCB);
            this.localStorageTab.Location = new System.Drawing.Point(4, 22);
            this.localStorageTab.Name = "localStorageTab";
            this.localStorageTab.Padding = new System.Windows.Forms.Padding(3);
            this.localStorageTab.Size = new System.Drawing.Size(552, 282);
            this.localStorageTab.TabIndex = 1;
            this.localStorageTab.Text = "Local Storage";
            this.localStorageTab.UseVisualStyleBackColor = true;
            // 
            // localStoragePath
            // 
            this.localStoragePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.localStoragePath.Location = new System.Drawing.Point(128, 29);
            this.localStoragePath.Name = "localStoragePath";
            this.localStoragePath.Size = new System.Drawing.Size(418, 20);
            this.localStoragePath.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Local file path:";
            // 
            // localStorageCB
            // 
            this.localStorageCB.AutoSize = true;
            this.localStorageCB.Location = new System.Drawing.Point(6, 6);
            this.localStorageCB.Name = "localStorageCB";
            this.localStorageCB.Size = new System.Drawing.Size(214, 17);
            this.localStorageCB.TabIndex = 1;
            this.localStorageCB.Text = "Store my QuickCopy data locally in a file";
            this.localStorageCB.UseVisualStyleBackColor = true;
            this.localStorageCB.CheckedChanged += new System.EventHandler(this.LocalStorageCB_CheckedChanged);
            // 
            // remoteStorageTab
            // 
            this.remoteStorageTab.Controls.Add(this.uxQuickCopyPassword);
            this.remoteStorageTab.Controls.Add(this.label7);
            this.remoteStorageTab.Controls.Add(this.label6);
            this.remoteStorageTab.Controls.Add(this.uxQuickCopyUsername);
            this.remoteStorageTab.Controls.Add(this.uxSqlServerDatabase);
            this.remoteStorageTab.Controls.Add(this.label5);
            this.remoteStorageTab.Controls.Add(this.label3);
            this.remoteStorageTab.Controls.Add(this.label2);
            this.remoteStorageTab.Controls.Add(this.uxSqlServerPassword);
            this.remoteStorageTab.Controls.Add(this.uxSqlServerUsername);
            this.remoteStorageTab.Controls.Add(this.uxSqlServerURL);
            this.remoteStorageTab.Controls.Add(this.label1);
            this.remoteStorageTab.Controls.Add(this.uxRemoteStorageCB);
            this.remoteStorageTab.Location = new System.Drawing.Point(4, 22);
            this.remoteStorageTab.Name = "remoteStorageTab";
            this.remoteStorageTab.Padding = new System.Windows.Forms.Padding(3);
            this.remoteStorageTab.Size = new System.Drawing.Size(552, 282);
            this.remoteStorageTab.TabIndex = 0;
            this.remoteStorageTab.Text = "Remote Storage";
            this.remoteStorageTab.UseVisualStyleBackColor = true;
            // 
            // uxQuickCopyPassword
            // 
            this.uxQuickCopyPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxQuickCopyPassword.Location = new System.Drawing.Point(128, 159);
            this.uxQuickCopyPassword.Name = "uxQuickCopyPassword";
            this.uxQuickCopyPassword.Size = new System.Drawing.Size(418, 20);
            this.uxQuickCopyPassword.TabIndex = 6;
            this.uxQuickCopyPassword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "QuickCopy Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "QuickCopy Username:";
            // 
            // uxQuickCopyUsername
            // 
            this.uxQuickCopyUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxQuickCopyUsername.Location = new System.Drawing.Point(128, 133);
            this.uxQuickCopyUsername.Name = "uxQuickCopyUsername";
            this.uxQuickCopyUsername.Size = new System.Drawing.Size(418, 20);
            this.uxQuickCopyUsername.TabIndex = 5;
            // 
            // uxSqlServerDatabase
            // 
            this.uxSqlServerDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxSqlServerDatabase.Location = new System.Drawing.Point(128, 55);
            this.uxSqlServerDatabase.Name = "uxSqlServerDatabase";
            this.uxSqlServerDatabase.Size = new System.Drawing.Size(418, 20);
            this.uxSqlServerDatabase.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "SQL Server Database:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "SQL Server Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "SQL Server Username:";
            // 
            // uxSqlServerPassword
            // 
            this.uxSqlServerPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxSqlServerPassword.Location = new System.Drawing.Point(128, 107);
            this.uxSqlServerPassword.Name = "uxSqlServerPassword";
            this.uxSqlServerPassword.Size = new System.Drawing.Size(418, 20);
            this.uxSqlServerPassword.TabIndex = 4;
            this.uxSqlServerPassword.UseSystemPasswordChar = true;
            // 
            // uxSqlServerUsername
            // 
            this.uxSqlServerUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxSqlServerUsername.Location = new System.Drawing.Point(128, 81);
            this.uxSqlServerUsername.Name = "uxSqlServerUsername";
            this.uxSqlServerUsername.Size = new System.Drawing.Size(418, 20);
            this.uxSqlServerUsername.TabIndex = 3;
            // 
            // uxSqlServerURL
            // 
            this.uxSqlServerURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxSqlServerURL.Location = new System.Drawing.Point(128, 29);
            this.uxSqlServerURL.Name = "uxSqlServerURL";
            this.uxSqlServerURL.Size = new System.Drawing.Size(418, 20);
            this.uxSqlServerURL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SQL Server URL:";
            // 
            // uxRemoteStorageCB
            // 
            this.uxRemoteStorageCB.AutoSize = true;
            this.uxRemoteStorageCB.Location = new System.Drawing.Point(6, 6);
            this.uxRemoteStorageCB.Name = "uxRemoteStorageCB";
            this.uxRemoteStorageCB.Size = new System.Drawing.Size(274, 17);
            this.uxRemoteStorageCB.TabIndex = 0;
            this.uxRemoteStorageCB.Text = "Store my QuickCopy data remotely on an SQL server";
            this.uxRemoteStorageCB.UseVisualStyleBackColor = true;
            this.uxRemoteStorageCB.CheckedChanged += new System.EventHandler(this.RemoteStorageCB_CheckedChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(497, 326);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(416, 326);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // uxAesKey
            // 
            this.uxAesKey.Location = new System.Drawing.Point(125, 29);
            this.uxAesKey.Name = "uxAesKey";
            this.uxAesKey.Size = new System.Drawing.Size(330, 20);
            this.uxAesKey.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "AES Decryption Key:";
            // 
            // uxGenerateKey
            // 
            this.uxGenerateKey.Location = new System.Drawing.Point(461, 27);
            this.uxGenerateKey.Name = "uxGenerateKey";
            this.uxGenerateKey.Size = new System.Drawing.Size(85, 23);
            this.uxGenerateKey.TabIndex = 3;
            this.uxGenerateKey.Text = "Generate";
            this.uxGenerateKey.UseVisualStyleBackColor = true;
            this.uxGenerateKey.Click += new System.EventHandler(this.uxGenerateKey_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(528, 52);
            this.label9.TabIndex = 4;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.preferenceTabs);
            this.Name = "SettingsForm";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.preferenceTabs.ResumeLayout(false);
            this.generalTab.ResumeLayout(false);
            this.generalTab.PerformLayout();
            this.localStorageTab.ResumeLayout(false);
            this.localStorageTab.PerformLayout();
            this.remoteStorageTab.ResumeLayout(false);
            this.remoteStorageTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl preferenceTabs;
        private System.Windows.Forms.TabPage remoteStorageTab;
        private System.Windows.Forms.TabPage localStorageTab;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox uxSqlServerPassword;
        private System.Windows.Forms.TextBox uxSqlServerUsername;
        private System.Windows.Forms.TextBox uxSqlServerURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox uxRemoteStorageCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox localStoragePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox localStorageCB;
        private System.Windows.Forms.TabPage generalTab;
        private System.Windows.Forms.CheckBox keepOnTopCB;
        private System.Windows.Forms.TextBox uxSqlServerDatabase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uxQuickCopyUsername;
        private System.Windows.Forms.TextBox uxQuickCopyPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button uxGenerateKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox uxAesKey;
        private System.Windows.Forms.Label label9;
    }
}