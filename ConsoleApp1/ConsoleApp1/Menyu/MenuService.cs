using ConsoleApp1.Helpers;
using ConsoleApp1.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Menyu
{
    static class MenuService
    {
        public static CinemaService cinemaService = new CinemaService();
        public static void CreateHallMenu()
        {
            Console.WriteLine("please enter row value: ");
            byte row;
            bool rowresault = byte.TryParse(Console.ReadLine(), out row);
            Console.WriteLine("olease enter column value: ");
            byte col;
            bool colresault = byte.TryParse(Console.ReadLine(), out col);
            Console.WriteLine("please enter catagory");
            foreach (var item in Enum.GetValues(typeof(Catagory)))
            {
                Console.WriteLine($"{(int)item}. {item}");
            }

            object cg;
            bool catagoryresault = Enum.TryParse(typeof(Catagory), Console.ReadLine(), out cg);
            if (catagoryresault)
            {
                if (cg is Catagory)
                {
                    Catagory catagory = (Catagory)cg;

                    string no = cinemaService.CreateHall(row, col, catagory);
                    Console.WriteLine($"{no}=> Hall succesfully created");
                }
            }
        }

        public static void EditHallMenu()
        {
            Console.WriteLine("plesae enter hall no which you wont to chargo");
            string OldNo = Console.ReadLine();
            Console.WriteLine("please enter new hall no");
            string NewNo = Console.ReadLine();
            cinemaService.EditHall(OldNo, NewNo);
        }

        public static void GetAllHallMenu()
        {

            cinemaService.GetAllHalls();
        }

        public static void GetAllSeatsMenu()
        {
            Console.WriteLine("plase enter hall no");
            string no = Console.ReadLine();
            cinemaService.GetAllSeats(no);
        }

        public static void ReservMenu()
        {
            Console.WriteLine("plase enter Row no");
            byte row;
            bool rowrevers = byte.TryParse(Console.ReadLine(), out row);
            Console.WriteLine("plase enter column no");
            byte col;
            bool colrevers = byte.TryParse(Console.ReadLine(), out col);
            Console.WriteLine("please hall no");
            string no = Console.ReadLine();
            cinemaService.Reserve(row,col,no);

        }
    }
}
