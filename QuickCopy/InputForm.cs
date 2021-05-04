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
    public partial class InputForm : Form
    {
        public InputForm(string message, string defaultText)
        {
            InitializeComponent();
            label.Text = message;
            if (defaultText != null)
            {
                input.Text = defaultText;
                input.SelectAll();
            }
        }

        public string GetText()
        {
            return input.Text;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public static DialogResult ShowDialog(IWin32Window owner, string message, out string text)
        {
            return ShowDialog(owner, message, null, out text);
        }

        public static DialogResult ShowDialog(IWin32Window owner, string message, string defaultText, out string text)
        {
            InputForm form = new InputForm(message, defaultText);
            DialogResult result = form.ShowDialog(owner);
            if (result == DialogResult.OK)
            {
                text = form.GetText();
            } else
            {
                text = null;
            }
            return result;
        }
    }
}
