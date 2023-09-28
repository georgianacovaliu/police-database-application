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
    public partial class CasatoriiForm : Form
    {
        int inPersoanaID = 0;
        int inPersoanaID1 = 0;
        int inCasatorieID = 0;
        string connectionString = "Data Source=DESKTOP-QIOVIJB\\SQLEXPRESS;Initial Catalog=EvidentaPopulatiei;Integrated Security=True";
        public CasatoriiForm()
        {
            InitializeComponent();
        }
        void Clear()
        {
            txtSearch.Text = txtSearch1.Text = txtSot.Text = txtSotie.Text = txtNumar.Text = txtData.Text = txtUnitate.Text = "";
            cmbStatus.SelectedIndex = 0;

            if (dgvPersoanaAll.DataSource == null) dgvPersoanaAll.Rows.Clear();
            else dgvPersoanaAll.DataSource = (dgvPersoanaAll.DataSource as DataTable).Clone();

            if (dgvPersoanaAll1.DataSource == null) dgvPersoanaAll1.Rows.Clear();
            else dgvPersoanaAll1.DataSource = (dgvPersoanaAll1.DataSource as DataTable).Clone();

            if (dgvCasatorii.DataSource == null) dgvCasatorii.Rows.Clear();
            else dgvCasatorii.DataSource = (dgvCasatorii.DataSource as DataTable).Clone();

            inPersoanaID1 = 0;
            inPersoanaID = 0;

        }
        void comboBoxFill()
        {

            cmbStatus.Items.Add("-Selectează-");
            cmbStatus.Items.Add("Activ");
            cmbStatus.Items.Add("Anulat");
            cmbStatus.SelectedIndex = 0;
        }

        void FillDgvCasatorii()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("CertificatCasatorieViewAll", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvCasatorii.DataSource = dtbl;
                dgvCasatorii.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dgvPersoanaAll.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dgvCasatorii.Columns[0].Visible = false;
            };
        }

        void FillDgvPersoana1()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("PersoanaViewCertificat", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@Nume", txtSearch.Text.Trim());
                sqlDa.SelectCommand.Parameters.AddWithValue("@Sex", 'M');
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvPersoanaAll.DataSource = dtbl;
                dgvPersoanaAll.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dgvPersoanaAll.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvPersoanaAll.Columns[0].Visible = false;
                dgvPersoanaAll.Columns[4].Visible = false;
            };
        }


        void FillDgvPersoana2()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("PersoanaViewCertificat", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@Nume", txtSearch1.Text.Trim());
                sqlDa.SelectCommand.Parameters.AddWithValue("@Sex", 'F');
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvPersoanaAll1.DataSource = dtbl;
                dgvPersoanaAll1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dgvPersoanaAll.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvPersoanaAll1.Columns[0].Visible = false;
                dgvPersoanaAll1.Columns[4].Visible = false;
            };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            FillDgvPersoana1();
            FillDgvPersoana2();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            FillDgvPersoana1();
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            FillDgvPersoana2();
        }

        private void CasatoriiForm_Load(object sender, EventArgs e)
        {
            comboBoxFill();
            FillDgvCasatorii();
        }

        private void dgvPersoanaAll_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPersoanaAll.CurrentRow.Index != -1)
            {
                DataGridViewRow _dgvCurrentRow = dgvPersoanaAll.CurrentRow;
                inPersoanaID = Convert.ToInt32(_dgvCurrentRow.Cells[0].Value);
                

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("CertificatCasatorieGatherInfo", sqlCon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDa.SelectCommand.Parameters.AddWithValue("@PersoanaID", inPersoanaID);
                    DataSet ds = new DataSet();
                    sqlDa.Fill(ds);

                    DataRow dr = ds.Tables[0].Rows[0];
                    txtSot.Text = dr["Nume"].ToString() + " " + dr["Prenume"].ToString();

                };
            }
        }

        private void dgvPersoanaAll1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand("CertificatCasatorieAddOrEdit", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@CertificatCasatorieID", inCasatorieID);
                sqlCmd.Parameters.AddWithValue("@SotID", inPersoanaID);
                sqlCmd.Parameters.AddWithValue("@SotieID", inPersoanaID1);
                sqlCmd.Parameters.AddWithValue("@Data", DateTime.Parse(txtData.Text));
                sqlCmd.Parameters.AddWithValue("@NrActCasatorie", txtNumar.Text);
                sqlCmd.Parameters.AddWithValue("@UnitateEmitenta", txtUnitate.Text);
                sqlCmd.Parameters.AddWithValue("@Status", cmbStatus.Text);

                sqlCmd.ExecuteNonQuery();

            };
            Clear();
            MessageBox.Show("Certificatul a fost daugat");
            tabControl1.SelectedIndex = 0;
            FillDgvCasatorii();

        }

        private void dgvPersoanaAll1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPersoanaAll1.CurrentRow.Index != -1)
            {
                DataGridViewRow _dgvCurrentRow1 = dgvPersoanaAll1.CurrentRow;
                inPersoanaID1 = Convert.ToInt32(_dgvCurrentRow1.Cells[0].Value);


                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("CertificatCasatorieGatherInfo", sqlCon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDa.SelectCommand.Parameters.AddWithValue("@PersoanaID", inPersoanaID1);
                    DataSet ds1 = new DataSet();
                    sqlDa.Fill(ds1);

                    DataRow dr1 = ds1.Tables[0].Rows[0];
                    txtSotie.Text = dr1["Nume"].ToString() + " " + dr1["Prenume"].ToString();

                };
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            this.Hide();
            form.ShowDialog();
            Close();
        }
    }
}
