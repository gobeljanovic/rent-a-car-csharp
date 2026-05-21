using projekat2tvp.Datas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekat2tvp
{
    public partial class frmRezervacije : Form
    {
        public frmRezervacije()
        {
            InitializeComponent();
            UcitajRezervacije();
            SakrijElemente();
        }

        private void frmRezervacije_Load(object sender, EventArgs e)
        {

        }
        private void UcitajRezervacije()
        {
            try
            {
                using(OleDbConnection conn = Baza.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT k.ime as Ime, k.prezime as Prezime, k.telefon as Telefon, v.naziv as [Naziv vozila],
                    r.datumVreme_pocetka as [Datum i vreme pocetka], r.datumVreme_kraja as [Datum i vreme kraja],
                    r.cena as Cena
                    FROM (Klijent k INNER JOIN Rezervacija r 
                    ON k.id_klijenta = r.id_klijenta)
                    INNER JOIN Vozilo v
                    ON r.id_vozila=v.id_vozila";


                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgRezervacije.DataSource = table;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SakrijElemente()
        {
            this.Size = this.Size = new System.Drawing.Size(800, 350);
            lblIme.Visible = false;
            lblPrezime.Visible = false;
            lblAdresa.Visible = false;
            lblNaslov.Visible = false;
            lblTelefon.Visible = false;
            lblVozackaKat.Visible = false;
            lblNaziv.Visible = false;
            lblDo.Visible = false;
            lblOd.Visible = false;
            lblMarka.Visible = false;
            lblModel.Visible = false;
            txtIme.Visible = false;
            txtPrezime.Visible = false;
            txtAdresa.Visible = false;
            txtTelefon.Visible = false;
            txtVozackaKat.Visible=false;
            txtMarka.Visible = false;
            txtModel.Visible = false;
            txtNaziv.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            btnDodaj.Visible = false;
            btnIzmeni.Visible=false;
            btnObrisi.Visible = false;
            lblCena.Visible = false;
        }
        private void PrikaziElemente()
        {
            this.Size = this.Size = new System.Drawing.Size(800, 590);
            lblIme.Visible = true;
            lblPrezime.Visible = true;
            lblAdresa.Visible = true;
            lblNaslov.Visible = true;
            lblTelefon.Visible = true;
            lblVozackaKat.Visible = true;
            lblNaziv.Visible = true;
            lblDo.Visible = true;
            lblOd.Visible = true;
            lblMarka.Visible = true;
            lblModel.Visible = true;
            txtIme.Visible = true;
            txtPrezime.Visible = true;
            txtAdresa.Visible = true;
            txtTelefon.Visible = true;
            txtVozackaKat.Visible = true;
            txtMarka.Visible = true;
            txtModel.Visible = true;
            txtNaziv.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            txtIme.Clear();
            txtPrezime.Clear();
            txtAdresa.Clear();
            txtTelefon.Clear();
            txtVozackaKat.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            txtNaziv.Clear();


        }

        private void pocetnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SakrijElemente();
        }

        private void dodajRezervacijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziElemente();
            btnDodaj.Visible = true;
            lblNaslov.Text = "Add Reservation";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtIme.Text) || String.IsNullOrEmpty(txtPrezime.Text) ||
                String.IsNullOrEmpty(txtAdresa.Text) || String.IsNullOrEmpty(txtTelefon.Text) ||
                String.IsNullOrEmpty(txtVozackaKat.Text) || String.IsNullOrEmpty(txtNaziv.Text) ||
                String.IsNullOrEmpty(txtModel.Text) || String.IsNullOrEmpty(txtMarka.Text))
            {
                MessageBox.Show("Must fill all input fileds!", "Issue", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ime = txtIme.Text.Trim();
            string prezime = txtPrezime.Text.Trim();
            string adresa = txtAdresa.Text.Trim();
            string telefon = txtTelefon.Text.Trim();
            string vozackaKategorija = txtVozackaKat.Text.Trim();
            string naziv = txtNaziv.Text.Trim();
            string model = txtModel.Text.Trim();
            string marka = txtMarka.Text.Trim();
            DateTime pocetniDatum = dateTimePicker1.Value;
            DateTime krajnjiDatum = dateTimePicker2.Value;

            if (krajnjiDatum <= pocetniDatum)
            {
                MessageBox.Show("The end date must be after the start date.", "Issue",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (OleDbConnection conn = Baza.GetConnection())
                {
                    conn.Open();
                    int voziloId = 0;
                    double cenaPoSatu = 0;
                    string queryVozilo = @"SELECT id_vozila,cena_po_satu
                                  FROM Vozilo
                                  WHERE naziv = ? AND marka = ? AND model = ?";

                    using (OleDbCommand cmd = new OleDbCommand(queryVozilo, conn))
                    {
                        cmd.Parameters.AddWithValue("?", naziv);
                        cmd.Parameters.AddWithValue("?", marka);
                        cmd.Parameters.AddWithValue("?", model);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                voziloId = Convert.ToInt32(reader["id_vozila"]);
                                cenaPoSatu = Convert.ToDouble(reader["cena_po_satu"]);
                            }
                            else
                            {
                                MessageBox.Show("Vozilo nije pronađeno!");
                                return;
                            }

                        }
                    }

                    string queryPostojecaRez = @"SELECT COUNT(*) FROM Rezervacija
                                            WHERE id_vozila=? AND NOT(datumVreme_pocetka >= ? OR datumVreme_kraja <= ? )";
                    using(OleDbCommand cmd2 = new OleDbCommand(queryPostojecaRez, conn))
                    {
                        cmd2.Parameters.AddWithValue("?", voziloId);
                        cmd2.Parameters.AddWithValue("?", krajnjiDatum);
                        cmd2.Parameters.AddWithValue("?", pocetniDatum);
                        int br = Convert.ToInt32(cmd2.ExecuteScalar() ?? 0);
                        if(br > 0)
                        {
                            MessageBox.Show("Vozilo je vec rezervisano za trazeni datum!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    int klijentId=0;
                    string queryKlijent = @"SELECT id_klijenta FROM Klijent
                                            WHERE ime = ? AND prezime = ? AND adresa = ? AND telefon = ? AND vozacka_kategorija = ?";
                    
                    using(OleDbCommand cmd3 = new OleDbCommand(queryKlijent, conn))
                    {
                        cmd3.Parameters.AddWithValue("?", ime);
                        cmd3.Parameters.AddWithValue("?", prezime);
                        cmd3.Parameters.AddWithValue("?", adresa);
                        cmd3.Parameters.AddWithValue("?", telefon);
                        cmd3.Parameters.AddWithValue("?", vozackaKategorija);
                        var rez = cmd3.ExecuteScalar(); 
                        if(rez!=null)
                        {
                             klijentId = Convert.ToInt32(rez);
                        }
                        else //ukoliko klijent ne postoji kreiramo novog klijenta
                        {
                            string queryNoviKlijent = @"INSERT INTO Klijent (ime, prezime, adresa, telefon, vozacka_kategorija)
                                                        VALUES (?,?,?,?,?)";
                            using(OleDbCommand cmdInsert = new OleDbCommand( queryNoviKlijent, conn))
                            {
                                cmdInsert.Parameters.AddWithValue("?", ime);
                                cmdInsert.Parameters.AddWithValue("?",prezime);
                                cmdInsert.Parameters.AddWithValue("?", adresa);
                                cmdInsert.Parameters.AddWithValue ("?", telefon);
                                cmdInsert.Parameters.AddWithValue("?",vozackaKategorija);
                                cmdInsert.ExecuteNonQuery();
                            }

                            using(OleDbCommand cmdGetId = new OleDbCommand("SELECT MAX(id_klijenta) FROM Klijent", conn))
                            {
                                 klijentId = Convert.ToInt32(cmdGetId.ExecuteScalar());
                            }
                        }
                    }
                    TimeSpan trajanje = krajnjiDatum - pocetniDatum;
                    double ukupnaCena = cenaPoSatu * trajanje.TotalHours;
                    lblCena.Visible = true;
                    lblCena.Text = "Ukupna cena: " + ukupnaCena.ToString();

                    string queryInsertRez = @"INSERT INTO Rezervacija (id_vozila,id_klijenta,datumVreme_pocetka,datumVreme_kraja,cena)
                                                    VALUES (?,?,?,?,?)";
                    using (OleDbCommand cmdInsertRez = new OleDbCommand(queryInsertRez, conn))
                    {
                        //cmdInsertRez.Parameters.AddWithValue("?", voziloId); DataType Miss Match, brkao je tipove podataka!
                        //cmdInsertRez.Parameters.AddWithValue("?", klijentId);
                        //cmdInsertRez.Parameters.AddWithValue("?", pocetniDatum);
                        //cmdInsertRez.Parameters.AddWithValue("?", krajnjiDatum);
                        //cmdInsertRez.Parameters.AddWithValue("?", ukupnaCena);
                        cmdInsertRez.Parameters.Add("?", OleDbType.Integer).Value = voziloId;
                        cmdInsertRez.Parameters.Add("?", OleDbType.Integer).Value = klijentId;
                        cmdInsertRez.Parameters.Add("?", OleDbType.Date).Value = pocetniDatum;
                        cmdInsertRez.Parameters.Add("?", OleDbType.Date).Value = krajnjiDatum;
                        cmdInsertRez.Parameters.Add("?", OleDbType.Currency).Value = ukupnaCena;
                        cmdInsertRez.ExecuteNonQuery();
                    }
                    MessageBox.Show("Rezervacija uspešno dodata!");
                    UcitajRezervacije();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("GRESKA: " + ex.Message);
            }
            
        }

        private void dgRezervacije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void izmeniRezervacijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziElemente();
            lblNaslov.Text = "Edit Reservation";
            btnDodaj.Visible = false;
            btnObrisi.Visible = false;
            btnIzmeni.Visible = true;
            lblAdresa.Visible = false;
            lblVozackaKat.Visible = false;
            txtAdresa.Visible=false;
            txtVozackaKat.Visible=false;
            lblMarka.Visible = false;
            lblModel.Visible = false;
            txtMarka.Visible = false;
            txtModel.Visible = false;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtIme.Text) || String.IsNullOrEmpty(txtPrezime.Text) ||
                String.IsNullOrEmpty(txtTelefon.Text) || String.IsNullOrEmpty(txtNaziv.Text))
            {
                MessageBox.Show("Morate popuniti sva polja!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ime = txtIme.Text.Trim();
            string prezime = txtPrezime.Text.Trim();
            string telefon = txtTelefon.Text.Trim();
            string naziv = txtNaziv.Text.Trim();
            DateTime pocetniDatum = dateTimePicker1.Value;
            DateTime krajnjiDatum = dateTimePicker2.Value;

            try
            {
                using(OleDbConnection conn = Baza.GetConnection())
                {
                    conn.Open();
                    string checkQuery = @"SELECT r.id_rezervacija, r.datumVreme_pocetka, r.datumVreme_kraja, v.cena_po_satu, r.id_vozila
                                  FROM (Rezervacija r
                                  INNER JOIN Klijent k ON r.id_klijenta = k.id_klijenta)
                                  INNER JOIN Vozilo v ON r.id_vozila = v.id_vozila 
                                  WHERE k.ime = ? AND k.prezime = ? AND k.telefon = ?";
                    using(OleDbCommand cmd = new OleDbCommand(checkQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("?", ime);
                        cmd.Parameters.AddWithValue("?", prezime);
                        cmd.Parameters.AddWithValue("?", telefon);
                        using(OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if(!reader.Read())
                            {
                                MessageBox.Show("Rezervacija nije pronađena.");
                                return;
                            }
                            int rezervacijaId = Convert.ToInt32(reader["id_rezervacija"]);
                            double cena_po_satu = Convert.ToDouble(reader["cena_po_satu"]);
                            int voziloId = Convert.ToInt32(reader["id_vozila"]);

                            string conflictQuery = @"SELECT COUNT(*) FROM Rezervacija 
                                             WHERE id_vozila = ? AND id_rezervacija <> ? 
                                             AND NOT (datumVreme_kraja <= ? OR datumVreme_pocetka >= ?)";

                            using (OleDbCommand preklapanjeCmd = new OleDbCommand(conflictQuery, conn))
                            {
                                preklapanjeCmd.Parameters.AddWithValue("?", voziloId);
                                preklapanjeCmd.Parameters.AddWithValue("?", rezervacijaId);
                                preklapanjeCmd.Parameters.AddWithValue("?", pocetniDatum);
                                preklapanjeCmd.Parameters.AddWithValue("?", krajnjiDatum);
                                int zauzeto = Convert.ToInt32(preklapanjeCmd.ExecuteScalar() ?? 0);
                                
                                //ovde umesto message-boxa izlazi mi miss match exception
                                if (zauzeto > 0)
                                {
                                    MessageBox.Show("Vozilo je već rezervisano u ovom periodu.");
                                    return;
                                }
                            }
                            TimeSpan trajanje = krajnjiDatum - pocetniDatum;
                            double ukupna_cena = trajanje.TotalHours * cena_po_satu;
                            lblCena.Visible = true;
                            lblCena.Text = ukupna_cena.ToString();

                            string updateQuery = @"UPDATE Rezervacija 
                                           SET datumVreme_pocetka = ?, datumVreme_kraja = ?, cena = ?
                                           WHERE id_rezervacija = ?";
                            using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.Add("?", OleDbType.Date).Value = pocetniDatum;
                                updateCmd.Parameters.Add("?", OleDbType.Date).Value = krajnjiDatum;
                                updateCmd.Parameters.Add("?", OleDbType.Currency).Value = ukupna_cena;
                                updateCmd.Parameters.Add("?", OleDbType.Integer).Value = rezervacijaId;
                                updateCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Rezervacija uspešno izmenjena.");
                            UcitajRezervacije();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
        }

        private void obrisiRezervacijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziElemente();
            lblNaslov.Text = "Remove Reservation";
            btnDodaj.Visible = false;
            btnIzmeni.Visible = false;
            btnObrisi.Visible = true;
            lblAdresa.Visible = false;
            lblVozackaKat.Visible = false;
            txtAdresa.Visible = false;
            txtVozackaKat.Visible = false;
            lblMarka.Visible = false;
            lblModel.Visible = false;
            txtMarka.Visible = false;
            txtModel.Visible = false;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIme.Text) || String.IsNullOrEmpty(txtPrezime.Text) ||
                        String.IsNullOrEmpty(txtTelefon.Text) || String.IsNullOrEmpty(txtNaziv.Text))
            {
                MessageBox.Show("Morate popuniti sva polja!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (dateTimePicker1.Value >= dateTimePicker2.Value)
            {
                MessageBox.Show("Datum početka mora biti pre datuma kraja.");
                return;
            }

            string ime = txtIme.Text.Trim();
            string prezime = txtPrezime.Text.Trim();
            string telefon = txtTelefon.Text.Trim();
            string naziv = txtNaziv.Text.Trim();
            DateTime pocetniDatum = dateTimePicker1.Value;
            DateTime krajnjiDatum = dateTimePicker2.Value;


            try
            {
                using(OleDbConnection conn = Baza.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT r.id_rezervacija 
                    FROM (Rezervacija r INNER JOIN Klijent k 
                    ON r.id_klijenta = k.id_klijenta)
                    INNER JOIN Vozilo v ON v.id_vozila = r.id_vozila
                    WHERE k.ime = ? AND k.prezime = ? AND k.telefon = ? AND
                    v.naziv = ? AND r.datumVreme_pocetka = ?  AND r.datumVreme_kraja = ?";

                    using(OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?",ime);
                        cmd.Parameters.AddWithValue("?", prezime);
                        cmd.Parameters.AddWithValue("?", telefon);
                        cmd.Parameters.AddWithValue("?", naziv);
                        cmd.Parameters.AddWithValue("?", pocetniDatum);
                        cmd.Parameters.AddWithValue("?", krajnjiDatum);

                        var rez = cmd.ExecuteScalar();
                        if (rez == null)
                        {
                            MessageBox.Show("Rezervacija nije pronađena.");
                            return;
                        }
                        int rezervacijaId = Convert.ToInt32(rez);

                        if (MessageBox.Show("Da li ste sigurni da želite da obrišete rezervaciju?", "Potvrda",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            return;

                        string queryBrisanjeRez = @"DELETE FROM Rezervacija WHERE id_rezervacija = ?";

                        using (OleDbCommand cmdDelete = new OleDbCommand(queryBrisanjeRez, conn))
                        {
                            cmdDelete.Parameters.AddWithValue("?", rezervacijaId);
                            cmdDelete.ExecuteNonQuery();
                        }
                        MessageBox.Show("Rezervacija uspešno izbrisana.");
                        UcitajRezervacije();

                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("GRESKA prilkom brisanja " + ex.Message);
            }
        }

        private void prikaziIzvestajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIzvestaj frm = new frmIzvestaj();
            frm.Show();
        }

        private void lblIme_Click(object sender, EventArgs e)
        {

        }
    }
}
