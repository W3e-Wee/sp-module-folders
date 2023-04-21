using System;
using System.Collections.Generic;
using System.Text;

namespace DSAL_CA2.Classes
{
    [Serializable]
    // Holds all info regarding the Role
    public class Role 
    {
        private string _uuid; // Role UUID
        private string _roleName = "";
        private bool _isProjectLeader = false;
        private RoleTreeNode _roleContainer; 

        //*************************
        // Constructors
        //*************************
        public Role()
        {
        }// End of empty constructor
        public Role(string roleName, bool isProjectLeader)
        {
            _uuid = General.GenerateUUID();
            _roleName = roleName;
            _isProjectLeader = isProjectLeader;
        }// End of constructor

        //*************************
        // Properties
        //*************************
        public RoleTreeNode RoleContainer
        {
            get { return _roleContainer; }
            set { _roleContainer = value; }
        }
        public string RoleName
        {
            get { return _roleName; }
            set { _roleName = value; }
        } // End of RoleName property
        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        } // End of UUID property

        public bool IsProjectLeader
        {
            get { return _isProjectLeader; }
            set { _isProjectLeader = value; }
        } // End of IsProjectLeader property

    }
}
