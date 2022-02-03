using CodingChallenge.Data.Helpers;
using System;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : Geometria, IFormaGeometrica
    {
        public Cuadrado(decimal lado)
        {
            Lado = lado;
            Tipo = (int)Constantes.Tipo.Cuadrado;
            Nombre = Enum.GetName(typeof(Constantes.Tipo), (int)Constantes.Tipo.Cuadrado);
        }
        public decimal CalcularArea()
        {
            return Lado * Lado;
        }

        public decimal CalcularPerimetro()
        {
            return Lado * 4;
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
