
namespace QuickCopy
{
    partial class EditCategoryForm
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
            this.uxOK = new System.Windows.Forms.Button();
            this.uxCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uxChangeColor = new System.Windows.Forms.Button();
            this.uxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxOK
            // 
            this.uxOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxOK.Location = new System.Drawing.Point(169, 67);
            this.uxOK.Name = "uxOK";
            this.uxOK.Size = new System.Drawing.Size(86, 23);
            this.uxOK.TabIndex = 11;
            this.uxOK.Text = "OK";
            this.uxOK.UseVisualStyleBackColor = true;
            // 
            // uxCancel
            // 
            this.uxCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uxCancel.Location = new System.Drawing.Point(261, 67);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(86, 23);
            this.uxCancel.TabIndex = 10;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            // 
            // uxChangeColor
            // 
            this.uxChangeColor.Location = new System.Drawing.Point(107, 38);
            this.uxChangeColor.Name = "uxChangeColor";
            this.uxChangeColor.Size = new System.Drawing.Size(240, 23);
            this.uxChangeColor.TabIndex = 8;
            this.uxChangeColor.Text = "Change Color...";
            this.uxChangeColor.UseVisualStyleBackColor = true;
            this.uxChangeColor.Click += new System.EventHandler(this.uxChangeColor_Click);
            // 
            // uxName
            // 
            this.uxName.Location = new System.Drawing.Point(107, 12);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(240, 20);
            this.uxName.TabIndex = 7;
            // 
            // EditCategoryForm
            // 
            this.AcceptButton = this.uxOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.uxCancel;
            this.ClientSize = new System.Drawing.Size(357, 100);
            this.Controls.Add(this.uxOK);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxChangeColor);
            this.Controls.Add(this.uxName);
            this.Name = "EditCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Category";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditItemForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxOK;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxChangeColor;
        private System.Windows.Forms.TextBox uxName;
    }
}