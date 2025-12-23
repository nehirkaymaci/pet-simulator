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
    public partial class Form2 : Form
    {
        string petAdi;
        int yas = 0;
        classes.köpekclass kopek;
        public Form2(string gelenad)
        
        {
            InitializeComponent();
            petAdi = gelenad;
            kopek = new classes.köpekclass(petAdi);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = petAdi;
            timerkopek.Start();
            label6.Text = yas + " yasinda!";
            label7.Text = "Durum: " + kopek.DurumKontrol();
            

        }
        private void timerkopek_Tick(object sender, EventArgs e)
        {
            yas++;
            label6.Text = yas + "  yasinda!";

            if (aclik2.Value > 0)
            {
                aclik2.Value -= 1;
            }
            if (enerji2.Value > 0)
            {
                enerji2.Value -= 1;
            }
            if (mutluluk2.Value > 0)
            {
                mutluluk2.Value -= 1;
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mutluluk2.Value <= 90)
            {
                mutluluk2.Value += 10;
            }
            else
            {
                mutluluk2.Value = 100;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (enerji2.Value <= 95)
            {
                enerji2.Value += 5;
            }
            else
            {
                enerji2.Value = 100;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (aclik2.Value <= 92)
            {
                aclik2.Value += 8;
            }
            else
            {
                aclik2.Value = 100;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            yetki yetkiFormu = new yetki();
            yetkiFormu.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
