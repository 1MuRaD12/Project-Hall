using ConsoleApp1.Helpers;
using ConsoleApp1.Menyu;
using ConsoleApp1.Service;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whelcome to our Cinema");
            int selection;
            do
            {


                Console.WriteLine("1  CreateHall");
                Console.WriteLine("2  EditHall");
                Console.WriteLine("3  GetAllHalls");
                Console.WriteLine("4  GetAllSeats");
                Console.WriteLine("5  Reserve");
                Console.WriteLine("0  Exit");
                bool result = int.TryParse(Console.ReadLine(), out selection);
                Console.Clear();
                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            MenuService.CreateHallMenu();
                            break;
                        case 2:
                            MenuService.EditHallMenu();
                            break;
                        case 3:
                            MenuService.GetAllHallMenu();
                            break;
                        case 4:
                            MenuService.GetAllSeatsMenu();
                            break;
                        case 5:
                            MenuService.ReservMenu();
                            break;
                        default:
                            break;
                    }
                }
            } while (selection != 0);
        }
    }
}
