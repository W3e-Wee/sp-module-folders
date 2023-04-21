using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Prep_Exercise_1.Classes
{
    // Manages the double linked list
    class SeatManager
    {
        // declare double linked list data type
        DoubleLinkedList _seats;
        public SeatManager()
        {
            _seats = new DoubleLinkedList();
        }
        public Seat InsertOneSeat(int row, int column)
        {
            // Declare Seat object
            Seat newSeat = new Seat();

            // Set up Seat object
            newSeat.Row = row;
            newSeat.SeatNumber = column;
            newSeat.CanBook = true;

            // Insert the Seat object into double linked list
            _seats.InsertAtEnd(newSeat);
            return newSeat;
        }// End of InsertOneSeat

        public Seat FindOneSeatToBook(int row, int column)
        {
            Seat seat = _seats.SearchByRowAndColumn(row, column);
            seat.BookStatus = true;
            return seat;
        }// End of FindOneSeatToBook

        public Seat FindOneSeatToUnbook(int row, int column)
        {
            Seat seat = _seats.SearchByRowAndColumn(row, column);
            seat.BookStatus = false;
            return seat;
        }// End of FindOneSeatToUnbook

    }// End of SeatManager class

} // End of namespace
