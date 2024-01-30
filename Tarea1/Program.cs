// See https://aka.ms/new-console-template for more information


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la longitud del lado del cuadrado:");

        // Lee el valor del lado desde la entrada del usuario
        string ladoInput = Console.ReadLine();

        // Intenta convertir la entrada a un número
        if (double.TryParse(ladoInput, out double lado))
        {
            // Calcula el perímetro del cuadrado
            double perimetro = CalcularPerimetroCuadrado(lado);

            // Muestra el resultado
            Console.WriteLine($"El perímetro del cuadrado con lado {lado} es: {perimetro}");
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un valor numérico válido para el lado del cuadrado.");
        }
    }

    // Función para calcular el perímetro del cuadrado
    static double CalcularPerimetroCuadrado(double lado)
    {
        return 4 * lado;
    }
}
