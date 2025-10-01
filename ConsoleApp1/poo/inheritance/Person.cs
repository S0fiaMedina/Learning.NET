using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * CLASE PADRE
 */
namespace ConsoleApp1.poo.inheritance
{
    internal class Person
    {
        private string name;
        private int age;

        public Person(string name, int age) {
            this.name = name;
            this.age = age;
        }

        public string GetInfo()
        {
            return "NOMBRE : " + name + " " + " EDAD : " + age;
        }
    }
}
