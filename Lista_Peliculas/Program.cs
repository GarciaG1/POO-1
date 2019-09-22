using System;

namespace Lista_Peliculas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> lista =new List<String>();
                lista.Add("Shrek");
                lista.Add("El rey leon");
                lista.Add("La Sirenita");
                lista.Add("La tumba de las luciernagas");
                lista.Add("El castillo ambulante");

           foreach(String Pelicula in lista)
                Console.WriteLine(Pelicula);
        }
    }
}
