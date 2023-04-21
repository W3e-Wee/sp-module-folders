using System;
using System.Collections.Generic;
using System.Text;

namespace DSAL_Assignment1.Classes
{
    // This node class stores all Seat info to be added to the double linked list
    // Required:
    // 1. Next property
    // 2. Previous property
    // 3. Seat info
    [Serializable]
    internal class Node
    {
        private Node _next;
        private Seat _seat;
        private Node _prev;

        public Node(Seat pSeat)
        {
            _next = null;
            _seat = pSeat;
            _prev = null;
        }// End of constructor

        #region Properties
        public Node Next
        {
            get { return _next; }
            set { _next = value; }
        }

        public Node Prev
        {
            get { return _prev; }
            set { _prev = value; }
        }

        public Seat Seat
        {
            get { return _seat; }
            set { _seat = value; }
        }
        #endregion
    }// End of Node class

}// End of namespace
