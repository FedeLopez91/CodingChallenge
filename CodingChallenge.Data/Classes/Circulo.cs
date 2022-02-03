using CodingChallenge.Data.Helpers;
using System;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : Geometria, IFormaGeometrica
    {
        public Circulo(decimal lado)
        {
            Lado = lado;
            Tipo = (int)Constantes.Tipo.Circulo;
            Nombre = Enum.GetName(typeof(Constantes.Tipo), (int)Constantes.Tipo.Circulo);
        }
        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (Lado / 2) * (Lado / 2);
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
