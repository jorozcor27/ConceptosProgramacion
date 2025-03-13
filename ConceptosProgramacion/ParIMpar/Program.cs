// Construir un programa que pida un número y luego diga si este número es par o no.


do
{
    Console.Write("INGRESAR NUMERO:");
    var numeroString = Console.ReadLine();
    var numeroInt = int.Parse(numeroString!);
    if (numeroInt % 2 == 0)
    {
        Console.WriteLine("el numero es par");
    }
    else
    {
        Console.WriteLine("el numero es impar");
    }
}while (true);
