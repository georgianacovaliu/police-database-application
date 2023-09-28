using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PoliceDatabase
{
    public partial class AmenziForm : Form
    {
        int inAmendaID = 0;
        int inPersoanaID = 0;
        string connectionString = "Data Source=DESKTOP-QIOVIJB\\SQLEXPRESS;Initial Catalog=EvidentaPopulatiei;Integrated Security=True";
        public AmenziForm()
        {
            InitializeComponent();
        }

        void FillDgvPersoanaName()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("PersoanaViewAllName", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@Nume", txtSearch.Text.Trim());
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvPersoanaAll.DataSource = dtbl;
                dgvPersoanaAll.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dgvPersoanaAll.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvPersoanaAll.Columns[0].Visible = false;
            }
        }

        void FillDgvPersoanaTotal()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("AmendaPersoanaViewAll", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvPersoanaAll.DataSource = dtbl;
                dgvPersoanaAll.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dgvPersoanaAll.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dgvPersoanaAll.Columns[0].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand("AmendaAddOrEdit", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@AmendaID", inAmendaID);
                sqlCmd.Parameters.AddWithValue("@Fapta", txtFapta.Text);
                sqlCmd.Parameters.AddWithValue("@ArticolPrevedere", txtPrevedere.Text);
                sqlCmd.Parameters.AddWithValue("@ArticolSanctionare", txtSanctionare.Text);
                sqlCmd.ExecuteNonQuery();
            };
            Clear();
            MessageBox.Show("Amenda adaugata");
            FillDgvAmenda();
        }

        void Clear()
        {
            txtFapta.Text = txtSanctionare.Text = txtPrevedere.Text = textDenFapta.Text = txtPersAmendata.Text = txtCNPAmendat .Text = txtDataAmenda.Text =
                txtSuma.Text = txtObservatii.Text = "";

            if (dgvAmenda.DataSource == null) dgvAmenda.Rows.Clear();
            else dgvAmenda.DataSource = (dgvAmenda.DataSource as DataTable).Clone();

            if (dgvPersoanaAll.DataSource == null) dgvPersoanaAll.Rows.Clear();
            else dgvPersoanaAll.DataSource = (dgvPersoanaAll.DataSource as DataTable).Clone();

            inAmendaID = 0;
            inPersoanaID = 0;

        }

        void FillDgvAmenda()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("AmendaViewAll", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvAmenda.DataSource = dtbl;
                dgvAmenda.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;    
                dgvAmenda.Columns[0].Visible = false;
            }
        }
        void FillDgvAmendaMax()
        {
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("AmendaViewMax", sqlCon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvPersoanaAll.DataSource = dtbl;
                    dgvPersoanaAll.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    //dgvPersoanaAll.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    //dgvPersoanaAll.Columns[0].Visible = false;
                }
            }
        }


        private void AmenziForm_Load(object sender, EventArgs e)
        {
            FillDgvAmenda();
            FillDgvPersoanaTotal();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            this.Hide();
            form.ShowDialog();
            Close();
        }

        private void dgvAmenda_DoubleClick(object sender, EventArgs e)
        {

            if (dgvAmenda.CurrentRow.Index != -1)
            {
                DataGridViewRow _dgvCurrentRow = dgvAmenda.CurrentRow;
                inAmendaID = Convert.ToInt32(_dgvCurrentRow.Cells[0].Value);
                tabControl1.SelectedIndex = 1;
                FillDgvPersoanaName();
            }
        }

        private void dgvPersoanaAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPersoanaAll_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPersoanaAll.CurrentRow.Index != -1)
            {
                DataGridViewRow _dgvCurrentRow1 = dgvPersoanaAll.CurrentRow;
                inPersoanaID = Convert.ToInt32(_dgvCurrentRow1.Cells[0].Value);
                tabControl1.SelectedIndex = 2;

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("AmendaPersoanaGatherInfo", sqlCon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDa.SelectCommand.Parameters.AddWithValue("@PersoanaID", inPersoanaID);
                    sqlDa.SelectCommand.Parameters.AddWithValue("@AmendaID", inAmendaID);
                    DataSet ds = new DataSet();
                    sqlDa.Fill(ds);


                    DataRow dr = ds.Tables[0].Rows[0];
                    txtCNPAmendat.Text = dr["CNP"].ToString();
                    txtPersAmendata.Text = dr["Nume"].ToString() + " " + dr["Prenume"].ToString();


                    //Adauga din Certificat Nastere
                    DataRow dr1 = ds.Tables[1].Rows[0];
                    textDenFapta.Text = dr1["Fapta"].ToString();


                };
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand("AmendaPersoanaAddOrEdit", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@AmendaID", inAmendaID);
                sqlCmd.Parameters.AddWithValue("@PersoanaID", inPersoanaID);
                sqlCmd.Parameters.AddWithValue("@Data", DateTime.Parse(txtDataAmenda.Text));
                sqlCmd.Parameters.AddWithValue("@Suma", txtSuma.Text);
                sqlCmd.Parameters.AddWithValue("@Observatii", txtObservatii.Text);

                sqlCmd.ExecuteNonQuery();

            };
            Clear();
            MessageBox.Show("Adaugat");
            tabControl1.SelectedIndex = 0;
            FillDgvPersoanaTotal();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillDgvPersoanaName();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
            tabControl1.SelectedIndex = 0;
            FillDgvAmenda();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
            tabControl1.SelectedIndex = 0;
            FillDgvAmenda();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
            FillDgvAmendaMax();
        }
    }
}
