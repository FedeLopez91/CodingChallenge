using CodingChallenge.Data.Classes;
using NUnit.Framework;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometrica>()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometrica>()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnFrances()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");

            Assert.AreEqual("<h1>Liste de formes vide!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometrica>()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<IFormaGeometrica> { new Cuadrado(5) };

            var resumen = FormaGeometrica.Imprimir(cuadrados);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 Formas Perimetro 20 Area 25", resumen);
        }


        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            var cuadrados = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 Shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new Triangulo(4),
                new Cuadrado(2),
                new Triangulo(9),
                new Circulo(2.75m),
                new Triangulo(4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>2 Circles | Area 13.01 | Perimeter 17.25 <br/>TOTAL:<br/>7 Shapes Perimeter 96.85 Area 91.65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new Triangulo(4),
                new Cuadrado(2),
                new Triangulo(9),
                new Circulo(2.75m),
                new Triangulo(4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>3 Triangulos | Area 49,64 | Perimetro 51,6 <br/>2 Circulos | Area 13,01 | Perimetro 17,25 <br/>TOTAL:<br/>7 Formas Perimetro 96,85 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposFrances()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");

            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new Triangulo(4),
                new Cuadrado(2),
                new Triangulo(9),
                new Circulo(2.75m),
                new Triangulo(4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Rapport sur les formes</h1>2 Carres | Zone 29 | Perimetre 28 <br/>3 Triangles | Zone 49,64 | Perimetre 51,6 <br/>2 Cercles | Zone 13,01 | Perimetre 17,25 <br/>LE TOTAL:<br/>7 Formes Perimetre 96,85 Zone 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConRectacgulos()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Rectangulo(2,6),
                new Rectangulo(3,5),
                new Rectangulo(1, 5)
            };
            var resumen = FormaGeometrica.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>3 Rectangulos | Area 32 | Perimetro 44 <br/>TOTAL:<br/>3 Formas Perimetro 44 Area 32",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConRectacgulosEnIngles()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            var formas = new List<IFormaGeometrica>
            {
                new Rectangulo(2,6),
                new Rectangulo(3,5),
                new Rectangulo(1, 5)
            };
            var resumen = FormaGeometrica.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Shapes report</h1>3 Rectangles | Area 32 | Perimeter 44 <br/>TOTAL:<br/>3 Shapes Perimeter 44 Area 32",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConTriangulosEnIngles()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            var formas = new List<IFormaGeometrica>
            {
                new Triangulo(3),
                new Triangulo(5),
            };
            var resumen = FormaGeometrica.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Triangles | Area 14.72 | Perimeter 24 <br/>TOTAL:<br/>2 Shapes Perimeter 24 Area 14.72",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposConRectanguloEnIngles()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new Rectangulo(2,6),
                new Triangulo(4),
                new Cuadrado(2),
                new Rectangulo(3,5),
                new Triangulo(9),
                new Circulo(2.75m),
                new Triangulo(4.2m),
                new Rectangulo(1, 5)
            };

            var resumen = FormaGeometrica.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>2 Circles | Area 13.01 | Perimeter 17.25 <br/>3 Rectangles | Area 32 | Perimeter 44 <br/>TOTAL:<br/>10 Shapes Perimeter 140.85 Area 123.65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposConRectanguloEnFrances()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");

            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new Rectangulo(2,6),
                new Triangulo(4),
                new Cuadrado(2),
                new Rectangulo(3,5),
                new Triangulo(9),
                new Circulo(2.75m),
                new Triangulo(4.2m),
                new Rectangulo(1, 5)
            };

            var resumen = FormaGeometrica.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Rapport sur les formes</h1>2 Carres | Zone 29 | Perimetre 28 <br/>3 Triangles | Zone 49,64 | Perimetre 51,6 <br/>2 Cercles | Zone 13,01 | Perimetre 17,25 <br/>3 Rectangles | Zone 32 | Perimetre 44 <br/>LE TOTAL:<br/>10 Formes Perimetre 140,85 Zone 123,65",
                resumen);
        }
    }
}
