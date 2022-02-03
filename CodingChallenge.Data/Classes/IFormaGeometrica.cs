namespace CodingChallenge.Data.Classes
{
    public interface IFormaGeometrica
    {
        decimal CalcularArea();
        decimal CalcularPerimetro();
        int ObtenerTipo();
        string GetNombre();
    }
}
