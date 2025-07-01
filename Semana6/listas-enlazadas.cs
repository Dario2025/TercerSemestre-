using System;

// Clase Nodo: representa cada elemento de la lista enlazada
class Nodo
{
    public int Dato;           // Valor que guarda el nodo
    public Nodo Siguiente;     // Referencia al siguiente nodo

    // Constructor que recibe un dato y lo asigna al nodo
    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

// Clase ListaEnlazada: maneja la lógica de la lista enlazada
class ListaEnlazada
{
    public Nodo Cabeza;  // Primer nodo de la lista

    // Constructor: inicializa la lista vacía
    public ListaEnlazada()
    {
        Cabeza = null;
    }

    // Método para agregar un nuevo nodo al final de la lista
    public void Agregar(int dato)
    {
        Nodo nuevo = new Nodo(dato); // Crear un nuevo nodo
        if (Cabeza == null) // Si la lista está vacía, el nuevo nodo será la cabeza
        {
            Cabeza = nuevo;
        }
        else
        {
            // Si no está vacía, buscar el último nodo y agregar el nuevo allí
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    // Método que cuenta cuántos nodos hay en la lista
    public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = Cabeza;
        // Recorre toda la lista y cuenta cada nodo
        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }
        return contador;
    }

    // Método que invierte el orden de la lista enlazada
    public void Invertir()
    {
        Nodo anterior = null;
        Nodo actual = Cabeza;
        Nodo siguiente = null;

        // Cambia las referencias de cada nodo para invertir la lista
        while (actual != null)
        {
            siguiente = actual.Siguiente;    // Guarda el siguiente nodo
            actual.Siguiente = anterior;     // Invierte la dirección del enlace
            anterior = actual;               // Mueve el puntero anterior
            actual = siguiente;              // Mueve el puntero actual
        }

        Cabeza = anterior; // El último nodo se convierte en la nueva cabeza
    }

    // Método para mostrar todos los elementos de la lista
    public void Mostrar()
    {
        Nodo actual = Cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null"); // Marca el final de la lista
    }
}

// Clase principal con el método Main para probar todo
class Program
{
    static void Main()
    {
        // Crear una nueva lista enlazada
        ListaEnlazada lista = new ListaEnlazada();

        // Agregar algunos elementos a la lista
        lista.Agregar(10);
        lista.Agregar(20);
        lista.Agregar(30);
        lista.Agregar(40);

        // Mostrar la lista original
        Console.WriteLine("Lista original:");
        lista.Mostrar();

        // Contar y mostrar cuántos elementos hay en la lista
        Console.WriteLine("Cantidad de elementos: " + lista.ContarElementos());

        // Invertir la lista
        lista.Invertir();

        // Mostrar la lista ya invertida
        Console.WriteLine("Lista invertida:");
        lista.Mostrar();
    }
}
