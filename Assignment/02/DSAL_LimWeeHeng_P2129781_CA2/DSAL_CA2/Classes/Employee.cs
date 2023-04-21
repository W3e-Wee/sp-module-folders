using System;
using System.Collections.Generic;
using System.Text;

namespace DSAL_CA2.Classes
{
    internal class Employee
    {
        private string _employeeName = "";
        private int _employeeSalary = 0;

        //*************************
        // Constructors
        //*************************
        public Employee()
        {
        }// End of empty constructor
        public Employee(string employeeName, int employeeSalary)
        {
            _employeeName = employeeName;
            _employeeSalary = employeeSalary;
        }// End of constructor

        //*************************
        // Properties
        //*************************
        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        } // End of EmployeeName

        public int EmployeeSalary
        {
            get { return _employeeSalary; }
            set { _employeeSalary = value; }
        } // End of EmployeeSalary
    }
}
