namespace MoviesDatabase
{
    partial class addCommentForm
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
            this.commentTxtBox = new System.Windows.Forms.TextBox();
            this.nameSurnameEmailComboBox = new System.Windows.Forms.ComboBox();
            this.moviesComboBox = new System.Windows.Forms.ComboBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.movieLabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.commentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.addCommentBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commentTxtBox
            // 
            this.commentTxtBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commentTxtBox.Location = new System.Drawing.Point(90, 175);
            this.commentTxtBox.Multiline = true;
            this.commentTxtBox.Name = "commentTxtBox";
            this.commentTxtBox.Size = new System.Drawing.Size(284, 107);
            this.commentTxtBox.TabIndex = 0;
            // 
            // nameSurnameEmailComboBox
            // 
            this.nameSurnameEmailComboBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameSurnameEmailComboBox.FormattingEnabled = true;
            this.nameSurnameEmailComboBox.Location = new System.Drawing.Point(90, 22);
            this.nameSurnameEmailComboBox.Name = "nameSurnameEmailComboBox";
            this.nameSurnameEmailComboBox.Size = new System.Drawing.Size(284, 23);
            this.nameSurnameEmailComboBox.TabIndex = 1;
            // 
            // moviesComboBox
            // 
            this.moviesComboBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moviesComboBox.FormattingEnabled = true;
            this.moviesComboBox.Location = new System.Drawing.Point(90, 95);
            this.moviesComboBox.Name = "moviesComboBox";
            this.moviesComboBox.Size = new System.Drawing.Size(284, 23);
            this.moviesComboBox.TabIndex = 2;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userLabel.Location = new System.Drawing.Point(47, 25);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(32, 15);
            this.userLabel.TabIndex = 3;
            this.userLabel.Text = "User";
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.movieLabel.Location = new System.Drawing.Point(38, 98);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(41, 15);
            this.movieLabel.TabIndex = 4;
            this.movieLabel.Text = "Movie";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commentLabel.Location = new System.Drawing.Point(21, 178);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(58, 15);
            this.commentLabel.TabIndex = 5;
            this.commentLabel.Text = "Comment";
            // 
            // commentDateTimePicker
            // 
            this.commentDateTimePicker.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commentDateTimePicker.Location = new System.Drawing.Point(90, 353);
            this.commentDateTimePicker.Name = "commentDateTimePicker";
            this.commentDateTimePicker.Size = new System.Drawing.Size(204, 23);
            this.commentDateTimePicker.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(37, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date";
            // 
            // addCommentBtn
            // 
            this.addCommentBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addCommentBtn.Location = new System.Drawing.Point(353, 500);
            this.addCommentBtn.Name = "addCommentBtn";
            this.addCommentBtn.Size = new System.Drawing.Size(75, 23);
            this.addCommentBtn.TabIndex = 8;
            this.addCommentBtn.Text = "Add to set";
            this.addCommentBtn.UseVisualStyleBackColor = true;
            this.addCommentBtn.Click += new System.EventHandler(this.addCommentBtn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(24, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addCommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 535);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addCommentBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.commentDateTimePicker);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.movieLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.moviesComboBox);
            this.Controls.Add(this.nameSurnameEmailComboBox);
            this.Controls.Add(this.commentTxtBox);
            this.Name = "addCommentForm";
            this.Text = "addCommentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commentTxtBox;
        private System.Windows.Forms.ComboBox nameSurnameEmailComboBox;
        private System.Windows.Forms.ComboBox moviesComboBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label movieLabel;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.DateTimePicker commentDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addCommentBtn;
        private System.Windows.Forms.Button button2;
    }
}