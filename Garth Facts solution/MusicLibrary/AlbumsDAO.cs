using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
    public class AlbumsDAO
    {

        string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GarthDB;Integrated Security=SSPI";

        public List<Album> getAllAlbums()
        {
            //creates a connection to the GarthDB local Database 
            
            string term = "";
            List<Album> albumsToReturn = new List<Album>();

            SqlConnection connection = new SqlConnection(connString);

            connection.Open();
            //gets all albums names from loacal database
            string searchPhrase = "%" + term + "%";
            SqlCommand command = new SqlCommand();
            command.CommandText =
            "SELECT * FROM albums WHERE AlbumName LIKE @term";

            command.Parameters.AddWithValue("@term", searchPhrase);
            command.Connection = connection;

            //fills datagrid data with data read from database
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        Id = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        AlbumArtist = reader.GetString(2),
                        AlbumYear = reader.GetInt32(3),
                        AlbumDesc = reader.GetString(4),
                        AlbumURL = reader.GetString(5),
                    };

                    albumsToReturn.Add(a);
                }//closes connection
                connection.Close();

                return albumsToReturn;
            }
        }
            public List<Album> getSearchAlbums(string search)
            {
            //establishes connection
                string term = "";
                List<Album> albumsToReturn = new List<Album>();

                SqlConnection connection = new SqlConnection(connString);

                connection.Open();
            // gets names of albums based on what you put in the search bar
                string searchPhrase = "%" + search + "%";
                SqlCommand command = new SqlCommand();
                command.CommandText =
                "SELECT * FROM albums WHERE AlbumName LIKE @search";

                command.Parameters.AddWithValue("@search", searchPhrase);
                command.Connection = connection;

                //fills datagrid with data read from database
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Album a = new Album
                        {
                            Id = reader.GetInt32(0),
                            AlbumName = reader.GetString(1),
                            AlbumArtist = reader.GetString(2),
                            AlbumYear = reader.GetInt32(3),
                            AlbumDesc = reader.GetString(4),
                            AlbumURL = reader.GetString(5),
                        };

                        albumsToReturn.Add(a);
                    }//closes connection
                    connection.Close();

                    return albumsToReturn;
                }

                
            }
        public List<AlbumFacts> getAlbumFacts(int albumID)
        {
            //establishes connection
            string term = "";
            List<AlbumFacts> albumsToReturn = new List<AlbumFacts>();

            SqlConnection connection = new SqlConnection(connString);

            connection.Open();
            // gets names of albums based on what you put in the search bar
            //string searchPhrase = "%" + search + "%";
            SqlCommand command = new SqlCommand();
            command.CommandText =
            "SELECT * FROM AlbumFacts WHERE AlbumID = @albumID";

            command.Parameters.AddWithValue("@albumID", albumID);
            command.Connection = connection;

            //fills datagrid with data read from database
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    AlbumFacts a = new AlbumFacts()
                    {
                        AlbumID = reader.GetInt32(0),
                        AlbumReleaseDate = reader.GetString(1),
                        AlbumStudio = reader.GetString(2),
                        AlbumDuration = reader.GetString(3),
                        AlbumLabel = reader.GetString(4)
                        
                    };

                    albumsToReturn.Add(a);
                }//closes connection
                connection.Close();

                return albumsToReturn;
            }
        }
           

        public List<song> getSongsForAlbum(int albumID)
        {//displays all songs in the clicked album
            List<song> songsToReturn = new List<song>();

            SqlConnection connection = new SqlConnection(connString);

            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM songs WHERE AlbumID = @albumID";
            command.Parameters.AddWithValue("@albumID", albumID);
            command.Connection = connection;

            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    song s = new song()
                    {
                        AlbumID = reader.GetInt32(0),
                        SongNumber = reader.GetInt32(1),
                        SongName = reader.GetString(2),
                        SongDuration = reader.GetString(3)
                    };

                    songsToReturn.Add(s);
                }

            }
            connection.Close();
            return songsToReturn;
        }
        }
    } 
