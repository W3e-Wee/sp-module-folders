using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentTreeViewV1.Classes
{
    [Serializable]
    internal class Role
    {
        private string _uuid; // Role UUID
        private string _name; // Role Name
        private RoleTreeNode _roleTreeNode; // Role Node

        public Role(string name)
        {
            _uuid = General.GenerateUUID();
            _name = name;
        } // end of constructor

        public string UUID
        {
            get { return _uuid; }
        } // End of UUID property

        public string Name
        {
            get { return _name; }
        } // End of Name property

        public void EditRole(string name)
        {
            _name = name;

        }// End of EditRole method


    }//end of Role class
}//end of namespace
