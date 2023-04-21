using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DSAL_CA2.Classes;

namespace DSAL_CA2
{
    public partial class FormMainRole : Form
    {
        DataManager _dataManager;
        private RoleTreeNode _selectedNode;
        private Role _role;
        // private TreeNode _currentSelectedNode;
        private ContextMenuStrip roleMenu;
        // Create menu items globally
        ToolStripMenuItem addLabel = new ToolStripMenuItem();
        ToolStripMenuItem editLabel = new ToolStripMenuItem();
        ToolStripMenuItem deleteLabel = new ToolStripMenuItem();
        public FormMainRole()
        {
            InitializeComponent();
            _dataManager = new DataManager();
            _selectedNode = null;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            treeViewRoleData.Nodes.Add(_dataManager.RoleTreeStructure);
            treeViewRoleData.ExpandAll();
            InitializeMenuTreeView();
        }


        //********************************************
        // ****** Context Menu Configuration *********
        //********************************************
        private void InitializeMenuTreeView()
        {
            // Create ContextMenuStrip
            roleMenu = new ContextMenuStrip();

            // Create Menu Items
            addLabel.Text = "Add";
            editLabel.Text = "Edit";
            deleteLabel.Text = "Delete";

            // Add the menu items to the menu. (Do checks to see if it is Root)
            roleMenu.Items.AddRange(new ToolStripMenuItem[] { addLabel, editLabel, deleteLabel });

            // Provide options when item menu click
            roleMenu.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);

            // Need to check selected nodes info (for checks)
            roleMenu.Opening += new CancelEventHandler(contextMenu_Opening);

            // Set the ContextMenuStrip property to the ContextMenuStrip.
            treeViewRoleData.ContextMenuStrip = roleMenu;
        }
        public void contextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            _selectedNode = (RoleTreeNode)treeViewRoleData.SelectedNode;
            if((item != null) && (_selectedNode != null))
            {
                if(item.Text == "Add")
                {
                    RoleTreeNode roleTreeNode = _selectedNode;
                    string roleName = roleTreeNode.RoleInfo.RoleName;
                    textBoxMessage.Text = roleName + " has been selected to add a new role";
                    FormAddRole far = new FormAddRole(roleName);

                    far.AddRoleCallBack = AddRoleCallBackFn;
                    far.ShowDialog();
                }
                if(item.Text == "Edit")
                {
                    Role role = _selectedNode.RoleInfo;

                    FormUpdateRole fur = new FormUpdateRole(role.UUID, role.RoleName, role.IsProjectLeader);
                    fur.UpdateRoleCallBack = new FormUpdateRole.UpdateRoleDelegate(UpdateRoleCallBackFn);
                    fur.ShowDialog();
                }
                if(item.Text == "Delete")
                {
                    deleteRoleFn();
                }
            }
        }// End of contextMenu_ItemClicked method

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            _selectedNode = (RoleTreeNode)treeViewRoleData.SelectedNode;
            // Dont show option, set the option to true first
            foreach(ToolStripMenuItem item in roleMenu.Items)
            {
                item.Visible = true;
            }

            if(_selectedNode.Text == "Root")
            {
                editLabel.Visible = false;
                deleteLabel.Visible = false;
            }
            if (_selectedNode.Text != "Root")
            {
                editLabel.Visible = true; // Name can still be edited
                if (_selectedNode.ChildRole.Count > 0) // Should not delete role if there are child roles
                {
                    deleteLabel.Visible = true;
                }
            }
        }// End of contextMenu_Opening method
         //**************************************** End of Context Menu Configuration **************************************

        //********************************************
        //              Callback Methods 
        //********************************************
        
        // AddRole Form Callback
        private void AddRoleCallBackFn(string parentRoleName, string uuid, string newRoleName, bool newIsProjectLeader)
        {
            textBoxMessage.Text = "Collected UUID:" + uuid + "\n" + "Collected name: " + newRoleName + "\n" + "Is Project Leader? : " + newIsProjectLeader;
            RoleTreeNode roleTreeNode = _selectedNode;
            _role = new Role();
            _role.UUID = uuid;
            _role.RoleName = newRoleName;
            _role.IsProjectLeader = newIsProjectLeader;
            RoleTreeNode tempRole = new RoleTreeNode(_role);

            roleTreeNode.AddRole(tempRole);
        }// End of AddRoleCallBackFn method

        // UpdateRole Form Callback

        private void UpdateRoleCallBackFn(string uuid, string roleName, bool isProjectLeader)
        {
            List<RoleTreeNode> resultNodes = new List<RoleTreeNode>();

            _dataManager.RoleTreeStructure.SearchByUUID(uuid, ref resultNodes);

            resultNodes[0].RoleInfo.RoleName = roleName;
            resultNodes[0].Text = roleName;
        }// End of UpdateRoleCallBackFn method

        private void deleteRoleFn()
        {
            RoleTreeNode roleTreeNode = _selectedNode;
            roleTreeNode.Remove();
        }
        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            _dataManager.SaveRoleData();
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            _dataManager.LoadRoleData();
            treeViewRoleData.Nodes.Clear();
            treeViewRoleData.Nodes.Add(_dataManager.RoleTreeStructure);
            treeViewRoleData.ExpandAll();
        }
    }
}
