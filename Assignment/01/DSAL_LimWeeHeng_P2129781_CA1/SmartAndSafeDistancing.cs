using DSAL_Assignment1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAL_Assignment1
{
    public partial class SmartAndSafeDistancing : Form
    {
        SeatDoubleLinkedList seatList = new SeatDoubleLinkedList();
        int numofBooking = 0;

        public SmartAndSafeDistancing()
        {
            InitializeComponent();
        }
        private void SmartAndSafeDistancing_Load(object sender, EventArgs e)
        {
            buttonGenerateSeats.Click += new EventHandler(createSeat);
            buttonSave.Click += new EventHandler(buttonSave_Click);
            buttonLoad.Click += new EventHandler(buttonLoad_Click);
        }
        private void createSeat(object sender, EventArgs e)
        {
            try
            {
                // read input values
                int numRow = int.Parse(textBoxNumRows.Text);
                int numColumns = int.Parse(textBoxSeatsperRow.Text);

                // Instantiate Seat type object
                Seat seat = new Seat();
                //Instantiate a new Label type object
                Label labelSeat = new Label();

                for (int x = 1; x <= numRow; x++) // creates Rows
                {
                    for (int y = 1; y <= numColumns; y++)// creates Columns
                    {
                        seat = new Seat();
                        seat.Row = x;
                        seat.Column = y;

                        seatList.InsertAtEnd(seat);

                        labelSeat = new Label(); //Instantiate a new Label type object, labelSeat

                        /* ======== Configure label Seats ========== */
                        labelSeat.Text = seat.ComputeSeatLabel();
                        labelSeat.Location = new Point((60 * (y - 1)) + 50 + (20 * (y - 1)), (60 * (x - 1)) + 50 + (20 * (x - 1))); //Create a Point type object which has x,y coordinate info
                        labelSeat.Size = new Size(60, 60); //Create a Size type object which has the width, height info
                        labelSeat.TextAlign = ContentAlignment.MiddleCenter; //Align the Text to mid - center
                        labelSeat.BorderStyle = BorderStyle.FixedSingle; //Make the border visible
                        labelSeat.Font = new Font("Calibri", 14, FontStyle.Bold);
                        labelSeat.BackColor = Color.LightGray;
                        labelSeat.ForeColor = Color.Black;
                        labelSeat.Tag = new SeatInfo() { Row = seat.Row, Column = seat.Column };
                        labelSeat.Click += new EventHandler(labelSeat_Click);
                        if (y == numColumns)
                        {
                            seat.isLastSeat = true;
                        }
                        if (y == 1)
                        {
                            seat.isFirstSeat = true;
                        }

                        panelSeats.Controls.Add(labelSeat);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } // End of try...catch
        }
        // when labelSeat is clicked below method will trigger
        private void labelSeat_Click(object sender, EventArgs e)
        {
            Label seatLabel = (Label)sender;
            SeatInfo seatInfo = (SeatInfo)seatLabel.Tag;


            Seat seat = seatList.SearchByRowAndColumn(seatInfo.Row, seatInfo.Column); // info of seat that user clicked

            if (numofBooking == 0) // checks if its the first seat booked
            {
                if (seat.BookStatus == false)
                {
                    seat.BookStatus = true;
                    seatLabel.BackColor = Color.Yellow;
                    numofBooking++;
                }
                else
                {
                    seat.BookStatus = false;
                    seatLabel.BackColor = Color.LightGray;
                    numofBooking--;
                }
            }
            else
            {
                Seat seatRight = seat.Parent.Next.Seat;
                Seat seatLeft = seat.Parent.Prev.Seat;

                /*
                seatLeft = seatList.SearchByRowAndColumn(seat.Row, seat.Column - 1);
                seatRight = seatList.SearchByRowAndColumn(seat.Row, seat.Column + 1);
                */

                // if prev seat is NOT the last in row(allow booking) 
                // if next seat is NOT the first in row(allow booking)
                if (!seat.isLastSeat && !seat.isFirstSeat)  // check for seat on left
                {
                    if (seatRight.BookStatus == true || seatLeft.BookStatus == true || numofBooking == 1) // checks if seat left/right is booked
                    {
                        if (seat.BookStatus == false)
                        {
                            seat.BookStatus = true;
                            seatLabel.BackColor = Color.Yellow;
                            numofBooking++;
                        }
                        else
                        {
                            seat.BookStatus = false;
                            seatLabel.BackColor = Color.LightGray;
                            numofBooking--;
                        }

                    }// End of check for seat checks if seat left/right is booked

                }// End of if check for first and last seat
                else
                {
                    if (seat.isLastSeat || seat.isFirstSeat) // checks if it really is the first/last in row
                    {
                        if ((seatRight.isFirstSeat && seatLeft.BookStatus == true) || (seatLeft.isLastSeat && seatRight.BookStatus == true))
                        // checks to see if the next seat is the first seat and if seat on left is booked
                        // checks to see if the prev seat is the last seat and if the seat on the right is booked
                        {
                            if (seat.BookStatus == false)
                            {
                                seat.BookStatus = true;
                                seatLabel.BackColor = Color.Yellow;
                                numofBooking++;
                            }
                            else
                            {
                                seat.BookStatus = false;
                                seatLabel.BackColor = Color.LightGray;
                                numofBooking--;
                            }// End of if check

                        }// End of if check

                    }// End of if check

                }// End of if..else
            }// End of if...else
        }// End of labelSeat_Click



        private void buttonPersonA_Click(object sender, EventArgs e)
        {
            textBoxMaxSeat.Enabled = true;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Stream stream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Path.
                GetFullPath(Path.Combine(Application.StartupPath, "..\\..\\..\\Data"));
            saveFileDialog.Filter = "Data Files (*.dat)|*.dat";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog.OpenFile()) != null)
                {
                    BinaryFormatter f = new BinaryFormatter();
                    f.Serialize(stream, seatList);
                    stream.Close();
                }
            }
        }// End of buttonSave_Click

        private void buttonLoad_Click(object sender, EventArgs e)
        {

            string filePath;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\..\\..\\Data"));
            openFileDialog.Filter = "Data Files (*.dat)|*.dat";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                BinaryFormatter f = new BinaryFormatter();
                Stream stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);

                if (stream.Length != 0)
                {
                    seatList = (SeatDoubleLinkedList)f.Deserialize(stream);
                }
                stream.Close();
            }

            panelSeats.Controls.Clear();

            List<Label> labelList = seatList.GenerateLabels();

            foreach (Label label in labelList)
            {
                {
                    label.Click += new System.EventHandler(labelSeat_Click);
                    panelSeats.Controls.Add(label);
                }
            }
        }//End of buttonLoad_Click

    }
}
