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
    public partial class yetki : Form
    {
        public yetki()
        {
            InitializeComponent();
        }

        private void yetki_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris girisForm = new giris("Kullanici");

            girisForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            giris girisForm = new giris("Admin");

           

            girisForm.Show();
            this.Hide();
        }
    }
}
