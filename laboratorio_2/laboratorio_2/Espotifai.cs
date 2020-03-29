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
                Console.WriteLine("\n");
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
                Console.WriteLine("\n");
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
                    Console.WriteLine("Genero:{0}.\nArtista:{1}.\nAlbum:{2}.\nNombre:{3}.\n", _song[i].Genre, _song[i].Artist, _song[i].Album, _song[i].Name);
                }
            }
        }
        public List<Song> SongsbyCriterion(String criterion, string value)//"CancionesPorCriterio() method.
        {
            List<Song> _crit = new List<Song>(); //Lista a retornar.
            if (criterion == "Genero") // Criterio elegido: Genero.
            {
                for (int t = 0; t < _song.Count(); t++)
                {
                    //busqueda de coincidencias
                    if (value == _song[t].Genre) {
                        _crit.Add(_song[t]);
                    }
                }
                if (_crit.Count() == 0) //no hay coincidencias.
                {
                    Console.WriteLine("No se ha encontrado ningun resultado con el género indicado.\n");
                    return _crit;
                }
                else {
                    Console.WriteLine("Resultados encontrados:\n"); // coincidencias encontradas.
                    for (int s = 0; s < _crit.Count(); s++) {
                        Console.WriteLine("Genero:{0}.\nArtista:{1}.\nAlbum:{2}.\nNombre:{3}.\n", _crit[s].Genre, _crit[s].Artist, _crit[s].Album, _crit[s].Name);
                    }
                    return _crit;
                }
            }
            else if (criterion == "Album") // el codigo es el mismo pero para los otros criterios.
            {
                for (int h=0; h < _song.Count(); h++)
                {
                    if (value == _song[h].Album)
                    {
                        _crit.Add(_song[h]);
                    }
                }
                if (_crit.Count() == 0)
                {
                    Console.WriteLine("No se ha encontrado ningun resultado con el álbum indicado,\n");
                    return _crit;
                }
                else
                {
                    Console.WriteLine("Resultados encontrados:\n");
                    for (int d = 0; d < _crit.Count(); d++)
                    {
                        Console.WriteLine("Genero:{0}.\nArtista:{1}.\nAlbum:{2}.\nNombre:{3}.\n", _crit[d].Genre, _crit[d].Artist, _crit[d].Album, _crit[d].Name);
                    }
                    return _crit;
                }
            }
            else if (criterion == "Artista")
            {
                for (int u=0; u < _song.Count(); u++)
                {
                    if (value == _song[u].Artist)
                    {
                        _crit.Add(_song[u]);
                    }
                }
                if (_crit.Count() == 0)
                {
                    Console.WriteLine("No se ha encontrado ningun resultado del artista indicado,\n");
                    return _crit;
                }
                else
                {
                    Console.WriteLine("Resultados encontrados:\n");
                    for (int f = 0; f < _crit.Count(); f++)
                    {
                        Console.WriteLine("Genero:{0}.\nArtista:{1}.\nAlbum:{2}.\nNombre:{3}.\n", _crit[f].Genre, _crit[f].Artist, _crit[f].Album, _crit[f].Name);
                    }
                    return _crit;
                }
            }
            else if (criterion == "Cancion")
            {
                for (int p=0; p < _song.Count(); p++)
                {
                    if (value == _song[p].Name)
                    {
                        _crit.Add(_song[p]);
                    }
                }
                if (_crit.Count() == 0)
                {
                    Console.WriteLine("No se ha encontrado ningun resultado de la canción indicado,\n");
                    return _crit;
                }
                else
                {
                    Console.WriteLine("Resultados encontrados:\n");
                    for (int g = 0; g < _crit.Count(); g++)
                    {
                        Console.WriteLine("Genero:{0}.\nArtista:{1}.\nAlbum:{2}.\nNombre:{3}.\n", _crit[g].Genre, _crit[g].Artist, _crit[g].Album, _crit[g].Name);
                    }
                    return _crit;
                }
            }
            else
            {
                //Criterio incorrecto.
                Console.WriteLine("El criterio entregado es incorrecto.\n");
                return _crit;
            }
        }
    }
}
