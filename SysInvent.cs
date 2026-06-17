using System;
using System.Diagnostics;

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

            //ya existe el almacen -
            //correji la presentacion del almacen

            Console.WriteLine("\n\n====================================================================================================");
            Console.WriteLine("| Codigo    | Nombre                   | Precio    | Daño      | Precision   | Alcance   | Stock   |");
            Console.WriteLine("====================================================================================================");

            //ahora si existen armas, por eso waah recorre
            //desde la posicion 0 hasta la ultima registrada

            for (int waah = 0; waah < cantidad; waah++)
            {
                Console.WriteLine(

                    //puse limite a... los caracteres que se pueden usar
                    $"| {codigos[waah],-10}" +
                    $"| {nombres[waah],-25}" +
                    $"| {precios[waah],-10}" +
                    $"| {danos[waah],-10}" +
                    $"| {precisiones[waah],-12}" +
                    $"| {alcances[waah],-10}" +
                    $"| {stocks[waah],-8} |");
            }

            Console.WriteLine("====================================================================================================");

            //por ahora solo existen dos opciones
            //mas adelante deberian aparecer buscar, editar, eliminar, etc.

            Console.WriteLine("\n1. Anadir arma");
            Console.WriteLine("2. Salir");
            System.Console.WriteLine("3. Buscar arma por código");
            System.Console.WriteLine("4. Modificar atributos de arma existente");
            //añadiendo sistema de insertar  y eliminar arma
            System.Console.WriteLine("5. Insertar arma en posicion especifica");
            System.Console.WriteLine("6. Eliminar arma");
            //funcion para ordenar implementada!
            Console.WriteLine("7. Ordenar arsenal por precio");
            //"estasdisticas" implementadas - jim carrey referencia
            Console.WriteLine("8. Ver estadisticas del arsenal");

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
                case 3:
                    //sistema de busqueda
                    BuscarArmaPorCodigo();
                    break;
                case 4:
                    ModificarArmaPorCodigo();
                    break;
                case 5:
                //Sistema de inserción de la posición de arma
                    InsertarPosicionDeArma();
                    break;
                case 6:
                //Sistema de eliminación de arma
                    EliminarArma();
                    break;
                //Siempre y ante todo, el orden!
                case 7:
                    OrdenarArsenalPoorPrecio();
                    break;
                //LAs estadisticas tambien son importantes
                case 8:
                    MostrarEstadisticas();
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
    //Parte 2 - metodo de busqueda por ID
    static void BuscarArmaPorCodigo()
    {
        Console.Clear();
        System.Console.WriteLine("====================================================");
        System.Console.WriteLine("               BUSCAR ARMA POR CODIGO               ");
        System.Console.WriteLine("====================================================");

        if(cantidad==0)
        {
            System.Console.WriteLine("El almacén está vacío, no hay armas registradas para buscar.");
            System.Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            return;
        }
        System.Console.WriteLine("Ingrese el código del arma que desee buscar: ");
        string codigoBuscar=Console.ReadLine().Trim();

        bool encontrado=false;

        for(int i=0;i<cantidad;i++)
        {
            if(codigos[i].Equals(codigoBuscar,StringComparison.OrdinalIgnoreCase))
            {
                System.Console.WriteLine("=======================================================");
                System.Console.WriteLine("                    ARMA ENCONTRADA                    ");
                System.Console.WriteLine("=======================================================");
                System.Console.WriteLine($"Posición de Registro : {i}");
                System.Console.WriteLine($"Código               : {codigos[i]}");
                System.Console.WriteLine($"Nombre               : {nombres[i]}");
                System.Console.WriteLine($"Precio               : {precios[i]}");
                System.Console.WriteLine($"Daño                 : {danos[i]}");
                System.Console.WriteLine($"Precisión            : {precisiones[i]}");
                System.Console.WriteLine($"Alcance              : {alcances[i]}");
                System.Console.WriteLine($"Stock                : {stocks[i]}");
                System.Console.WriteLine("=======================================================");
                encontrado=true;
                break;
            }
        }
        if(!encontrado)
        {
            System.Console.WriteLine($"No se encontro ningún arma con el código {codigoBuscar}.");
        }
        System.Console.WriteLine("Presione cualquier tecla para volver al menú principal...");
        Console.ReadKey();
    }
    static void ModificarArmaPorCodigo()
    {
        Console.Clear();
        System.Console.WriteLine("====================================================");
        System.Console.WriteLine("                   MODIFICAR ARMA                   ");
        System.Console.WriteLine("====================================================");

        if (cantidad==0)
        {
            System.Console.WriteLine("El almacén está vacío, no hay armas registradas para modificar.");
            System.Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            return;
        }
        System.Console.WriteLine("Ingrese el código del arma que desee modificar: ");
        string codigoBuscar=Console.ReadLine().Trim();

        bool encontrado=false;

        for(int i=0;i<cantidad;i++)
        {
            if (codigos[i].Equals(codigoBuscar,StringComparison.OrdinalIgnoreCase))
            {
                encontrado=true;

                System.Console.WriteLine("======================================================");
                System.Console.WriteLine($"           ARMA LOCALIZADA EN POSICIÓN {i}           ");
                System.Console.WriteLine("======================================================");
                System.Console.WriteLine($"Nombre actual: {nombres[i]} | Precio: {precios[i]} | Daño: {danos[i]}");
                System.Console.WriteLine("======================================================");
                System.Console.WriteLine("Ingrese los nuevos datos técnicos del arma:");

                System.Console.Write("Nuevo Nombre: ");
                nombres[i]=Console.ReadLine();

                System.Console.Write("Nuevo Precio: ");
                precios[i]=double.Parse(Console.ReadLine());

                System.Console.Write("Nuevo Daño: ");
                danos[i]=double.Parse(Console.ReadLine());

                System.Console.Write("Nueva Precisión: ");
                precisiones[i]=double.Parse(Console.ReadLine());

                System.Console.Write("Nuevo Alcance: ");
                alcances[i]=double.Parse(Console.ReadLine());

                System.Console.Write("Nuevo Stock: ");
                stocks[i]=int.Parse(Console.ReadLine());
                System.Console.Write("Atributos modificados correctamente.");
                Console.ReadKey();
                break;
            }
        }
        if(!encontrado)
        {
            System.Console.WriteLine($"No se encontró ningún arma con el código {codigoBuscar}.");
            System.Console.WriteLine("Presione cualquier tecla para volver al menú principal...");
            Console.ReadKey();
        }
    } 
    //Sistema de Codigo para la posicion del arma
    static void InsertarPosicionDeArma()
    
    {
        Console.Clear();
        System.Console.WriteLine("============================================");
        System.Console.WriteLine(" INSERTA TU ARMA EN UNA POSICIÓN ESPECÍFICA ");
        System.Console.WriteLine("============================================");
        if (cantidad >= MAX)
        {
            System.Console.WriteLine("El almacen esta lleno.");
            Console.ReadKey();
            return;
        }
        System.Console.WriteLine("Ingrese la posicion del arma para insertar: ");
        int posicion = int.Parse(Console.ReadLine());
        if (posicion < 0 || posicion > cantidad)
        {
            System.Console.WriteLine("Posición del arma no válida.");
            Console.ReadKey();
            return;
        }
        for (int i = cantidad; i > posicion; i--)
        {
            codigos[i] = codigos[i - 1];
            nombres[i] = nombres[i - 1];
            precios[i] = precios[i - 1];
            danos[i] = danos[i - 1];
            precisiones[i] = precisiones[i - 1];
            alcances[i] = alcances[i - 1];
            stocks[i] = stocks[i - 1];
        }
        System.Console.WriteLine("Codigo:");
        codigos[posicion] = Console.ReadLine();
        System.Console.WriteLine("Nombre:");
        nombres[posicion] = Console.ReadLine();
        System.Console.WriteLine("Precio:");
        precios[posicion] = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Daño:");
        danos[posicion] = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Presicion:");//XD
        precisiones[posicion] = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Alcance:");
        alcances[posicion] = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Stock:");
        stocks[posicion] = int.Parse(Console.ReadLine());
        cantidad++;
        System.Console.WriteLine("\nTu arma ha sido inserta con exito :D. ");
        Console.ReadKey();
    }
    //Ahora el sistema de codigo para poder eliminar el arma
    static void EliminarArma()
    {
        Console.Clear();
        System.Console.WriteLine("========================================");
        System.Console.WriteLine("            ELIMINA TU ARMA             ");
        System.Console.WriteLine("========================================");
        if (cantidad == 0)
        {
            System.Console.WriteLine("No hay armas registradas para eliminar D:");
            Console.ReadKey();
            return;
        }
        System.Console.WriteLine("Por favor ingresa el código de el arma a eliminar");
        string codEliminar = Console.ReadLine();
        int posicion = -1;
        for (int i = 0; i < cantidad; i++)
        {
            if (codigos[i] == codEliminar)
            {
                posicion = i;
                break;
            }
        }
        if (posicion == -1)
        {
            System.Console.WriteLine("Tu arma no se encontró ");
            Console.ReadKey();
            return;
        }
        for (int i = posicion; i < cantidad - 1; i++)
        {
            codigos[i] = codigos[ i + 1];
            nombres[i] = nombres[ i + 1];
            precios[i] = precios[ i + 1];
            danos[i] = danos[ i + 1];
            precisiones[i] = precisiones[ i + 1];
            alcances[i] = alcances[ i + 1];
            stocks[i] = stocks[ i + 1];
        }
        cantidad--;
        System.Console.WriteLine("\nTu arma se eliminó.... D:");
        Console.ReadKey();
        
    }


    //toca poner orden en el hogar!  
    static void OrdenarArsenalPoorPrecio()
    
    {
        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("      ORDENAR ARSENAL POR PRECIO");
        Console.WriteLine("========================================");

        if (cantidad <= 1)
        {
            //mensajito por si el usuario es... ###!!!
            Console.WriteLine("No hay suficientes armas para ordenar pues!!!!!");
            Console.ReadKey();
            return;
        }

        //uso de variable formales como robocop
        for (int i = 0; i < cantidad - 1; i++)
        {
            for (int j = 0; j < cantidad - i - 1; j++)
            {
                if (precios[j] > precios[j + 1])
                {
                    //aplicando temp, el arte oscura para
                    //un buen intercambio de valores
                    string tempCodigo = codigos[j];
                    codigos[j] = codigos[j + 1];
                    codigos[j + 1] = tempCodigo;

                    string tempNombre = nombres[j];
                    nombres[j] = nombres[j + 1];
                    nombres[j + 1] = tempNombre;

                    double tempPrecio = precios[j];
                    precios[j] = precios[j + 1];
                    precios[j + 1] = tempPrecio;

                    double tempDano = danos[j];
                    danos[j] = danos[j + 1];
                    danos[j + 1] = tempDano;

                    double tempPrecision = precisiones[j];
                    precisiones[j] = precisiones[j + 1];
                    precisiones[j + 1] = tempPrecision;

                    double tempAlcance = alcances[j];
                    alcances[j] = alcances[j + 1];
                    alcances[j + 1] = tempAlcance;

                    int tempStock = stocks[j];
                    stocks[j] = stocks[j + 1];
                    stocks[j + 1] = tempStock;
                    //un infortunio pero algo necesario: cuando se
                    //intercambian posiciones de articulos se debe
                    //intercambiar tambien cada dato
                    //uno por uno
                }
            }
        }

        Console.WriteLine("\nArsenal ordenado correctamente, preciado usuario!.");
        Console.WriteLine("Orden aplicado: Menor precio -> Mayor precio");

        Console.ReadKey();
    
    //detalle pequeño pero importante correjido - la llave
    //de cierre estaba en una ubicacion erronea
    }


    //las estadisticas, porque un verdadero comandante quispe
    //debe conocer el estado de su arsenal

    static void MostrarEstadisticas()
    {
        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("       ESTADISTICAS DEL ARSENAL");
        Console.WriteLine("========================================");

        if (cantidad == 0)
        {
            Console.WriteLine("No existen armas registradas.");
            Console.ReadKey();
            return;
        }

        //estas variables almacenaran los resultados
        //de los calculos
        double sumaPrecios = 0;
        int stockTotal = 0;

        //guardaremos posiciones para luego mostrar
        //la informacion completa del arma
        int posMasCara = 0;
        int posMasBarata = 0;
        int posMayorDano = 0;

        //recorriendo todo el arsenal, como si inspeccionara cada arma
        //(como la señora "i" esta cansada, la seño "k"
        //sera su reemplazo... por ahora)
        for (int k = 0; k < cantidad; k++)
        {
            sumaPrecios += precios[k];

            stockTotal += stocks[k];

            if (precios[k] > precios[posMasCara])
            {
                posMasCara = k;
            }

            if (precios[k] < precios[posMasBarata])
            {
                posMasBarata = k;
            }

            if (danos[k] > danos[posMayorDano])
            {
                posMayorDano = k;
            }
        }

        double promedioPrecio = sumaPrecios / cantidad;

        //ahora lo mas... tedioso pero simple, la presentacion!!
        Console.WriteLine($"\nTotal de armas registradas: {cantidad}");
        
        //f2 para limitar el decimal
        Console.WriteLine($"\nPrecio promedio del arsenal: {promedioPrecio:F2}");

        Console.WriteLine($"\nStock total disponible: {stockTotal}");

        Console.WriteLine("\n----------------------------------------");
        Console.WriteLine("ARMA MAS CARA");
        Console.WriteLine("----------------------------------------");

        Console.WriteLine($"Codigo : {codigos[posMasCara]}");
        Console.WriteLine($"Nombre : {nombres[posMasCara]}");
        Console.WriteLine($"Precio : {precios[posMasCara]}");

        Console.WriteLine("\n----------------------------------------");
        Console.WriteLine("ARMA MAS BARATA");
        Console.WriteLine("----------------------------------------");

        Console.WriteLine($"Codigo : {codigos[posMasBarata]}");
        Console.WriteLine($"Nombre : {nombres[posMasBarata]}");
        Console.WriteLine($"Precio : {precios[posMasBarata]}");

        Console.WriteLine("\n----------------------------------------");
        Console.WriteLine("ARMA CON MAYOR DANO");
        Console.WriteLine("----------------------------------------");

        Console.WriteLine($"Codigo : {codigos[posMayorDano]}");
        Console.WriteLine($"Nombre : {nombres[posMayorDano]}");
        Console.WriteLine($"Dano   : {danos[posMayorDano]}");

        Console.WriteLine("\n========================================");
        Console.WriteLine("   Fin del informe tactico del arsenal.");
        Console.WriteLine("========================================");

        Console.ReadKey();
    }
    
}


//Declaramos que el presente trabajo fue desarrollado
//por los integrantes del equipo, sin generación de código, 
//informe o solución mediante herramientas de inteligencia artificial 
//generativa. El historial de GitHub refleja nuestro proceso de trabajo y participación.