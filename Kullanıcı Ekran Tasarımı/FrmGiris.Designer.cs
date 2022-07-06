
namespace Kullanıcı_Ekran_Tasarımı
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnContactUs = new System.Windows.Forms.Button();
            this.BtnCalender = new System.Windows.Forms.Button();
            this.BtnAnalytics = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PnlFromLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.PnlNav);
            this.panel1.Controls.Add(this.BtnSettings);
            this.panel1.Controls.Add(this.BtnContactUs);
            this.panel1.Controls.Add(this.BtnCalender);
            this.panel1.Controls.Add(this.BtnAnalytics);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 533);
            this.panel1.TabIndex = 0;
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 175);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 100);
            this.PnlNav.TabIndex = 1;
            // 
            // BtnSettings
            // 
            this.BtnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnSettings.Image = ((System.Drawing.Image)(resources.GetObject("BtnSettings.Image")));
            this.BtnSettings.Location = new System.Drawing.Point(0, 491);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(217, 42);
            this.BtnSettings.TabIndex = 5;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            this.BtnSettings.Leave += new System.EventHandler(this.BtnSettings_Leave);
            // 
            // BtnContactUs
            // 
            this.BtnContactUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnContactUs.FlatAppearance.BorderSize = 0;
            this.BtnContactUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContactUs.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContactUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnContactUs.Image = ((System.Drawing.Image)(resources.GetObject("BtnContactUs.Image")));
            this.BtnContactUs.Location = new System.Drawing.Point(0, 259);
            this.BtnContactUs.Name = "BtnContactUs";
            this.BtnContactUs.Size = new System.Drawing.Size(217, 42);
            this.BtnContactUs.TabIndex = 4;
            this.BtnContactUs.Text = "Contact Us";
            this.BtnContactUs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnContactUs.UseVisualStyleBackColor = true;
            this.BtnContactUs.Click += new System.EventHandler(this.BtnContactUs_Click);
            this.BtnContactUs.Leave += new System.EventHandler(this.BtnContactUs_Leave);
            // 
            // BtnCalender
            // 
            this.BtnCalender.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCalender.FlatAppearance.BorderSize = 0;
            this.BtnCalender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalender.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnCalender.Image = ((System.Drawing.Image)(resources.GetObject("BtnCalender.Image")));
            this.BtnCalender.Location = new System.Drawing.Point(0, 217);
            this.BtnCalender.Name = "BtnCalender";
            this.BtnCalender.Size = new System.Drawing.Size(217, 42);
            this.BtnCalender.TabIndex = 3;
            this.BtnCalender.Text = "EURO - TL";
            this.BtnCalender.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnCalender.UseVisualStyleBackColor = true;
            this.BtnCalender.Click += new System.EventHandler(this.BtnCalender_Click);
            this.BtnCalender.Leave += new System.EventHandler(this.BtnCalender_Leave);
            // 
            // BtnAnalytics
            // 
            this.BtnAnalytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAnalytics.FlatAppearance.BorderSize = 0;
            this.BtnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnalytics.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnalytics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnAnalytics.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnalytics.Image")));
            this.BtnAnalytics.Location = new System.Drawing.Point(0, 175);
            this.BtnAnalytics.Name = "BtnAnalytics";
            this.BtnAnalytics.Size = new System.Drawing.Size(217, 42);
            this.BtnAnalytics.TabIndex = 2;
            this.BtnAnalytics.Text = "DOLAR - TL";
            this.BtnAnalytics.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAnalytics.UseVisualStyleBackColor = true;
            this.BtnAnalytics.Click += new System.EventHandler(this.BtnAnalytics_Click);
            this.BtnAnalytics.Leave += new System.EventHandler(this.BtnAnalytics_Leave);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("BtnDashboard.Image")));
            this.BtnDashboard.Location = new System.Drawing.Point(0, 133);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(217, 42);
            this.BtnDashboard.TabIndex = 1;
            this.BtnDashboard.Text = "Ana Menü";
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            this.BtnDashboard.Leave += new System.EventHandler(this.BtnDashboard_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 133);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(46, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Some User Text Here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(63, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.LblTitle.Location = new System.Drawing.Point(232, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(163, 32);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Dashboard";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBox1.Location = new System.Drawing.Point(764, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Search For Some Thing...";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1072, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PnlFromLoader
            // 
            this.PnlFromLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFromLoader.Location = new System.Drawing.Point(217, 56);
            this.PnlFromLoader.Name = "PnlFromLoader";
            this.PnlFromLoader.Size = new System.Drawing.Size(892, 477);
            this.PnlFromLoader.TabIndex = 4;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1109, 533);
            this.Controls.Add(this.PnlFromLoader);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnContactUs;
        private System.Windows.Forms.Button BtnCalender;
        private System.Windows.Forms.Button BtnAnalytics;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PnlFromLoader;
    }
}

