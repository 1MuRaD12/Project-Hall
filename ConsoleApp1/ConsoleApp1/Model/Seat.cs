using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    internal class Seat
    {
        public byte Row { get; set; }
        public byte Coloumn { get; set; }
        public bool IsFull { get; set; }

        public Seat(byte row,byte coloumn,bool status = false)
        {
            Row = row;
            Coloumn = coloumn;
            IsFull = status;
        }
        public override string ToString()
        {
            return $"Row:{Row} Column:{Coloumn} Status:{(IsFull ? "Full" : "Empty")}";
        }
    }
}
