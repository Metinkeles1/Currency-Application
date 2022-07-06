using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
//bu kütüphane menü içinde oluşturduğumuz çizginin tıklanan butonlar arasında yer değiştirmesini ayarlıyoruz.
using CircularProgressBar;
using System.Xml;

namespace Kullanıcı_Ekran_Tasarımı
{
    public partial class FrmGiris : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        bool dragging;
        Point offset;

        public FrmGiris()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);


            LblTitle.Text = "Ana Menü";
            this.PnlFromLoader.Controls.Clear();
            FrmDashboard frmDashboard_Vrb = new FrmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFromLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            LblTitle.Text = "Ana Menü";
            this.PnlFromLoader.Controls.Clear();
            FrmDashboard frmDashboard_Vrb = new FrmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFromLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void BtnAnalytics_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnAnalytics.Height;
            PnlNav.Top = BtnAnalytics.Top;
            BtnAnalytics.BackColor = Color.FromArgb(46, 51, 73);

            LblTitle.Text = "$ - ₺";
            this.PnlFromLoader.Controls.Clear();
            FrmAnalytics FrmAnalytics_Vrb = new FrmAnalytics() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmAnalytics_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFromLoader.Controls.Add(FrmAnalytics_Vrb);
            FrmAnalytics_Vrb.Show();
        }

        private void BtnCalender_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnCalender.Height;
            PnlNav.Top = BtnCalender.Top;
            BtnCalender.BackColor = Color.FromArgb(46, 51, 73);

            LblTitle.Text = "Calender";
            this.PnlFromLoader.Controls.Clear();
            FrmCalender FrmCalender_Vrb = new FrmCalender() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmCalender_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFromLoader.Controls.Add(FrmCalender_Vrb);
            FrmCalender_Vrb.Show();
        }

        private void BtnContactUs_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnContactUs.Height;
            PnlNav.Top = BtnContactUs.Top;
            BtnContactUs.BackColor = Color.FromArgb(46, 51, 73);

            LblTitle.Text = "Contact Us";
            this.PnlFromLoader.Controls.Clear();
            FrmContactUs frmContactUs_Vrb = new FrmContactUs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmContactUs_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFromLoader.Controls.Add(frmContactUs_Vrb);
            frmContactUs_Vrb.Show();

        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnSettings.Height;
            PnlNav.Top = BtnSettings.Top;
            BtnSettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnAnalytics_Leave(object sender, EventArgs e)
        {
            BtnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnCalender_Leave(object sender, EventArgs e)
        {
            BtnCalender.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnContactUs_Leave(object sender, EventArgs e)
        {
            BtnContactUs.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnSettings_Leave(object sender, EventArgs e)
        {
            BtnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Search For Some Thing...")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Search For Some Thing...";
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X,
                currentScreenPos.Y - offset.Y);
            }
        }
    }
}
