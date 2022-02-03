using CodingChallenge.Data.RecursosLocalizables;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        public static string Imprimir(List<IFormaGeometrica> formas)
        {

            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append($@"<h1>{ StringResources.Vacio}</h1>");
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append($@"<h1>{ StringResources.NoVacio}</h1>");
                int numero = 0;
                decimal area = 0;
                decimal perimetro = 0;
                int tipo = 0;
                int numeroDeFormas = 0;
                decimal perimetrosDeFormas = 0;
                decimal areaDeFormas = 0;
                var lista = formas.OrderBy(f => f.ObtenerTipo()).ToList();
                string nombre = null;
                foreach (var forma in lista)
                {

                    if (forma.ObtenerTipo() != tipo)
                    {
                        if (tipo != 0)
                            sb.Append(ObtenerLinea(numero, area, perimetro, nombre));
                        nombre = forma.GetNombre();
                        tipo = forma.ObtenerTipo();
                        numero = 1;
                        area = forma.CalcularArea();
                        perimetro = forma.CalcularPerimetro();
                    }
                    else
                    {
                        numero++;
                        area += forma.CalcularArea();
                        perimetro += forma.CalcularPerimetro();
                    }
                    areaDeFormas += forma.CalcularArea();
                    perimetrosDeFormas += forma.CalcularPerimetro();
                    numeroDeFormas++;

                }

                sb.Append(ObtenerLinea(numero, area, perimetro, nombre));

                // FOOTER
                sb.Append($"{StringResources.Total}:<br/>");
                sb.Append($"{numeroDeFormas} {StringResources.Formas} ");
                sb.Append($"{StringResources.Perimetro} {perimetrosDeFormas:#.##} ");
                sb.Append($"{StringResources.Area} {areaDeFormas:#.##}");

            }

            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string nombreForma)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {GetForma(nombreForma, cantidad)} | {StringResources.Area} {area:#.##} | {StringResources.Perimetro} {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

        private static string GetForma(string nombreForma, int cantidad)
        {
            if (cantidad > 1 )
                return StringResources.ResourceManager.GetString(nombreForma+"s", CultureInfo.CurrentCulture);

            return StringResources.ResourceManager.GetString(nombreForma, CultureInfo.CurrentCulture);
        }


    }
}
