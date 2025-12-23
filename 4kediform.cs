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
    public partial class kediform : Form
    {

        string petAdi;
        int yas = 0;
        classes.kediclass kedy;

        public kediform(string gelenAd)
        {
            InitializeComponent();
            petAdi = gelenAd;
            kedy = new classes.kediclass(petAdi);
        }


        private void kediform_Load(object sender, EventArgs e)
        {
            label1.Text = petAdi;
            timerkedi.Start();
            label2.Text = yas + " yasinda!";
            label7.Text = "Durum: " + kedy.DurumKontrol();
        }

        private void timerkedi_Tick(object sender, EventArgs e)
        {
            yas++;
            label2.Text = yas + "  yasinda!";

            if (aclik.Value > 0)
            {
                aclik.Value -= 1;
            }
            if (enerji.Value > 0)
            {
                enerji.Value -= 1;
            }
            if (mutluluk.Value > 0)
            {
                mutluluk.Value -= 1;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mutluluk.Value <= 90)
            {
                mutluluk.Value += 10;
            }
            else
            {
                mutluluk.Value = 100;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (aclik.Value <= 92)
            {
                aclik.Value += 8;
            }
            else
            {
                aclik.Value = 100;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (enerji.Value <= 95)
            {
                enerji.Value += 5;
            }
            else
            {
                enerji.Value = 100;
            }

        }

        private void enerji_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            yetki yetkiFormu = new yetki(); 
            yetkiFormu.Show();
        }
    }
}
