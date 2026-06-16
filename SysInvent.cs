using System;

class Almacenpues
{
    //constante entera que define el limite maximo de "items" en el almacen
    const int MAX = 100;

    //los arreglos, cada [] guarda datos de su tipo especifico: string, double, int
    static string[] codigos = new string[MAX];
    static string[] nombres = new string[MAX];

    static double[] precios = new double[MAX];
    static double[] danos = new double[MAX];
    static double[] precisiones = new double[MAX];
    static double[] alcances = new double[MAX];

    static int[] stocks = new int[MAX];

    //cuenta cuantas armas existen actualmente en el almacen
    static int cantidad = 0;

    //inicio del programa en si
    static void Main()
    {
        Console.Clear();

        Console.WriteLine("=============================================================");
        Console.WriteLine("                      ALMACEN DE ARMAS");
        Console.WriteLine("=============================================================");
        Console.WriteLine("\nPresione ENTER para acceder al almacen...");
        Console.ReadLine();

        //este readline hace la magia

        int opcion;

        //parece que esta en el aire pero sirve para que
        //"do" y "while" lean la respuesta

        do
        {
            Console.Clear();

            //ya existe el almacen aunque este vacio en principio

            Console.WriteLine("====================================================================================================");
            Console.WriteLine("| Codigo | Nombre | Precio | Dano | Precision | Alcance | Stock |");
            Console.WriteLine("====================================================================================================");

            //ahora si existen armas, por eso waah recorre
            //desde la posicion 0 hasta la ultima registrada

            for (int waah = 0; waah < cantidad; waah++)
            {
                Console.WriteLine(
                    $"| {codigos[waah]} " +
                    $"| {nombres[waah]} " +
                    $"| {precios[waah]} " +
                    $"| {danos[waah]} " +
                    $"| {precisiones[waah]} " +
                    $"| {alcances[waah]} " +
                    $"| {stocks[waah]} |");
            }

            Console.WriteLine("====================================================================================================");

            //por ahora solo existen dos opciones
            //mas adelante deberian aparecer buscar, editar, eliminar, etc.

            Console.WriteLine("\n1. Anadir arma");
            Console.WriteLine("2. Salir");

            Console.Write("\nSeleccione una opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    Console.Clear();

                    Console.WriteLine("======================================");
                    Console.WriteLine("      ANADIR NUEVA ARMA AL ALMACEN");
                    Console.WriteLine("======================================");

                    Console.WriteLine("\nComplete las especificaciones necesarias");
                    Console.WriteLine("del articulo.\n");

                    Console.Write("Codigo: ");
                    codigos[cantidad] = Console.ReadLine();

                    Console.Write("Nombre: ");
                    nombres[cantidad] = Console.ReadLine();

                    Console.Write("Precio: ");
                    precios[cantidad] = double.Parse(Console.ReadLine());

                    Console.Write("Dano: ");
                    danos[cantidad] = double.Parse(Console.ReadLine());

                    Console.Write("Precision: ");
                    precisiones[cantidad] = double.Parse(Console.ReadLine());

                    Console.Write("Alcance: ");
                    alcances[cantidad] = double.Parse(Console.ReadLine());

                    Console.Write("Stock: ");
                    stocks[cantidad] = int.Parse(Console.ReadLine());

                    //si se llega hasta aqui significa que
                    //todos los datos ya fueron guardados

                    cantidad++;

                    Console.WriteLine("\nArma agregada correctamente.");

                    //para que el usuario tenga tiempo de ver la pantalla
                    //quizas deba añadir una funcion para editar antes de almacenar
                    //pero si habra una directamente de editar despues de almacenar

                    Console.ReadKey();
                    break;

                case 2:

                    //la unica forma legal de escapar del almacen

                    Console.WriteLine("\nSaliendo del sistema...\n");
                    break;

                default:

                    //si escribe cualquier otra cosa

                    Console.WriteLine("\nOpcion invalida.");
                    Console.ReadKey();
                    break;
            }

        } while (opcion != 2);

        //mientras opcion sea distinta de 2
        //el almacen seguira funcionando
    }
}