using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        public string titulo;
        public Int16 año;
        public string pais;
        public string director;
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
            pelicula1.titulo = "El señor de los anillos: La comunidad del anillo";
            pelicula1.año = 2001;
            pelicula2.titulo = "El señor de los anillos: Las dos torres";
            pelicula2.año = 2002;
            Console.WriteLine(pelicula1.titulo);
            Console.WriteLine(pelicula1.año);
            Console.WriteLine(pelicula2.titulo);
            Console.WriteLine(pelicula2.año);

            Console.WriteLine("Hello");
        }
    }
}
