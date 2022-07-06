using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;

namespace Kullanıcı_Ekran_Tasarımı
{
    public partial class FrmAnalytics : Form
    {
        public FrmAnalytics()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VQIFM1S;Initial Catalog=Doviz;Integrated Security=True");
        #region
        private void TxtDolarAlış_Enter(object sender, EventArgs e)
        {
            if (TxtDolarAlış.Text == "0")
            {
                TxtDolarAlış.Text = "";
            }
        }

        private void TxtDolarAlış_Leave(object sender, EventArgs e)
        {
            if (TxtDolarAlış.Text == "")
            {
                TxtDolarAlış.Text = "0";
            }
        }

        private void TxtDolarSatış_Enter(object sender, EventArgs e)
        {
            if (TxtDolarSatış.Text == "0")
            {
                TxtDolarSatış.Text = "";
            }
        }

        private void TxtDolarSatış_Leave(object sender, EventArgs e)
        {
            if (TxtDolarSatış.Text == "")
            {
                TxtDolarSatış.Text = "0";
            }
        }

        private void TxtEuroAlış_Enter(object sender, EventArgs e)
        {
            if (TxtEuroAlış.Text == "0")
            {
                TxtEuroAlış.Text = "";
            }
        }

        private void TxtEuroAlış_Leave(object sender, EventArgs e)
        {
            if (TxtEuroAlış.Text == "")
            {
                TxtEuroAlış.Text = "0";
            }
        }

        private void TxtEuroSatış_Enter(object sender, EventArgs e)
        {
            if (TxtEuroSatış.Text == "0")
            {
                TxtEuroSatış.Text = "";
            }
        }

        private void TxtEuroSatış_Leave(object sender, EventArgs e)
        {
            if (TxtEuroSatış.Text == "")
            {
                TxtEuroSatış.Text = "0";
            }
        }
        #endregion     
        void txtclear()
        {
            if (TxtDolarAlış.Text != "0")
            {
                TxtDolarAlış.Text = "0";
            }
            if (TxtDolarSatış.Text != "0")
            {
                TxtDolarSatış.Text = "0";
            }
            if (TxtEuroAlış.Text != "0")
            {
                TxtEuroAlış.Text = "0";
            }
            if (TxtEuroSatış.Text != "0")
            {
                TxtEuroSatış.Text = "0";
            }

        }

        public void xmlDosya()
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
        }

        private void FrmAnalytics_Load(object sender, EventArgs e)
        {
            xmlDosya();            
        }
           
        private void BtnDolarAlış_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Kur(dolaral) VALUES(@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", LblDolarSonuç.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İsleminiz gerçekleşmiştir.","Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnDolarSaıtış_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_kur(dolarsat) values(@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", LblDolarSonuç.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İsleminiz gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEuroAlış_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_kur(euroal) values(@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", LblEuroSonuç.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İsleminiz gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEuroSatış_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_kur(eurosat) values(@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", LblEuroSonuç.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İsleminiz gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void TxtDolarAlış_TextChanged(object sender, EventArgs e)
        {            
            if(TxtDolarAlış.Text != "")
            {
                double deger1 = Convert.ToDouble(TxtDolarAlış.Text);
                double deger2 = Convert.ToDouble(LblDolarAlış.Text);
                double sonuc = deger1 * deger2;
                LblDolarSonuç.Text = sonuc.ToString();                
            }            
        }

        private void TxtDolarSatış_TextChanged(object sender, EventArgs e)
        {
            if (TxtDolarSatış.Text != "")
            {
                double deger1 = Convert.ToDouble(TxtDolarSatış.Text);
                double deger2 = Convert.ToDouble(LblDolarSatış.Text);
                double sonuc = (deger1 * deger2);
                LblDolarSonuç.Text = sonuc.ToString();                
            }           
        }

        private void TxtEuroAlış_TextChanged(object sender, EventArgs e)
        {
            if (TxtEuroAlış.Text != "")
            {
                double deger1 = Convert.ToDouble(TxtEuroAlış.Text);
                double deger2 = Convert.ToDouble(LblEuroAlış.Text);
                double sonuc = deger1 * deger2;
                LblEuroSonuç.Text = sonuc.ToString();
            }           
        }

        private void TxtEuroSatış_TextChanged(object sender, EventArgs e)
        {
            if (TxtEuroSatış.Text != "")
            {
                double deger1 = Convert.ToDouble(TxtEuroSatış.Text);
                double deger2 = Convert.ToDouble(LblEuroSatış.Text);
                double sonuc = deger1 * deger2;
                LblEuroSonuç.Text = sonuc.ToString();                
            }           
        }

  
    }
}
