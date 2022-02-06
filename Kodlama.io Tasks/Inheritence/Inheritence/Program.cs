﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
              new Customer{FirstName = "Emre", LastName = "Değirmenci", City ="İstanbul", Id = 1},
              new Student{FirstName = "Engin" },
              new Person{FirstName = "Salih"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
  
    class Customer : Person // Bir class'ın sadece 1 tane base class'ı olabilir.
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
}
