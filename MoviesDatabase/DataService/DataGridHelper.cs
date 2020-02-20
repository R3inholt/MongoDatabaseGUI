using MongoDB.Bson;
using MoviesDatabase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService
{
    public static class DataGridHelper
    {
        static bool _nested;

        public static object CreateNestedGrid(List<BsonDocument> queryResult, MongoQueries._nestedGrid[] nestedItems, string fieldName)
        {
            DataSet _dataSet = new DataSet();


            if (nestedItems.Contains((MongoQueries._nestedGrid)Enum.Parse(typeof(MongoQueries._nestedGrid), "Movies_Comments")) && fieldName == "Komentarze")
            {
                var _moviesDT = CreateMoviesDT(queryResult);
                var _commentsDT = CreateCommentsDT(queryResult, fieldName, _nested = true);

                _dataSet.Tables.Add(_moviesDT);
                _dataSet.Tables.Add(_commentsDT);

            }
            else if (nestedItems.Contains((MongoQueries._nestedGrid)Enum.Parse(typeof(MongoQueries._nestedGrid), "Users_Comments")) && fieldName == "Wszystkie komentarze użytkownika")
            {
                var _usersDT = CreateUsersDT(queryResult, fieldName, _nested = false);
                var _commentsDT = CreateCommentsDT(queryResult, fieldName, _nested = true);

                _dataSet.Tables.Add(_usersDT);
                _dataSet.Tables.Add(_commentsDT);

            }
            else if (nestedItems.Contains((MongoQueries._nestedGrid)Enum.Parse(typeof(MongoQueries._nestedGrid), "Comments_Users")) && fieldName == "Pokaż dane użytkownika")
            {
                var _commentsDT = CreateCommentsDT(queryResult, fieldName, _nested = false);
                var _usersDT = CreateUsersDT(queryResult, fieldName, _nested = true);

                _dataSet.Tables.Add(_commentsDT);
                _dataSet.Tables.Add(_usersDT);
            }

            return CreateRelation(_dataSet, nestedItems);

        }

        public static DataTable CreateMoviesDT(List<BsonDocument> queryResult)
        {
            List<string> _movieDocumentFields = new List<string>() { "tytul", "rok_wydania", "dlugosc_trwania", "rezyseria", "gatunek", "krotki_opis", "ilosc_komentarzy" };
            List<string> _movieDataTableColumns = new List<string>() { "Tytuł", "Rok wydania", "Długość trwania", "Reżyseria", "Gatunek", "Krótki opis", "Ilość komentarzy" };

            DataTable _dtMovies = new DataTable();

            foreach (var columnName in _movieDataTableColumns)
            {
                _dtMovies.Columns.Add(columnName);
            }

            var _zippedValues = _movieDocumentFields.Zip(_movieDataTableColumns, (mdf, mdt) => new { movieDocumentField = mdf, movieDataTableColumn = mdt });

            foreach (var item in queryResult)
            {
                var _row = _dtMovies.NewRow();

                foreach (var zv in _zippedValues)
                {
                    _row[zv.movieDataTableColumn] = item[zv.movieDocumentField];
                }

                _dtMovies.Rows.Add(_row);
            }

            return _dtMovies;
        }

        public static DataTable CreateCommentsDT(List<BsonDocument> queryResult, string fieldName, bool nested = false)
        {
            DataTable _dtComments = new DataTable();

            List<string> _commentDocumentFields = new List<string>() {"Imie", "Nazwisko", "Email", "Nazwa_filmu", "Tresc", "Data_dodania"};
            List<string> _commentDataTableColumns = new List<string>() { "Imię", "Nazwisko", "Email", "Nazwa filmu", "Treść", "Data dodania" };

            var _zippedValues = _commentDocumentFields.Zip(_commentDataTableColumns, (cdf, cdt) => new { commentDocumentField = cdf, commentDataTableColumn = cdt});

            foreach (var columnName in _commentDataTableColumns)
            {
                _dtComments.Columns.Add(columnName);
            }

            foreach (var item in queryResult)
            {
                if (nested)
                {

                    for (int i = 0; i < item[fieldName].AsBsonArray.Count; i++)
                    {
                        int j = 1;
                        var _row = _dtComments.NewRow();
                        foreach (var columnName in _commentDataTableColumns)
                        {
                            _row[columnName] = item[fieldName][i][j];
                            j++;
                        }
                        _dtComments.Rows.Add(_row);
                    }

                }
                else
                {
                    var _row = _dtComments.NewRow();

                    foreach (var zv in _zippedValues)
                    {
                        _row[zv.commentDataTableColumn] = item[zv.commentDocumentField];
                    }

                    _dtComments.Rows.Add(_row);
                }

            }


            return _dtComments;
        }

        public static DataTable CreateUsersDT(List<BsonDocument> queryResult, string fieldName, bool nested = false)
        {
            DataTable _dtUsers = new DataTable();

            List<string> _usersDocumentFields = new List<string> { "Imie", "Nazwisko", "Email", "Haslo", "Skomentowane_filmy", "Data_rejestracji" };
            List<string> _usersDataTableColumns = new List<string> { "Imię", "Nazwisko", "Email", "Haslo", "Skomentowane filmy", "Data rejestracji"};

            var _zippedValues = _usersDocumentFields.Zip(_usersDataTableColumns, (udf, udt) => new { usersDocumentField = udf, usersDataTableColumn = udt });

            foreach (var columnName in _usersDataTableColumns)
            {
                _dtUsers.Columns.Add(columnName);
            }


            foreach (var item in queryResult)
            {
                if (nested)
                {
                    for (int i = 0; i < item[fieldName].AsBsonArray.Count; i++)
                    {

                        int j = 1;
                        var _row = _dtUsers.NewRow();
                        foreach (var columnName in _usersDataTableColumns)
                        {
                            _row[columnName] = item[fieldName][i][j];
                            j++;
                        }
                        _dtUsers.Rows.Add(_row);

                    }
                }
                else
                {
                    var _row = _dtUsers.NewRow();

                    foreach (var zv in _zippedValues)
                    {
                        _row[zv.usersDataTableColumn] = item[zv.usersDocumentField];
                    }

                    _dtUsers.Rows.Add(_row);
                }


            }
            return _dtUsers;
        }

        public static DataTable CreateRelation(DataSet dataSet, MongoQueries._nestedGrid[] nestedItems)
        {

            if (nestedItems.Contains((MongoQueries._nestedGrid)Enum.Parse(typeof(MongoQueries._nestedGrid), "Movies_Comments")))
            {
                DataRelation _commentsMoviesRelation = new DataRelation("Komentarze pod filmem", dataSet.Tables[0].Columns[0], dataSet.Tables[1].Columns[3], true);

                dataSet.Relations.Add(_commentsMoviesRelation);
            }
            else if (nestedItems.Contains((MongoQueries._nestedGrid)Enum.Parse(typeof(MongoQueries._nestedGrid), "Users_Comments")))
            {
                DataRelation _usersCommentsRelation = new DataRelation("Wszystkie komentarze użytkownika", dataSet.Tables[0].Columns[2], dataSet.Tables[1].Columns[2], true);

                dataSet.Relations.Add(_usersCommentsRelation);
            }
            else if (nestedItems.Contains((MongoQueries._nestedGrid)Enum.Parse(typeof(MongoQueries._nestedGrid), "Comments_Users")))
            {
                DataRelation _commentsUsersRelation = new DataRelation("Pokaż dane użytkownika", dataSet.Tables[0].Columns[2], dataSet.Tables[1].Columns[2], false);

                dataSet.Relations.Add(_commentsUsersRelation);
            }

            return dataSet.Tables[0];
        }



    }
}
