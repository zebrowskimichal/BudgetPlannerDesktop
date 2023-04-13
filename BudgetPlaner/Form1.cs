using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace BudgetPlaner
{
    public partial class Form1 : Form
    {
        [DllImport("Kernel32")]
        public static extern void AllocConsole();
        public Form1()
        {
            InitializeComponent();
            LoadData("SELECT * FROM data;");
        }
        private void LoadData(string sql)
        {
            string connectionString = "server=localhost;database=budget-planner;uid=root;pwd=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = sql;

            try
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
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
            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void filterButtonClick(object sender, EventArgs e)
        {
            string dateMin = "'" + dateFrom.Value.Date.Year + "-" + dateFrom.Value.Date.Month + "-" + dateFrom.Value.Date.Day + "'";
            string dateMax = "'" + dateTo.Value.Date.Year + "-" + dateTo.Value.Date.Month + "-" + dateTo.Value.Date.Day + "'";
            decimal valueM = valueFrom.Value;
            string valueMin = valueM.ToString();
            valueMin = valueMin.Replace(",", ".");
            decimal valueX = valueTo.Value;
            string valueMax = valueX.ToString();
            valueMax = valueMax.Replace(",", ".");
            LoadData("SELECT * FROM data WHERE date BETWEEN " + dateMin + " AND " + dateMax + " AND total BETWEEN " + valueMin + " AND " + valueMax + ";");
            //MessageBox.Show("SELECT * FROM data WHERE date BETWEEN " + dateMin + " AND " + dateMax + " AND total BETWEEN " + valueMin + " AND " + valueMax + ";", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resetButtonClick(object sender, EventArgs e)
        {
            dateFrom.Value = new DateTime(2000,01,01);
            dateTo.Value = new DateTime(2099, 12, 31);
            valueFrom.Value = 0.00M;
            valueTo.Value = 9999.00M;
            LoadData("SELECT * FROM data;");
        }

        private void addButtonClick(object sender, EventArgs e)
        {
            AddValue AddValueForm = new AddValue();
            AddValueForm.ShowDialog();
        }

        private void AddShop_Click(object sender, EventArgs e)
        {
            addShop addShopForm = new addShop();
            addShopForm.ShowDialog();
        }

        private void saveToFile_Click(object sender, EventArgs e)
        {
            string location = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string fileName = "/tekst.txt";
            string path = location + fileName;
            TextWriter writer = new StreamWriter(@path);
            for(int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + ";");
                }
                writer.WriteLine("");
            }
            writer.Close();
            MessageBox.Show("Data exported!");
            Process.Start(@location);
            Process.Start(@path);
        }
        private void importButtonClick(object sender, EventArgs e)
        {
            AllocConsole();
            
        }
        
    }
}
