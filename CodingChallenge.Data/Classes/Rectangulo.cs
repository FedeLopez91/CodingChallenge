using CodingChallenge.Data.Helpers;
using System;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : Geometria, IFormaGeometrica
    {
        public decimal Base { get; set; }

        public Rectangulo(decimal lado, decimal _base)
        {
            Lado = lado;
            Base = _base;
            Tipo = (int)Constantes.Tipo.Rectangulo;
            Nombre = Enum.GetName(typeof(Constantes.Tipo), (int)Constantes.Tipo.Rectangulo);
        }
        public decimal CalcularArea()
        {
            return Base * Lado;
        }

        public decimal CalcularPerimetro()
        {
            return Base * 2 + Lado * 2;
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
