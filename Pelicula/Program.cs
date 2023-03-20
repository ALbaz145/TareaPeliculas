using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private string titulo { get; set;}
        public string SetTitulo
        {
            set { titulo = value;}
        }
        public string GetTitulo
        {
            get { return titulo;}
        }
        private Int16 año { get; set;}
        public Int16 SetAño
        {
            set { año = value;}
        }
        public Int16 GetAño
        {
            get { return año;}
        }

        private string pais { get; set;}
        private string director { get; set;}
        private List<Actor> actores = new List<Actor>();

        //Constructores
     
        //Métodos
     
        public void Imprime()
        {
           Console.WriteLine($"{titulo} ({año})");

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
            pelicula1.SetTitulo = "El Señor de los Anillos: La Comunidad del Anillo";
            pelicula1.SetAño = 2001;
            pelicula2.SetTitulo = "El Señor de los Anillos: Las Dos Torres";
            pelicula2.SetAño = 2002;
            Console.WriteLine("{0} {1}" ,pelicula1.GetTitulo ,pelicula1.GetAño);
            Console.WriteLine("{0} {1}" ,pelicula2.GetTitulo ,pelicula2.GetAño);
            Console.WriteLine("Hello");
        }
    }
}
