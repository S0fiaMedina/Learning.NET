using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.poo.interfaceExample
{

    // INTERFAZ 1 
    interface IAnimal
    {

        public string Name { get; set; }


    }

    // INTERFAZ 2 
    interface IFish
    {


        public int Speed { get; set; }


        public String Swim(int speed);
    }


    // CLASE QUE IMPLEMENTA 2 INTERFACES
    class Shark : IAnimal, IFish
    {
        public int Speed { get; set; }
        public string Name { get; set; }

        public string Swim(int speed)
        {

            return $"Tiburin nada a {speed} Km por hora... Su nombre es {this.Name}";
        }
    }



    //  EJECUCION
    class ExecutionExample()
    {
        public static  void ExampleExecution()
        {
            Shark[] Sharks = new Shark[] {
                new Shark(),
                new Shark()
            };

            // COmo solo herreda de IAnimal no tendra los emtodos de Fish
            IAnimal sharkie = new Shark();
            sharkie.Name = Sharks[0].Name;
        }
    }
}
