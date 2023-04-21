using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DSAL_Assignment1.Classes
{
    // Seat class used to create Seat type objects
    // Properties needed:
    // 1. Row info
    // 2. Column info
    // 3. Book status
    // 4. Bookable?
    // 5. Check for Seat next to it
    [Serializable]
    internal class Seat
    {
        #region Variables
        // Row and Column dinfi
        private int _row;
        private int _column;

        // Book status info
        private bool _bookStatus = false;

        // Bookabe?
        private bool _bookable = false;

        // check if seat is first or last in row
        private bool _isLastSeat = false;
        private bool _isFirstSeat = false;

        // check if there is divider
        private bool _hasDivider = false;

        // check to see if its the start or end of list
        private bool _endList = false;
        private bool _startList = false;

        private Node _parent;
        #endregion
 
        #region Properties
        public Node Parent 
        { 
            get { return _parent; } 
            set { _parent = value; }
        }
        public int Row
        {
            get { return _row; }
            set { _row = value; }
        }// End of Row property

        public int Column
        {
            get { return _column; }
            set { _column = value; }
        }// End of Column property

        public bool BookStatus
        {
            get { return _bookStatus; }
            set { _bookStatus = value; }
        }// End of BookStatus property

        public bool IsBookable
        {
            get { return _bookable; }
            set { _bookable = value; }
        }// End of Bookable

        public bool isLastSeat
        {
            get { return _isLastSeat; }
            set { _isLastSeat = value; }
        }

        public bool isFirstSeat
        {
            get { return _isFirstSeat; }
            set { _isFirstSeat = value; }
        }

        public bool hasDivider
        {
            get { return _hasDivider; }
            set { _hasDivider = value; }
        }
        public bool isEndOfList
        {
            get { return _endList; }
            set { _endList = value; }
        }
        public bool isStartOfList
        {
            get { return _startList; }
            set { _startList = value; }
        }
        #endregion

        #region Methods
        // converts row and column num to seat numbers
        public string ComputeSeatLabel()
        {
            return ((char)(_row + 64)).ToString() + _column.ToString();
        }// End of ComputeSeatLabel 

        public Label CreateLabel() // for saving
        {
            Label labelSeat = new Label();//Instantiate a new Label type object, labelSeat
            labelSeat.Text = this.ComputeSeatLabel();//Set the Text property by using a string
            labelSeat.Location = new Point((60 * (this.Column - 1)) + 60 + (20 * (this.Column - 1)), (60 * (this.Row - 1)) + 60 + (20 * (this.Row - 1)));//Create a Point type object which has x,y coordinate info
            labelSeat.Size = new Size(60, 60);//Create a Size type object which has the width, height info
            labelSeat.TextAlign = ContentAlignment.MiddleCenter;//Align the Text to mid - center
            labelSeat.BorderStyle = BorderStyle.FixedSingle;//Make the border visible
            labelSeat.Font = new Font("Calibri", 14, FontStyle.Bold);
            labelSeat.ForeColor = Color.Black;
            labelSeat.Tag = new SeatInfo() { Row = this.Row, Column = this.Column };
            labelSeat.BackColor = Color.LightGray;
            if (this.BookStatus == true)
            {
                labelSeat.BackColor = Color.Yellow;
            }
            return labelSeat;
        }//End of CreateLabel
        
        #endregion
    }// End of Seat class

}// End of namespace
