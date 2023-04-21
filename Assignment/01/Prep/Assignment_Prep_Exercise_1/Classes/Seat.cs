using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Prep_Exercise_1.Classes
{
    class Seat
    {
        private bool _bookStatus = false;
        private bool _canBook = false;

        private int _row;

        private int _seatNumber;
        public int Row
        {
            get { return _row; } // get method
            set { _row = value; } // set method
        } // End of Row

        public int SeatNumber
        {
            get { return _seatNumber; } 
            set { _seatNumber = value; }
        } // End of SeatNumber

        public bool CanBook
        {
            get { return _canBook; }
            set { _canBook = value; }
        } // End of CanBook

        public bool BookStatus
        {
            get { return _bookStatus; }
            set { _bookStatus = value; }
        } // End of BookStatus
        public string ComputeSeatLabel()
        {
            // converts row number to alphabets
            // is then concatinated with seatNumber
            return ((char)(_row + 64)).ToString() + _seatNumber.ToString();
        }// End of ComputeSeatLabel

    }// End of class

}// End of namespace
