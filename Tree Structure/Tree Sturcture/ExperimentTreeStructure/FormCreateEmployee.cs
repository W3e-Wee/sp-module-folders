using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExperimentTreeStructure
{
    public partial class FormCreateEmployee : Form
    {
        public delegate void AddEmployeeDelegate(string reportingOfficerName, string newEmployeeName, int newEmployeeSalary);
        public AddEmployeeDelegate AddEmployeeCallBack;


        
        public FormCreateEmployee()
        {
            InitializeComponent();
        }

        public FormCreateEmployee(string reportingOfficerName)
        {
            InitializeComponent();
            // Display employee name that was chosen in FormExperimentTreeStructure
            labelReportingOfficerName.Text = reportingOfficerName;
        }

        private void FormCreateEmployee_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textboxName.Text;
            int salary = int.Parse(textboxSalary.Text);
            AddEmployeeCallBack(labelReportingOfficerName.Text, name, salary);

            // Brings the focus to parent form (FormExperimentTreeStructure)
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
