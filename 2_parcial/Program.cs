using System;

namespace segundo_parcial
{
    public class MaterialBibliografico
    {
        public string Titulo;
        public string Autor;

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}");
        }
    }

    public class Libro : MaterialBibliografico
    {
        public int NumeroDePaginas;


        public override void MostrarInfo()
        {
            Console.WriteLine($"Libro - Título: {Titulo}, Autor: {Autor}, Páginas: {NumeroDePaginas}");
        }
    }

    public class Revista : MaterialBibliografico
    {
        public int NumeroDeEdicion;

        public override void MostrarInfo()
        {
            Console.WriteLine($"Libro - Título: {Titulo}, Autor: {Autor}, Páginas: {NumeroDeEdicion}");
        }

    }

}


