using System;
using Addressbook;

namespace Adressbook
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonService personService = new PersonService();
            MenuActionsService menuActionsService = new MenuActionsService();
            var menu = menuActionsService.GetMenuActions();

            Console.WriteLine("Welcome to addressbook app.");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Select options: ");
                
                for (int i = 0; i < menu.Count; i++)
                {
                    Console.WriteLine($"{menu[i].Id}. {menu[i].Name}");

                }
                Console.WriteLine();
                var operation = Console.ReadKey();
                Console.WriteLine();
                
                switch (operation.KeyChar)
                {
                    case '1':
                        var id = personService.AddNewPerson();
                        break;
                    case '2':
                        var removeId = personService.RemovePersonView();
                        personService.RemovePerson(removeId);
                        break;
                    case '3':
                        personService.ShowPerson();
                        break;
                    case '4':
                        var detailsId = personService.ShowDeatailsPersonView();
                        personService.ShowDetailsPerson(detailsId);
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