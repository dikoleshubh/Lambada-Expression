using System;
using System.Collections.Generic;
using System.Text;

namespace LambadaExpression
{
    class PersonList

    { //UC1 person management
        List<Person> list = new List<Person>();
        public static void AddingPersonDetails(List<Person> personList) //creating method
        {
            personList.Add(new Person() { SSN = 1, Age = 16, Name = "EDUGAWA", Address = "Pune" });
            personList.Add(new Person() { SSN = 2, Age = 18, Name = "CONAN", Address = "Pune" });
            personList.Add(new Person() { SSN = 3, Age = 25, Name = "JOHN", Address = "Bangalore" });
            personList.Add(new Person() { SSN = 5, Age = 75, Name = "SNOW", Address = "pune" });
            personList.Add(new Person() { SSN = 6, Age = 86, Name = "NED", Address = "KINGS LANDING" });
            personList.Add(new Person() { SSN = 7, Age = 56, Name = "STARK", Address = "KINGS LANDING" });
            IterateOverList(personList);
        }
        public static void IterateOverList(List<Person> personlist)
        {
            foreach (Person person in personlist)
            {
                Console.WriteLine("Age\t" + person.Age + "\t" + "Name\t" + person.Name + "\t" + "Address\t" + person.Address);
            }
        }
    }
}
