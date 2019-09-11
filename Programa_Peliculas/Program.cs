using System;

namespace Programa_Peliculas
{
    class Pelicula
    {
    public string titulo;

    public Int16 año;

    public string pais;

    public string director;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pelicula pelicula1= new Pelicula();
            Pelicula pelicula2= new Pelicula();

            pelicula1.titulo="Bohemian Rapsody";
            pelicula1.año=2018;
            pelicula2.titulo="Una Mente Brillante";
            pelicula2.año=2001;

            Console.WriteLine("{0},{1}",pelicula1.titulo,pelicula1.año);
            Console.WriteLine("{0},{1}",pelicula2.titulo,pelicula2.año);
        }
    }
}
