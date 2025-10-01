using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.poo.encapsulation
{
    internal class Mathe
    {


        // SOBRE CARGA DE METODOS 
        public int Sum(int x, int y) {  return x + y; }

        public int Sum(string x, string y) { return int.Parse(x) +  int.Parse(y); }

        public int Sum(int[] a )
        {
            int result = 0;
            int i = 0;
            while (i < a.Length)
            {
                result += a[i];
                i++;
            }
            return result;
        }



    }
}
