using DataService;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesDatabase
{
    public partial class addUserForm : Form
    {

        public BsonDocument Document;
        public addUserForm()
        {
            InitializeComponent();
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to add user to database?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BsonDocument _newDocument = DBItem.Movie(nameTxt.Text, secondNameTxt.Text, emailTxt.Text, passwordTxt.Text, rdDateTimePicker.Value);

                Document = _newDocument;
                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
