using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace DSAL_CA2.Classes
{
    [Serializable]
    // Manages Nodes in the TreeView Control
    public class RoleTreeNode:TreeNode, ISerializable
    {
        //********************
        // Variables
        //********************
        private RoleTreeNode _parent = null; // Parent Node or not?
        private Role _roleInfo = new Role(); // Info about Role
        private List<RoleTreeNode> _childRole; // Stores child Roles

        //********************
        // Constructor
        //********************
        public RoleTreeNode()
        {
            _childRole = new List<RoleTreeNode>(); // Declare the List
        }// End of constructor 1

        public RoleTreeNode(Role role)
        {
            _parent = null;
            _childRole = new List<RoleTreeNode>();
            _roleInfo = role;
            _roleInfo.RoleContainer = this;
            this.Text = role.RoleName;
            

        }// End of constructor 2

        //********************
        // Properties
        //********************
        public RoleTreeNode Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }// End of Parent property
        public Role RoleInfo
        {
            get { return _roleInfo; }
            set { _roleInfo = value; }
        }// End of RoleInfo property

        public List<RoleTreeNode> ChildRole
        {
            get { return _childRole; }
            set { _childRole = value; }
        }// End of ChildRole property

        //********************
        // Methods
        //********************

        public void RebuildTreeNodes()
        {
            this.Text = this.RoleInfo.RoleName;
            if (this.ChildRole.Count > 0)
            {
                int i = 0;
                for (i = 0; i < this.ChildRole.Count; i++)
                {
                    this.Nodes.Add(this.ChildRole[i]);
                    this.ChildRole[i].Parent = this;
                    this.ChildRole[i].RebuildTreeNodes();
                }
            }

        }//End of RebuildTreeNodes
        // File IO Functions ----------------------------------------------------------------------------------------------

        public void SaveToFileBinary(string filepath)
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                Stream stream = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);

                bf.Serialize(stream, this);
                stream.Close();

                MessageBox.Show("Data is added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } //End of SaveToFileBinary

        public RoleTreeNode ReadFromFileBinary(string filepath)
        {
            try
            {
                Stream stream = new FileStream(@filepath, FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                RoleTreeNode root = null;
                if (stream.Length != 0)
                {
                    root = (RoleTreeNode)bf.Deserialize(stream);
                }
                stream.Close();

                return root;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Unable to find file.");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }//end of ReadFromFileBinary

        // [ SERIALIZE ]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //add the required data to file
            info.AddValue("RoleInfo", _roleInfo);
            info.AddValue("ChildRole", _childRole);
            info.AddValue("Parent", _parent);

        }//end of GetObjectData [ SERIALIZE ]
        // [DESERIALIZE]
        protected RoleTreeNode(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new System.ArgumentNullException("info");
            this.RoleInfo = (Role)info.GetValue("RoleInfo", typeof(Role));
            this.RoleInfo.RoleContainer = this;
            this.ChildRole = (List<RoleTreeNode>)info.GetValue("ChildRole", typeof(List<RoleTreeNode>));
            this.Parent = (RoleTreeNode)info.GetValue("Parent", typeof(RoleTreeNode));
        }//end of RoleTreeNode [ DESERIALIZE ]

        // End Of File IO Functions ---------------------------------------------------------------------------------------

        public void AddRole(RoleTreeNode roleNode)
        {
            // Set the variable that called this method the Parent
            roleNode.Parent = this;
            // Add a child RoleTreeNode into the List
            ChildRole.Add(roleNode);
            // Adds it to the tree structure
            this.Nodes.Add(roleNode);
        }// End of AddRole method

        public void SearchByUUID(string uuid, ref List<RoleTreeNode> foundNodes)
        {
            if (this.ChildRole.Count > 0)//Note: This if block may not be necessary at all. Though the logic works.
            {
                int i = 0;
                for (i = 0; i < this.ChildRole.Count; i++)
                {
                    if (this.ChildRole[i].RoleInfo.UUID == uuid)
                    {  //Base case (Where the method code stops calling itself, 
                       //perform action and finally exit). This avoids infinite loop

                        foundNodes.Add(this.ChildRole[i]);
                    }
                    else
                    { //Recursive case (where the method calls itself)
                      //Each DepartmentNode type object has SearchDeleteById method
                        this.ChildRole[i].SearchByUUID(uuid, ref foundNodes);
                    }
                }
            }
        }//End of SearchByUUID method

        public void removeRole(RoleTreeNode roleNode)
        {
            roleNode.Parent = this;
            ChildRole.Remove(roleNode);
            this.Nodes.Add(roleNode);
        }
    }
}
