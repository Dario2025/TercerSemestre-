class Program
{
    // Diccionario Español -> Inglés
    static Dictionary<string, string> diccionario = new Dictionary<string, string>()
    {
        {"tiempo", "time"},
        {"persona", "person"},
        {"año", "year"},
        {"camino", "way"},
        {"día", "day"},
        {"cosa", "thing"},
        {"hombre", "man"},
        {"mundo", "world"},
        {"vida", "life"},
        {"mano", "hand"},
        {"ojo", "eye"},
        {"mujer", "woman"},
        {"lugar", "place"},
        {"trabajo", "work"},
        {"semana", "week"},
        {"caso", "case"},
        {"punto", "point"},
        {"gobierno", "government"},
        {"empresa", "company"}
    };

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabra al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    TraducirFrase();
                    break;
                case 2:
                    AgregarPalabra();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del traductor...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }

    static void TraducirFrase()
    {
        Console.Write("Ingrese una frase en español: ");
        string frase = Console.ReadLine();

        string[] palabras = frase.Split(' ');
        string traduccion = "";

        foreach (string palabra in palabras)
        {
            string minuscula = palabra.ToLower();

            if (diccionario.ContainsKey(minuscula))
            {
                traduccion += diccionario[minuscula] + " ";
            }
            else
            {
                traduccion += palabra + " ";
            }
        }

        Console.WriteLine("Traducción: " + traduccion);
    }

    static void AgregarPalabra()
    {
        Console.Write("Ingrese la palabra en español: ");
        string espanol = Console.ReadLine().ToLower();

        Console.Write("Ingrese su traducción en inglés: ");
        string ingles = Console.ReadLine().ToLower();

        if (!diccionario.ContainsKey(espanol))
        {
            diccionario.Add(espanol, ingles);
            Console.WriteLine("Palabra agregada correctamente.");
        }
        else
        {
            Console.WriteLine("Esa palabra ya existe en el diccionario.");
        }
    }
}
