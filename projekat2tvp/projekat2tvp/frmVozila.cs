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
using System.Windows.Forms.VisualStyles;
using projekat2tvp.Datas;

namespace projekat2tvp
{
    public partial class frmVozila : Form
    {
        public frmVozila()
        {
            InitializeComponent();
            UcitajVozila();
            UcitajKategorije();
            SakrijElemente();
        }

        private void UcitajKategorije()
        {
            try
            {
                using (OleDbConnection conn = Baza.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT naziv FROM Kategorija ORDER BY naziv";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    cbKategorije.Items.Clear();

                    while (reader.Read())
                    {
                        cbKategorije.Items.Add(reader["naziv"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UcitajVozila()
        {
            try
            {
                using (OleDbConnection conn = Baza.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT k.naziv as Kategorija, v.naziv as Naziv, v.marka as Marka, v.model as Model, v.godina_proizvodnje as Godiste, v.cena_po_satu as [Cena po satu]
                        FROM Vozilo v INNER JOIN Kategorija k
                        ON v.id_kategorije = k.id_kategorije";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgIspisVozila.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmVozila_Load(object sender, EventArgs e)
        {

        }

        

        private void dodajVoziloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UcitajVozila();
            PrikaziElemente();
            
        }

        private void dodajVoziloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UcitajVozila();
            SakrijElemente();
           
        }
        private void SakrijElemente()
        {
            this.Size = new System.Drawing.Size(566, 465);
            lblKat.Visible = false;
            lblMarka.Visible = false;
            lblModel.Visible = false;
            lblNaziv.Visible = false;
            lblCenaPoSatu.Visible = false;
            lblDodajteNovoVozilo.Visible = false;
            lblGodProiz.Visible = false;
            btnDodaj.Visible = false;
            txtCenaPoSatu.Visible = false;
            txtGodProiz.Visible = false;
            cbKategorije.Visible = false;
            txtMarka.Visible = false;
            txtModel.Visible = false;
            txtNaziv.Visible = false;
        }
        private void PrikaziElemente()
        {
            this.Size = new System.Drawing.Size(900, 465);
            lblKat.Visible = true;
            lblMarka.Visible = true;
            lblModel.Visible = true;
            lblNaziv.Visible = true;
            lblCenaPoSatu.Visible = true;
            lblDodajteNovoVozilo.Visible = true;
            lblGodProiz.Visible = true;
            btnDodaj.Visible = true;
            txtCenaPoSatu.Visible = true;
            txtGodProiz.Visible = true;
            cbKategorije.Visible = true;
            txtMarka.Visible = true;
            txtModel.Visible = true;
            txtNaziv.Visible = true;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            if(String.IsNullOrEmpty(txtGodProiz.Text) || String.IsNullOrEmpty(txtNaziv.Text) ||
                String.IsNullOrEmpty(txtModel.Text) || String.IsNullOrEmpty(txtMarka.Text) ||
                String.IsNullOrEmpty(txtCenaPoSatu.Text) || cbKategorije.SelectedItem==null) 
            {
                MessageBox.Show("Morate popuniti sva polja!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            int god_proiz = int.Parse(txtGodProiz.Text);
            string naziv = txtNaziv.Text.Trim();
            string model = txtModel.Text.Trim();
            string marka = txtMarka.Text.Trim();
            string kategorija = cbKategorije.SelectedItem.ToString();
            double cena_po_satu = double.Parse(txtCenaPoSatu.Text.Trim());

            try
            {
                using(OleDbConnection conn = Baza.GetConnection())
                {
                    conn.Open();

                    //provera da li vozilo vec postoji
                    string query = @"SELECT COUNT(*) 
                    FROM Vozilo v INNER JOIN Kategorija k 
                    ON v.id_kategorije = k.id_kategorije
                    WHERE k.naziv = ? AND v.naziv = ? AND v.model = ?";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("?", kategorija);
                    cmd.Parameters.AddWithValue("?", naziv);
                    cmd.Parameters.AddWithValue ("?", model);
                    int br = Convert.ToInt32(cmd.ExecuteScalar());

                    if(br > 0)
                    {
                        MessageBox.Show("Vozilo sa unetom kategorijom, nazivom i modelom vec postoji", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    //Uzimanje id-a od izabrane kategorije
                    string idKategorije = @"SELECT id_kategorije FROM Kategorija WHERE naziv=?";
                    OleDbCommand cmd2 = new OleDbCommand(idKategorije, conn);
                    cmd2.Parameters.AddWithValue("?", kategorija);
                    int idKat = Convert.ToInt32(cmd2.ExecuteScalar());


                    string query2 = @"INSERT INTO Vozilo (id_kategorije,naziv,marka,model,godina_proizvodnje,cena_po_satu)
                    VALUES (?,?,?,?,?,?)";

                    using(OleDbCommand cmd3 = new OleDbCommand(query2, conn))
                    { 
                        cmd3.Parameters.AddWithValue("?", idKat);
                        cmd3.Parameters.AddWithValue("?", naziv);
                        cmd3.Parameters.AddWithValue("?", marka);
                        cmd3.Parameters.AddWithValue("?", model);
                        cmd3.Parameters.AddWithValue("?", god_proiz);
                        cmd3.Parameters.AddWithValue("?", cena_po_satu);
                        cmd3.ExecuteNonQuery();
                    }
                    MessageBox.Show("Vozilo uspešno dodato.","Obavestenje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    UcitajVozila();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Greška prilikom dodavanja vozila: " + ex.Message);
            }
            

        }
    }
}
