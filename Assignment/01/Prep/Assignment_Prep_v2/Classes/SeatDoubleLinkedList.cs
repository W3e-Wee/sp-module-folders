using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Prep_v2.Classes
{
    // structures the data to a double linked list
    // creates SeatDoubleLinkedList type object to have various functionalities for each Seat
    // that operates on the double linked list
    internal class SeatDoubleLinkedList
    {
        // define property
        public Node Start { get; set; }

        public SeatDoubleLinkedList()
        {
            // init Start variable
            Start = null;
        }// End of constructor

        public void InsertAtEnd(Seat pSeatData)
        {
            Node newNode = new Node(pSeatData);

            if(Start == null)
            {
                // creates a new node if there is no Start
                Start = newNode;
                return;
            }

            Node p = Start;

            // Traverse through the list till
            // it p refers to the last node
            while (p.Next != null)
            {
                p = p.Next;
            }// End of while

            // Once p refers to the last node of the list
            // creates a new node
            p.Next = newNode;
            newNode.Prev = p;
        }// End of InsertAtEnd method

        public Seat SearchByRowAndColumn(int pRow, int pColumn)
        {
            Node p = Start;
            while(p != null)
            {
                if((p.Seat.Column == pColumn) && (p.Seat.Row == pRow))
                {
                    // if node referenced by p satisifies above condition
                    // exit loop
                    break;
                    // this means that p has referenced the node satisfing above condition
                }

                // p will continue traversing the list to reference the node
                // that satisfies condition in IF
                p = p.Next;
            }// End of while

            if(p == null)
            {
                return null;
            }
            else
            {
                return p.Seat;
            }// End of if...else block

        }// End of SearchByRowAndColumn method

    }// End of SeatDoubleLinkedList class

}// End of namespace
