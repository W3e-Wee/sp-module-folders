using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Prep_Exercise_1.Classes
{
    class DoubleLinkedList
    {
        // make sure this refers to the first node of the list
        public Node Start { get; set; } 
        public DoubleLinkedList()
        {
            Start = null;
        } // End of constructor
        
        public void InsertAtEnd(Seat seatData)
        {
            Node newNode = new Node(seatData);
            if(Start == null)
            {
                Start = newNode;
                return;
            }

            // declares a Node object
            Node p = Start;
            // Moves through the list till p refers to the last node
            while(p.Next != null)
            {
                p = p.Next;
            } // End of while
            p.Next = newNode;
            newNode.Prev = p;
        }// End of InsertAtEnd

        public Seat SearchByRowAndColumn(int pRow, int pColumn)
        {
            // Declare Node object
            Node p = Start;
            
            while(p != null)
            {
                // while loop will continue running
                // till p satisifies below condition
                if ((p.Seat.SeatNumber == pColumn) && (p.Seat.Row == pRow))
                {
                    // if referenced node p satisfies the above condition
                    break; // Exit loop
                }
                // references next node
                p = p.Next; 
            }

            if(p == null)
            {
                return null;
            }
            else
            {
                return p.Seat;
            }// End of if...else block

        }//End of SearchByRowAndColumn

    } // End of class

} // End of namespace
