namespace projekat2tvp
{
    partial class frmRezervacije
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
            this.dgRezervacije = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pocetnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajRezervacijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniRezervacijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiRezervacijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziIzvestajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblVozackaKat = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtVozackaKat = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblOd = new System.Windows.Forms.Label();
            this.lblDo = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblCena = new System.Windows.Forms.Label();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRezervacije)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgRezervacije
            // 
            this.dgRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRezervacije.Location = new System.Drawing.Point(9, 41);
            this.dgRezervacije.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgRezervacije.Name = "dgRezervacije";
            this.dgRezervacije.RowHeadersWidth = 51;
            this.dgRezervacije.RowTemplate.Height = 24;
            this.dgRezervacije.Size = new System.Drawing.Size(769, 240);
            this.dgRezervacije.TabIndex = 0;
            this.dgRezervacije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRezervacije_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pocetnaToolStripMenuItem,
            this.dodajRezervacijuToolStripMenuItem,
            this.izmeniRezervacijuToolStripMenuItem,
            this.obrisiRezervacijuToolStripMenuItem,
            this.prikaziIzvestajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pocetnaToolStripMenuItem
            // 
            this.pocetnaToolStripMenuItem.Name = "pocetnaToolStripMenuItem";
            this.pocetnaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.pocetnaToolStripMenuItem.Text = "Home";
            this.pocetnaToolStripMenuItem.Click += new System.EventHandler(this.pocetnaToolStripMenuItem_Click);
            // 
            // dodajRezervacijuToolStripMenuItem
            // 
            this.dodajRezervacijuToolStripMenuItem.Name = "dodajRezervacijuToolStripMenuItem";
            this.dodajRezervacijuToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.dodajRezervacijuToolStripMenuItem.Text = "Add Reservation";
            this.dodajRezervacijuToolStripMenuItem.Click += new System.EventHandler(this.dodajRezervacijuToolStripMenuItem_Click);
            // 
            // izmeniRezervacijuToolStripMenuItem
            // 
            this.izmeniRezervacijuToolStripMenuItem.Name = "izmeniRezervacijuToolStripMenuItem";
            this.izmeniRezervacijuToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.izmeniRezervacijuToolStripMenuItem.Text = "Edit Reservation";
            this.izmeniRezervacijuToolStripMenuItem.Click += new System.EventHandler(this.izmeniRezervacijuToolStripMenuItem_Click);
            // 
            // obrisiRezervacijuToolStripMenuItem
            // 
            this.obrisiRezervacijuToolStripMenuItem.Name = "obrisiRezervacijuToolStripMenuItem";
            this.obrisiRezervacijuToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.obrisiRezervacijuToolStripMenuItem.Text = "Remove Reservation";
            this.obrisiRezervacijuToolStripMenuItem.Click += new System.EventHandler(this.obrisiRezervacijuToolStripMenuItem_Click);
            // 
            // prikaziIzvestajToolStripMenuItem
            // 
            this.prikaziIzvestajToolStripMenuItem.Name = "prikaziIzvestajToolStripMenuItem";
            this.prikaziIzvestajToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.prikaziIzvestajToolStripMenuItem.Text = "Show";
            this.prikaziIzvestajToolStripMenuItem.Click += new System.EventHandler(this.prikaziIzvestajToolStripMenuItem_Click);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(330, 295);
            this.lblNaslov.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(46, 18);
            this.lblNaslov.TabIndex = 2;
            this.lblNaslov.Text = "label1";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(62, 331);
            this.lblIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(48, 18);
            this.lblIme.TabIndex = 3;
            this.lblIme.Text = "Name";
            this.lblIme.Click += new System.EventHandler(this.lblIme_Click);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.Location = new System.Drawing.Point(62, 361);
            this.lblPrezime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(68, 18);
            this.lblPrezime.TabIndex = 4;
            this.lblPrezime.Text = "Surname";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.Location = new System.Drawing.Point(62, 422);
            this.lblAdresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(62, 18);
            this.lblAdresa.TabIndex = 5;
            this.lblAdresa.Text = "Address";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.Location = new System.Drawing.Point(62, 390);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(51, 18);
            this.lblTelefon.TabIndex = 6;
            this.lblTelefon.Text = "Phone";
            // 
            // lblVozackaKat
            // 
            this.lblVozackaKat.AutoSize = true;
            this.lblVozackaKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVozackaKat.Location = new System.Drawing.Point(25, 449);
            this.lblVozackaKat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVozackaKat.Name = "lblVozackaKat";
            this.lblVozackaKat.Size = new System.Drawing.Size(169, 18);
            this.lblVozackaKat.TabIndex = 7;
            this.lblVozackaKat.Text = "Driving Licence category";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(198, 332);
            this.txtIme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(122, 20);
            this.txtIme.TabIndex = 8;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(198, 361);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(122, 20);
            this.txtPrezime.TabIndex = 9;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(198, 422);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(122, 20);
            this.txtAdresa.TabIndex = 10;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(198, 392);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(122, 20);
            this.txtTelefon.TabIndex = 11;
            // 
            // txtVozackaKat
            // 
            this.txtVozackaKat.Location = new System.Drawing.Point(198, 451);
            this.txtVozackaKat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVozackaKat.Name = "txtVozackaKat";
            this.txtVozackaKat.Size = new System.Drawing.Size(122, 20);
            this.txtVozackaKat.TabIndex = 12;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(464, 390);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(48, 18);
            this.lblNaziv.TabIndex = 13;
            this.lblNaziv.Text = "Name";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarka.Location = new System.Drawing.Point(464, 328);
            this.lblMarka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(47, 18);
            this.lblMarka.TabIndex = 14;
            this.lblMarka.Text = "Brand";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(464, 359);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(49, 18);
            this.lblModel.TabIndex = 15;
            this.lblModel.Text = "Model";
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOd.Location = new System.Drawing.Point(464, 422);
            this.lblOd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(44, 18);
            this.lblOd.TabIndex = 16;
            this.lblOd.Text = "From";
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDo.Location = new System.Drawing.Point(464, 449);
            this.lblDo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(26, 18);
            this.lblDo.TabIndex = 17;
            this.lblDo.Text = "To";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(544, 390);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(122, 20);
            this.txtNaziv.TabIndex = 18;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(544, 328);
            this.txtMarka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(122, 20);
            this.txtMarka.TabIndex = 19;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(544, 361);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(122, 20);
            this.txtModel.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(544, 423);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(544, 451);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(310, 485);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(194, 34);
            this.btnDodaj.TabIndex = 23;
            this.btnDodaj.Text = "Add Reservation";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCena.Location = new System.Drawing.Point(560, 497);
            this.lblCena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(51, 20);
            this.lblCena.TabIndex = 24;
            this.lblCena.Text = "label1";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(310, 485);
            this.btnIzmeni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(194, 32);
            this.btnIzmeni.TabIndex = 25;
            this.btnIzmeni.Text = "Edit";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.Control;
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(310, 483);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(194, 34);
            this.btnObrisi.TabIndex = 26;
            this.btnObrisi.Text = "Remove";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // frmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(799, 539);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblDo);
            this.Controls.Add(this.lblOd);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtVozackaKat);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblVozackaKat);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.dgRezervacije);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRezervacije";
            this.Text = "Rezervacije";
            this.Load += new System.EventHandler(this.frmRezervacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRezervacije)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRezervacije;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pocetnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajRezervacijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniRezervacijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiRezervacijuToolStripMenuItem;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblVozackaKat;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtVozackaKat;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.ToolStripMenuItem prikaziIzvestajToolStripMenuItem;
    }
}