using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projekat2tvp.Datas;

namespace projekat2tvp
{
    public partial class Main : Form
    {
        private string popularniTekst = "";
        private int indeksSlova = 0;
        public Main()
        {
            InitializeComponent();
            UcitajKategorije();
            UcitajVozila();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PrikaziNajpopularnijeVozilo();
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
                    string query = @"SELECT k.naziv as Kategorija, v.naziv as Naziv, v.marka as Marka, 
                                    v.model as Model, v.godina_proizvodnje as [Godina proizvodnje],
                        v.cena_po_satu as [Cena po satu]
                        FROM Vozilo v INNER JOIN Kategorija k
                        ON v.id_kategorije = k.id_kategorije";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);   //na adapter primenimo sqlQuery
                    DataTable table = new DataTable();                              //kreiramo novu praznu tabelu
                    adapter.Fill(table);                                            //popunjavamo tabelu podacima koje smo izvukli pomocu adaptera
                    dgIspis.DataSource = table;                                     //ispis tabele u dataGritView
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnFiltrirajCena_Click(object sender, EventArgs e)
        {
           
            if(cbKategorije.SelectedItem == null || String.IsNullOrEmpty(txtCenaOd.Text) || String.IsNullOrEmpty(txtCenaOd.Text))
            {
                MessageBox.Show("Morate popuniti sva polja","Greska", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime pocetniDatum = dtimePocetak.Value;
            DateTime krajnjiDatum = dtimeKraj.Value;
            string kategorija = cbKategorije.SelectedItem.ToString();
            double minCena = double.Parse(txtCenaOd.Text);
            double maxCena = double.Parse(txtCenaDo.Text);

            if (pocetniDatum > krajnjiDatum)
            {
                MessageBox.Show("Početni datum mora biti pre krajnjeg!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (OleDbConnection conn = Baza.GetConnection())
            {
                conn.Open();
                string query = @"SELECT v.id_vozila, k.naziv as Kategorija, v.naziv as Naziv, v.marka as Marka, v.model as Model, v.godina_proizvodnje as [Godina proizvodnje],
                v.cena_po_satu as [Cena po satu]
                FROM Vozilo v INNER JOIN Kategorija k
                ON v.id_kategorije = k.id_kategorije
                WHERE k.naziv = ? AND v.cena_po_satu >= ? AND v.cena_po_satu <= ?";

                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", kategorija);
                cmd.Parameters.AddWithValue("?", minCena);
                cmd.Parameters.AddWithValue("?", maxCena);

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                
                DataTable dostupnaVozila = table.Clone(); //kreiranje prazne tabele sa istom semom

                foreach (DataRow red in table.Rows)
                {
                    int idVozila = (int)red["id_vozila"];
                    string rez = @"SELECT COUNT(*) FROM Rezervacija 
                        WHERE id_vozila = ? AND 
                        NOT (datumVreme_kraja <= ? OR datumVreme_pocetka >= ?)";
                    OleDbCommand rezCmd = new OleDbCommand(rez, conn);
                    rezCmd.Parameters.AddWithValue("?", idVozila);
                    rezCmd.Parameters.AddWithValue("?", pocetniDatum);
                    rezCmd.Parameters.AddWithValue("?", krajnjiDatum);
                    int brojRez = Convert.ToInt32(rezCmd.ExecuteScalar() ?? 0); //ukoliko ne dodje do preklapanja, tj ne vrati se ni jedan red tabele postavlja se da brRez bude podrazumevana vrednost na 0

                    if (brojRez == 0) //ako nema preklapanja znaci da je vozilo dostupno za prosledjene kriterijume
                        dostupnaVozila.ImportRow(red);
                }
                
                if (dostupnaVozila.Rows.Count == 0)
                {
                    MessageBox.Show("Nema dostupnih vozila za zadate kriterijume.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                    dgIspis.DataSource = dostupnaVozila;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
     
        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            frmVozila frm = new frmVozila();
            frm.Show();
        }

        private void btnKategorija_Click(object sender, EventArgs e)
        {
            frmKategorija frm = new frmKategorija();
            frm.Show();
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            frmRezervacije frm = new frmRezervacije();
            frm.Show();
        }
        private void PrikaziNajpopularnijeVozilo()
        {
            Task.Run(() =>
            {
                string markaModelNajpopularnijeg = "";
                using (OleDbConnection conn = Baza.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT TOP 1 v.marka, v.naziv, v.model, COUNT(r.id_vozila) AS BrojRezervacija 
                                     FROM Vozilo v 
                                     LEFT JOIN Rezervacija r ON v.id_vozila = r.id_vozila 
                                     GROUP BY v.marka, v.naziv, v.model
                                     ORDER BY COUNT(r.id_vozila) DESC";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            markaModelNajpopularnijeg = reader["marka"] + " " + reader["naziv"] + " " + reader["model"];
                    }
                }
                if (!string.IsNullOrEmpty(markaModelNajpopularnijeg))
                {
                    popularniTekst = markaModelNajpopularnijeg + " ";
                    this.Invoke(new Action(() => { timer1.Start(); }));
                }
            });
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(popularniTekst))
                return;
            lblNajpopularnijee.Text = "The most wanted Vehicle: \n" + popularniTekst.Substring(indeksSlova) + popularniTekst.Substring(0, indeksSlova);
            indeksSlova++;
            if (indeksSlova >= popularniTekst.Length)
                indeksSlova = 0;
        }

        private void cbKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNajpopularnijee_Click(object sender, EventArgs e)
        {

        }
    }
}
