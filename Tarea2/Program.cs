// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese cuatro números
        Console.WriteLine("Ingrese el primer número:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer número:");
        double num3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el cuarto número:");
        double num4 = Convert.ToDouble(Console.ReadLine());

        // Calcular la suma de los dos primeros números
        double suma = num1 + num2;

        // Calcular el producto del tercer y cuarto número
        double producto = num3 * num4;

        // Mostrar los resultados
        Console.WriteLine($"La suma de {num1} y {num2} es: {suma}");
        Console.WriteLine($"El producto de {num3} y {num4} es: {producto}");
    }
}
