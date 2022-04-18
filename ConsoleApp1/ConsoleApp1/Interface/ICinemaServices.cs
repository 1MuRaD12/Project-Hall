using ConsoleApp1.Helpers;
using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interface
{
    internal interface ICinemaServices
    {
        List<Hall> halls { get; }
      string CreateHall(byte row, byte col, Catagory catagory);
        void EditHall(string OldNo, string NewNo);
        void GetAllHalls();
        void GetAllSeats(string no);
        void Reserve(byte row, byte col, string no);
        
    }
}
