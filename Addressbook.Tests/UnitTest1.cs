
using Addressbook.App.Abstract;
using Addressbook.App.Concrete;
using Addressbook.App.Managers;
using Addressbook.Domain.Entity;
using FluentAssertions;
using Moq;

namespace Addressbook.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange
        Person person = new Person(2, "Adam", "Miałzcyński", "Addressbook@wp.pl", "777777777");
        var mock = new Mock<IService<Person>>();
        mock.Setup(s => s.GetItemById(2)).Returns(person);

        var manager = new PeopleManager(mock.Object);
        //Act

        var result = manager.GetItemById(person.Id);
        //Assert
        result.Should().NotBeNull();
        result.Should().BeOfType(typeof(Person));
        result.Should().BeSameAs(person);

    }

    [Fact]
    public void Test2()
    {
        //Arrange
        Person person = new Person(2, "Adam", "Miałzcyński", "Addressbook@wp.pl", "777777777");
        IService<Person> peopleService = new PeopleService();
        peopleService.AddItem(person);
        var manager = new PeopleManager(peopleService);
        //Act
        manager.RemovePerson();
        //Assert


    }
}
