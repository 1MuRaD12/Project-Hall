using ConsoleApp1.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    internal class Hall
    {
        public string No { get; set; }

        public Catagory Catagory { get; set; }

        public Seat [,] seats { get; set; }

        private static  int Count = 1; 

        public Hall(byte row, byte coloumn, Catagory catagory)
        {
            switch (catagory)
            {
                case Catagory.Sci_Fi:
                    No = $"SF - {Count}";
                    break;
                case Catagory.Comedy:
                    No = $"C - {Count}";
                    break;
                case Catagory.Thriller:
                    No = $"T - {Count}";
                    break;
                case Catagory.Drama:
                    No = $"D - {Count}";
                    break;
                case Catagory.Action:
                    No = $"A - {Count}";
                    break;
                case Catagory.Horror:
                    No = $"H - {Count}";
                    break;
                default:
                    break;
                   
            }
            Catagory = catagory;
            seats = new Seat[row, coloumn];
            for (byte i = 0; i < row; i++)
            {
                for (byte j = 0; j < coloumn; j++)
                {
                    Seat seat = new Seat((byte)(i+1),(byte)(j +1));
                    seats[i, j] = seat;
                }
            }
            Count++;
        }
        public override string ToString()
        {
            return $"Hall no:{No}, Catagory:{Catagory}";
        }
    }
}
