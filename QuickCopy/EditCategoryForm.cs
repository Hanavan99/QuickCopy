using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickCopy
{
    public partial class EditCategoryForm : Form
    {
        public string CategoryName { get; set; }

        public Color CategoryColor { get; set; }

        public EditCategoryForm()
        {
            InitializeComponent();
        }

        public EditCategoryForm(string name, Color color)
        {
            InitializeComponent();
            uxName.Text = CategoryName = name;
            uxName.BackColor = CategoryColor = color;
        }

        private void uxChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = CategoryColor;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                uxName.BackColor = CategoryColor = cd.Color;
            }
        }

        private void EditItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (uxName.Text == null || uxName.Text == "")
                {
                    MessageBox.Show("The category name is invalid.");
                    e.Cancel = true;
                }
                else
                {
                    CategoryName = uxName.Text;
                    CategoryColor = uxName.BackColor;
                }
            }
        }
    }
}
