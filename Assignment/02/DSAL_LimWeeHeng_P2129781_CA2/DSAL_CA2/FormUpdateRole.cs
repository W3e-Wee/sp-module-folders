using DSAL_CA2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DSAL_CA2
{
    public partial class FormUpdateRole : Form
    {
        private Role _updatedRole;
        public delegate void UpdateRoleDelegate(string uuid, string roleName, bool isProjectLeader);
        public UpdateRoleDelegate UpdateRoleCallBack;

        public FormUpdateRole()
        {
            InitializeComponent();
        }

        public FormUpdateRole(string uuid, string roleName, bool isProjectLeader)
        {
            InitializeComponent();
            _updatedRole= new Role();
            _updatedRole.UUID = uuid;
            _updatedRole.RoleName = roleName;
            _updatedRole.IsProjectLeader = isProjectLeader;
        }

        private void FormUpdateRole_Load(object sender, EventArgs e)
        {
            textBoxRoleName.Text = _updatedRole.RoleName;
            textBoxRoleUUID.Text = _updatedRole.UUID;
            checkBoxIsProjectLeader.Checked = _updatedRole.IsProjectLeader;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string uuid = textBoxRoleUUID.Text;
            string name = _updatedRole.RoleName.Trim();
            bool projectLeader = _updatedRole.IsProjectLeader;
            if(name != "")
            {
                UpdateRoleCallBack(uuid, name, projectLeader);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error! Role name cannot be empty");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
