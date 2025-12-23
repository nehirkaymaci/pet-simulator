using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using classes;

namespace evcil_hayvan_sahiplenme
{
    public partial class giris : Form
    {
        private string _aktifyetki;
        public giris(string yetki)
        {
            InitializeComponent();
            _aktifyetki = yetki;
            this.Text = $"{yetki} girisi";
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }
        public giris()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi= textBox1.Text;
            string sifre= textBox2.Text;
            bool girisBasarili = false;
            if (kullaniciadi==null || sifre==null)
            {
                MessageBox.Show("Lutfen kullanici adi ve sifre giriniz.");
                return;
            }
            if(_aktifyetki == "Admin" && sifre=="1234")
            {
                girisBasarili = true;
            }
            else if (_aktifyetki == "Kullanici")
            {
                girisBasarili = true;
            }

            if(_aktifyetki == "Kullanici")
            {
                sahiplenme sahiplenmeForm= new sahiplenme(kullaniciadi);
                sahiplenmeForm.Show();
                this.Hide();
            }
            else if (_aktifyetki == "Admin")
            {
                MessageBox.Show("yönetici girisi basarili");
                adminForm adminEkrani = new adminForm();
                adminEkrani.Show();
                this.Hide();
                
            }
        }
    }
}
