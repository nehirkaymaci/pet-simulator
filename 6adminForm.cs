using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evcil_hayvan_sahiplenme
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(classes.admin.petKayit);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            yetki yetkiFormu = new yetki();
            yetkiFormu.Show();
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var pet in classes.admin.petKayit)
            {
                listBox1.Items.Add($"Ad: {pet.ad} | Tür: {pet.tur} | Sahibi: {pet.sahip}");
            }
        }
    }
}
