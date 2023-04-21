using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using DSAL_CA2.Classes;

namespace DSAL_CA2
{
    public partial class FormAddRole : Form
    {
        //**************************
        // Variables
        //**************************
        public delegate void AddRoleDelegate(string parentRoleName, string uuid, string newRoleName, bool newIsProjectLeader);
        public AddRoleDelegate AddRoleCallBack;
        private bool newIsProjectLeader = false;
        private string _uuid;
        public FormAddRole()
        {
            InitializeComponent();
        }

        public FormAddRole(string parentRoleName)
        {
            InitializeComponent();
            // Display Parent role name
            labelParentRoleName.Text = parentRoleName;
            _uuid = General.GenerateUUID();
            labelRoleUUID.Text = _uuid;
        }

        private void FormAddRole_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string uuid = _uuid;
            string roleName = textBoxRoleName.Text;
            bool isProjectLeader = newIsProjectLeader;
            AddRoleCallBack(labelParentRoleName.Text, uuid, roleName, isProjectLeader);
            // Check
            // MessageBox.Show("Role Name: " + roleName +" \n" + "Project Leader: " + isProjectLeader);

            this.DialogResult = DialogResult.OK;
        }

        private void checkBoxIsProjectLeader_CheckChanged(object sender, EventArgs e)
        {
            if (checkBoxProjectLeader.Checked)
            {
                this.newIsProjectLeader = true;
            }
            else
            {
                this.newIsProjectLeader = false;
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
