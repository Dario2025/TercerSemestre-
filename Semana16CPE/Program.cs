class Nodo
{
    public int Valor;
    public Nodo Izquierdo;
    public Nodo Derecho;

    public Nodo(int valor)
    {
        Valor = valor;
        Izquierdo = null;
        Derecho = null;
    }
}

class ArbolBinarioBusqueda
{
    public Nodo Raiz;

    public ArbolBinarioBusqueda()
    {
        Raiz = null;
    }

    // Insertar un valor en el árbol
    public void Insertar(int valor)
    {
        Raiz = InsertarRecursivo(Raiz, valor);
    }

    private Nodo InsertarRecursivo(Nodo nodo, int valor)
    {
        if (nodo == null)
            return new Nodo(valor);

        if (valor < nodo.Valor)
            nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, valor);
        else if (valor > nodo.Valor)
            nodo.Derecho = InsertarRecursivo(nodo.Derecho, valor);

        return nodo;
    }

    // Recorridos
    public void InOrden(Nodo nodo)
    {
        if (nodo != null)
        {
            InOrden(nodo.Izquierdo);
            Console.Write(nodo.Valor + " ");
            InOrden(nodo.Derecho);
        }
    }

    public void PreOrden(Nodo nodo)
    {
        if (nodo != null)
        {
            Console.Write(nodo.Valor + " ");
            PreOrden(nodo.Izquierdo);
            PreOrden(nodo.Derecho);
        }
    }

    public void PostOrden(Nodo nodo)
    {
        if (nodo != null)
        {
            PostOrden(nodo.Izquierdo);
            PostOrden(nodo.Derecho);
            Console.Write(nodo.Valor + " ");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ArbolBinarioBusqueda arbol = new ArbolBinarioBusqueda();

        // Simulamos datos desde un "archivo de texto" con un arreglo de enteros
        int[] datos = { 50, 30, 70, 20, 40, 60, 80 };

        Console.WriteLine("Insertando valores en el árbol binario...");
        foreach (int valor in datos)
        {
            arbol.Insertar(valor);
        }

        Console.WriteLine("\n--- Reportería del Árbol Binario ---");
        Console.WriteLine("Recorrido InOrden (menor a mayor):");
        arbol.InOrden(arbol.Raiz);

        Console.WriteLine("\n\nRecorrido PreOrden:");
        arbol.PreOrden(arbol.Raiz);

        Console.WriteLine("\n\nRecorrido PostOrden:");
        arbol.PostOrden(arbol.Raiz);

        Console.WriteLine("\n\nEjecución finalizada. Presione una tecla para salir.");
        Console.ReadKey();
    }
}
