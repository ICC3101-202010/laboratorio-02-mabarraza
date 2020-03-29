using System;
using System.Collections.Generic;
using System.Linq;
namespace laboratorio_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string choice;
            bool f_t = true;
            string _name;
            string _album;
            string _artist;
            string _genre;
            Espotifai canc = new Espotifai();
            Console.WriteLine("Bienvenido a Espotifai! \n");
            while (f_t) {
                Console.WriteLine("Porfavor elija una de las siguientes opciones:\n1 Ver las canciones agregadas a la lista.\n2 Agregar una canción a la lista.\n3 Salir de Espotifai.\n");
                choice = Console.ReadLine();
                Console.WriteLine("\n");
                switch (choice) {
                    case "1":
                        canc.ShowSong();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el nombre se la canción:");
                        _name = Console.ReadLine();
                        Console.WriteLine("Ingrese el album de la canción");
                        _album = Console.ReadLine();
                        Console.WriteLine("Ingrese el artista de la canción");
                        _artist = Console.ReadLine();
                        Console.WriteLine("Ingrese el género de la canción");
                        _genre = Console.ReadLine();
                        Song cancion = new Song(nm: _name, al: _album, ar: _artist, gr: _genre);
                        canc.AdddSong(cancion);
                        break;
                    case "3":
                        f_t = false;
                        break;
                    default:
                        Console.WriteLine("La opción elegida es incorrecta, por favor vuelva a intentarlo\n");
                        break;
                }
            }
        
        }
    }
}
