using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using Dapper;

namespace SakilaFilms
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["SakilaDB"].ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = "select name from sakila.category";
                List<string> categories = new List<string>();
                categories = connection.Query<string>(sql).ToList();
                foreach (string categpry in categories)
                {
                    categoryComboBox.Items.Add(categpry);
                }
            }


                
            //connection.Close();
            //connection.Dispose();



        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmsListView.Clear();
            string connectionString = ConfigurationManager.ConnectionStrings["SakilaDB"].ConnectionString;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = $"select film.film_id as id, film.title, film.description, film.length" +
                                $" from" +
                                $" film inner join film_category on film.film_id = film_category.film_id" +
                                    $" inner join category on film_category.category_id = category.category_id" +
                                    $" where category.name = '{categoryComboBox.Text}'";

                List<FilmModel> films = new List<FilmModel>();
                films = connection.Query<FilmModel>(sql).ToList();
                foreach(FilmModel film in films)
                {
                    filmsListView.Items.Add(film.ToString());
                }
            }
        }
    }
}
