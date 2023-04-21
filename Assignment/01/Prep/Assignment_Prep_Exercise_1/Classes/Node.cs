using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Prep_Exercise_1.Classes
{
    class Node
    {
        public Node Prev;
        public Seat Seat;
        public Node Next;

        public Node(Seat pSeat)
        {
            Seat = pSeat;
            Prev = null;
            Next = null;
        }
    } // End of class

} // End of namespace
