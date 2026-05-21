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
using projekat2tvp.Datas;

namespace projekat2tvp
{
    public partial class frmKategorija : Form
    {
        public frmKategorija()
        {
            InitializeComponent();
            UcitajKategorije();
            SakrijElemente();
        }

        private void pocetnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UcitajKategorije();
            SakrijElemente();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtNaziv.Text) || String.IsNullOrEmpty(txtOpis.Text))
            {
                MessageBox.Show("Morate popuniti sva polja!","Greska",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string naziv = txtNaziv.Text.Trim();
            string opis = txtOpis.Text.Trim();

            try
            {
                using(OleDbConnection conn = Baza.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT COUNT(*)
                                    FROM Kategorija
                                    WHERE naziv=?";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("?", naziv);
                    int br = Convert.ToInt32(cmd.ExecuteScalar() ?? 0);
                    if(br> 0)
                    {
                        MessageBox.Show("Kategorija sa unetim nazivom vec postoji!","Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query2 = @"INSERT INTO Kategorija (naziv,opis)
                                      VALUES (?,?)";
                    using (OleDbCommand cmd2 = new OleDbCommand(query2, conn))
                    {
                        cmd2.Parameters.AddWithValue("?", naziv);
                        cmd2.Parameters.AddWithValue("?", opis);
                        cmd2.ExecuteNonQuery();
                    }
                    MessageBox.Show("Kategorija Uspesno dodata", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UcitajKategorije();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void UcitajKategorije()
        {
            try
            {
                using(OleDbConnection conn = Baza.GetConnection())
                {
                    conn.Open();
                    string guery = @"SELECT naziv,opis FROM Kategorija";
                    OleDbCommand cmd = new OleDbCommand(guery,conn);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgKategorije.DataSource = table;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SakrijElemente()
        {
            this.Size = new System.Drawing.Size(487, 417);
            lblDodajKat.Visible=false;
            lblNaziv.Visible=false;
            lblOpis.Visible = false;
            txtNaziv.Visible=false;
            txtOpis.Visible=false;
            btnDodaj.Visible=false;
        }
        private void PrikaziElemente()
        {
            this.Size = new System.Drawing.Size(900, 417);
            lblDodajKat.Visible = true;
            lblNaziv.Visible = true;
            lblOpis.Visible = true;
            txtNaziv.Visible = true;
            txtOpis.Visible = true;
            btnDodaj.Visible = true;
        }

        private void dodajKategorijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziElemente();
        }

        
    }
}
