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
using System.Windows.Forms.DataVisualization.Charting;

namespace projekat2tvp
{
    public partial class frmIzvestaj : Form
    {
        public frmIzvestaj()
        {
            InitializeComponent();
        }

        private void frmIzvestaj_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIzvestaj_Click(object sender, EventArgs e)
        {
            DateTime pocetniDatum = pocetniDatumPicker.Value;
            DateTime krajnjiDatum = krajnjiDatumPicker.Value;
            try
            {
                using (OleDbConnection conn = Baza.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT k.ime as Ime, k.prezime as Prezime, k.telefon as Telefon, v.naziv as [Naziv vozila],
                    r.datumVreme_pocetka as [Datum i vreme pocetka], r.datumVreme_kraja as [Datum i vreme kraja], r.cena as Cena
                    FROM (Klijent k INNER JOIN Rezervacija r 
                    ON k.id_klijenta = r.id_klijenta)
                    INNER JOIN Vozilo v
                    ON r.id_vozila=v.id_vozila
                    WHERE datumVreme_pocetka >= ? AND datumVreme_kraja <= ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", pocetniDatum);
                        cmd.Parameters.AddWithValue("?", krajnjiDatum);

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvIzvestaj.DataSource = table;
                    }
                    string queryKatRez = @"SELECT k.naziv AS Kategorija, COUNT(r.id_rezervacija) AS [Broj rezervacija]
                                               FROM (Rezervacija r INNER JOIN Vozilo v ON r.id_vozila = v.id_vozila)
                                               INNER JOIN Kategorija k ON v.id_kategorije = k.id_kategorije
                                               WHERE r.datumVreme_pocetka >= ? AND r.datumVreme_kraja <= ?
                                               GROUP BY k.naziv";
                    chart1.Series.Clear();
                    chart1.Series.Add("Rezervacije");
                    chart1.Series["Rezervacije"].ChartType = SeriesChartType.Column;
                    using (OleDbCommand cmd = new OleDbCommand(queryKatRez, conn))
                    {
                        cmd.Parameters.Add("?", OleDbType.Date).Value = pocetniDatum;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = krajnjiDatum;
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            chart1.Series["Rezervacije"].Points.Clear();
                            while (reader.Read())
                            {
                                string kategorija = reader["Kategorija"].ToString();
                                int broj = Convert.ToInt32(reader["Broj rezervacija"]);
                                chart1.Series["Rezervacije"].Points.AddXY(kategorija, broj);//po x osi kategorije po y osi broj rezervacija za tu kat
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
        }
    }
}
