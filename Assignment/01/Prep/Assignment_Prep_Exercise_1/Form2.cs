using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Prep_Exercise_1
{
    public partial class Form2 : Form
    {
        Classes.SeatManager _seatManager = new Classes.SeatManager();
        public Form2()
        {
            InitializeComponent();
            // Statement sets the button control to raise an event and ask the
            // .NET engine to execute the method createSeats
            buttonCreateAndDisplay.Click += new EventHandler(createSeats);
        }

        public void createSeats(object sender, EventArgs e)
        {
            // -- 3 commands to show the concept of dynamicaly added
            // -- event handler method
            // Button button = (Button)sender;
            // button.Enabled = false;
            // MessageBox.Show("Click");

            int maxRow = 2;
            int maxColumn = 3;
            int x, y;
            int seatWidth = 60;
            int seatHeight = 60;
            for (y = 1; y <= maxRow; y++)
            {
                for (x = 1; x <= maxColumn; x++)
                {
                    Label labelSeat = new Label();
                    labelSeat.Width = seatWidth;
                    labelSeat.Height = seatHeight;
                    labelSeat.Top = 25 + (y * (seatHeight + 5));
                    labelSeat.Left = 25 + (x * (seatWidth + 5));
                    labelSeat.BackColor = Color.LightGray;
                    labelSeat.Name = "labelSeat " + y.ToString() + "_" + x.ToString();
                    labelSeat.Click += new EventHandler(HandleLabelClick);

                    // Seat manager object creates a new Seat object at pos x,y
                    Classes.Seat seat = _seatManager.InsertOneSeat(y, x);

                    // Set Tag property of the new Label control to reference Seat object
                    labelSeat.Tag = seat;
                    labelSeat.Text = seat.ComputeSeatLabel();
                    
                    // Insert Label object inside the Panel control
                    panelSeats.Controls.Add(labelSeat);

                }; // End of x FOR loop

            } // End of y FOR loop

        }// End of method

        private void HandleLabelClick(object sender, EventArgs e)
        {
            // sender references the object which raised the click event (in this case is Label)
            Label labelSeat = (Label)sender;

            // Obtain Seat object that is tagged to Label
            Classes.Seat seat = (Classes.Seat)labelSeat.Tag;

            // Obtain row and seat number info from the Seat object to search for the seat

            // if seat is unbooked...
            if(seat.BookStatus == false)
            {
                // book a seat
                seat = _seatManager.FindOneSeatToBook(seat.Row, seat.SeatNumber);
                labelSeat.BackColor = Color.Yellow;
            }
            // else if its booked...
            else
            {
                // unbook a seat
                seat = _seatManager.FindOneSeatToUnbook(seat.Row, seat.SeatNumber);
                labelSeat.BackColor = Color.LightGray;
            }

            labelMessage.Text = String.Format("You have clicked {0}", labelSeat.Text);

        } // End of HandleLabelClick

    } // End of Form2

}// End of namespace
