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
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = "select name from sakila.category";
            List<string> categories = new List<string>();
            categories = connection.Query<string>(sql).ToList();
            foreach(string categpry in categories)
            {
                categoryComboBox.Items.Add(categpry);
            }



        }
    }
}
