using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService
{
    static class DBItem
    {
        static public BsonDocument User(string name, string secondName, string email, string password, DateTime registrationDate)
        {
            BsonDocument _newDocument = new BsonDocument
                {
                    { "Imie", new BsonString(name) },
                    { "Nazwisko", new BsonString(secondName) },
                    { "Email", new BsonString(email) },
                    { "Haslo", new BsonString(password) },
                    { "Skomentowane_filmy", new BsonInt32(0) },
                    { "Data_rejestracji", new BsonDateTime(registrationDate) }
                };

            return _newDocument;
        }

        static public BsonDocument Movie(string name, string secondName, string email, string password, DateTime registrationDate)
        {
            BsonDocument _newDocument = new BsonDocument
                {
                    { "Imie", new BsonString(name) },
                    { "Nazwisko", new BsonString(secondName) },
                    { "Email", new BsonString(email) },
                    { "Haslo", new BsonString(password) },
                    { "Skomentowane_filmy", new BsonInt32(0) },
                    { "Data_rejestracji", new BsonDateTime(registrationDate) }
                };

            return _newDocument;
        }

        static public BsonDocument Comment(string name, string secondName, string email, string movieTitle, string contents, DateTime addDate)
        {
                BsonDocument _newDocument = new BsonDocument
                {
                    {"Imie", new BsonString(name) },
                    {"Nazwisko", new BsonString(secondName)},
                    {"Email", new BsonString(email)},
                    {"Nazwa_filmu", new BsonString(movieTitle) },
                    {"Tresc", new BsonString(contents)},
                    {"Data_dodania", new BsonDateTime(addDate) }
                };

            return _newDocument;
        }
    }
}
