using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace QuickCopy
{

    public partial class MainForm : Form
    {
        private FileQuickCopySource fileSource;
        private SQLQuickCopySource sqlSource;
        private QuickCopyData qcData;
        private readonly JsonSerializer json;

        private readonly ContextMenu copyTreeMenu;
        private readonly ContextMenu categoryMenu;
        private readonly ContextMenu itemMenu;

        private bool exited = false;

        /**
         * ==================== BUGS TO BE FIXED ==================== 
         * Close menu item does not close the program
         * Unchecking "close on copy" and rechecking it does not work properly
         * Right clicking an item that is not selected does not select it
         * Settings sometimes do not get saved?
         * 
         * ==================== FEATURES TO BE ADDED ==================== 
         * File -> Save feature
         * 
         */

        public MainForm()
        {
            InitializeComponent();

            // create JSON serializer
            json = JsonSerializer.CreateDefault();

            // create context menu for copy tree
            copyTreeMenu = new ContextMenu();
            MenuItem editMenuItem = new MenuItem("New Category...");
            editMenuItem.Click += AddCategory;
            copyTreeMenu.MenuItems.Add(editMenuItem);

            // create context menu for categories
            categoryMenu = new ContextMenu();
            MenuItem addItemMenuItem = new MenuItem("Add Item...");
            addItemMenuItem.Click += AddItem;
            categoryMenu.MenuItems.Add(addItemMenuItem);

            categoryMenu.MenuItems.Add("-"); // adds a separator

            MenuItem editCategoryMenuItem = new MenuItem("Edit...");
            editCategoryMenuItem.Click += EditCategory;
            categoryMenu.MenuItems.Add(editCategoryMenuItem);

            MenuItem deleteCategoryMenuItem = new MenuItem("Delete");
            deleteCategoryMenuItem.Click += DeleteCategory;
            categoryMenu.MenuItems.Add(deleteCategoryMenuItem);

            // create context menu for items
            itemMenu = new ContextMenu();
            MenuItem editItemMenuItem = new MenuItem("Edit...");
            editItemMenuItem.Click += EditItem;
            itemMenu.MenuItems.Add(editItemMenuItem);

            MenuItem deleteItemMenuItem = new MenuItem("Delete");
            deleteItemMenuItem.Click += DeleteItem;
            itemMenu.MenuItems.Add(deleteItemMenuItem);
        }

        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            if (copyTree.SelectedNode.Level == 1)
            {
                string categoryGuid = copyTree.SelectedNode.Parent.Name;
                string itemGuid = copyTree.SelectedNode.Name;
                Item item = qcData.Categories[Guid.Parse(categoryGuid)].Items[Guid.Parse(itemGuid)];
                EditItemForm eif = new EditItemForm(item.Name, item.Content, item.Color);
                if (eif.ShowDialog() == DialogResult.OK)
                {
                    // update item
                    item.Name = eif.ItemName;
                    item.Content = eif.ItemContent;
                    item.Color = eif.ItemColor;

                    // update tree
                    TreeNode node = copyTree.Nodes[categoryGuid].Nodes[itemGuid];
                    node.Text = item.Name;
                    node.BackColor = item.Color;
                }
            }
            else if (copyTree.SelectedNode.Level == 0)
            {
                string categoryGuid = copyTree.SelectedNode.Name;
                Category category = qcData.Categories[Guid.Parse(categoryGuid)];
                EditCategoryForm ecf = new EditCategoryForm(category.Name, category.Color);
                if (ecf.ShowDialog() == DialogResult.OK)
                {
                    // update category
                    category.Name = ecf.CategoryName;
                    category.Color = ecf.CategoryColor;

                    // update tree
                    TreeNode node = copyTree.Nodes[categoryGuid];
                    node.Text = category.Name;
                    node.BackColor = category.Color;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // set system icons in tree view
            //copyTree.ImageList = new ImageList();
            //Icon folderIcon = IconHelper.GetStockIcon(4, IconHelper.SHGSI_SMALLICON);
            //copyTree.ImageList.Images.Add(folderIcon);
            //Icon itemIcon = IconHelper.GetStockIcon(58, IconHelper.SHGSI_SMALLICON);
            //copyTree.ImageList.Images.Add(itemIcon);

            QuickCopyData sqlData = null, fileData = null;
            string url = Properties.Settings.Default.SQLServerURL;
            string database = Properties.Settings.Default.SQLServerDatabase;
            string username = Properties.Settings.Default.SQLServerUsername;
            string password = Properties.Settings.Default.SQLServerPassword;
            string userUsername = Properties.Settings.Default.QuickCopyUsername;
            string userPassword = Properties.Settings.Default.QuickCopyPassword;
            string key = null;
            try
            {
                key = Encoding.ASCII.GetString(Convert.FromBase64String(Properties.Settings.Default.QuickCopyAesKey));
            }
            catch (FormatException ex)
            {
                MessageBox.Show("AES decryption key is not valid: " + ex.Message);
            }

            // try to load data from sql server
            if (Properties.Settings.Default.RemoteSaveEnabled)
            {
                try
                {
                    sqlSource = new SQLQuickCopySource(url, database, username, password, userUsername, userPassword);
                    sqlData = json.Deserialize<QuickCopyData>(new JsonTextReader(new StringReader(sqlSource.GetData(key))));
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Failed to connect to database: " + ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show("No QuickCopy data was found in the database.");
                }
                catch (JsonSerializationException ex)
                {
                    MessageBox.Show("Failed to deserialize JSON data: " + ex.Message);
                }
            }

            // try to load data from file
            if (Properties.Settings.Default.LocalSaveEnabled)
            {
                try
                {
                    fileSource = new FileQuickCopySource(Properties.Settings.Default.LocalFilePath);
                    fileData = json.Deserialize<QuickCopyData>(new JsonTextReader(new StringReader(fileSource.GetData(key))));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to read file: " + ex.Message);
                }
            }

            // see which one is newer and keep that one
            if (sqlData != null)
            {
                if (fileData != null)
                {
                    qcData = sqlData.LastModifiedTime >= fileData.LastModifiedTime ? sqlData : fileData;
                }
                else
                {
                    qcData = sqlData;
                }
            }
            else
            {
                if (fileData != null)
                {
                    qcData = fileData;
                }
                else
                {
                    MessageBox.Show("Neither source of data could be accessed. If you wish to save, you must explicitly save using \"File\" -> \"Save\".");
                    qcData = new QuickCopyData();
                }
            }

            // put data into tree
            foreach (KeyValuePair<Guid, Category> kv in qcData.Categories)
            {
                TreeNode node = copyTree.Nodes.Add(kv.Key.ToString(), kv.Value.Name);
                node.BackColor = kv.Value.Color;
                node.ContextMenu = categoryMenu;
                //node.ImageIndex = 0;

                foreach (KeyValuePair<Guid, Item> item in kv.Value.Items)
                {
                    TreeNode subNode = node.Nodes.Add(item.Key.ToString(), item.Value.Name);
                    subNode.BackColor = item.Value.Color;
                    subNode.ContextMenu = itemMenu;
                    //subNode.ImageIndex = 1;
                }

                if (kv.Value.Expanded)
                {
                    BeginInvoke(new NodeDelegate(Expand), node);
                }
                else
                {
                    BeginInvoke(new NodeDelegate(Collapse), node);
                }
            }

            copyTree.ContextMenu = copyTreeMenu;
        }

        private void DeleteItem(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to delete \"" + copyTree.SelectedNode.Text + "\"?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                copyTree.SelectedNode.Remove();
                qcData.Categories[Guid.Parse(copyTree.SelectedNode.Parent.Name)].Items.Remove(Guid.Parse(copyTree.SelectedNode.Name));
            }
        }

        private void AddItem(object sender, EventArgs e)
        {
            string categoryGuid = copyTree.SelectedNode.Name;
            EditItemForm eif = new EditItemForm();
            if (eif.ShowDialog() == DialogResult.OK)
            {
                Guid itemGuid = Guid.NewGuid();
                Item item = new Item(eif.ItemName, eif.ItemContent, eif.ItemColor);
                TreeNode node = copyTree.Nodes[categoryGuid].Nodes.Add(itemGuid.ToString(), item.Name);
                node.BackColor = item.Color;
                node.ContextMenu = itemMenu;
                qcData.Categories[Guid.Parse(categoryGuid)].Items[itemGuid] = item;
            }
        }

        private void EditItem(object sender, EventArgs e)
        {
            string categoryGuid = copyTree.SelectedNode.Parent.Name;
            string itemGuid = copyTree.SelectedNode.Name;
            Item item = qcData.Categories[Guid.Parse(categoryGuid)].Items[Guid.Parse(itemGuid)];
            EditItemForm eif = new EditItemForm(item.Name, item.Content, item.Color);
            if (eif.ShowDialog() == DialogResult.OK)
            {
                // update item
                item.Name = eif.ItemName;
                item.Content = eif.ItemContent;
                item.Color = eif.ItemColor;

                // update tree
                TreeNode node = copyTree.Nodes[categoryGuid].Nodes[itemGuid];
                node.Text = item.Name;
                node.BackColor = item.Color;
            }
        }

        private void AddCategory(object sender, EventArgs e)
        {
            EditCategoryForm ecf = new EditCategoryForm();
            if (ecf.ShowDialog() == DialogResult.OK)
            {
                // create category
                Guid guid = Guid.NewGuid();
                Category category = new Category(ecf.CategoryName, true, ecf.CategoryColor);
                qcData.Categories[guid] = category;

                // update tree
                TreeNode node = copyTree.Nodes.Add(guid.ToString(), category.Name);
                node.BackColor = category.Color;
                node.ContextMenu = categoryMenu;
            }
        }

        private void EditCategory(object sender, EventArgs e)
        {
            string categoryGuid = copyTree.SelectedNode.Name;
            Category category = qcData.Categories[Guid.Parse(categoryGuid)];
            EditCategoryForm ecf = new EditCategoryForm(category.Name, category.Color);
            if (ecf.ShowDialog() == DialogResult.OK)
            {
                // update category
                category.Name = ecf.CategoryName;
                category.Color = ecf.CategoryColor;

                // update tree
                TreeNode node = copyTree.Nodes[categoryGuid];
                node.Text = category.Name;
                node.BackColor = category.Color;
            }
        }

        private void DeleteCategory(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to delete \"" + copyTree.SelectedNode.Text + "\"?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                copyTree.SelectedNode.Remove();
                qcData.Categories.Remove(Guid.Parse(copyTree.SelectedNode.Name));
            }
        }

        private delegate void NodeDelegate(TreeNode node);

        private static void Expand(TreeNode node)
        {
            node.Expand();
        }

        private static void Collapse(TreeNode node)
        {
            node.Collapse();
        }

        private void PreferencesMI_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit();
        }

        private void copyTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (copyTree.SelectedNode.Level == 1)
            {
                Category category = qcData.Categories[Guid.Parse(copyTree.SelectedNode.Parent.Name)];
                string text = category.Items[Guid.Parse(copyTree.SelectedNode.Name)].Content;
                if (text != null && text != "")
                {
                    Clipboard.SetText(text);
                }
                else
                {
                    Clipboard.SetText(category.Items[Guid.Parse(copyTree.SelectedNode.Name)].Name);
                }

                if (closeOnCopyCB.Checked)
                {
                    Exit();
                    System.Windows.Forms.Application.Exit(); // calling Form.Close() breaks things
                }
            }
        }

        private void Exit()
        {
            if (!exited)
            {
                if (fileSource != null)
                {
                    fileSource.Path = Properties.Settings.Default.LocalFilePath;
                }

                // update modified time
                qcData.LastModifiedTime = DateTime.Now;

                // updated category expanded data
                foreach (KeyValuePair<Guid, Category> kv in qcData.Categories)
                {
                    kv.Value.Expanded = copyTree.Nodes[kv.Key.ToString()].IsExpanded;
                }

                string key = Encoding.ASCII.GetString(Convert.FromBase64String(Properties.Settings.Default.QuickCopyAesKey));
                StringWriter sw = new StringWriter();
                json.Serialize(sw, qcData);
                string data = sw.ToString();

                if (sqlSource != null && Properties.Settings.Default.RemoteSaveEnabled)
                {
                    try
                    {
                        sqlSource.PutData(key, data);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Failed to write data to database: " + ex.Message);
                    }
                }

                if (fileSource != null && Properties.Settings.Default.LocalSaveEnabled)
                {
                    try
                    {
                        fileSource.PutData(key, data);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to write data to file: " + ex.Message);
                    }
                }

                exited = true;
            }
        }

        private void uxImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    qcData = json.Deserialize<QuickCopyData>(new JsonTextReader(new StringReader(File.ReadAllText(ofd.FileName))));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to import QuickCopy data: " + ex.Message);
                }
            }
        }

        private void uxExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringWriter sw = new StringWriter();
                    json.Formatting = Formatting.Indented;
                    json.Serialize(new JsonTextWriter(sw), qcData);
                    json.Formatting = Formatting.None;
                    File.WriteAllText(sfd.FileName, sw.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to export QuickCopy data: " + ex.Message);
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Exit(false);
        }
    }
}
