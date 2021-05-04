
namespace QuickCopy
{
    partial class EditItemForm
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
            this.uxName = new System.Windows.Forms.TextBox();
            this.uxContent = new System.Windows.Forms.TextBox();
            this.uxChangeColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxName
            // 
            this.uxName.Location = new System.Drawing.Point(107, 12);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(240, 20);
            this.uxName.TabIndex = 0;
            // 
            // uxContent
            // 
            this.uxContent.Location = new System.Drawing.Point(107, 38);
            this.uxContent.Multiline = true;
            this.uxContent.Name = "uxContent";
            this.uxContent.Size = new System.Drawing.Size(240, 141);
            this.uxContent.TabIndex = 1;
            // 
            // uxChangeColor
            // 
            this.uxChangeColor.Location = new System.Drawing.Point(107, 185);
            this.uxChangeColor.Name = "uxChangeColor";
            this.uxChangeColor.Size = new System.Drawing.Size(240, 23);
            this.uxChangeColor.TabIndex = 2;
            this.uxChangeColor.Text = "Change Color...";
            this.uxChangeColor.UseVisualStyleBackColor = true;
            this.uxChangeColor.Click += new System.EventHandler(this.uxChangeColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Content:";
            // 
            // uxCancel
            // 
            this.uxCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uxCancel.Location = new System.Drawing.Point(261, 214);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(86, 23);
            this.uxCancel.TabIndex = 5;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            // 
            // uxOK
            // 
            this.uxOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxOK.Location = new System.Drawing.Point(169, 214);
            this.uxOK.Name = "uxOK";
            this.uxOK.Size = new System.Drawing.Size(86, 23);
            this.uxOK.TabIndex = 6;
            this.uxOK.Text = "OK";
            this.uxOK.UseVisualStyleBackColor = true;
            // 
            // EditItemForm
            // 
            this.AcceptButton = this.uxOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.uxCancel;
            this.ClientSize = new System.Drawing.Size(359, 249);
            this.Controls.Add(this.uxOK);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxChangeColor);
            this.Controls.Add(this.uxContent);
            this.Controls.Add(this.uxName);
            this.Name = "EditItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Item";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditItemForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxName;
        private System.Windows.Forms.TextBox uxContent;
        private System.Windows.Forms.Button uxChangeColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Button uxOK;
    }
}