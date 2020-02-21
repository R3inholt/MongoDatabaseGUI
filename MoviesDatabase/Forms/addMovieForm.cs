using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesDatabase
{
    public partial class addMovieForm : Form
    {
        public int amount()
        {
            return MoviesList.Count;
        }

        public List<BsonDocument> MoviesList = new List<BsonDocument>();
        DataSet _itemList = new DataSet();
        bool _firstInsert = true;

        bool CheckError(bool checkOnlyDB)
        {            
            bool _anyErrors = false;
            List<string> _dataGridTitlesList = new List<string>();
            List<string> _dbTitlesList = new List<string>();
            Regex _yearRegex = new Regex(@"(\d{4})");
            Regex _lengthRegex = new Regex(@"(\d{3})");
            Regex _onlyLetters = new Regex(@"^[a-zA-Z?:,. \s?]+$");

            if(checkOnlyDB)
            {
                _dbTitlesList = MongoQueries.GetMoviesTitles();
            }
            else
            {
                if (_itemList.Tables.Count == 0)
                {
                    _dbTitlesList = MongoQueries.GetMoviesTitles();
                }
                else
                {
                    _dbTitlesList = MongoQueries.GetMoviesTitles();

                    foreach (var item in _itemList.Tables[0].AsEnumerable())
                    {
                        _dataGridTitlesList.Add(item["Title"].ToString());
                    }

                }
            }




            if ((_dbTitlesList.Contains(titleTxtBox.Text) || _dataGridTitlesList.Contains(titleTxtBox.Text)) || titleTxtBox.Text == string.Empty)
            {
                MessageBox.Show("The title is inappropiate or is already given!", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _anyErrors = true;
            }
            else if (!(_yearRegex.IsMatch(yearTxtBox.Text)) || yearTxtBox.Text == string.Empty)
            {
                MessageBox.Show("Give a proper year of production!", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _anyErrors = true;
            }
            else if (!(_lengthRegex.IsMatch(lengthTxtBox.Text)) || lengthTxtBox.Text == string.Empty)
            {
                MessageBox.Show("Give a proper duration of movie!", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _anyErrors = true;
            }
            else if (!(_onlyLetters.IsMatch(directorsTxtBox.Text)) || directorsTxtBox.Text == string.Empty)
            {
                MessageBox.Show("Give a proper directors name/names!", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _anyErrors = true;
            }
            else if (!(_onlyLetters.IsMatch(genreTxtBox.Text)) || genreTxtBox.Text == string.Empty)
            {
                MessageBox.Show("Give a proper film genre/genres!", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _anyErrors = true;
            }
            else if (descriptionLabel.Text == string.Empty)
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
        DataTable fillRows(DataTable newItem)
        {
            newItem.Columns.Add("Title");
            newItem.Columns.Add("Year of release");
            newItem.Columns.Add("Duration");
            newItem.Columns.Add("Directors");
            newItem.Columns.Add("Genre");
            newItem.Columns.Add("Description");

            var _row = newItem.NewRow();

            _row["Title"] = titleTxtBox.Text;
            _row["Year of release"] = Convert.ToInt32(yearTxtBox.Text);
            _row["Duration"] = Convert.ToInt32(lengthTxtBox.Text);
            _row["Directors"] = directorsTxtBox.Text;
            _row["Genre"] = genreTxtBox.Text;
            _row["Description"] = descriptionTxtBox.Text;

            newItem.Rows.Add(_row);

            return newItem;

        }
        void addOneOperation()
        {

            if(CheckError(true) == true)
            {
                //encountered an error, do nothing
            }
            else
            {
                if(MessageBox.Show("Do you want to add this movie to database?", "Question", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    //do nothing
                }
            }
        }


        public addMovieForm()
        {
            InitializeComponent();
        }

        private void addToListBtn_Click(object sender, EventArgs e)
        {
            if (CheckError(false) == false)
            {
                DataTable _newItem = new DataTable();
                _newItem = fillRows(_newItem);

                if (_firstInsert)
                {
                    _itemList.Tables.Add(_newItem);
                    _firstInsert = false;
                }
                else
                {
                    _itemList.Tables[0].Merge(_newItem);
                }

                listDataGrid.DataSource = _itemList.Tables[0];
            }
            else
            {
                //encountered an error, do nothing then
            }
        }

        private void addOneBtn_Click(object sender, EventArgs e)
        {
            addOneOperation();
        }

        private void addAllBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in _itemList.Tables[0].AsEnumerable())
            {
                var _document = new BsonDocument
                {
                    {"tytul", new BsonString(item["Title"].ToString()) },
                    {"rok_wydania", new BsonInt32(Convert.ToInt32(item["Year of release"])) },
                    {"dlugosc_trwania", new BsonInt32(Convert.ToInt32(item["Duration"])) },
                    {"rezyseria", new BsonString(item["Directors"].ToString()) },
                    {"gatunek", new BsonString(item["Genre"].ToString())},
                    {"krotki_opis", new BsonString(item["Description"].ToString()) },
                    {"ilosc_komentarzy", new BsonInt32(0) }
                };


                MoviesList.Add(_document);
            }

            foreach (var item in MoviesList)
            {
                MessageBox.Show(item.ToString());
            }

            if (MessageBox.Show("Do you want to add these movies to database?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                //do nothing
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
