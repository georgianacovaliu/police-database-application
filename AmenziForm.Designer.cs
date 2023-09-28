
namespace PoliceDatabase
{
    partial class AmenziForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvAmenda = new System.Windows.Forms.DataGridView();
            this.dgvtxtAmendaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtFapta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgtxtPrevedere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgtxtSanctionare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSanctionare = new System.Windows.Forms.TextBox();
            this.txtPrevedere = new System.Windows.Forms.TextBox();
            this.txtFapta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvPersoanaAll = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservatii = new System.Windows.Forms.TextBox();
            this.txtDataAmenda = new System.Windows.Forms.TextBox();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.txtCNPAmendat = new System.Windows.Forms.TextBox();
            this.txtPersAmendata = new System.Windows.Forms.TextBox();
            this.textDenFapta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmenda)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoanaAll)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1318, 581);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.btnBack);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1310, 550);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Amenzi";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.dgvAmenda);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(529, 38);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(737, 457);
            this.panel5.TabIndex = 6;
            // 
            // dgvAmenda
            // 
            this.dgvAmenda.AllowUserToAddRows = false;
            this.dgvAmenda.AllowUserToDeleteRows = false;
            this.dgvAmenda.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvAmenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtAmendaID,
            this.dgvtxtFapta,
            this.dvgtxtPrevedere,
            this.dvgtxtSanctionare});
            this.dgvAmenda.Location = new System.Drawing.Point(12, 41);
            this.dgvAmenda.Name = "dgvAmenda";
            this.dgvAmenda.RowTemplate.Height = 25;
            this.dgvAmenda.Size = new System.Drawing.Size(712, 404);
            this.dgvAmenda.TabIndex = 0;
            this.dgvAmenda.DoubleClick += new System.EventHandler(this.dgvAmenda_DoubleClick);
            // 
            // dgvtxtAmendaID
            // 
            this.dgvtxtAmendaID.DataPropertyName = "AmendaID";
            this.dgvtxtAmendaID.HeaderText = "AmendaID";
            this.dgvtxtAmendaID.Name = "dgvtxtAmendaID";
            this.dgvtxtAmendaID.Visible = false;
            // 
            // dgvtxtFapta
            // 
            this.dgvtxtFapta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvtxtFapta.DataPropertyName = "Fapta";
            this.dgvtxtFapta.HeaderText = "Denumirea faptei";
            this.dgvtxtFapta.Name = "dgvtxtFapta";
            // 
            // dvgtxtPrevedere
            // 
            this.dvgtxtPrevedere.DataPropertyName = "ArticolPrevedere";
            this.dvgtxtPrevedere.HeaderText = "Prevăzută în Art.";
            this.dvgtxtPrevedere.Name = "dvgtxtPrevedere";
            // 
            // dvgtxtSanctionare
            // 
            this.dvgtxtSanctionare.DataPropertyName = "ArticolSanctionare";
            this.dvgtxtSanctionare.HeaderText = "Sanctionată de Art.";
            this.dvgtxtSanctionare.Name = "dvgtxtSanctionare";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(12, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 18);
            this.label14.TabIndex = 2;
            this.label14.Text = "Tipuri de Amenzi";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(17, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 26);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Înapoi";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(46, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 253);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtSanctionare);
            this.panel4.Controls.Add(this.txtPrevedere);
            this.panel4.Controls.Add(this.txtFapta);
            this.panel4.Location = new System.Drawing.Point(15, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(399, 189);
            this.panel4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fapta:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(293, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adaugă";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sanctionată de Articolul:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prevăzută în Articolul:";
            // 
            // txtSanctionare
            // 
            this.txtSanctionare.Location = new System.Drawing.Point(168, 102);
            this.txtSanctionare.Name = "txtSanctionare";
            this.txtSanctionare.Size = new System.Drawing.Size(209, 24);
            this.txtSanctionare.TabIndex = 1;
            // 
            // txtPrevedere
            // 
            this.txtPrevedere.Location = new System.Drawing.Point(168, 61);
            this.txtPrevedere.Name = "txtPrevedere";
            this.txtPrevedere.Size = new System.Drawing.Size(209, 24);
            this.txtPrevedere.TabIndex = 1;
            // 
            // txtFapta
            // 
            this.txtFapta.Location = new System.Drawing.Point(168, 17);
            this.txtFapta.Name = "txtFapta";
            this.txtFapta.Size = new System.Drawing.Size(209, 24);
            this.txtFapta.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(243, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "AMENDA";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1310, 550);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Persoane Amendate ";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.dgvPersoanaAll);
            this.panel6.Controls.Add(this.txtSearch);
            this.panel6.Controls.Add(this.btnSearch);
            this.panel6.Location = new System.Drawing.Point(145, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1058, 503);
            this.panel6.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(799, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 26);
            this.button4.TabIndex = 6;
            this.button4.Text = "Afișează amenda maximă";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvPersoanaAll
            // 
            this.dgvPersoanaAll.AllowUserToAddRows = false;
            this.dgvPersoanaAll.AllowUserToDeleteRows = false;
            this.dgvPersoanaAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersoanaAll.Location = new System.Drawing.Point(24, 46);
            this.dgvPersoanaAll.Name = "dgvPersoanaAll";
            this.dgvPersoanaAll.ReadOnly = true;
            this.dgvPersoanaAll.RowTemplate.Height = 25;
            this.dgvPersoanaAll.Size = new System.Drawing.Size(1008, 439);
            this.dgvPersoanaAll.TabIndex = 5;
            this.dgvPersoanaAll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersoanaAll_CellContentClick);
            this.dgvPersoanaAll.DoubleClick += new System.EventHandler(this.dgvPersoanaAll_DoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(114, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(207, 24);
            this.txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(24, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 26);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Caută";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 26);
            this.button2.TabIndex = 6;
            this.button2.Text = "Renunță";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1310, 550);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Adauga detalii";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.label12);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(419, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(427, 492);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtObservatii);
            this.panel2.Controls.Add(this.txtDataAmenda);
            this.panel2.Controls.Add(this.txtSuma);
            this.panel2.Controls.Add(this.txtCNPAmendat);
            this.panel2.Controls.Add(this.txtPersAmendata);
            this.panel2.Controls.Add(this.textDenFapta);
            this.panel2.Location = new System.Drawing.Point(12, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 438);
            this.panel2.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(274, 389);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 26);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Adăugare";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Observatii:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Persoana amendata:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Suma:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "CNP:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(198, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "Date selectate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(189, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Introduceți detalii";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Denumirea faptei:";
            // 
            // txtObservatii
            // 
            this.txtObservatii.Location = new System.Drawing.Point(149, 340);
            this.txtObservatii.Name = "txtObservatii";
            this.txtObservatii.Size = new System.Drawing.Size(209, 24);
            this.txtObservatii.TabIndex = 0;
            // 
            // txtDataAmenda
            // 
            this.txtDataAmenda.Location = new System.Drawing.Point(149, 245);
            this.txtDataAmenda.Name = "txtDataAmenda";
            this.txtDataAmenda.Size = new System.Drawing.Size(209, 24);
            this.txtDataAmenda.TabIndex = 0;
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(149, 294);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(209, 24);
            this.txtSuma.TabIndex = 0;
            // 
            // txtCNPAmendat
            // 
            this.txtCNPAmendat.Location = new System.Drawing.Point(149, 152);
            this.txtCNPAmendat.Name = "txtCNPAmendat";
            this.txtCNPAmendat.Size = new System.Drawing.Size(209, 24);
            this.txtCNPAmendat.TabIndex = 0;
            // 
            // txtPersAmendata
            // 
            this.txtPersAmendata.Location = new System.Drawing.Point(149, 104);
            this.txtPersAmendata.Name = "txtPersAmendata";
            this.txtPersAmendata.Size = new System.Drawing.Size(209, 24);
            this.txtPersAmendata.TabIndex = 0;
            // 
            // textDenFapta
            // 
            this.textDenFapta.Location = new System.Drawing.Point(149, 51);
            this.textDenFapta.Name = "textDenFapta";
            this.textDenFapta.Size = new System.Drawing.Size(209, 24);
            this.textDenFapta.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(15, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "Adăugare Amendă";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 26);
            this.button3.TabIndex = 7;
            this.button3.Text = "Renunță";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AmenziForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1342, 635);
            this.Controls.Add(this.tabControl1);
            this.Name = "AmenziForm";
            this.Text = "AmenziForm";
            this.Load += new System.EventHandler(this.AmenziForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmenda)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoanaAll)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSanctionare;
        private System.Windows.Forms.TextBox txtPrevedere;
        private System.Windows.Forms.TextBox txtFapta;
        private System.Windows.Forms.DataGridView dgvAmenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmendaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtFapta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgtxtPrevedere;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgtxtSanctionare;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvPersoanaAll;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservatii;
        private System.Windows.Forms.TextBox txtDataAmenda;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.TextBox txtCNPAmendat;
        private System.Windows.Forms.TextBox txtPersAmendata;
        private System.Windows.Forms.TextBox textDenFapta;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
    }
}