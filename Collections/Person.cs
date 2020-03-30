using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person()
        {

        }
        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public static void ShowPerson(Person p)
        {
            Console.WriteLine($"Возраст:{p.Age} Имя:{p.Name}");
        }
    }
}
