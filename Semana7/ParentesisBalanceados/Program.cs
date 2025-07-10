using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Mensaje inicial para explicar el propósito del programa
        Console.WriteLine("Verificación de paréntesis balanceados en una expresión matemática.");
        
        // Solicitar al usuario que ingrese una expresión matemática
        Console.Write("Ingresa una expresión matemática: ");
        string expresion = Console.ReadLine();

        // Llamar a la función que verifica si los paréntesis están balanceados
        bool estanBalanceados = VerificarParentesisBalanceados(expresion);

        // Mostrar el resultado al usuario
        if (estanBalanceados)
        {
            Console.WriteLine("Los paréntesis están balanceados.");
        }
        else
        {
            Console.WriteLine("Los paréntesis NO están balanceados.");
        }
    }

    // Función que verifica el balance de paréntesis usando una pila (stack)
    static bool VerificarParentesisBalanceados(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        // Recorrer cada caracter de la expresión ingresada
        foreach (char c in expresion)
        {
            // Si el caracter es un paréntesis de apertura, se agrega a la pila
            if (c == '(')
            {
                pila.Push(c);
            }
            // Si el caracter es un paréntesis de cierre
            else if (c == ')')
            {
                // Si la pila está vacía, significa que no hay paréntesis de apertura para emparejar
                if (pila.Count == 0)
                    return false;

                // Si hay un paréntesis de apertura en la pila, se elimina (empareja)
                pila.Pop();
            }
        }

        // Al final, si la pila está vacía, todos los paréntesis están balanceados
        return pila.Count == 0;
    }
}
