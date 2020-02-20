using DataService;
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
    public partial class addCommentForm : Form
    {
        public BsonDocument NewComment = new BsonDocument();
        public string MovieTitle = "";
        public string UserEmail = "";

        List<BsonDocument> _userList = (List<BsonDocument>)MongoQueries.GetFullNameAndEmail();
        List<string> _moviesTitles = MongoQueries.GetMoviesTitles();
        List<string> _userInfo = new List<string>();

        void _loadControlsData()
        {
            foreach (var item in _moviesTitles)
            {
                moviesComboBox.Items.Add(item);
            }

            foreach (var item in _userList)
            {
                string newUser = "";
                int i = 0;

                foreach (var element in item)
                {
                    if (i == 2)
                        newUser += ", " + element.Value.ToString();
                    if (i == 1)
                        newUser += element.Value.ToString();
                    if (i == 0)
                        newUser += element.Value.ToString() + " ";
                    i++;

                }

                _userInfo.Add(newUser);
            }


            foreach (var item in _userInfo)
            {
                nameSurnameEmailComboBox.Items.Add(item);
            }
        }
        public addCommentForm()
        {
            InitializeComponent();

            _loadControlsData();
           
        }

        private void addCommentBtn_Click(object sender, EventArgs e)
        {
            if(nameSurnameEmailComboBox.SelectedItem == null)
            {
                MessageBox.Show("Select user which will add a comment!", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(moviesComboBox.SelectedItem == null)
            {
                MessageBox.Show("Select movie which will be commented!", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
            else if(commentTxtBox.Text == string.Empty)
            {
                MessageBox.Show("Give a proper comment input!", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(MessageBox.Show("Do you want to add these movies to database?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
            }
            if(this.DialogResult == DialogResult.OK)
            {
                string name = nameSurnameEmailComboBox.SelectedItem.ToString().Split(' ')[0];
                string secondName = nameSurnameEmailComboBox.SelectedItem.ToString().Split(' ', ',')[1];
                string email = nameSurnameEmailComboBox.SelectedItem.ToString().Substring(nameSurnameEmailComboBox.SelectedItem.ToString().LastIndexOf(',') + 2);
                string movieTitle = moviesComboBox.SelectedItem.ToString();
                string contents = commentTxtBox.Text;
                DateTime addDate = commentDateTimePicker.Value;

                BsonDocument _document = DBItem.Comment(name, secondName, email, movieTitle, contents, addDate);

                NewComment = _document;
                MovieTitle = movieTitle;
                UserEmail = email;




            }
        }
    }
}
