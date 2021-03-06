using System;
using System.Collections.Generic;
using System.Text;
namespace OOP_4
{
    class Person
    {
        string firstname;
        string lastname;
        int age;

        public Person(string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        public string LastName //Property
        {
            get
            {
                return lastname; //Returns the value of a field
            }
            set
            {
                lastname = value; //Sets the value of a field
            }
        }
        public string FirstName //Property
        {
            get
            {
                return firstname; //Returns the value of a field
            }
            set
            {
                if (value.Length > 1)
                    firstname = value; //Sets the value of a field
                else Console.WriteLine("Name is too short");
            }
        }
        public int Age //Property
        {
            get
            {
                return age; //Returns the value of a field
            }
            set
            {
                if (value > 0)
                    age = value; //Sets the value of a field
                else age = 18;
            }
        }
    }
    class Program
    {
        static void Main (string[] args)
        {
            Person p = new Person("Willard", "Smith", 55);

            Console.WriteLine($"Name: {p.FirstName}\t Age: {p.Age}");

            p.Age = 56;
            Console.WriteLine($"Name: {p.FirstName}\t Age: {p.Age}");

            p.FirstName = "Will";
            Console.WriteLine($"New name: {p.FirstName}");
        }
    }
}