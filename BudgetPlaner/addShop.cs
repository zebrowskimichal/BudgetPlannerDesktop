using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetPlaner
{
    public partial class addShop : Form
    {
        public addShop()
        {
            InitializeComponent();
        }

        private void shopAdd(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=budget-planner;uid=root;pwd=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = connection.CreateCommand();
            string shop = shopName.Text;
            command.CommandText = "INSERT INTO `shops`(`shop`) VALUES ('" + shop + "');";
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Succesfully added value: " + shop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
