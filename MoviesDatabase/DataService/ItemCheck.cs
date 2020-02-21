using MoviesDatabase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace DataService
{
    public class ItemCheck
    {
        private string title;
        private int year;
        private int length;
        private string directors;
        private string genre;
        private string description;
        private string name;
        private string secondName;
        private string email;
        private string contents;
        private DateTime addDate;
        private string password;
        private DateTime registrationDate;
        private object selectedNameSurnameEmail;
        private object selectedMovie;





        public ItemCheck(string _title, int _year, int _length, string _directors, string _genre, string _description)
        {
            title = _title;
            year = _year;
            length = _length;
            directors = _directors;
            genre = _genre;
            description = _description;

        }

        public ItemCheck(object _selectedNameSurnameEmail, object _selectedMovie, string _contents, DateTime _addDate)
        {
            selectedNameSurnameEmail = _selectedNameSurnameEmail;
            selectedMovie = _selectedMovie;
            contents = _contents;
            addDate = _addDate;
        }

        public ItemCheck(string _name, string _secondName, string _email, string _password, DateTime _registrationDate)
        {
            name = _name;
            secondName = _secondName;
            email = _email;
            password = _password;
            registrationDate = _registrationDate;
        }


        public bool MovieCheck(bool checkOnlyDB, DataSet itemList)
        {
            bool _anyErrors = false;
            List<string> _dataGridTitlesList = new List<string>();
            List<string> _dbTitlesList = new List<string>();
            Regex _yearRegex = new Regex(@"(\d{4})");
            Regex _lengthRegex = new Regex(@"(\d{3})");
            Regex _onlyLetters = new Regex(@"^[a-zA-Z?:,. \s?]+$");

            if (checkOnlyDB)
            {
                _dbTitlesList = MongoQueries.GetMoviesTitles();
            }
            else
            {
                if (itemList.Tables.Count == 0)
                {
                    _dbTitlesList = MongoQueries.GetMoviesTitles();
                }
                else
                {
                    _dbTitlesList = MongoQueries.GetMoviesTitles();

                    foreach (var item in itemList.Tables[0].AsEnumerable())
                    {
                        _dataGridTitlesList.Add(item["Title"].ToString());
                    }

                }
            }

            if ((_dbTitlesList.Contains(title) || _dataGridTitlesList.Contains(title)) || title == string.Empty)
            {
                MessageBox.Show("The title is inappropiate or is already given!", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _anyErrors = true;
            }
            else if (!(_yearRegex.IsMatch(year.ToString())) || year.ToString() == string.Empty)
            {
                MessageBox.Show("Give a proper year of production!", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _anyErrors = true;
            }
            else if (!(_lengthRegex.IsMatch(length.ToString())) || length.ToString() == string.Empty)
            {
                MessageBox.Show("Give a proper duration of movie!", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _anyErrors = true;
            }
            else if (!(_onlyLetters.IsMatch(directors)) || directors == string.Empty)
            {
                MessageBox.Show("Give a proper directors name/names!", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _anyErrors = true;
            }
            else if (!(_onlyLetters.IsMatch(genre)) || genre == string.Empty)
            {
                MessageBox.Show("Give a proper film genre/genres!", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _anyErrors = true;
            }
            else if (description== string.Empty)
            {
                MessageBox.Show("Give a proper description!", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _anyErrors = true;
            }
            else
            {
                _anyErrors = false;
            }

            return _anyErrors;
        }

        public bool CommentCheck()
        {
            bool _anyErrors = false;

            if (selectedNameSurnameEmail == null)
            {
                MessageBox.Show("Select user which will add a comment!", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _anyErrors = true;
            }
            else if (selectedMovie == null)
            {
                MessageBox.Show("Select movie which will be commented!", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _anyErrors = true;
            }
            else if (contents == string.Empty)
            {
                MessageBox.Show("Give a proper comment input!", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _anyErrors = true;
            }

            return _anyErrors;
        }

        public bool UserCheck()
        {
            bool _anyErrors = false;
            List<string> _dbEmailsList = MongoQueries.GetUsersEmails();

            if(name == String.Empty)
            {
                MessageBox.Show("Given name is inappropiate!", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _anyErrors = true;
            }
            else if(secondName == String.Empty)
            {
                MessageBox.Show("Given second name is inappropiate!", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _anyErrors = true;
            }
            else if(_dbEmailsList.Contains(email))
            {
                MessageBox.Show("This email is already given! Please use another.", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _anyErrors = true;
            }

            return _anyErrors;
        }

    }
}
