using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_Iterator
{
    public class Person
    {
        private string Name { get; set; }
        private int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }


        public string GetName()
        {
            return this.Name;
        }
        public Person AddPerson(string name, int age)
        {
            return new Person(name, age);
        }
        
        public override string ToString()
        {
            return $"Nome: {Name}, Idade: {Age}";
        }
    }

}
