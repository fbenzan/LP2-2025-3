namespace Ejemplo1;

public class Vehiculo
{
    public int Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Anio { get; set; }

    public override string ToString()
    {
        return $"{Marca} - {Modelo} ({Anio})";
    }
}
