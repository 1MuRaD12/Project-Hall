using ConsoleApp1.Helpers;
using ConsoleApp1.Interface;
using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Service
{
    internal class CinemaService : ICinemaServices
    {
        private List<Hall> _hall = new List<Hall>();

        public List<Hall> halls => _hall;

        public string CreateHall(byte row, byte col, Catagory catagory)
        {
            if (row <= 0 || col <= 0)
            {
                return "plase choose valid row or column value ";
            }
            Hall hall = new Hall(row, col, catagory);
            _hall.Add(hall);
            return hall.No;

        }

        public void EditHall(string OldNo, string NewNo)
        {
            Hall hall = _hall.FirstOrDefault(h => h.No.ToLower().Trim() == OldNo.ToLower().Trim());
            if (hall != null)
            {
                Hall exstedHall = _hall.FirstOrDefault(h => h.No.ToLower().Trim() == NewNo.ToLower().Trim());
                if (hall == null)
                {
                    hall.No = NewNo;
                }
                else
                {
                    Console.WriteLine($"This all already exist => {NewNo.ToUpper().Trim()}");
                }
            }
            else
            {
                Console.WriteLine($"There is no hall => {OldNo.ToUpper().Trim()}");
            }
        }

        public void GetAllHalls()
        {
            if (_hall.Count > 0)
            {
                foreach (Hall hall in _hall)
                {
                    Console.WriteLine(hall);
                }
            }
        }

        public void GetAllSeats(string no)
        {
            Hall hall = _hall.FirstOrDefault(h => h.No.ToLower().Trim() == no.ToLower().Trim());

            if (hall != null)
            {
                foreach (Seat seat in hall.seats)
                {
                    Console.WriteLine(seat);
                }
            }
            else
            {
                Console.WriteLine("please choose valid hall no");
            }
        }

        public void Reserve(byte row, byte col, string no)
        {
            if (string.IsNullOrEmpty(no) || string.IsNullOrWhiteSpace(no))
            {
                Console.WriteLine("please enter valid row or column no");
                return;
            }
            if (row <= 0 || col <= 0)
            {
                Console.WriteLine("please enter valid row or column value");
                return;
            }
            Hall hall = _hall.FirstOrDefault(h => h.No.ToLower().Trim() == no.ToLower().Trim());
            if (hall == null)
            {
                Console.WriteLine("please enter valid hall no");
                return;
            }
            if (row > hall.seats.GetLength(0) || col > hall.seats.GetLength(1))
            {
                Console.WriteLine("please enter valid row or column value");
                return;
            }
            if (!hall.seats[row - 1, col - 1].IsFull)
            {
                hall.seats[row - 1, col - 1].IsFull = true;
                Console.WriteLine("Seat succesfully reserved");
            }
            else
            {
                Console.WriteLine("This seat has already reserve \n Please choos another seat");
                GetAllSeats(no);
            }
        }
    }
}
