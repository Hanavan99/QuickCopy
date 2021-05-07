namespace QuickCopy
{
    partial class MainForm
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
            this.copyTree = new System.Windows.Forms.TreeView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxReload = new System.Windows.Forms.ToolStripMenuItem();
            this.uxForceLoadRemote = new System.Windows.Forms.ToolStripMenuItem();
            this.uxForceLoadLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.uxImport = new System.Windows.Forms.ToolStripMenuItem();
            this.uxExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.uxClose = new System.Windows.Forms.ToolStripMenuItem();
            this.uxCloseNoSave = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesMI = new System.Windows.Forms.ToolStripMenuItem();
            this.closeOnCopyCB = new System.Windows.Forms.CheckBox();
            this.uxSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // copyTree
            // 
            this.copyTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyTree.Location = new System.Drawing.Point(12, 53);
            this.copyTree.Name = "copyTree";
            this.copyTree.Size = new System.Drawing.Size(256, 461);
            this.copyTree.TabIndex = 0;
            this.copyTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.copyTree_AfterSelect);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(280, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxSave,
            this.uxReload,
            this.uxForceLoadRemote,
            this.uxForceLoadLocal,
            this.toolStripSeparator1,
            this.uxImport,
            this.uxExport,
            this.toolStripSeparator3,
            this.uxClose,
            this.uxCloseNoSave});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // uxReload
            // 
            this.uxReload.Name = "uxReload";
            this.uxReload.Size = new System.Drawing.Size(207, 22);
            this.uxReload.Text = "Reload";
            this.uxReload.Click += new System.EventHandler(this.uxReload_Click);
            // 
            // uxForceLoadRemote
            // 
            this.uxForceLoadRemote.Name = "uxForceLoadRemote";
            this.uxForceLoadRemote.Size = new System.Drawing.Size(207, 22);
            this.uxForceLoadRemote.Text = "Force Load From Remote";
            this.uxForceLoadRemote.Click += new System.EventHandler(this.uxForceLoadRemote_Click);
            // 
            // uxForceLoadLocal
            // 
            this.uxForceLoadLocal.Name = "uxForceLoadLocal";
            this.uxForceLoadLocal.Size = new System.Drawing.Size(207, 22);
            this.uxForceLoadLocal.Text = "Force Load From Local";
            this.uxForceLoadLocal.Click += new System.EventHandler(this.uxForceLoadLocal_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // uxImport
            // 
            this.uxImport.Name = "uxImport";
            this.uxImport.Size = new System.Drawing.Size(207, 22);
            this.uxImport.Text = "Import...";
            this.uxImport.Click += new System.EventHandler(this.uxImport_Click);
            // 
            // uxExport
            // 
            this.uxExport.Name = "uxExport";
            this.uxExport.Size = new System.Drawing.Size(207, 22);
            this.uxExport.Text = "Export...";
            this.uxExport.Click += new System.EventHandler(this.uxExport_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(204, 6);
            // 
            // uxClose
            // 
            this.uxClose.Name = "uxClose";
            this.uxClose.Size = new System.Drawing.Size(207, 22);
            this.uxClose.Text = "Close";
            this.uxClose.Click += new System.EventHandler(this.uxClose_Click);
            // 
            // uxCloseNoSave
            // 
            this.uxCloseNoSave.Name = "uxCloseNoSave";
            this.uxCloseNoSave.Size = new System.Drawing.Size(207, 22);
            this.uxCloseNoSave.Text = "Close Without Saving";
            this.uxCloseNoSave.Click += new System.EventHandler(this.uxCloseNoSave_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesMI});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // preferencesMI
            // 
            this.preferencesMI.Name = "preferencesMI";
            this.preferencesMI.Size = new System.Drawing.Size(144, 22);
            this.preferencesMI.Text = "Preferences...";
            this.preferencesMI.Click += new System.EventHandler(this.PreferencesMI_Click);
            // 
            // closeOnCopyCB
            // 
            this.closeOnCopyCB.AutoSize = true;
            this.closeOnCopyCB.Checked = true;
            this.closeOnCopyCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.closeOnCopyCB.Location = new System.Drawing.Point(12, 30);
            this.closeOnCopyCB.Name = "closeOnCopyCB";
            this.closeOnCopyCB.Size = new System.Drawing.Size(93, 17);
            this.closeOnCopyCB.TabIndex = 2;
            this.closeOnCopyCB.Text = "Close on copy";
            this.closeOnCopyCB.UseVisualStyleBackColor = true;
            // 
            // uxSave
            // 
            this.uxSave.Name = "uxSave";
            this.uxSave.Size = new System.Drawing.Size(207, 22);
            this.uxSave.Text = "Save";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 526);
            this.Controls.Add(this.closeOnCopyCB);
            this.Controls.Add(this.copyTree);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "QuickCopy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView copyTree;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxClose;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesMI;
        private System.Windows.Forms.CheckBox closeOnCopyCB;
        private System.Windows.Forms.ToolStripMenuItem uxImport;
        private System.Windows.Forms.ToolStripMenuItem uxExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem uxCloseNoSave;
        private System.Windows.Forms.ToolStripMenuItem uxReload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem uxForceLoadRemote;
        private System.Windows.Forms.ToolStripMenuItem uxForceLoadLocal;
        private System.Windows.Forms.ToolStripMenuItem uxSave;
    }
}
