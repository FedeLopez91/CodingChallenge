using CodingChallenge.Data.Helpers;
using System;

namespace CodingChallenge.Data.Classes
{
    public class Triangulo : Geometria, IFormaGeometrica
    {
        public Triangulo(decimal lado)
        {
            Lado = lado;
            Tipo = (int)Constantes.Tipo.Triangulo;
            Nombre = Enum.GetName(typeof(Constantes.Tipo), (int)Constantes.Tipo.Triangulo);
        }
        public decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * Lado * Lado;
        }

        public decimal CalcularPerimetro()
        {
            return Lado * 3;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public int ObtenerTipo()
        {
            return Tipo;
        }
    }
}
