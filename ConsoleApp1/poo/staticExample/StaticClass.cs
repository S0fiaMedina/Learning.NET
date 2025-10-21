using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.poo.staticExample
{
    internal class StaticClass
    {

        // Propiedad estática
        public static int count = 0;

        // Propiedades requeridas
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        // Constructor
        public StaticClass(int num1, int num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
            count++; // opcional, ejemplo de uso de la propiedad estática
        }


        public static string GetCount() 
        {
            return $"Esta clase se ha instanciado {count} veces";
        }
    }
}
