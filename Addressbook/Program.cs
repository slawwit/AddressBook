using System;
using Addressbook;

namespace Adressbook
{
    class Program
    {
        static void Main(string[] args)
        {
            PeopleService peopleService = new PeopleService();
            MenuActionsService menuActionsService = new MenuActionsService();
            var menu = menuActionsService.GetMenuActions();
            Console.WriteLine("Welcome to addressbook app.");
            var operation = new ConsoleKeyInfo();
            while (operation.Key != ConsoleKey.D0)
            {
                Console.WriteLine();
                Console.WriteLine("Select options: ");

                for (int i = 0; i < menu.Count; i++)
                {
                    Console.WriteLine($"{menu[i].Id}. {menu[i].Name}");

                }
                Console.WriteLine();
                operation = Console.ReadKey();
                Console.WriteLine();

                switch (operation.Key)
                {
                    case ConsoleKey.D1:
                        var id = peopleService.AddNewPersonView();
                        break;
                    case ConsoleKey.D2:
                        var removeId = peopleService.RemovePersonView();
                        break;
                    case ConsoleKey.D3:
                        peopleService.ShowPersons();
                        break;
                    case ConsoleKey.D4:
                        var detailsId = peopleService.ShowDetailsPersonView();
                        break;
                    case ConsoleKey.D0:
                        Console.WriteLine("Bye");
                        break;
                    default:
                        Console.WriteLine("I don't know what do you want to do.!!");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}