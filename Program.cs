// See https://aka.ms/new-console-template for more information
using ImplementacionClases.Utils;


//Ejemplo de utilidades 
//Console.WriteLine("Hello, World!");

//Console.WriteLine(ConsoleUtils.Saludar(" Jullianno"));


Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Green;

/*Ejemplo escribir por consola
Console.Write("Escribe un nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine($"Ha escrito {nombre}");*/

while (Menu())
{
    Console.ReadKey(); //Pausa, solicitar la entrada de una tecla
}

static bool Menu()
{

    bool continuar = true;

    Console.Clear();
    Console.Title = "Ejercicio Menu";

    Console.WriteLine("Menu de opciones");
    Console.WriteLine("================");
    Console.WriteLine("1)Listar datos");
    Console.WriteLine("2)Agregar datos");
    Console.WriteLine("");
    Console.WriteLine("0)Salir");

    Console.WriteLine("Elija su opcion");

    string opcion = Console.ReadLine().Trim();

    switch (opcion)
    {

        case "1":
            Console.WriteLine("Escogio la opcion 1");
            break;

            case "2":
            Console.WriteLine("Escogio la opcion 2");
            OpcionInsertar();
            break ;

            case "0":
            Console.WriteLine("Saliendo del programa...");
            continuar = false;
            break;

        default:
            Console.WriteLine("Opcion no valida");
            break;
    }

    return false;
}

static void OpcionInsertar()
{
   
    Console.WriteLine("Ingrese el valor de la temperatura");
    string respuestaT = Console.ReadLine();

    Console.WriteLine("Ingrese el valor del flujo");
    string respuestaF = Console.ReadLine();

    Console.WriteLine("Ingrese el valor del voltaje");
    string respuestaV = Console.ReadLine();

    Console.WriteLine("Ingrese el valor del nivel");
    string respuestaN = Console.ReadLine();

    /*Ejemplos de conversion 

    int i = 5;
    i.ToString(); //Cualquier cosa a string

    int convertido = Convert.ToInt32(respuesta); //Utilizando la clase Convert (Sirve a varios tipos)

    string test = "12345";
    float conDecimales = (float) test; //Conversion explicita

    //Conversion implicita
    int otroTest = 12345;
    float otroDecimal = otroTest;


    // A traves de clases de tipos de datos

    string unEnteroSinConvertir = "98";


    */

}