using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program_yukleniyor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmryukleyici.Start();
        }

        private void tmryukleyici_Tick(object sender, EventArgs e)
        {
            Random rastgeleSayiOlusturucu = new Random();
            int artisOranı = rastgeleSayiOlusturucu.Next(1, 20);
            pbdurum.Step = artisOranı;
            int suAnkiDeger = pbdurum.Value;
            if(suAnkiDeger<=20)
            {
                lbldurum.Text = "Program yüklemeye hazırlanıyor.";
            }
            else if (suAnkiDeger <= 20 && suAnkiDeger <= 45)
            {
                lbldurum.Text = "güvenlik modülü yükleniyor.";
            }
            else if (suAnkiDeger <= 45 && suAnkiDeger <= 70 )
            {
                lbldurum.Text = "veritabanı modülü yükleniyor.";
            }
            else if (suAnkiDeger <= 70 && suAnkiDeger <= 95)
            {
                lbldurum.Text = "bellek optimizasyonu yapılıyor.";
            }
            else if (suAnkiDeger <= 95 && suAnkiDeger <= 100)
            {
                lbldurum.Text = "lazer klkanları devre dışı bırakılıyor.";
            }
            else 
            {
                tmryukleyici.Stop();
                btndevam.Enabled = true;
            }
        }

        private void btndevam_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
