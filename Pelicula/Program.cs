using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private string titulo { get; set;}
        public string Titulo
        {
            get { return titulo;}
            set { titulo = value;}
        }
        private Int16 año { get; set;}
        public Int16 Año
        {
            get { return año;}
            set { año = value;}
        }

        private string pais { get; set;}
        private string director { get; set;}
        private List<Actor> actores = new List<Actor>();

        //Constructores
     
        //Métodos
     
        public void Imprime()
        {
     //       Console.WriteLine($"{titulo} ({año})");

        }
    }

    public class Actor
    {
        //Propiedades

        //Constructores


        //Métodos 
        public void Imprime()
        {
      //      Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
            Pelicula pelicula1 = new Pelicula();
            Pelicula pelicula2 = new Pelicula();
            pelicula1.Titulo = "El Señor de los Anillos: La Comunidad del Anillo";
            pelicula1.Año = 2001;
            pelicula2.Titulo = "El Señor de los Anillos: Las Dos Torres";
            pelicula2.Año = 2002;
            Console.WriteLine("{0} {1}" ,pelicula1.Titulo ,pelicula1.Año);
            Console.WriteLine("{0} {1}" ,pelicula2.Titulo ,pelicula2.Año);
            Console.WriteLine("Hello");
        }
    }
}
