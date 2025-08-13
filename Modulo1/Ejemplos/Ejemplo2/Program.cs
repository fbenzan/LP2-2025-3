//Permitir al usuario elegir: Ver hora, saludar y salir.
Console.WriteLine("#### MENU PRINCIPAL ####");
Console.WriteLine("1) Ver la hora actual");
Console.WriteLine("2) Saludar!");
Console.WriteLine("3) Salir");
Console.Write("Elige una opción: ");
var op = Console.ReadLine();
switch (op)
{
    case "1":
        {
            Console.Clear();//Sentencia #1
            Console.WriteLine($"Hora: {DateTime.Now.ToString("hh:mm tt")}");//Sentencia #2
        }
        break;
    case "2":
        {
            Console.Clear();//Sentencia #1
            Console.WriteLine("Hola!!");//Sentencia #2
        }
        break;
    case "3":
        {
            Console.Clear();//Sentencia #1
            Console.WriteLine("Adios!!");//Sentencia #2
        }
        break;
    default:
            Console.WriteLine("Opción invalida.");
        break;
}