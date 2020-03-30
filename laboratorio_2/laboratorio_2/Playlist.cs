using System;
using System.Collections.Generic; //needed to work with lists.
using System.Linq;    //needed to work with lists.
namespace laboratorio_2
{
    public class Playlist
    {
        public string Playlistname { get; set; }
        public List<Song> playlistsongs = new List<Song>();
        public Playlist(string nm) // Playlist builder.
        {
            Playlistname = nm;
        }
        public void ShowPlaylist(Playlist playy) // method that shows the information of the current playlist.
        {
            Console.WriteLine("Nombre de playlist:{0}.\n", playy.Playlistname);//name of the playlist output.
            for (int i = 0; i < playy.playlistsongs.Count(); i++)//we go through the playlist.
            {
                Console.WriteLine("Genero:{0}.\nArtista:{1}.\nAlbum:{2}.\nNombre:{3}.\n",playy.playlistsongs[i].Genre, playy.playlistsongs[i].Artist, playy.playlistsongs[i].Album, playy.playlistsongs[i].Name);
                //we print the songs information.
            }
        }
    }
}
