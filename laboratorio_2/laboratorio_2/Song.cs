using System;
using System.Collections.Generic;
using System.Linq;
namespace laboratorio_2
{
    public class Song
    {
        public string Name { get; set; } // no logic statements needed, so we can uset get and set this way.
        public string Album { get; set; } // note that this is a faster notation to use get and set property while keeping atributes private.
        public string Artist { get; set; }
        public string Genre { get; set; }
        public string Information() //Informacion() method.
        {
            string original = "Genero:genero,Artista:artista,Album:album,Nombre:nombre."; //string to return as requested
            string original_1 = original.Replace("genero", Genre);
            string original_2 = original_1.Replace("artista", Artist);
            string original_3 = original_2.Replace("album", Album);
            string original_4 = original_3.Replace("nombre", Name);
            Console.WriteLine("{0}\n",original_4);
            return original_4;// final string edited with song info.
        }
        public Song(string nm, string al, string ar, string gr) //song builder
        {
            Name = nm;
            Album = al;
            Artist = ar;
            Genre = gr;
        }
    }
}
