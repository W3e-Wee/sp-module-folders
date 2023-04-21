using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DSAL_CA2.Classes
{
    internal class EmployeeTreeNode: TreeNode
    {
        //********************
        // Variables
        //********************
        private EmployeeTreeNode _parent = null; // Parent Node or not?
        private Employee _employee = new Employee(); // Info about Role
        private List<EmployeeTreeNode> _childEmployeeRole; // Stores child Roles

        //********************
        // Constructor
        //********************
        public EmployeeTreeNode()
        {
            _childEmployeeRole = new List<EmployeeTreeNode>(); // Declare the List
        }// End of constructor 1

        public EmployeeTreeNode(Employee employee)
        {
            _parent = null;
            _childEmployeeRole = new List<EmployeeTreeNode>();
            _employee = employee;
            this.Text = employee.EmployeeName;

        }// End of constructor 2

        //********************
        // Properties
        //********************
        public EmployeeTreeNode Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }// End of Parent property
        public Employee Employee
        {
            get { return _employee; }
            set { _employee = value; }
        }// End of RoleInfo property

        public List<EmployeeTreeNode> ChildEmployeeRole
        {
            get { return _childEmployeeRole; }
            set { _childEmployeeRole = value; }
        }

        //********************
        // Methods
        //********************
        public void AddRole(EmployeeTreeNode employeeNode)
        {
            // Set the variable that called this method the Parent
            employeeNode.Parent = this;
            // Add a child RoleTreeNode into the List
            ChildEmployeeRole.Add(employeeNode);
            // Adds it to the tree structure
            this.Nodes.Add(employeeNode);
        }// End of AddRole method
    }
}
