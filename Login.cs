using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PoliceDatabase
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-QIOVIJB\\SQLEXPRESS;Initial Catalog=EvidentaPopulatiei;Integrated Security=True");
            string query = "Select * from Utilizatori Where Utilizator= '" + txtUtilizator.Text + "' and Parola= '" + txtParola.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                MainMenu form = new MainMenu();
                this.Hide();
                form.ShowDialog();
                Close();
            }
            else
            {
                //if wrong password, show
                MessageBox.Show("Nume de utilizator sau parolă incorecte");
            }
        }
    }
}
