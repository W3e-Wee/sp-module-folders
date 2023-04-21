using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DSAL_CA2.Classes
{
    [Serializable]
    internal class DataManager
    {
        private RoleTreeNode _roleTreeStructure;
        private string _filePath;
        
        //******************************************
        // Constructor
        //******************************************
        public DataManager()
        {
            _filePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Data.dat";
            _roleTreeStructure = new RoleTreeNode(new Role("Root", false));
        }

        //******************************************
        // Properties
        //******************************************
        public RoleTreeNode RoleTreeStructure
        {
            get { return _roleTreeStructure; }
            set { _roleTreeStructure = value; }
        }

        //******************************************
        // Methods
        //******************************************
        public RoleTreeNode GenerateTreeStructure()
        {
            _roleTreeStructure = new RoleTreeNode(new Role("Root", false));

            return _roleTreeStructure;
        }

        public void SaveRoleData() // Save Tree structure data
        {
            this.RoleTreeStructure.SaveToFileBinary(_filePath);
        }

        public RoleTreeNode LoadRoleData() // Loads saved data
        {
            this.RoleTreeStructure = this.RoleTreeStructure.ReadFromFileBinary(_filePath);
            this.RoleTreeStructure.RebuildTreeNodes();
            return this.RoleTreeStructure;
        }
    }
}
