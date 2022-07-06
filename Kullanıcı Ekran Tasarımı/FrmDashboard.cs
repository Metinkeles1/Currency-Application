using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace Kullanıcı_Ekran_Tasarımı
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VQIFM1S;Initial Catalog=Doviz;Integrated Security=True");
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            string bugün = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugün);

            string dolarAlis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            LblDolarAlış.Text = dolarAlis;

            string dolarSatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            LblDolarSatış.Text = dolarSatis;

            string euroAlis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            LblEuroAlış.Text = euroAlis;

            string euroSatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            LblEuroSatış.Text = euroSatis;


            baglanti.Open();
            SqlCommand komut = new SqlCommand("select SUM(DolarAl) - SUM(DolarSat) from Tbl_Kur", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblKasadakiDolar.Text = dr[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT Sum(EuroAl) - SUM(EuroSat) FROM Tbl_Kur", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblKasadakiEuro.Text = dr2[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("SELECT Sum(Kasa) FROM Tbl_Kur", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblKasadakiTl.Text = dr3[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count(ID) from tbl_kur ", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblYapılanİslem.Text = dr4[0].ToString();
            }
            baglanti.Close();

        }
    }
}
