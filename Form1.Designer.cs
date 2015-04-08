namespace Movie_app
{
    partial class Form1
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
            this.lblListTitle = new System.Windows.Forms.Label();
            this.lblAddMovie = new System.Windows.Forms.Label();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.dataGridMovieList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovieList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListTitle
            // 
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListTitle.ForeColor = System.Drawing.Color.White;
            this.lblListTitle.Location = new System.Drawing.Point(12, 9);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(258, 39);
            this.lblListTitle.TabIndex = 1;
            this.lblListTitle.Text = "Current Queue";
            // 
            // lblAddMovie
            // 
            this.lblAddMovie.AutoSize = true;
            this.lblAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMovie.ForeColor = System.Drawing.Color.White;
            this.lblAddMovie.Location = new System.Drawing.Point(376, 26);
            this.lblAddMovie.Name = "lblAddMovie";
            this.lblAddMovie.Size = new System.Drawing.Size(166, 29);
            this.lblAddMovie.TabIndex = 2;
            this.lblAddMovie.Text = "Add A Movie!";
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMovieTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMovieTitle.ForeColor = System.Drawing.Color.White;
            this.txtMovieTitle.Location = new System.Drawing.Point(308, 96);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(319, 20);
            this.txtMovieTitle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(305, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Movie Title";
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMovie.Location = new System.Drawing.Point(381, 187);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(161, 45);
            this.btnAddMovie.TabIndex = 5;
            this.btnAddMovie.Text = "Add!";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(308, 152);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(319, 20);
            this.txtID.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(305, 136);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(48, 13);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "IMBD ID";
            // 
            // dataGridMovieList
            // 
            this.dataGridMovieList.AllowUserToAddRows = false;
            this.dataGridMovieList.AllowUserToDeleteRows = false;
            this.dataGridMovieList.AllowUserToResizeRows = false;
            this.dataGridMovieList.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridMovieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMovieList.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridMovieList.Location = new System.Drawing.Point(12, 51);
            this.dataGridMovieList.Name = "dataGridMovieList";
            this.dataGridMovieList.ReadOnly = true;
            this.dataGridMovieList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridMovieList.Size = new System.Drawing.Size(258, 424);
            this.dataGridMovieList.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(670, 487);
            this.Controls.Add(this.dataGridMovieList);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMovieTitle);
            this.Controls.Add(this.lblAddMovie);
            this.Controls.Add(this.lblListTitle);
            this.Name = "Form1";
            this.Text = "Awesome Movie Queue";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovieList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Label lblAddMovie;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dataGridMovieList;
    }
}

