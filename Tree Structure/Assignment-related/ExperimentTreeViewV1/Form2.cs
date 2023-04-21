using ExperimentTreeViewV1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExperimentTreeViewV1
{
    public partial class Form2 : Form
    {
        RoleManager roleManager;
        public Form2()
        {
            InitializeComponent();
            roleManager = new RoleManager();
        }

        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            roleManager.LoadRoleData();
            treeViewRole.Nodes.Clear();
            treeViewRole.Nodes.Add(roleManager.RoleTreeStructure);
            treeViewRole.ExpandAll();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitializeMenuTreeView();
        }
        //Reference: https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-attach-a-shortcut-menu-to-a-treeview-node?view=netframeworkdesktop-4.8
        // Declare the ContextMenuStrip
        private ContextMenuStrip roleMenu;

        public void InitializeMenuTreeView()
        {

            // Create the ContextMenuStrip.
            roleMenu = new ContextMenuStrip();

            //Create some menu items.
            ToolStripMenuItem viewLabel = new ToolStripMenuItem();
            viewLabel.Text = "View";
            ToolStripMenuItem addLabel = new ToolStripMenuItem();
            addLabel.Text = "Add child role";
            ToolStripMenuItem updateLabel = new ToolStripMenuItem();
            updateLabel.Text = "Update";
            //Reference: https://stackoverflow.com/questions/5789023/how-to-respond-to-a-contextmenustrip-item-click
            roleMenu.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);



            //Add the menu items to the menu.
            roleMenu.Items.AddRange(new ToolStripMenuItem[]{viewLabel,
        addLabel, updateLabel});
            // Set the ContextMenuStrip property to the ContextMenuStrip.
            this.treeViewRole.ContextMenuStrip = roleMenu;
        }
        public void contextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            if (item != null)
            {
                if(item.Text == "View")
                {
                    MessageBox.Show(treeViewRole.SelectedNode.Text);
                }
            }
            // your code here
        }
    }//end of class


}
