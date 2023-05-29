using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("Sehirler");
            checkedListBox1.Items.Add("Gidilen Sehirler");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
               string Sehir = txtEklenecekSehir.Text;

               foreach (var item in checkedListBox1.CheckedItems)
               {
                   string checkedItem = item.ToString();

                   if (checkedItem == "Sehirler")
                   {
                       listboxSehirler.Items.Add(Sehir);
                   }
                   else if (checkedItem == "Gidilen Sehirler")
                   {
                       listboxGSehir.Items.Add(Sehir);
                   }
               }

               txtEklenecekSehir.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string arananKelime = txtSehirAra.Text;

            int indeks = listboxSehirler.FindStringExact(arananKelime);

            if (indeks != ListBox.NoMatches)
            {
                listboxSehirler.SetSelected(indeks, true);
                MessageBox.Show("Kelime bulundu!");
            }
            else
            {
                MessageBox.Show("Kelime bulunamadı!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var item in listboxSehirler.Items)
            {
                listboxGSehir.Items.Add(item);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSehirSil_Click(object sender, EventArgs e)
        {
            string silinecekKelime = txtSehirSil.Text;

            listboxSehirler.Items.Remove(silinecekKelime);
        }

        private void txtSehirAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSolaAktar_Click(object sender, EventArgs e)
        {
            foreach (var item in listboxGSehir.Items)
            {
                listboxSehirler.Items.Add(item);
            }
        }
    }
}
