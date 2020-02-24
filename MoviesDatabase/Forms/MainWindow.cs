using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using DataService;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace MoviesDatabase
{
    public partial class mainWindowForm : Form
    {
        public enum _checkChoice
        {
            Movies,
            Comments,
            Users
        };

        _checkChoice check;

        public mainWindowForm()
        { 
            InitializeComponent();
        }

        private void getAllMoviesBtn_Click(object sender, EventArgs e)
        {
            dataGrid1.DataSource = MongoQueries.GetAllMovies();            
            check = _checkChoice.Movies;
            filterComboBox.Items.Clear();
            DataHelper.FillFilterComboBox(check, filterComboBox);           
        }

        private void getAllComments_Click(object sender, EventArgs e)
        {
            dataGrid1.DataSource = MongoQueries.GetAllComments();
            check = _checkChoice.Comments;
            filterComboBox.Items.Clear();
            DataHelper.FillFilterComboBox(check, filterComboBox);
        }

        private void showAllUsersBtn_Click(object sender, EventArgs e)
        {
            dataGrid1.DataSource = MongoQueries.GetAllUsers();
            check = _checkChoice.Users;
            filterComboBox.Items.Clear();
            DataHelper.FillFilterComboBox(check, filterComboBox);
        }



        private void addMovieBtn_Click(object sender, EventArgs e)
        {
            using(addMovieForm addMovieForm = new addMovieForm())
            {
                DialogResult dr = addMovieForm.ShowDialog();

                if(dr == DialogResult.OK)
                {
                    MongoQueries.AddMovie(addMovieForm.NewMovie);
                    MessageBox.Show("Successfully added 1 movie.", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if(dr == DialogResult.Yes)
                {
                    int amount = addMovieForm.amount();
                    MongoQueries.AddMovies(addMovieForm.MoviesList);
                    MessageBox.Show("Successfully added " + amount + " movies.", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void addCommentBtn_Click(object sender, EventArgs e)
        {
            using(addCommentForm addComment = new addCommentForm())
            {
                DialogResult dr = addComment.ShowDialog();

                if (dr == DialogResult.Yes)
                {
                    MongoQueries.AddComment(addComment.NewComment);
                    MongoQueries.UpdateCommentAmount(addComment.MovieTitle, addComment.UserEmail);
                    MessageBox.Show("Comment added successfully.", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
            int itemIndex = 0;
            DataTable myTable = (DataTable)dataGrid1.DataSource;

            List<string> argumentsList = new List<string>();


            foreach (DataRow item in myTable.Rows)
            {
                if(dataGrid1.IsSelected(itemIndex))
                {
                    if(check.ToString() == "Movies")
                        argumentsList.Add(item["Tytuł"].ToString());
                    if (check.ToString() == "Comment")
                        argumentsList.Add(item["Tytuł"].ToString());

                }

                itemIndex++;
                
            }

            var deleteAll = Builders<BsonDocument>.Filter.AnyIn("tytul", argumentsList);
            
            MongoQueries.DeleteMany(deleteAll, argumentsList);

            getAllMoviesBtn_Click(sender, e);

        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            using(addUserForm addUserForm = new addUserForm())
            {
                if(addUserForm.ShowDialog() == DialogResult.OK)
                {
                    MongoQueries.AddUser(addUserForm.Document);
                }
            }
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            foreach(var foo in Enum.GetValues(typeof(_checkChoice)))
            {
                if(check.ToString() == foo.ToString())
                {
                    dataGrid1.DataSource = MongoQueries.FilterBy(findTxt.Text, check.ToString(), filterComboBox.SelectedItem.ToString());
                }
            }
        }
    }
}
