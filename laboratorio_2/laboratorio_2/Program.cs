using System;
using System.Collections.Generic;
using System.Linq;
namespace laboratorio_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string choice;// User selected option(1 to 6).
            bool f_t = true; // used for while loop control
            string _name;
            string _album;
            string _artist;
            string _genre;
            string _criTerio;
            string _vaLor;
            string _PlaylN;// name of the playlist , used to instanciate the object.
            Espotifai canc = new Espotifai(); // we instanciate espotifai before the loop to keep the data until the user wants to close the "app"
            Console.WriteLine("Bienvenido a Espotifai! \n");
            while (f_t) {
                Console.WriteLine("Porfavor elija una de las siguientes opciones:\n1 Ver las canciones agregadas a la lista.\n2 Agregar una canción a la lista.\n3 Salir de Espotifai.\n4 Ver canciones por criterio.\n5 Crear playlist.\n6 Ver mis playlists.\n");
                choice = Console.ReadLine();
                Console.WriteLine("\n");
                switch (choice) {
                    case "1":
                        canc.ShowSong();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el nombre se la canción:");
                        _name = Console.ReadLine();
                        Console.WriteLine("Ingrese el album de la canción:");
                        _album = Console.ReadLine();
                        Console.WriteLine("Ingrese el artista de la canción:");
                        _artist = Console.ReadLine();
                        Console.WriteLine("Ingrese el género de la canción:");
                        _genre = Console.ReadLine();
                        Song cancion = new Song(nm: _name, al: _album, ar: _artist, gr: _genre);
                        canc.AdddSong(cancion);
                        break;
                    case "3":
                        f_t = false;
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el criterio de búsqueda:");
                        _criTerio = Console.ReadLine();
                        Console.WriteLine("Ingrese el valor a utilizar:");
                        _vaLor = Console.ReadLine();
                        canc.SongsbyCriterion(criterion:_criTerio,value:_vaLor);
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el nombre de la playlist:");
                        _PlaylN = Console.ReadLine();
                        Console.WriteLine("Ingerese el criterio a utilizar:");
                        _criTerio = Console.ReadLine();
                        Console.WriteLine("Ingrese el valor del criterio");
                        _vaLor = Console.ReadLine();
                        Console.WriteLine("\n");
                        Playlist plll = new Playlist(_PlaylN);
                        if (canc.PlaylistGenerator(cr: _criTerio, valcr: _vaLor, np: _PlaylN))// shows the playlist info if created.
                        {
                            plll.ShowPlaylist(canc._playlist[(canc._playlist.Count() - 1)]);
                        }
                        break;
                    case "6":
                        canc.PlayListinfo();
                        break;
                    default:
                        Console.WriteLine("La opción elegida es incorrecta, por favor vuelva a intentarlo\n");
                        break;
                }
            }
        }
    }
}// Notice that when no playlist is created,  the program still shows info related to the songs if the criterion and the value are right.
//this happens because in the PlaylistGenerator method i used the Songsbycriterionmethod() i didnt know how to fix that.
