using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SeatBookingSimulator
{
    public partial class ParentForm : Form
    {
        // class level variables
        public Form1 f1=null;
        public Form2 f2=null;
        public Form3 f3=null;
        public ParentForm()
        {
            InitializeComponent();
            this.normalModeMenuItem1.Click += new EventHandler(normalModeMenuItem1_Click);
        }

        private void normalModeMenuItem1_Click(object sender, EventArgs e)
        {
            if(f1 == null)
            {
                f1 = new Form1();
                f1.MdiParent = this;
                f1.Show();
            }
            else
            {
                f1 = new Form1();
            }
        }
           
    }
}
