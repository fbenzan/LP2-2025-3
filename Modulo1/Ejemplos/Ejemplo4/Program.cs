List<string> nombres = [];
while (true)
{
    Console.Clear();
    Console.WriteLine("#### MENU PRINCIPAL ####");
    Console.WriteLine(
        "1) Agregar un nombre.\n" +
        "2) Mostrar nombres agregados.\n" +
        "Otra) Terminar."
        );
    var op = Console.ReadLine();
    if (op == "1") AgregarNombres();
    else if (op == "2") MostrarNombres();
    else break;
}

void AgregarNombres()
{
AGREGAR:
    Console.Clear();
    Console.Write("¿Que nombre deseas agregar?: ");
    nombres.Add(Console.ReadLine()!);
    Console.WriteLine($"Nombre agregado!, nombres({nombres.Count}), Deseas agregar otro? (s/n)...");
    if (Console.ReadLine() == "s") goto AGREGAR;
}
void MostrarNombres()
{
    Console.Clear();
        Console.WriteLine("Nombres: ");
        foreach (var nombre in nombres)
        {
            var posicion = nombres.IndexOf(nombre) + 1;
            Console.WriteLine($"{posicion}. {nombre}");
        }
        Console.WriteLine($"Deseas agregar otro? (s/n)...");
    if (Console.ReadLine() == "s") AgregarNombres();
}