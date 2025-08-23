//Gestion de datos...
/*  
1. Generar la clase Vehiculo en una carpeta
    de nombre Models (Models/Vehiculo.cs) con las 
    propiedades(Id,Marca,Modelo,Anio)

    2. Generar la clase Memoria para almacenar en la Memoria RAM
    una lista de Vehiculos
*/
using Ejemplo1;
#region Funciones

//Funcion para imprimir cualquier lista de vehiculos...
void ImprimirElementos(List<Vehiculo> items) => items.ForEach(Console.WriteLine);
//Funcion para buscar por año:
void MostrarVehiculosPorAnio(int anio)
=> ImprimirElementos(//Como busco en la memoria los vehiculos del año que me pidan
    Memoria.Vehiculos.Where(x => x.Anio == anio).ToList()
);
#endregion Funciones

//Inicializamos los datos temporales con un primer vehiculo.
Memoria.Vehiculos = [
    new Vehiculo(){Id = 1, Marca = "Toyota", Modelo = "Hihglander", Anio = 2019 },
    new Vehiculo(){Id = 2, Marca = "Toyota", Modelo = "Glanza", Anio = 2000 },
    new Vehiculo(){Id = 3, Marca = "Honda", Modelo = "Civic", Anio = 2005 },
    new Vehiculo(){Id = 4, Marca = "Toyota", Modelo = "Camry", Anio = 2025 },
];
//Mostramos cada vehiculo de la memoria, en la consola.
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Todos los vehiculos:");
ImprimirElementos(Memoria.Vehiculos);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Vehiculos del año (2000):");
MostrarVehiculosPorAnio(2000);
Console.ForegroundColor = ConsoleColor.White;