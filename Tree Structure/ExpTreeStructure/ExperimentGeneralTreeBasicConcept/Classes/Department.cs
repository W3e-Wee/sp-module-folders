using System;
using System.Collections.Generic;
using System.Text;

namespace ExperimentGeneralTreeBasicConcept.Classes
{
    internal class Department
    {
        // Constructor for Department class
        public Department(int pld, string pName)
        {
            this.DepartmentId = pld;
            this.Name = pName;
        }

        public string Name
        {
            get;
            set;
        }

        public int DepartmentId
        {
            get;
            set;
        }
    }
}
