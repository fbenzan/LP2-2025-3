using Ejemplo2;

var E1 = new Estudiante();

E1.Matricula = "2021-1025";
E1.Nombre = "Alberto Caceres";

E1.PrimerParcial = 10; // 10/15
E1.SegundoParcial = 8; // 8/15
E1.Practica = 25; // 25/40
E1.ExamenFinal = 30;// 30/30
Console.WriteLine($"Calificacion Final: {E1.NotaFinal}");
Console.WriteLine($"El estudiante aprobó: {E1.Aprobado}");
