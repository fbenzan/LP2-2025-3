namespace Ejemplo2;

public class Estudiante
{
    #region Datos Basicos
    public string Matricula { get; set; } = null!;
    public string Nombre { get; set; } = null!;
    #endregion Datos Basicos

    #region Calificaciones
    public int PrimerParcial { get; set; } = 0;
    public int SegundoParcial { get; set; } = 0;
    public int Practica { get; set; } = 0;
    public int ExamenFinal { get; set; } = 0;
    #endregion Calificaciones

    #region Propiedades Computadas
    public int NotaFinal => PrimerParcial + SegundoParcial + Practica + ExamenFinal;
    private bool Aprobo => NotaFinal >= 70;
    public string Aprobado => Aprobo ? "Si" : "No";
    #endregion Propiedades Computadas
}