using System;
using.System.generics;  

namespace Programa_Peliculas
{
    class Pelicula
    {   
    private string titulo;

    private Int16 año;
    
    
    private string pais;

    private string director;

    
    public void setAño(Int16 año)
    
    {
        this.Año=año;
    } 
    public Int16 getAño()
    {
        return this.Año;
    }

    public void setTitulo(string titulo)
    {
        this.titulo=titulo;
    }
    
    public String GetTitulo()
    {
        return this.Titulo;
    }

    public void SetDirector(string director)
    {
        this.Director = director;
    }

    public String GetDirector()
    {
        return this.Director;
    }


    public Pelicula()

    public Pelicula(string titulo, Int16 año, string director, string pais)
        {
            this.Titulo = titulo;
            this.Año = año;
            
        }

    class Program
    {
        static void Main(string[] args)
        {
            Pelicula pelicula1 = new Pelicula();
            pelicula1.SetTitulo("Bohemian Rapsody");
            pelicula1.SetAño(2018); 
            Console.WriteLine("{0}({1})", pelicula1.GetTitulo(), pelicula1.GetAño());

            Pelicula pelicula2 = new Pelicula();
            pelicula2.SetTitulo("Quiero ser millonario");
            pelicula2.SetAño(2001); 
            Console.WriteLine("{0}({1})", pelicula2.GetTitulo(), pelicula2.GetAño());

            console readline();

        
        }
    }
}
