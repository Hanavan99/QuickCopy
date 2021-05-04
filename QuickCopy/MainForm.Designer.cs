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
            this.uxImport = new System.Windows.Forms.ToolStripMenuItem();
            this.uxExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesMI = new System.Windows.Forms.ToolStripMenuItem();
            this.closeOnCopyCB = new System.Windows.Forms.CheckBox();
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
            this.uxImport,
            this.uxExport,
            this.toolStripSeparator3,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // uxImport
            // 
            this.uxImport.Name = "uxImport";
            this.uxImport.Size = new System.Drawing.Size(180, 22);
            this.uxImport.Text = "Import...";
            this.uxImport.Click += new System.EventHandler(this.uxImport_Click);
            // 
            // uxExport
            // 
            this.uxExport.Name = "uxExport";
            this.uxExport.Size = new System.Drawing.Size(180, 22);
            this.uxExport.Text = "Export...";
            this.uxExport.Click += new System.EventHandler(this.uxExport_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
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
            this.preferencesMI.Size = new System.Drawing.Size(180, 22);
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
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesMI;
        private System.Windows.Forms.CheckBox closeOnCopyCB;
        private System.Windows.Forms.ToolStripMenuItem uxImport;
        private System.Windows.Forms.ToolStripMenuItem uxExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

