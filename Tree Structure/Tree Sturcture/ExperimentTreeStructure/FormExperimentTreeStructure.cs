using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ExperimentTreeStructure.Classes;

namespace ExperimentTreeStructure
{
    public partial class FormExperimentTreeStructure : Form
    {
        private EmployeeTreeNode _root;
        private Employee _emp;
        private TreeNode _currentSelectedNode;
        public FormExperimentTreeStructure()
        {
            InitializeComponent();
        }

        private void FormExperimentTreeStructure_Load(object sender, EventArgs e)
        {

        }

        private void buttonExperiment1_Click(object sender, EventArgs e)
        {
            // Prepare the root of the tree structure.
            // The root does not hold any employee data at all.
            _emp = new Employee();
            _emp.EmployeeName = "root";
            _emp.Salary = 0;
            _root = new EmployeeTreeNode(_emp);

            _emp = new Employee();
            _emp.EmployeeName = "Tom";
            _emp.Salary = 10000;
            EmployeeTreeNode employee1 = new EmployeeTreeNode(_emp);

            _emp = new Employee();
            _emp.EmployeeName = "Thomas";
            _emp.Salary = 9000;
            EmployeeTreeNode employee2 = new EmployeeTreeNode(_emp);

            _emp = new Employee();
            _emp.EmployeeName = "Tara";
            _emp.Salary = 9000;
            EmployeeTreeNode employee3 = new EmployeeTreeNode(_emp);

            _root.AddSubordinate(employee1);

            employee1.AddSubordinate(employee2);
            employee1.AddSubordinate(employee3);
            // PrintTree(_root, "", true);
            treeViewEmployeeData.Nodes.Add(_root);

        }// End of buttonExperiment1_Click

        private void PrintTree(EmployeeTreeNode employeeTreeNode, string indent, bool last)
        {
            EmployeeTreeNode tree = employeeTreeNode;
            int numberOfChildNodes = tree.MySubordinates.Count;
            Debug.Write(indent);//You can delete this statement to check the effects.
            if (last)
            { //The following code was done through trial and error
                Debug.Write("+-");//You can delete this statement to check the effects.
                indent += " ";//You can delete this statement to check the effects.
            }
            else
            { //The following code was done through trial and error
                Debug.Write("+-");//You can delete this statement to check the effects.
                indent += "| ";//You can delete this statement to check the effects.
            }
            Debug.WriteLine(tree.Employee.EmployeeName);
            for (int i = 0; i < numberOfChildNodes; i++)
            {
                //Keep calling the PrintTree method
                PrintTree(tree.MySubordinates[i], indent, i == numberOfChildNodes - 1);
            }//End of for loop
        }//End of PrintTree

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _currentSelectedNode = treeViewEmployeeData.SelectedNode; // Remembers what is currently selected

            if(_currentSelectedNode == null)
            {
                textBoxMessage.Text += "You did not select any employee to add an employee.\r\n";
            }
            else
            {
                EmployeeTreeNode employeeTreeNode = (EmployeeTreeNode)_currentSelectedNode;
                string name = employeeTreeNode.Employee.EmployeeName;
                textBoxMessage.Text += name+ " has been selected to add a new employee\r\n";
                FormCreateEmployee fce = new FormCreateEmployee(name);
      
                fce.AddEmployeeCallBack = AddEmployeeCallBackFn;  // This assigns a method to the other form (FormCreateEmployee)
                fce.ShowDialog(); // Shows form in dialog mode - Can't access parent form till this form closes

            }

        }

        private void AddEmployeeCallBackFn(string reportingOfficerName, string newEmployeeName, int newEmployeeSalary)
        {
            textBoxMessage.Text = "Collected name: " + newEmployeeName + " salary: " + newEmployeeSalary.ToString();
            EmployeeTreeNode employeeTreeNode = (EmployeeTreeNode)_currentSelectedNode;
            _emp = new Employee();
            _emp.EmployeeName = newEmployeeName;
            _emp.Salary = newEmployeeSalary;
            EmployeeTreeNode tempEmployee = new EmployeeTreeNode(_emp);

            employeeTreeNode.AddSubordinate(tempEmployee);
        }


    }// End of class

}// End of namespace
