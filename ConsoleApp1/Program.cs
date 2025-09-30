// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Sale sale1 = new Sale();
Console.WriteLine(sale1.GetInfo());



/**
 * CREAR CLASES
 */
class Sale
{
    int id;
    DateTime time;


    // Constructor sin argumentos
    public Sale()
    {
        this.id = 1;
        this.time = DateTime.Now;
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
}
