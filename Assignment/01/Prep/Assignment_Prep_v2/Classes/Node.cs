using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Prep_v2.Classes
{
    // creates Node type object to remember Seat type object before and after it
    // structures the data to a double linked list
    internal class Node
    {
        // variables for this class
        private Node _prev;
        private Seat _seat;
        private Node _next;

        public Node(Seat pSeat)
        {
            // declare variables
            _prev = null;
            _next = null;
            _seat = pSeat;

        }// End of constructor

        public Node Prev
        {
            get { return _prev; }
            set { _prev = value; }
        }// End of Prev property

        public Seat Seat
        {
            get { return _seat; }
            set { _seat = value; }
        }// End of Seat property

        public Node Next
        {
            get { return _next; }
            set { _next = value; }
        }// End of Next property

    }// End of Node class

}// End of namespace
