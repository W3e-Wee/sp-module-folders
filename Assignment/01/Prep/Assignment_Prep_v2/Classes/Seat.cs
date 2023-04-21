using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Prep_v2.Classes
{
    // create a Seat class to create Seat type object with following property
    internal class Seat
    {
        // property to describe if seat 'was selected  for booking'
        // remb booking status
        private bool _bookStatus = false;

        // propety to describe that seat is bookable anot
        // remb if seat is selectable
        private bool _canBook = false;

        // following two variable is to remb position of seat
        private int _row;
        private int _col;

        public int Row
        {
            get { return _row; }
            set
            {
                _row = value;
            }
        }// End of Row property

        public int Column
        {
            get { return _col; }
            set
            {
                _col = value;
            }
        }// End of Column property
        
        public bool BookStatus
        {
            get { return _bookStatus; }
            set
            {
                _bookStatus = value;
            }
        }// End of BookStatus property

        public bool CanBook
        {
            get { return _canBook;}
            set
            {
                _canBook = value;
            }
        }// End of CanBook property

        // method to generate label for individual seat
        public string ComputeSeatLabel()
        {
            return ((char)(_row + 64)).ToString() + _col.ToString();
        }// End of ComputeSeatLabel method

    }// End of Seat class

}// End of namespace
