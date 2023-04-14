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
    public partial class AddValue : Form
    {
        public AddValue()
        {
            InitializeComponent();
            listShops();
        }
        private void listShops()
        {
            string connectionString = "server=localhost;database=budget-planner;uid=root;pwd=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT shop FROM shops";
            try
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);
                shopAdd.DataSource = table;
                shopAdd.DisplayMember = "shop";
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

        private void addValue(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=budget-planner;uid=root;pwd=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = connection.CreateCommand();
            string date = "'" + dateAdd.Value.Date.Year + "-" + dateAdd.Value.Date.Month + "-" + dateAdd.Value.Date.Day + "'";
            string shop = shopAdd.GetItemText(shopAdd.SelectedItem);
            string value = valueAdd.Value.ToString();
            string price = value.Replace(",", ".");
            command.CommandText = "INSERT INTO `data`(`date`, `shop`, `total`) VALUES (" + date + ", '" + shop + "', '" + price + "')";
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Succesfully added value: " + date + ", " + shop + ", " + value);
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
