using Assignment_Prep_v2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Prep_v2
{
    public partial class Form1 : Form
    {
        SeatDoubleLinkedList seatList = new SeatDoubleLinkedList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        /*  
         // Delcare a new Seat type object
         Seat s = new Seat();

            // First seat info       // Inserts the object into linked list
            s.Row = 1; s.Column = 1; seatList.InsertAtEnd(s);

            // Reinitialize s to create another Seat type object
            s = new Seat();
            // Second Seat info 
            s.Row = 1; s.Column = 2;seatList.InsertAtEnd(s);
            
            
            s = new Seat();
            // Third Seat info
            s.Row = 1; s.Column = 3; seatList.InsertAtEnd(s);
            
            // Declare Label control
            Label labelSeat = new Label();

            // ----------- Configure labelSeat -------------
            labelSeat.Text = "A1";
            labelSeat.Location = new Point(50, 50);
            labelSeat.Size = new Size(60, 60);
            labelSeat.TextAlign = ContentAlignment.MiddleCenter;
            labelSeat.BorderStyle = BorderStyle.FixedSingle;
            labelSeat.BackColor = Color.LightGray;
            labelSeat.Font = new Font("Calibri", 14, FontStyle.Bold);
            labelSeat.ForeColor = Color.Black;
            labelSeat.Tag = new SeatInfo() { Row = 1, Column = 1 };
            // ----------- End of configuartion -------------

            // Add label to panel control
            panelSeats.Controls.Add(labelSeat);
        */

        }// End of Form1_Load

        class SeatInfo
        {
            public int Row { get; set; }
            public int Column { get; set; }
        }// End of SeatInfo class

        private void buttonGenerateSeats_Click(object sender, EventArgs e)
        {

        }
    }// End of class

}// End of namespace
