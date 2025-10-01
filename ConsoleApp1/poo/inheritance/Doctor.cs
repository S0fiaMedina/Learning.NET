using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.poo.inheritance
{
    internal class Doctor : Person 
    {

        private string speciality;

        public Doctor(string name , int age, string speciality) : base(name, age)
        {
            this.speciality = speciality;
            
        }


        // Extiende del metodo del padre 
        public string GetData()
        {
            return GetInfo() + " ESPECIALIDAD : " + this.speciality;
        }
    }
}
