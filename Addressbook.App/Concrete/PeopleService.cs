using System;
using Addressbook.App.Common;
using Addressbook.Domain;
using Addressbook.Domain.Entity;

namespace Addressbook.App.Concrete
{
    public class PeopleService : BaseService<Person>
    {
        //public int RemovePersonView()
        //{
        //    Console.WriteLine("Please enter the id of person you want to remove:");
        //    int personId = GetPersonId();
        //    RemovePerson(personId);
        //    return personId;
        //}

        //private void RemovePerson(int removeId)
        //{
        //    foreach (var person in People)
        //    {
        //        if (person.Id == removeId)
        //        {
        //            People.Remove(person);
        //            break;
        //        }
        //    }
        //}

        //public int ShowPersonDetailsView()
        //{
        //    Console.WriteLine("Please enter the id of the person you want to show:");
        //    int personId = GetPersonId();
        //    ShowPersonDetails(personId);
        //    return personId;
        //}

        //private void ShowPersonDetails(int detailsId)
        //{
        //    foreach (var person in People)
        //    {
        //        if (person.Id == detailsId)
        //        {
        //            Console.WriteLine("----------------------");
        //            Console.WriteLine($"Id: {person.Id}");
        //            Console.WriteLine($"First Name: {person.FirstName}");
        //            Console.WriteLine($"Last Name: {person.LastName}");
        //            Console.WriteLine($"Email: {person.Email}");
        //            Console.WriteLine($"Phone Number: {person.PhoneNumber}");
        //            Console.WriteLine("----------------------");
        //        }
        //    }
        //}
    }
}
