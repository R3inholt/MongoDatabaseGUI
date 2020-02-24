using MongoDB.Driver;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using System.Windows.Forms;
using System;
using MoviesDatabase.MongoDB;
using DataService;

namespace MoviesDatabase
{


    public static class MongoQueries
    {
        static IMongoDatabase _db = MongoConnection.Establish();


        static IMongoCollection<BsonDocument> _movieCollection = _db.GetCollection<BsonDocument>("Filmy");
        static IMongoCollection<BsonDocument> _commentsCollection = _db.GetCollection<BsonDocument>("Komentarze");
        static IMongoCollection<BsonDocument> _userCollection = _db.GetCollection<BsonDocument>("Użytkownicy");

        public enum _nestedGrid
        {
            Movies_Comments,
            Comments_Users,
            Users_Comments

        }






        public static object GetAllComments()
        {
            _nestedGrid[] nestedItems = new _nestedGrid[] { _nestedGrid.Comments_Users };

            string fieldName = "Pokaż dane użytkownika";

            var queryResult = _commentsCollection.Aggregate()
                .Lookup("Użytkownicy", "Email", "Email", fieldName)
                .Project(Builders<BsonDocument>.Projection.Exclude("_id"))
                .ToList();

            return DataGridHelper.CreateNestedGrid(queryResult, nestedItems, fieldName);
        }

        public static object GetAllUsers()
        {
            _nestedGrid[] nestedItems = new _nestedGrid[] { _nestedGrid.Users_Comments };

            string fieldName = "Wszystkie komentarze użytkownika";

            var queryResult = _userCollection.Aggregate()
                .Lookup("Komentarze", "Email", "Email", fieldName)
                .Project(Builders<BsonDocument>.Projection.Exclude("_id"))
                .ToList();

            return DataGridHelper.CreateNestedGrid(queryResult, nestedItems, fieldName);
        }

        public static object GetAllMovies()
        {
            _nestedGrid[] nestedItems = new _nestedGrid[] { _nestedGrid.Movies_Comments };

            string fieldName = "Komentarze";

            List<BsonDocument> queryResult = _movieCollection.Aggregate()
                .Lookup("Komentarze", "tytul", "Nazwa_filmu", fieldName)
                .Project(Builders<BsonDocument>.Projection.Exclude("_id"))
                .ToList();

            return DataGridHelper.CreateNestedGrid(queryResult, nestedItems, fieldName);

        }



        public static void AddMovies(List<BsonDocument> moviesList)
        {
            _movieCollection.InsertMany(moviesList);
        }

        public static void AddMovie(BsonDocument newMovie)
        {
            _movieCollection.InsertOne(newMovie);

        }

        public static void AddComment(BsonDocument newComment)
        {
            _commentsCollection.InsertOne(newComment);
        }

        public static void AddUser(BsonDocument newUser)
        {
            _userCollection.InsertOne(newUser);
        }



        public static void UpdateCommentAmount(string movieTitle,string userEmail)
        {
            var movieFilter = Builders<BsonDocument>.Filter.Eq("tytul", movieTitle);
            var movieUpdate = new BsonDocument("$inc", new BsonDocument { { "ilosc_komentarzy", 1 } });

            _movieCollection
                .FindOneAndUpdate(movieFilter, movieUpdate);

            var userFilter = Builders<BsonDocument>.Filter.Eq("Email", userEmail);
            var userUpdate = new BsonDocument("$inc", new BsonDocument { { "Skomentowane_filmy", 1 } });

            _userCollection
                .FindOneAndUpdate(userFilter, userUpdate);


        }


        public static void DeleteMany(FilterDefinition<BsonDocument> deleteAll, List<string> titlesList)
        {
           
                      
            var query = _movieCollection
                .DeleteMany(deleteAll)
                .DeletedCount;
                
            var commentFilter = Builders<BsonDocument>.Filter.AnyIn("Nazwa_filmu", titlesList);

            var deletedOrphans = _commentsCollection
                .DeleteMany(commentFilter)
                .DeletedCount;


            MessageBox.Show("Deleted " + query + " movies from database and " + deletedOrphans + " associated comments.");
              
        }


        public static object GetFullNameAndEmail()
        {
            List<BsonDocument> getUsers = _userCollection
                .Find(Builders<BsonDocument>.Filter.Empty)
                .Project(Builders<BsonDocument>.Projection.Include("Imie").Include("Nazwisko").Include("Email").Exclude("_id"))
                .ToList();

            return getUsers;
        }

        public static List<string> GetMoviesTitles()
        {
            List<string> titlesList = new List<string>();

            List<BsonDocument> queryResult = _movieCollection
                .Find(Builders<BsonDocument>.Filter.Empty)
                .ToList();



            foreach (var item in queryResult)
            {
                titlesList.Add(item["tytul"].ToString());
            }

            return titlesList;
        }

        public static List<string> GetUsersEmails()
        {
            List<string> usersEmails = new List<string>();

            List<BsonDocument> queryResult = _userCollection
                .Find(Builders<BsonDocument>.Filter.Empty)
                .ToList();

            foreach (var item in queryResult)
            {
                usersEmails.Add(item["Email"].ToString());
            }

            return usersEmails;

        }

        
        public static object FilterBy(string filter, string check, string field)
        {
            if(check == "Movies")
            {
                _nestedGrid[] nestedItems = new _nestedGrid[] { _nestedGrid.Movies_Comments };
                string fieldName = "Komentarze";


                var filterQuery = Builders<BsonDocument>.Filter.Regex(field, new BsonRegularExpression(filter, "i"));
                var queryResult = _movieCollection
                .Aggregate()
                .Lookup("Komentarze", "tytul", "Nazwa_filmu", fieldName)
                .Match(filterQuery)
                .ToList();


                return DataGridHelper.CreateNestedGrid(queryResult, nestedItems, fieldName);
            }
            else if(check == "Comments")
            {
                _nestedGrid[] nestedItems = new _nestedGrid[] { _nestedGrid.Comments_Users };
                string fieldName = "Pokaż dane użytkownika";
               
                var filterQuery = Builders<BsonDocument>.Filter.Regex(field, new BsonRegularExpression(filter, "i"));
                var queryResult = _movieCollection
                .Aggregate()
                .Lookup("Użytkownicy", "Email", "Email", fieldName)
                .Match(filterQuery)
                .ToList();


                return DataGridHelper.CreateNestedGrid(queryResult, nestedItems, fieldName);
            }
            else if(check == "Users")
            {
                _nestedGrid[] nestedItems = new _nestedGrid[] { _nestedGrid.Users_Comments };
                string fieldName = "Wszystkie komentarze użytkownika";

                var filterQuery = Builders<BsonDocument>.Filter.Regex(field, new BsonRegularExpression(filter, "i"));
                var queryResult = _movieCollection
                .Aggregate()
                .Lookup("Komentarze", "Email", "Email", fieldName)
                .Match(filterQuery)
                .ToList();


                return DataGridHelper.CreateNestedGrid(queryResult, nestedItems, fieldName);
            }

            return 0;
        }

    }
}

