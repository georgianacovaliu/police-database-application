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
    public partial class MasterPersoane : Form
    {
        int inPersoanaID = 0;
        bool isDefaultImage = true;
        string connectionString = "Data Source=DESKTOP-QIOVIJB\\SQLEXPRESS;Initial Catalog=EvidentaPopulatiei;Integrated Security=True";
        public MasterPersoane()
        {
            InitializeComponent();
        }

        private void Detalii_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void FillDgvPersoana()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("PersoanaViewAll", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvPersoanaAll.DataSource = dtbl;
                dgvPersoanaAll.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dgvPersoanaAll.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvPersoanaAll.Columns[0].Visible = false;
            }
        }

        void FillDgvPersoanaOldest()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("PersoanaOldest", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvPersoanaAll.DataSource = dtbl;
                dgvPersoanaAll.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dgvPersoanaAll.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dgvPersoanaAll.Columns[0].Visible = false;
            }
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

        void FillDgvPersoanaCNP()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("PersoanaViewAllCNP", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@CNP", txtSearch.Text.Trim());
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvPersoanaAll.DataSource = dtbl;
                dgvPersoanaAll.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dgvPersoanaAll.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvPersoanaAll.Columns[0].Visible = false;
            }
        }

        void FillDgvPersoanaJudet()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("PersoanaViewAllJudet", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@Judet", txtSearch.Text.Trim());
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvPersoanaAll.DataSource = dtbl;
                dgvPersoanaAll.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dgvPersoanaAll.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvPersoanaAll.Columns[0].Visible = false;
            }
        }
        void FillDgvPersoanaData()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("PersoanaViewAllData", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@Data", DateTime.Parse(txtSearch.Text.Trim()));
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvPersoanaAll.DataSource = dtbl;
                dgvPersoanaAll.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dgvPersoanaAll.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvPersoanaAll.Columns[0].Visible = false;
            }
        }

        void Clear()
        {
            txtCNP.Text = txtNume.Text = txtPrenume.Text = txtStudii.Text = txtProfesie.Text = txtOcupatie.Text = txtSursaVenit.Text = txtNumeAnterioare.Text
            = txtUnitateEmitentaNastere.Text = txtNrActNastere.Text = txtDataNasterii.Text = txtCertificatNastereID.Text = txtMama.Text = txtTata.Text = "";
            cmbSituatieMilitara.SelectedIndex = cmbStatutMarital.SelectedIndex = cmbSex.SelectedIndex = 0;
            rdbDa.Checked = false;
            rdbNu.Checked = false;

            if (dgvBuletin.DataSource == null) dgvBuletin.Rows.Clear();
            else dgvBuletin.DataSource = (dgvBuletin.DataSource as DataTable).Clone();

            if (dgvAdresa.DataSource == null) dgvAdresa.Rows.Clear();
            else dgvAdresa.DataSource = (dgvAdresa.DataSource as DataTable).Clone();

            inPersoanaID = 0;
            btnSave.Text = "Adaugă";
            btnDelete.Enabled = false;

        }

        private void MasterPersoane_Load(object sender, EventArgs e)
        {
            comboBoxFill();
            FillDgvPersoanaName();
            Clear();
        }

        void comboBoxFill()
        {
            
            cmbStatutMarital.Items.Add("-Selectează-");
            cmbStatutMarital.Items.Add("Necăsătorit/ă");
            cmbStatutMarital.Items.Add("Căsătorit/ă");
            cmbStatutMarital.Items.Add("Divortat/ă");
            cmbStatutMarital.Items.Add("Văduv/ă");
            cmbStatutMarital.SelectedIndex = 0;

            cmbSex.Items.Add("F");
            cmbSex.Items.Add("M");
            cmbSex.SelectedIndex = 0;


            cmbSituatieMilitara.Items.Add("-Selectează-");
            cmbSituatieMilitara.Items.Add("Fără stagiu militar satisfăcut");
            cmbSituatieMilitara.Items.Add("În rezervă");
            cmbSituatieMilitara.Items.Add("Militar activ");
            cmbSituatieMilitara.SelectedIndex = 0;

            dgvcmbStatus.Items.Add("-Selectează-");
            dgvcmbStatus.Items.Add("Valid");
            dgvcmbStatus.Items.Add("Anulat");
            dgvcmbStatus.Items.Add("Expirat");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int _PersoanaID = 0;
            int _AdresaID = 0;
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                //Master
                SqlCommand sqlCmd = new SqlCommand("PersoanaAddOrEdit", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@PersoanaID", inPersoanaID);
                sqlCmd.Parameters.AddWithValue("@Nume", txtNume.Text);
                sqlCmd.Parameters.AddWithValue("@Prenume", txtPrenume.Text);
                sqlCmd.Parameters.AddWithValue("@CNP", txtCNP.Text);
                sqlCmd.Parameters.AddWithValue("@Sex", cmbSex.Text);
                sqlCmd.Parameters.AddWithValue("@StatutMarital", cmbStatutMarital.Text);
                sqlCmd.Parameters.AddWithValue("@Copii",rdbDa.Checked ? "Da":"Nu");
                sqlCmd.Parameters.AddWithValue("@Studii", txtStudii.Text);
                sqlCmd.Parameters.AddWithValue("@SituatieMilitara", cmbSituatieMilitara.Text);
                sqlCmd.Parameters.AddWithValue("@Profesie", txtProfesie.Text);
                sqlCmd.Parameters.AddWithValue("@Ocupatie", txtOcupatie.Text);
                sqlCmd.Parameters.AddWithValue("@SursaVenit", txtSursaVenit.Text);
                sqlCmd.Parameters.AddWithValue("@NumeAnterioare", txtNumeAnterioare.Text);

                _PersoanaID = Convert.ToInt32(sqlCmd.ExecuteScalar());
                
            }

            //Certificat Nastere

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                //Master
                SqlCommand sqlCmd = new SqlCommand("CertificatNastereAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@CertificatNastereID", Convert.ToInt32(txtCertificatNastereID.Text == "" ? "0" : txtCertificatNastereID.Text));
                sqlCmd.Parameters.AddWithValue("@PersoanaID", _PersoanaID);
                sqlCmd.Parameters.AddWithValue("@MamaCNP", txtMama.Text);
                sqlCmd.Parameters.AddWithValue("@TataCNP", txtTata.Text);
                sqlCmd.Parameters.AddWithValue("@NrActNastere", txtNrActNastere.Text);
                sqlCmd.Parameters.AddWithValue("@UnitateEmitenta", txtUnitateEmitentaNastere.Text);
                sqlCmd.Parameters.AddWithValue("@Data", DateTime.Parse(txtDataNasterii.Text));
                sqlCmd.ExecuteNonQuery();

            }

            //Adresa
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                foreach (DataGridViewRow dgvRow1 in dgvAdresa.Rows)
                {
                    if (dgvRow1.IsNewRow) break;
                    else
                    {
                        SqlCommand sqlCmd = new SqlCommand("AdresaAddOrEdit", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@AdresaID", Convert.ToInt32(dgvRow1.Cells["dgvtxtadrAdresaID"].Value == DBNull.Value ? "0" : dgvRow1.Cells["dgvtxtadrAdresaID"].Value));
                        sqlCmd.Parameters.AddWithValue("@Judet", dgvRow1.Cells["dgvtxtJudet"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Oras", dgvRow1.Cells["dgvtxtOras"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Sector", dgvRow1.Cells["dgvtxtSector"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Strada", dgvRow1.Cells["dgvtxtStrada"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Numar", dgvRow1.Cells["dgvtxtNr"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Bloc", dgvRow1.Cells["dgvtxtBloc"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Scara", dgvRow1.Cells["dgvtxtScara"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Etaj", dgvRow1.Cells["dgvtxtEtaj"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Apartament", dgvRow1.Cells["dgvtxtApartament"].Value.ToString());
                        _AdresaID = Convert.ToInt32(sqlCmd.ExecuteScalar());
                    }
                }
            }


            //Buletin
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                foreach(DataGridViewRow dgvRow in dgvBuletin.Rows)
                {
                    if (dgvRow.IsNewRow) break;
                    else
                    {
                        SqlCommand sqlCmd = new SqlCommand("BuletinAddOrEdit", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@BuletinID", Convert.ToInt32(dgvRow.Cells["dgvtxtBuletinID"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtBuletinID"].Value));
                        sqlCmd.Parameters.AddWithValue("@PersoanaID", _PersoanaID);
                        sqlCmd.Parameters.AddWithValue("@AdresaID", _AdresaID);
                        sqlCmd.Parameters.AddWithValue("@Status", dgvRow.Cells["dgvcmbStatus"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Seria", dgvRow.Cells["dgvtxtSeria"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Numar", dgvRow.Cells["dgvtxtNumar"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Cetatenie", dgvRow.Cells["dgvtxtCetatenie"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@LocNastere", dgvRow.Cells["dgvtxtLocNastere"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@UnitateEmitenta", dgvRow.Cells["dgvtxtUnitateEmitenta"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@DataEliberare", DateTime.Parse(dgvRow.Cells["dgvtxtDataEliberare"].Value.ToString()));
                        sqlCmd.Parameters.AddWithValue("@DataExpirare", DateTime.Parse(dgvRow.Cells["dgvtxtDataExpirare"].Value.ToString()));
                        //sqlCmd.Parameters.AddWithValue("@AdresaID", Convert.ToInt32(dgvRow.Cells["dgvtxtAdresaID"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtAdresaID"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                }
            }
            FillDgvPersoanaName();
            Clear();
            MessageBox.Show("Adaugat");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
                    SqlDataAdapter sqlDa = new SqlDataAdapter("PersoanaViewByID", sqlCon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDa.SelectCommand.Parameters.AddWithValue("@PersoanaID", inPersoanaID);
                    DataSet ds = new DataSet();
                    sqlDa.Fill(ds);

                    //Master-Fill
                    
                    //Adauga din Persoana
                    DataRow dr = ds.Tables[0].Rows[0];
                    txtCNP.Text = dr["CNP"].ToString();
                    txtNume.Text = dr["Nume"].ToString();
                    txtPrenume.Text = dr["Prenume"].ToString();
                    txtStudii.Text = dr["Studii"].ToString();
                    txtProfesie.Text = dr["Profesie"].ToString();
                    txtOcupatie.Text = dr["Ocupatie"].ToString();
                    txtSursaVenit.Text = dr["SursaVenit"].ToString();
                    txtNumeAnterioare.Text = dr["NumeAnterioare"].ToString();
                    cmbSex.Text = dr["Sex"].ToString();
                    cmbSituatieMilitara.Text = dr["SituatieMilitara"].ToString();
                    cmbStatutMarital.Text = dr["StatutMarital"].ToString();
                    if (dr["Copii"].ToString() == "Da") rdbDa.Checked = true;
                    else { if (dr["Copii"].ToString() == "Nu") rdbDa.Checked = true; }

                    //Adauga din Certificat Nastere
                    DataRow dr1 = ds.Tables[2].Rows[0];
                    txtCertificatNastereID.Text = dr1["CertificatNastereID"].ToString();
                    txtMama.Text = dr1["MamaCNP"].ToString();
                    txtTata.Text = dr1["TataCNP"].ToString();
                    txtNrActNastere.Text = dr1["NrActNastere"].ToString();
                    txtUnitateEmitentaNastere.Text = dr1["UnitateEmitenta"].ToString();
                    txtDataNasterii.Text = dr1["Data"].ToString();

                    //Adauga din Buletin
                    dgvBuletin.AutoGenerateColumns = false;
                    dgvBuletin.DataSource = ds.Tables[1];
                    btnDelete.Enabled = true;
                    btnSave.Text = "Update";
                    tabControl1.SelectedIndex = 0;

                };

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa1 = new SqlDataAdapter("AdresaViewByPersoanaID", sqlCon);
                    sqlDa1.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDa1.SelectCommand.Parameters.AddWithValue("@PersoanaID", inPersoanaID);
                    DataSet ds1 = new DataSet();
                    sqlDa1.Fill(ds1);

                    dgvAdresa.AutoGenerateColumns = false;
                    dgvAdresa.DataSource = ds1.Tables[0];
                };

            }
        }

        private void dgvBuletin_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow dgvRow = dgvBuletin.CurrentRow;
            if (dgvRow.Cells["dgvtxtBuletinID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Sunteti sigur ca doriti sa stergeti aceasta inregistrare ?", "Master Detail CRUD", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("BuletinDelete", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@BuletinID", Convert.ToInt32(dgvRow.Cells["dgvtxtBuletinID"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                }

                else e.Cancel = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sunteti sigur ca doriti sa stergeti aceasta persoana ?", "Master Detail CRUD", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("PersoanaDelete", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@PersoanaID", inPersoanaID);
                    sqlCmd.ExecuteNonQuery();
                    Clear();
                    FillDgvPersoana();
                    MessageBox.Show("Persoana a fost stearsa");
                }
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillDgvPersoanaName();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtMama_DoubleClick(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("PersoanaViewByCNP", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@CNP", txtMama.Text.Trim());
                DataSet ds = new DataSet();
                sqlDa.Fill(ds);

                //Master-Fill

                //Adauga din Persoana
                DataRow dr = ds.Tables[0].Rows[0];
                txtCNP.Text = dr["CNP"].ToString();
                txtNume.Text = dr["Nume"].ToString();
                txtPrenume.Text = dr["Prenume"].ToString();
                txtStudii.Text = dr["Studii"].ToString();
                txtProfesie.Text = dr["Profesie"].ToString();
                txtOcupatie.Text = dr["Ocupatie"].ToString();
                txtSursaVenit.Text = dr["SursaVenit"].ToString();
                txtNumeAnterioare.Text = dr["NumeAnterioare"].ToString();
                cmbSex.Text = dr["Sex"].ToString();
                cmbSituatieMilitara.Text = dr["SituatieMilitara"].ToString();
                cmbStatutMarital.Text = dr["StatutMarital"].ToString();
                if (dr["Copii"].ToString() == "Da") rdbDa.Checked = true;
                else { if (dr["Copii"].ToString() == "Nu") rdbDa.Checked = true; }

                //Adauga din Certificat Nastere
                DataRow dr1 = ds.Tables[2].Rows[0];
                txtCertificatNastereID.Text = dr1["CertificatNastereID"].ToString();
                txtNrActNastere.Text = dr1["NrActNastere"].ToString();
                txtUnitateEmitentaNastere.Text = dr1["UnitateEmitenta"].ToString();
                txtDataNasterii.Text = dr1["Data"].ToString();



                //Adauga din Buletin
                dgvBuletin.AutoGenerateColumns = false;
                dgvBuletin.DataSource = ds.Tables[1];
                btnDelete.Enabled = true;
                btnSave.Text = "Update";
                tabControl1.SelectedIndex = 0;

            };

            //Adauga din Adresa
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa1 = new SqlDataAdapter("AdresaViewByPersoanaCNP", sqlCon);
                sqlDa1.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa1.SelectCommand.Parameters.AddWithValue("@CNP", txtMama.Text.Trim());
                DataSet ds1 = new DataSet();
                sqlDa1.Fill(ds1);

                dgvAdresa.AutoGenerateColumns = false;
                dgvAdresa.DataSource = ds1.Tables[0];
            };
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            this.Hide();
            form.ShowDialog();
            Close();
        }

        private void txtMama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTata_DoubleClick(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("PersoanaViewByCNP", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@CNP", txtTata.Text.Trim());
                DataSet ds = new DataSet();
                sqlDa.Fill(ds);

                //Master-Fill

                //Adauga din Persoana
                DataRow dr = ds.Tables[0].Rows[0];
                txtCNP.Text = dr["CNP"].ToString();
                txtNume.Text = dr["Nume"].ToString();
                txtPrenume.Text = dr["Prenume"].ToString();
                txtStudii.Text = dr["Studii"].ToString();
                txtProfesie.Text = dr["Profesie"].ToString();
                txtOcupatie.Text = dr["Ocupatie"].ToString();
                txtSursaVenit.Text = dr["SursaVenit"].ToString();
                txtNumeAnterioare.Text = dr["NumeAnterioare"].ToString();
                cmbSex.Text = dr["Sex"].ToString();
                cmbSituatieMilitara.Text = dr["SituatieMilitara"].ToString();
                cmbStatutMarital.Text = dr["StatutMarital"].ToString();
                if (dr["Copii"].ToString() == "Da") rdbDa.Checked = true;
                else { if (dr["Copii"].ToString() == "Nu") rdbDa.Checked = true; }

                //Adauga din Certificat Nastere
                DataRow dr1 = ds.Tables[2].Rows[0];
                txtCertificatNastereID.Text = dr1["CertificatNastereID"].ToString();
                txtNrActNastere.Text = dr1["NrActNastere"].ToString();
                txtUnitateEmitentaNastere.Text = dr1["UnitateEmitenta"].ToString();
                txtDataNasterii.Text = dr1["Data"].ToString();



                //Adauga din Buletin
                dgvBuletin.AutoGenerateColumns = false;
                dgvBuletin.DataSource = ds.Tables[1];
                btnDelete.Enabled = true;
                btnSave.Text = "Update";
                tabControl1.SelectedIndex = 0;

            };

            //Adauga din Adresa
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa1 = new SqlDataAdapter("AdresaViewByPersoanaCNP", sqlCon);
                sqlDa1.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa1.SelectCommand.Parameters.AddWithValue("@CNP", txtMama.Text.Trim());
                DataSet ds1 = new DataSet();
                sqlDa1.Fill(ds1);

                dgvAdresa.AutoGenerateColumns = false;
                dgvAdresa.DataSource = ds1.Tables[0];
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillDgvPersoanaCNP();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FillDgvPersoanaJudet();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FillDgvPersoanaData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FillDgvPersoanaOldest();
        }
    }
}
