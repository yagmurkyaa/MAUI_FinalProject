using SQLite;
using _180201028_yagmurkaya_cproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180201028_yagmurkaya_cproject.DataTransaction
{
    public class DBTrans
    {
        public string dbPath;
        private SQLiteConnection conn;

        public DBTrans(string _dbPath)
        {
            this.dbPath = _dbPath;
        }

        public void Init()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<Movie>();
            conn.CreateTable<Actor>();
            conn.CreateTable<MovieActor>();
            conn.CreateTable<Place>();
        }

        //INITIALIZING TABLES
        public List<Movie> GetAllMovies()
        {
            Init();
            return conn.Table<Movie>().ToList();
        }
        public List<Actor> GetAllActors()
        {
            Init();
            return conn.Table<Actor>().ToList();
        }
        public List<MovieActor> GetAllMovieActors()
        {
            Init();
            return conn.Table<MovieActor>().ToList();
        }
        public List<Place> GetAllPlaces()
        {
            Init();
            return conn.Table<Place>().ToList();
        }

        //INSERTION
        public void AddMovie(Movie movie)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(movie);
        }
        public void AddActor(Actor actor)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(actor);
        }
        public void AddMovieActor(MovieActor movieActor)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(movieActor);
        }
        public void AddPlace(Place place)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(place);
        }

        //DELETION
        public void DeleteMovie(int movieID)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Movie { MovieID = movieID });
        }
        public void DeleteActor(int actorID)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Actor { ActorID = actorID });
        }
        public void DeleteMovieActor(int movieActorID)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new MovieActor { MovieActorID = movieActorID });
        }
        public void DeletePlace(int placeID)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Place { PlaceID = placeID });
        }
    }
}
