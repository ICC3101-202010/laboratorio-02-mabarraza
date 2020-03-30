using System;
using System.Collections.Generic; //needed to work with lists.
using System.Linq;    //needed to work with lists.
using System.Text;

namespace laboratorio_2
{
    public class Espotifai
    {
        public List<Song> _song = new List<Song>();
        public List<Playlist> _playlist = new List<Playlist>();
        public Espotifai()// Espotifai empty builder.
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
            else
            {
                for (int i = 0; i < _song.Count(); i++)
                {
                    Console.WriteLine("Genero:{0}.\nArtista:{1}.\nAlbum:{2}.\nNombre:{3}.\n", _song[i].Genre, _song[i].Artist, _song[i].Album, _song[i].Name);
                }
            }
        }
        public List<Song> SongsbyCriterion(String criterion, String value)//"CancionesPorCriterio()" method.
        {
            List<Song> _crit = new List<Song>(); //Lista a retornar.
            if (criterion == "Genero") // Criterio elegido: Genero.
            {
                for (int t = 0; t < _song.Count(); t++)
                {
                    //busqueda de coincidencias
                    if (value == _song[t].Genre)
                    {
                        _crit.Add(_song[t]);
                    }
                }
                if (_crit.Count() == 0) //no hay coincidencias.
                {
                    Console.WriteLine("No se ha encontrado ningun resultado con el género indicado.\n");
                    return _crit;
                }
                else
                {
                    Console.WriteLine("Resultados encontrados:\n"); // coincidencias encontradas.
                    for (int s = 0; s < _crit.Count(); s++)
                    {
                        Console.WriteLine("Genero:{0}.\nArtista:{1}.\nAlbum:{2}.\nNombre:{3}.\n", _crit[s].Genre, _crit[s].Artist, _crit[s].Album, _crit[s].Name);
                    }
                    return _crit;
                }
            }
            else if (criterion == "Album") // el codigo es el mismo pero para los otros criterios.
            {
                for (int h = 0; h < _song.Count(); h++)
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
                for (int u = 0; u < _song.Count(); u++)
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
                for (int p = 0; p < _song.Count(); p++)
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
        public bool PlaylistGenerator(String cr, String valcr, String np)//"GenerarPlaylist()" method.
        {
            int a = _playlist.Count();// Integer used to check if the playlist was created and added to the List<Playlist> _playlist or not.
            int b = a;//Integer used to check if a playlist with the same name was added to the List<Playlist> _playlist , if it was added then the return wll be false otherwise true.
            List<Song> ppl = new List<Song>(SongsbyCriterion(criterion: cr, value: valcr));//List of songs to create a playlist.
            //Here i use the method SongsbyCriterion to generate the list, which is why when i create a new playlist it shows the songs that apply to the criterion and the playlist itself.
            if (_playlist.Count() == 0)//checking whether the List<> of playlist is empty or not. This means we dont need to check if the name of the playlist has already been used.
            {
                if (ppl.Count() == 0)//since the List<Song> ppl calls the method SongsbyCriterion() we don't need to check if the criterion used or the value are right because the method already does that.
                    // so, if the List<Song> ppl is empty it means that either the criterion or the value introduced are wrong in which case we dont create the playlist and return false.
                {
                    Console.WriteLine("La información entregada es incorrecta, su playlist no ha sido creada, porfavor vuelva a intentarlo\n.");
                    return false;
                }
                else // and of List<Song> ppl is bigger than 0 means the given input was right so we create the playlist and we return true.
                {
                    Playlist _pl = new Playlist(np);
                    _pl.playlistsongs = ppl;
                    _playlist.Add(_pl);
                    return true;
                }
            }
            else // if we got here is becasue the List<Playlist>_playlist is not empty.
            {
                for (int i = 0; i < _playlist.Count(); i++) // we go through List<Playlist> _playlist.
                {
                    if (np == _playlist[i].Playlistname)
                    {
                        b += 1;                           // if there name for the playlist has already been used then we add 1 to the integer b.
                    }
                }
                if (b != a)// if b is diffrent than a means the name has been used
                {
                    Console.WriteLine("El nombre de playlist ingresado ya existe, su playlist no ha sido creada.\n");
                    return false;
                }
                else
                {
                    if (ppl.Count() == 0)
                    {
                        Console.WriteLine("La información entregada es incorrecta, su playlist no ha sido creada, porfavor vuelva a intentarlo\n.");
                        return false;
                    }
                    else 
                    {
                        Playlist _pl = new Playlist(np);
                        _pl.playlistsongs = ppl;
                        _playlist.Add(_pl);
                        return true;
                    }
                }
            }
        }
        public string PlayListinfo()//"VerCanciones()" method.
        {
            int e = 0;
            string finalplinfo = "";//string to be returned.
            if (_playlist.Count() == 0)
            {
                Console.WriteLine("Aun no has creado ninguna playlist!\n");
                return finalplinfo; // if no playlists have been created then the string should be empty.
            }
            else
            {
                for (int v = 0; v < _playlist.Count(); v++)//we go through the List<Playlist> _playlist.
                {
                    finalplinfo = finalplinfo.Insert(e, _playlist[v].Playlistname); // we add as string with the name of the playlist at the end of the origina string.
                    e += 1;
                    Console.WriteLine("Nombre de la playlist:{0}\n" , _playlist[v].Playlistname); // output.
                    for (int c = 0; c < _playlist[v].playlistsongs.Count(); c++)//we go through the List<Song> playlistsongs (fron the playlist Class).
                    {
                        finalplinfo = finalplinfo.Insert(e, _playlist[v].playlistsongs[c].Genre); // we add the song info in order to the string to be returned.
                        e += 1;
                        finalplinfo = finalplinfo.Insert(e, _playlist[v].playlistsongs[c].Artist);
                        e += 1;
                        finalplinfo = finalplinfo.Insert(e, _playlist[v].playlistsongs[c].Album);
                        e += 1;
                        finalplinfo = finalplinfo.Insert(e, _playlist[v].playlistsongs[c].Name);
                        e += 1;
                        Console.WriteLine("Genero:{0}.\nArtista:{1}.\nAlbum:{2}.\nNombre:{3}.\n", _playlist[v].playlistsongs[c].Genre, _playlist[v].playlistsongs[c].Artist, _playlist[v].playlistsongs[c].Album, _playlist[v].playlistsongs[c].Name);
                        //output.
                    }
                }
                return finalplinfo;
            }
        }
    }
}
