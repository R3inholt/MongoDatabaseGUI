namespace MoviesDatabase
{
    partial class mainWindowForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.findTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showAllUsersBtn = new System.Windows.Forms.Button();
            this.addCommentBtn = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.addMovieBtn = new System.Windows.Forms.Button();
            this.getAllMoviesBtn = new System.Windows.Forms.Button();
            this.getAllComments = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.AlternatingBackColor = System.Drawing.Color.White;
            this.dataGrid1.BackColor = System.Drawing.Color.White;
            this.dataGrid1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGrid1.CaptionBackColor = System.Drawing.Color.White;
            this.dataGrid1.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dataGrid1.CaptionForeColor = System.Drawing.Color.Lavender;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid1.FlatMode = true;
            this.dataGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dataGrid1.ForeColor = System.Drawing.Color.Black;
            this.dataGrid1.GridLineColor = System.Drawing.Color.ForestGreen;
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.ForestGreen;
            this.dataGrid1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGrid1.LinkColor = System.Drawing.Color.ForestGreen;
            this.dataGrid1.Location = new System.Drawing.Point(0, 0);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.DarkGreen;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.White;
            this.dataGrid1.PreferredColumnWidth = 150;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.PaleGreen;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid1.Size = new System.Drawing.Size(1104, 644);
            this.dataGrid1.TabIndex = 12;
            // 
            // findTxt
            // 
            this.findTxt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.findTxt.Location = new System.Drawing.Point(829, 62);
            this.findTxt.Name = "findTxt";
            this.findTxt.Size = new System.Drawing.Size(210, 23);
            this.findTxt.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.showAllUsersBtn);
            this.panel1.Controls.Add(this.addCommentBtn);
            this.panel1.Controls.Add(this.addUserBtn);
            this.panel1.Controls.Add(this.addMovieBtn);
            this.panel1.Controls.Add(this.getAllMoviesBtn);
            this.panel1.Controls.Add(this.getAllComments);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 744);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MoviesDatabase.Properties.Resources.c__logo;
            this.pictureBox2.Location = new System.Drawing.Point(149, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MoviesDatabase.Properties.Resources.mongodb_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // showAllUsersBtn
            // 
            this.showAllUsersBtn.BackColor = System.Drawing.Color.Gray;
            this.showAllUsersBtn.FlatAppearance.BorderSize = 0;
            this.showAllUsersBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.showAllUsersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.showAllUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllUsersBtn.Font = new System.Drawing.Font("Calibri", 10F);
            this.showAllUsersBtn.ForeColor = System.Drawing.Color.White;
            this.showAllUsersBtn.Image = global::MoviesDatabase.Properties.Resources.man_user;
            this.showAllUsersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showAllUsersBtn.Location = new System.Drawing.Point(12, 378);
            this.showAllUsersBtn.Name = "showAllUsersBtn";
            this.showAllUsersBtn.Size = new System.Drawing.Size(189, 65);
            this.showAllUsersBtn.TabIndex = 10;
            this.showAllUsersBtn.Text = "     Show all users";
            this.showAllUsersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showAllUsersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.showAllUsersBtn.UseVisualStyleBackColor = false;
            this.showAllUsersBtn.Click += new System.EventHandler(this.showAllUsersBtn_Click);
            // 
            // addCommentBtn
            // 
            this.addCommentBtn.BackColor = System.Drawing.Color.Gray;
            this.addCommentBtn.FlatAppearance.BorderSize = 0;
            this.addCommentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.addCommentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.addCommentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCommentBtn.Font = new System.Drawing.Font("Calibri", 10F);
            this.addCommentBtn.ForeColor = System.Drawing.Color.White;
            this.addCommentBtn.Image = global::MoviesDatabase.Properties.Resources.add;
            this.addCommentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCommentBtn.Location = new System.Drawing.Point(12, 313);
            this.addCommentBtn.Name = "addCommentBtn";
            this.addCommentBtn.Size = new System.Drawing.Size(189, 65);
            this.addCommentBtn.TabIndex = 18;
            this.addCommentBtn.Text = "     Add comment";
            this.addCommentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCommentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addCommentBtn.UseVisualStyleBackColor = false;
            this.addCommentBtn.Click += new System.EventHandler(this.addCommentBtn_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.BackColor = System.Drawing.Color.Gray;
            this.addUserBtn.FlatAppearance.BorderSize = 0;
            this.addUserBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.addUserBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserBtn.Font = new System.Drawing.Font("Calibri", 10F);
            this.addUserBtn.ForeColor = System.Drawing.Color.White;
            this.addUserBtn.Image = global::MoviesDatabase.Properties.Resources.add;
            this.addUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addUserBtn.Location = new System.Drawing.Point(12, 443);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(189, 65);
            this.addUserBtn.TabIndex = 19;
            this.addUserBtn.Text = "     Add user";
            this.addUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addUserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addUserBtn.UseVisualStyleBackColor = false;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // addMovieBtn
            // 
            this.addMovieBtn.BackColor = System.Drawing.Color.Gray;
            this.addMovieBtn.FlatAppearance.BorderSize = 0;
            this.addMovieBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.addMovieBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.addMovieBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMovieBtn.Font = new System.Drawing.Font("Calibri", 10F);
            this.addMovieBtn.ForeColor = System.Drawing.Color.White;
            this.addMovieBtn.Image = global::MoviesDatabase.Properties.Resources.add;
            this.addMovieBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addMovieBtn.Location = new System.Drawing.Point(12, 184);
            this.addMovieBtn.Name = "addMovieBtn";
            this.addMovieBtn.Size = new System.Drawing.Size(189, 65);
            this.addMovieBtn.TabIndex = 17;
            this.addMovieBtn.Text = "     Add movie";
            this.addMovieBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addMovieBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addMovieBtn.UseVisualStyleBackColor = false;
            this.addMovieBtn.Click += new System.EventHandler(this.addMovieBtn_Click);
            // 
            // getAllMoviesBtn
            // 
            this.getAllMoviesBtn.BackColor = System.Drawing.Color.Gray;
            this.getAllMoviesBtn.FlatAppearance.BorderSize = 0;
            this.getAllMoviesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.getAllMoviesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.getAllMoviesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getAllMoviesBtn.Font = new System.Drawing.Font("Calibri", 10F);
            this.getAllMoviesBtn.ForeColor = System.Drawing.Color.White;
            this.getAllMoviesBtn.Image = global::MoviesDatabase.Properties.Resources.movie_clapper_open;
            this.getAllMoviesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getAllMoviesBtn.Location = new System.Drawing.Point(12, 120);
            this.getAllMoviesBtn.Name = "getAllMoviesBtn";
            this.getAllMoviesBtn.Size = new System.Drawing.Size(189, 65);
            this.getAllMoviesBtn.TabIndex = 2;
            this.getAllMoviesBtn.Text = "     Show all movies";
            this.getAllMoviesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.getAllMoviesBtn.UseVisualStyleBackColor = false;
            this.getAllMoviesBtn.Click += new System.EventHandler(this.getAllMoviesBtn_Click);
            // 
            // getAllComments
            // 
            this.getAllComments.BackColor = System.Drawing.Color.Gray;
            this.getAllComments.FlatAppearance.BorderSize = 0;
            this.getAllComments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.getAllComments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.getAllComments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getAllComments.Font = new System.Drawing.Font("Calibri", 10F);
            this.getAllComments.ForeColor = System.Drawing.Color.White;
            this.getAllComments.Image = global::MoviesDatabase.Properties.Resources.chat;
            this.getAllComments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getAllComments.Location = new System.Drawing.Point(12, 249);
            this.getAllComments.Name = "getAllComments";
            this.getAllComments.Size = new System.Drawing.Size(189, 65);
            this.getAllComments.TabIndex = 9;
            this.getAllComments.Text = "     Show all comments";
            this.getAllComments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.getAllComments.UseVisualStyleBackColor = false;
            this.getAllComments.Click += new System.EventHandler(this.getAllComments_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.filterLabel);
            this.panel2.Controls.Add(this.filterComboBox);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.searchButton);
            this.panel2.Controls.Add(this.findTxt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(201, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1104, 100);
            this.panel2.TabIndex = 21;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filterLabel.Location = new System.Drawing.Point(617, 36);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(72, 23);
            this.filterLabel.TabIndex = 24;
            this.filterLabel.Text = "Filter by";
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(621, 63);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(202, 21);
            this.filterComboBox.TabIndex = 23;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.DimGray;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Calibri", 10F);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Image = global::MoviesDatabase.Properties.Resources.rubbish_bin;
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Location = new System.Drawing.Point(0, 29);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(204, 65);
            this.deleteBtn.TabIndex = 22;
            this.deleteBtn.Text = "     Delete selected records";
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(825, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Search";
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.Color.DimGray;
            this.searchButton.Image = global::MoviesDatabase.Properties.Resources.magnifying_glass;
            this.searchButton.Location = new System.Drawing.Point(1045, 50);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(47, 44);
            this.searchButton.TabIndex = 14;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGrid1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(201, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1104, 644);
            this.panel3.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 744);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button getAllMoviesBtn;
        private System.Windows.Forms.Button getAllComments;
        private System.Windows.Forms.Button showAllUsersBtn;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.TextBox findTxt;
        private System.Windows.Forms.Button addMovieBtn;
        private System.Windows.Forms.Button addCommentBtn;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.ComboBox filterComboBox;
    }
}

