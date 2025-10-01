// See https://aka.ms/new-console-template for more information
using ConsoleApp1.poo.encapsulation;
using ConsoleApp1.poo.inheritance;
using System.Numerics;


/**
 * CLASES Y ENCAPSULACION
 * 
 */
Console.WriteLine("Hello, World!");
Sale sale1 = new Sale();
Console.WriteLine("Valor de TOTAL de SALE : " + sale1.Total);
sale1.Total = 100;
Console.WriteLine("Nuevo valor de TOTAL de SALE : " + sale1.Total);
Console.WriteLine("TOTAL FORMATEADO: " + sale1.TotalFormateado);




/**
 * HERENCIA 
 */

Console.WriteLine("------------------- HERENCIA ----------------------");
Doctor doc = new Doctor("Juan", 45, "cardiologo");
Console.WriteLine(doc.GetInfo()); // Metodo del padre
Console.WriteLine(doc.GetData()); // Metodo del hijo


/**
 * SOBRECARGA DE METODOS
 */

Console.WriteLine("------------------- SOBRECARGA DE METODOS ----------------------");
Mathe mate = new Mathe();
Console.WriteLine(mate.Sum("1", "2")); // por sring
Console.WriteLine(mate.Sum(1, 2)); // por nums

int[] n = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine(mate.Sum(n)); // por array 


