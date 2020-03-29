using System;
using System.Collections.Generic; //needed to work with lists.
using System.Linq;    //needed to work with lists.

namespace laboratorio_2
{
    public class Espotifai
    {
        public List<Song> _song = new List<Song>();
        public Espotifai()
        {
        }
        public bool AdddSong(Song song) // "AgregarCancion()" method.
        {
            int b = _song.Count();
            int c = _song.Count();
            if (_song.Count() == 0)//adding the first song to the empty list as well as checking that is the very first one to be added.
            {
                // this is needed because when the list is empty the program will not get in the folling loop(the for).
                _song.Add(song);
                return true;
            }
            else
            {
                for (int h = 0; h < _song.Count(); h++)//going through the songs list.
                {
                    if ((song.Artist == _song[h].Artist) && (song.Album == _song[h].Album) && (song.Name == _song[h].Name))
                    {
                        //if the song is already on the list this will happen.
                        Console.WriteLine("La canción agregada ya se encuentra en la lista!\n");
                        c -= 1;
                    }
                }
            }
            if (b != c)
            {
                //if the song is already on the list the return will be false.
                return false;
            }
            else
            {
                // if the song is new we add it to the list and the return will be true.
                _song.Add(song);
                return true;
            }
        }
        public void ShowSong()//"VerCanciones()" method.
        {
            if (_song.Count() == 0)
            {
                Console.WriteLine("Tu lista está vacía!\n");
            }
            else {
                for (int i = 0; i < _song.Count(); i++)
                {
                    Console.WriteLine("Genero:{0}\nArtista:{1}\nAlbum:{2}\nNombre:{3}.\n", _song[i].Genre, _song[i].Artist, _song[i].Album, _song[i].Name);
                }
            }
        }
    }
}
