using System;
using Addressbook;
using Addressbook.App.Concrete;
using Addressbook.App.Managers;

namespace Adressbook
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuActionsService menuActionsService = new MenuActionsService();
            PeopleManager peopleManager = new PeopleManager();

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
                        var newId = peopleManager.AddNewPerson();
                        break;
                    case ConsoleKey.D2:
                        var removeId = peopleManager.RemovePerson();
                        break;
                    case ConsoleKey.D3:
                        peopleManager.ShowAllPeople();
                        break;
                    case ConsoleKey.D4:
                        var detailsId = peopleManager.ShowPersonDetails();
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