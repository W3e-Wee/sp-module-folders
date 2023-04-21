using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ExperimentTreeStructure.Classes
{
    public class EmployeeTreeNode : TreeNode
    {
        // ********************
        // Variables
        // ********************
        private EmployeeTreeNode _parent = null;
        private Employee _employee = new Employee();
        private List<EmployeeTreeNode> _mySubordinates;

        // ********************
        // Constructor
        // ********************
        public EmployeeTreeNode()
        {
            _mySubordinates = new List<EmployeeTreeNode>();
        }// End of constructor 1

        public EmployeeTreeNode(Employee employee)
        {
            _mySubordinates = new List<EmployeeTreeNode>();
            _employee = new Employee();
            _employee.EmployeeName = employee.EmployeeName;
            _employee.Salary = employee.Salary;
            this.Text = employee.EmployeeName;
            _parent = null; // Parent not planned to be set here
        }// End of constructor 2

        // ********************
        // Properties
        // ********************
        public Employee Employee
        {
            get { return _employee; }
            set { _employee = value; }
        }// End of Employee property

        public EmployeeTreeNode Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }// End of Parent property

        public List<EmployeeTreeNode> MySubordinates
        {
            get { return _mySubordinates; }
            set { _mySubordinates = value; }
        }// End of MySubordinates property

        // ********************
        // Methods
        // ********************
        public void AddSubordinate(EmployeeTreeNode employeeNode)
        {
            // There is a List<EmployeeTreeNode> type member variable, _mySubordinates.
            // _mySubordinate was declared as a collection to collecy EmployeeTreeNode type objects,
            // This method takes an EmployeeTreeNode type object as a input
            // The command below inserts the object into _mySubordinates

            employeeNode.Parent = this;
            _mySubordinates.Add(employeeNode);
            this.Nodes.Add(employeeNode);

        }// End of AddSubordinate method

        public void SearchByEmployeeName(string employeeName, ref List<EmployeeTreeNode> foundNode)
        {
            int i = 0;
            if(this.MySubordinates.Count == 0) // following statement will only execute if EmployeeTreeNode object is the "leaf node"
            {
                if(this.Employee.EmployeeName == employeeName)
                {
                    foundNode.Add(this);
                }
            }
            for(i = 0; i < this._mySubordinates.Count; i++)
            {
                if(this._mySubordinates[i].Employee.EmployeeName == employeeName)
                { // Base case (Where mehtod code stops calling itself, performs an action and finally exits)
                  // This avoids an infinite loop
                    foundNode.Add(this.MySubordinates[i]);
                }
                this.MySubordinates [i].SearchByEmployeeName(employeeName, ref foundNode);
            }

            return;
        }// End of SearchByEmployeeName method

    } // End of class

}// End of namespace