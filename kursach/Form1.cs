using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kursach
{
    public partial class Form1 : Form
    {
        MySqlCommand command;
        public Form1()
        {
            InitializeComponent();

        }
        MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=sport;");
        private void Form1_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM sport.vid_sporta";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, con);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public void populate_DGV()
        {
            string selectQuery = "SELECT * FROM sport.vid_sporta";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, con);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_вид.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_един.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_рекорд.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }


        public void openConnection()
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, con);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("query executed");
                }
                else
                {
                    MessageBox.Show("query not executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void BNT_Seach_Click(object sender, EventArgs e)
        {
            MySqlDataReader mdr;
            string select = "SELECT * FROM sport.vid_sporta WHERE ID = " + textBox_id.Text;
            command = new MySqlCommand(select, con);
            openConnection();
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                textBox_вид.Text = mdr.GetString("вид_спорта");
                textBox_един.Text = mdr.GetString("единица_измерения");
                textBox_рекорд.Text = mdr.GetString("мировой_рекорд");
            }
            else
            {
                MessageBox.Show("User not found");
            }
            closeConnection();
        }

        private void BTN_Insert_Click_Click_1(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO sport.vid_sporta(вид_спорта, единица_измерения, мировой_рекорд) VALUES ('" + textBox_вид.Text + "', '" + textBox_един.Text + "', '" + textBox_рекорд.Text + "')";
            executeMyQuery(insertQuery);
            populate_DGV();
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE sport.vid_sporta SET вид_спорта='" + textBox_вид.Text + "', единица_измерения='" + textBox_един.Text + "', мировой_рекорд='" + textBox_рекорд.Text + "' WHERE id =" + int.Parse(textBox_id.Text) + "";
            executeMyQuery(updateQuery);
            populate_DGV();
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM sport.vid_sporta WHERE ID=" + int.Parse(textBox_id.Text) + "";
            executeMyQuery(deleteQuery);
            populate_DGV();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
