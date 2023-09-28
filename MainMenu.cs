using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoliceDatabase
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void asdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterPersoane form = new MasterPersoane();
            this.Hide();
            form.ShowDialog();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void sadfvgdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AmenziForm form = new AmenziForm();
            this.Hide();
            form.ShowDialog();
            Close();
        }

        private void CasatoriiItem_Click(object sender, EventArgs e)
        {
            CasatoriiForm form = new CasatoriiForm();
            this.Hide();
            form.ShowDialog();
            Close();
        }
    }
}
