using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private string titulo;
        private Int16 año;
        private string pais;
        private string director;
        private List<Actor> actores = new List<Actor>();

        //Constructores
        public Pelicula()
        {

        }
        public Pelicula(string titulo, Int16 año)
        {
            this.titulo = titulo;
            this.año = año;

        }
     
        //Métodos
        public string SetDirector(string director)
        {
            this.director = director;
            return director;
        }
        public string GetDirector()
        {
            return director;
        }
        public string SetPais(string pais)
        {
            this.pais = pais;
            return pais;
        }
        public string GetPais()
        {
            return pais;
        }
        
        public string SetTitulo(string titulo)
        {
            this.titulo = titulo;
            return titulo;
        }
        public string GetTitulo()
        {
            return titulo;
        }
        public void SetAño(Int16 año)
        {
            this.año = año;
        }
        public Int16 GetAño()
        {
            return año;
        }
        public void AgregaActor(Actor actor)
        {
            actores.Add(actor);
        }
        public void ImprimeActores()
        {
            foreach (Actor artista in actores)
            {
                artista.Imprime();
            }
        }
     
        public void Imprime( )
        {
           Console.WriteLine($"{titulo} ({año})");
        }
    }

    public class Actor
    {
        //Propiedades
        public string Nombre;
        public Int16 Año;

        //Constructores
        public Actor(string nombreActor , Int16 añoNacimiento)
        {
            Nombre = nombreActor;
            Año = añoNacimiento;
        }


        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Año})");
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
            Pelicula pelicula3 = new Pelicula("El Bromas",2019);
            Pelicula pelicula4 = new Pelicula("Spider-Man: Into the Spider-Verse",2018);
            Pelicula pelicula5 = new Pelicula("La La Land",2016);
            pelicula1.SetTitulo("El Señor de los Anillos: La Comunidad del Anillo");
            pelicula1.SetAño(2001);
            pelicula1.SetDirector("Peter Jackson");
            pelicula1.SetPais("Nueva Zelanda");
            pelicula2.SetTitulo("El Señor de los Anillos: Las Dos Torres");
            pelicula2.SetAño(2002);
            pelicula2.SetDirector("Peter Jackson");
            pelicula2.SetPais("Nueva Zelanda");
            Console.WriteLine("{0} {1} {2} {3}" ,pelicula1.GetTitulo() ,pelicula1.GetAño(), pelicula1.GetDirector(), pelicula1.GetPais());
            Console.WriteLine("{0} {1} {2} {3}" ,pelicula2.GetTitulo() ,pelicula2.GetAño(), pelicula2.GetDirector(), pelicula2.GetPais());
            pelicula3.Imprime();
            pelicula4.Imprime();
            pelicula5.Imprime();
            Console.WriteLine("Hello");
            pelicula3.AgregaActor(new Actor("Joaquin Phoenix", 1974));
            pelicula3.ImprimeActores();
            pelicula4.AgregaActor(new Actor("Shameik Moore", 1995));
            pelicula4.ImprimeActores();
            pelicula5.AgregaActor(new Actor("Ryan Gosling", 1980));
            pelicula5.AgregaActor(new Actor("Emma Stone", 1988));
            pelicula5.ImprimeActores();
            List<Pelicula> peliculas = new List<Pelicula>();
            peliculas.Add(new Pelicula("El Señor de los Anillos: La Comunidad del Anillo", 2001));
            peliculas.Add(new Pelicula("El Señor de los Anillos: Las Dos Torres", 2002));
            peliculas.Add(new Pelicula("El Señor de los Anillos: El Retorno del Rey", 2003));
            peliculas.Add(new Pelicula("Volver al Futuro", 1985));
            peliculas.Add(new Pelicula("Volver al Futuro Parte II", 1989));
            foreach (Pelicula peli in peliculas)
            {
                peli.Imprime();
            }
        }
    }
}
