using System;

class Almacenpues
{
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

            //aqui deberia mostrarse el almacen en general, justo aaaaquiii
            //por ahora esta vacio porque aun no existen armas

            Console.WriteLine("====================================================================================================");
            Console.WriteLine("| Codigo | Nombre | Precio | Dano | Precision | Alcance | Stock |");
            Console.WriteLine("====================================================================================================");

            //aqui en algun momento deberian aparecer las armas
            //pero todavia no existe ninguna forma de guardarlas

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

                    //todavia no existe ninguna forma de escribir
                    //ni guardar datos, esta pantalla es puramente la "cara"

                    Console.WriteLine("Codigo:");
                    Console.WriteLine();

                    Console.WriteLine("Nombre:");
                    Console.WriteLine();

                    Console.WriteLine("Precio:");
                    Console.WriteLine();

                    Console.WriteLine("Dano:");
                    Console.WriteLine();

                    Console.WriteLine("Precision:");
                    Console.WriteLine();

                    Console.WriteLine("Alcance:");
                    Console.WriteLine();

                    Console.WriteLine("Stock:");

                    Console.WriteLine("\n(Version en construccion)");

                    //para que el usuario tenga tiempo de ver la pantalla

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