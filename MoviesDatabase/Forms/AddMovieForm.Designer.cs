namespace MoviesDatabase
{
    partial class addMovieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addOneBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.yearTxtBox = new System.Windows.Forms.TextBox();
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.lengthTxtBox = new System.Windows.Forms.TextBox();
            this.directorsTxtBox = new System.Windows.Forms.TextBox();
            this.genreTxtBox = new System.Windows.Forms.TextBox();
            this.descriptionTxtBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.directorsLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.listDataGrid = new System.Windows.Forms.DataGrid();
            this.addToListBtn = new System.Windows.Forms.Button();
            this.addAllBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addOneBtn
            // 
            this.addOneBtn.Location = new System.Drawing.Point(222, 415);
            this.addOneBtn.Name = "addOneBtn";
            this.addOneBtn.Size = new System.Drawing.Size(75, 23);
            this.addOneBtn.TabIndex = 0;
            this.addOneBtn.Text = "Add one";
            this.addOneBtn.UseVisualStyleBackColor = true;
            this.addOneBtn.Click += new System.EventHandler(this.addOneBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(12, 415);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // yearTxtBox
            // 
            this.yearTxtBox.Location = new System.Drawing.Point(12, 92);
            this.yearTxtBox.Name = "yearTxtBox";
            this.yearTxtBox.Size = new System.Drawing.Size(61, 20);
            this.yearTxtBox.TabIndex = 2;
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.Location = new System.Drawing.Point(12, 51);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(285, 20);
            this.titleTxtBox.TabIndex = 3;
            // 
            // lengthTxtBox
            // 
            this.lengthTxtBox.Location = new System.Drawing.Point(12, 133);
            this.lengthTxtBox.Name = "lengthTxtBox";
            this.lengthTxtBox.Size = new System.Drawing.Size(55, 20);
            this.lengthTxtBox.TabIndex = 4;
            // 
            // directorsTxtBox
            // 
            this.directorsTxtBox.Location = new System.Drawing.Point(12, 174);
            this.directorsTxtBox.Name = "directorsTxtBox";
            this.directorsTxtBox.Size = new System.Drawing.Size(285, 20);
            this.directorsTxtBox.TabIndex = 5;
            // 
            // genreTxtBox
            // 
            this.genreTxtBox.Location = new System.Drawing.Point(12, 215);
            this.genreTxtBox.Name = "genreTxtBox";
            this.genreTxtBox.Size = new System.Drawing.Size(285, 20);
            this.genreTxtBox.TabIndex = 6;
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.Location = new System.Drawing.Point(12, 278);
            this.descriptionTxtBox.Multiline = true;
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.Size = new System.Drawing.Size(285, 67);
            this.descriptionTxtBox.TabIndex = 7;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(9, 33);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(31, 15);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Title";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yearLabel.Location = new System.Drawing.Point(9, 74);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(30, 15);
            this.yearLabel.TabIndex = 9;
            this.yearLabel.Text = "Year";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lengthLabel.Location = new System.Drawing.Point(9, 115);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(42, 15);
            this.lengthLabel.TabIndex = 10;
            this.lengthLabel.Text = "Length";
            // 
            // directorsLabel
            // 
            this.directorsLabel.AutoSize = true;
            this.directorsLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.directorsLabel.Location = new System.Drawing.Point(9, 156);
            this.directorsLabel.Name = "directorsLabel";
            this.directorsLabel.Size = new System.Drawing.Size(58, 15);
            this.directorsLabel.TabIndex = 11;
            this.directorsLabel.Text = "Directors";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.genreLabel.Location = new System.Drawing.Point(9, 197);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(64, 15);
            this.genreLabel.TabIndex = 12;
            this.genreLabel.Text = "Film genre";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionLabel.Location = new System.Drawing.Point(9, 260);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(70, 15);
            this.descriptionLabel.TabIndex = 13;
            this.descriptionLabel.Text = "Description";
            // 
            // listDataGrid
            // 
            this.listDataGrid.DataMember = "";
            this.listDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.listDataGrid.Location = new System.Drawing.Point(303, 51);
            this.listDataGrid.Name = "listDataGrid";
            this.listDataGrid.Size = new System.Drawing.Size(651, 294);
            this.listDataGrid.TabIndex = 14;
            // 
            // addToListBtn
            // 
            this.addToListBtn.Location = new System.Drawing.Point(117, 415);
            this.addToListBtn.Name = "addToListBtn";
            this.addToListBtn.Size = new System.Drawing.Size(75, 23);
            this.addToListBtn.TabIndex = 15;
            this.addToListBtn.Text = "Add to list";
            this.addToListBtn.UseVisualStyleBackColor = true;
            this.addToListBtn.Click += new System.EventHandler(this.addToListBtn_Click);
            // 
            // addAllBtn
            // 
            this.addAllBtn.Location = new System.Drawing.Point(879, 415);
            this.addAllBtn.Name = "addAllBtn";
            this.addAllBtn.Size = new System.Drawing.Size(75, 23);
            this.addAllBtn.TabIndex = 16;
            this.addAllBtn.Text = "Add all";
            this.addAllBtn.UseVisualStyleBackColor = true;
            this.addAllBtn.Click += new System.EventHandler(this.addAllBtn_Click);
            // 
            // addMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.ControlBox = false;
            this.Controls.Add(this.addAllBtn);
            this.Controls.Add(this.addToListBtn);
            this.Controls.Add(this.listDataGrid);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.directorsLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.descriptionTxtBox);
            this.Controls.Add(this.genreTxtBox);
            this.Controls.Add(this.directorsTxtBox);
            this.Controls.Add(this.lengthTxtBox);
            this.Controls.Add(this.titleTxtBox);
            this.Controls.Add(this.yearTxtBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addOneBtn);
            this.Name = "addMovieForm";
            this.Text = "addMovieForm";
            ((System.ComponentModel.ISupportInitialize)(this.listDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addOneBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label directorsLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label descriptionLabel;
        public System.Windows.Forms.TextBox yearTxtBox;
        public System.Windows.Forms.TextBox titleTxtBox;
        public System.Windows.Forms.TextBox lengthTxtBox;
        public System.Windows.Forms.TextBox directorsTxtBox;
        public System.Windows.Forms.TextBox genreTxtBox;
        public System.Windows.Forms.TextBox descriptionTxtBox;
        private System.Windows.Forms.DataGrid listDataGrid;
        private System.Windows.Forms.Button addToListBtn;
        private System.Windows.Forms.Button addAllBtn;
    }
}