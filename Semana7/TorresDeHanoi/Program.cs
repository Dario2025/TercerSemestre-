using System;
using System.Collections.Generic;

public class Program
{
    static Stack<int> torreA = new Stack<int>();
    static Stack<int> torreB = new Stack<int>();
    static Stack<int> torreC = new Stack<int>();

    public static void Main()
    {
        Console.Write("Ingrese el número de discos: ");
        string? input = Console.ReadLine();

        // Validación segura de entrada
        if (!int.TryParse(input, out int n) || n <= 0)
        {
            Console.WriteLine("Por favor ingrese un número entero positivo válido.");
            return;
        }

        // Apilamos los discos en la torre A (de mayor a menor)
        for (int i = n; i >= 1; i--)
        {
            torreA.Push(i);
        }

        Console.WriteLine("\nMovimientos para resolver Torres de Hanoi:\n");
        ResolverHanoi(n, torreA, torreB, torreC, "A", "B", "C");
    }

    static void MoverDisco(Stack<int> origen, Stack<int> destino, string nombreOrigen, string nombreDestino)
    {
        int disco = origen.Pop();
        destino.Push(disco);
        Console.WriteLine("Mover disco " + disco + " de " + nombreOrigen + " a " + nombreDestino);
    }

    static void ResolverHanoi(int n, Stack<int> origen, Stack<int> auxiliar, Stack<int> destino, string nombreOrigen, string nombreAuxiliar, string nombreDestino)
    {
        if (n == 1)
        {
            MoverDisco(origen, destino, nombreOrigen, nombreDestino);
        }
        else
        {
            ResolverHanoi(n - 1, origen, destino, auxiliar, nombreOrigen, nombreDestino, nombreAuxiliar);
            MoverDisco(origen, destino, nombreOrigen, nombreDestino);
            ResolverHanoi(n - 1, auxiliar, origen, destino, nombreAuxiliar, nombreOrigen, nombreDestino);
        }
    }
}
