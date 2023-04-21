using System;
using System.Collections.Generic;
using System.Text;

namespace ExperimentTreeStructure.Classes
{
    public class Employee
    {
        private string _employeeName = "";
        private int _salary = 0;

        //*******************
        // Constructors
        //*******************
        public Employee()
        {
        }// End of empty constructor
        public Employee(string employeeName, int salary)
        {
            this._employeeName = employeeName;
            this._salary = salary;

        }// End of constructor

        //*******************
        // Properties
        //*******************
        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }// End of EmployeeName property

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }// End of Salary property
    }
}
