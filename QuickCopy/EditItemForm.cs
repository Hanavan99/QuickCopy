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
    public partial class EditItemForm : Form
    {

        public string ItemName { get; set; }

        public string ItemContent { get; set; }

        public Color ItemColor { get; set; }

        public EditItemForm()
        {
            InitializeComponent();
        }

        public EditItemForm(string name, string content, Color color)
        {
            InitializeComponent();
            uxName.Text = ItemName = name;
            uxContent.Text = ItemContent = content;
            uxName.BackColor = ItemColor = color;
        }

        private void uxChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = ItemColor;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                uxName.BackColor = ItemColor = cd.Color;
            }
        }

        private void EditItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (uxName.Text == null || uxName.Text == "")
                {
                    MessageBox.Show("The item name is invalid.");
                    e.Cancel = true;
                }
                else
                {
                    ItemName = uxName.Text;
                    ItemContent = uxContent.Text;
                    ItemColor = uxName.BackColor;
                }
            }
        }
    }
}
