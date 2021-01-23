using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int _soruNumarasi = 0;
        int _dogru = 0;
        int _yanlis = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = false;
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            SeceneklerGorunur();
            btnBasla.Enabled = false;
            _soruNumarasi++;
            lblSoruSayisi.Text = _soruNumarasi.ToString();
            if (_soruNumarasi == 1)
            {
                richTextBox1.Text = "Cumhuriyet hangi tarihte ilan edilmiştir?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                lblCevapDogru.Text = "1923";
            }

        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            SeceneklerGorunur();
            btnBasla.Enabled = false;
            pbxDogru.Visible = false;
            pbxYanlis.Visible = false;
            _soruNumarasi++;
            lblSoruSayisi.Text = _soruNumarasi.ToString();

            if (_soruNumarasi == 2)
            {
                richTextBox1.Text = "Aşağıdaki illerden hangisi Ege Bölgesinde yer almaz?";
                btnA.Text = "Balıkesir";
                btnB.Text = "Aydın";
                btnC.Text = "İzmir";
                btnD.Text = "Uşak";
                lblCevapDogru.Text = "Balıkesir";
            }

            if (_soruNumarasi == 3)
            {
                richTextBox1.Text = "Aşağıdaki kitap isimlerinden hangisi Dan Brown'a aittir?";
                btnA.Text = "Çalı Kuşu";
                btnB.Text = "Kaşağı";
                btnC.Text = "Melekler ve Şeytanlar";
                btnD.Text = "Aşk";
                lblCevapDogru.Text = "Melekler ve Şeytanlar";
                btnSonraki.Text = "Sonuçlar";
            }
            if (_soruNumarasi == 4)
            {
                _soruNumarasi--;
                lblSoruSayisi.Text = _soruNumarasi.ToString();
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                btnBasla.Enabled = false;
                MessageBox.Show("Toplam Soru Sayısı: " + _soruNumarasi + "\n" + "Doğru: " + _dogru + "\n" + "Yanlış: " + _yanlis);
            }
        }

        private void SeceneklerGorunur()
        {
            
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;
            
        }

        private void SeceneklerGorunmez()
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
        }

        private void Yanlis()
        {
            _yanlis++;
            lblYanlis.Text = _yanlis.ToString();
            pbxYanlis.Visible = true;
        }

        private void Dogru()
        {
            _dogru++;
            lblDogru.Text = _dogru.ToString();
            pbxDogru.Visible = true;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            lblCevap.Text = btnA.Text;

            if (lblCevap.Text == lblCevapDogru.Text)
            {
                Dogru();
            }
            else
            {
                Yanlis();
            }
            SeceneklerGorunmez();
            btnBasla.Enabled = false;

        }


        private void btnB_Click(object sender, EventArgs e)
        {
            lblCevap.Text = btnB.Text;

            if (lblCevap.Text == lblCevapDogru.Text)
            {
                Dogru();
            }
            else
            {
                Yanlis();
            }
            SeceneklerGorunmez();
            btnBasla.Enabled = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblCevap.Text = btnC.Text;

            if (lblCevap.Text == lblCevapDogru.Text)
            {
                Dogru();
            }
            else
            {
                Yanlis();
            }
            SeceneklerGorunmez();
            btnBasla.Enabled = false;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            lblCevap.Text = btnD.Text;

            if (lblCevap.Text == lblCevapDogru.Text)
            {
                Dogru();
            }
            else
            {
                Yanlis();
            }
            SeceneklerGorunmez();
            btnBasla.Enabled = false;
        }

        
    }
}
