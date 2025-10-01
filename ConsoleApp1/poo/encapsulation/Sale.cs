using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.poo.encapsulation
{
    internal class Sale
    {
        int id;
        DateTime time;
        private int total; // atributo privado
        public int Total // Prop publica
        {
            get { return total; }
            set // setter con logica 
            {
                if (value > 0)
                {
                    total = value;
                }
                total = 0;
            }
        }
        public string TotalFormateado
        {
            get { return total.ToString("#.00"); } // lo formatea a decimal con 2 ceros
        }





        // Constructor sin argumentos
        public Sale()
        {
            id = 1;
            time = DateTime.Now;
        }

        // Constructor con argumentos 
        public Sale(int id, DateTime time)
        {
            this.id = id;
            this.time = time;
        }


        /**
         * METODOS DE CLASE
         */
        public void Show()
        {
            Console.WriteLine("Hola, Soy sale");
        }

        public string GetInfo()
        {
            return "SI " + ":)";
        }

        // eSto es una propiedad



        // Esta es una forma recortada de escribirlo    
        //public int Total { get; set; }

    }
}
