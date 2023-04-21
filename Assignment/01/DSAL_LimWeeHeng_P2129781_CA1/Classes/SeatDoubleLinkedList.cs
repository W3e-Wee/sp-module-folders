using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DSAL_Assignment1.Classes
{
    [Serializable]
    internal class SeatDoubleLinkedList
    {
        public Node Start { get ; set; } // Start property

        public SeatDoubleLinkedList()
        {
            Start = null;
        }// End of constructor

        public void InsertAtEnd(Seat pSeatData)
        {
            Node newNode = new Node(pSeatData);

            if(Start == null)
            {
                Start = newNode;
                return;
            }

            Node p = Start;

            // traverses doubly-linked-list till
            // it references the last node
            while (p.Next != null)
            {
                p = p.Next;
            }// End of while

            p.Next = newNode;
            newNode.Prev = p;
            
        }// End of InsertAtEnd

        public Seat SearchByRowAndColumn(int pRow, int pColumn)
        {
            Node p = Start;
            while(p != null)
            {
                if((p.Seat.Column == pColumn) && (p.Seat.Row == pRow))
                {
                    // if node referenced by p satisifies above condition
                    // exit loop
                    p.Seat.Parent = p;
                    break;
                }

                // continue traversing the list
                p = p.Next;
            }// End of while

            if (p == null)
            {
                return null;
            }
            else
            {
                return p.Seat;
            }// End of IF...ELSE block

        }// End of SearchByRowAndColumn

        public List<Label> GenerateLabels()
        {
            List<Label> labels = new List<Label>();
            Node p = this.Start;
            while (p != null)
            {
                Label labelSeat = p.Seat.CreateLabel();
                labels.Add(labelSeat);

                p = p.Next; //Continue to the next node
            }//While loop
            if (p == null)
            {
                return labels;
            }
            else
            {
                return labels;
            }//End of if..else block
        }//End of GenerateLabels

    }// End of SeatDoubleLinkedList

}// End of namespace
