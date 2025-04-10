using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chronicle.Plugins.Core;
using MySqlConnector;

namespace Chronicle.About
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            listView1.MultiSelect = false;
            listView1.FullRowSelect = true;
            ListViewItem rootItem = new();
            rootItem.Text = "Chronicle";
            rootItem.SubItems.Add(Globals.BaseAppVersion.ToString());
            listView1.Items.Add(rootItem);
            foreach (var item in Globals.PluginManager.plugins.Keys)
            {
                IPlugable currentPlugin = Globals.PluginManager.plugins[item];
                ListViewItem itm = new();
                itm.Text = item;
                itm.SubItems.Add(currentPlugin.Version.ToString());
                listView1.Items.Add(itm);

            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            if (listView1.SelectedIndices.Count == 0)
                return;
           
            int index = listView1.SelectedIndices[0];

            ListViewItem itm = listView1.Items[index];
            if(itm.Text == "Chronicle")
            {
                richTextBox1.SelectedText += $"Plugin Name: Base Application\n";
                richTextBox1.SelectedText += $"Plugin Description: Base Chronicle Loader\n";
                richTextBox1.SelectedText += $"Plugin Version: {Globals.BaseAppVersion}\n\n";
                
                richTextBox1.SelectedText += $"Plugin Namespace: Chronicle";

                return;
            }
            IPlugable plugin = Globals.PluginManager.plugins[itm.Text];
            richTextBox1.SelectedText += $"Plugin Name: {plugin.PluginName}\n";
            richTextBox1.SelectedText += $"Plugin Description: {plugin.PluginDescription}\n";
            richTextBox1.SelectedText += $"Plugin Version: {plugin.Version}\n\n";

            richTextBox1.SelectedText += $"Plugin Namespace: {plugin.GetType().Namespace}";

        }

    }
}
