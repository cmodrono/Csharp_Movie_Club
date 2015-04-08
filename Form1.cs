using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_app
{
    public partial class Form1 : Form
    {
        List<Movie> Queue = new List<Movie>();

        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            if (txtMovieTitle.Text != "" && txtID.Text != "")
            {
                Movie Entry = new Movie(txtMovieTitle.Text, txtID.Text);
                Queue.Add(Entry);
                txtMovieTitle.Clear();
                txtID.Clear();
                RefreshQueue();
            }
        }
        
        
        public void RefreshQueue()
        {
            
            dataGridMovieList.DataSource = null;
            dataGridMovieList.DataSource = Queue;
            dataGridMovieList.AutoGenerateColumns = true;
            dataGridMovieList.Refresh();
        }
        
        
        public class Movie
        {

            public string Title {get;set;}
            public string ID {get;set;}

            public Movie(string movieTitle, string imbd)
            {
                Title = movieTitle;
                ID = imbd;
            }
        }


    }
}
