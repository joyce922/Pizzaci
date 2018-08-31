using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBoxAdSoyad.Text = "";
            textBoxTelNo.Text = "";
            textBoxEposta.Text = "";
            textBoxAdres.Text = "";

            comboBoxBoyut.Text = "";
            comboBoxİçecek.Text = "";

            numericUpDownBoyut.Value = 0;
            numericUpDownİçecek.Value = 0;

            checkBoxSucuk.Checked = false;
            checkBoxSosis.Checked = false;
            checkBoxSalam.Checked = false;
            checkBoxMısır.Checked = false;
            checkBoxZeytin.Checked = false;
            checkBoxBiber.Checked = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal ucret = 0;
            string ekstra = "";
            string Sucuk = "";
            string Sosis = ""; 
            string Salam = ""; 
            string Mısır = ""; 
            string Zeytin = ""; 
            string Biber = "" ;
      
            if(checkBoxSucuk.Checked == true)
            {
                ekstra+="Sucuk";
            }
            if(checkBoxSosis.Checked == true)
            {
                ekstra+= "Sosis" + "-";
            }
            if(checkBoxSalam.Checked == true)
            {
                ekstra+= "-" +"Salam";
            }
            if(checkBoxMısır.Checked == true)
            {
                ekstra+= "-" + "Mısır";
            }
            if(checkBoxZeytin.Checked == true)
            {
                ekstra+= "-" + "Zeytin";
            }
            if(checkBoxBiber.Checked == true)
            {
                ekstra+= "-" + "Biber";
            }


            if(comboBoxBoyut.Text == "Küçük")
            {
                ucret = numericUpDownBoyut.Value * 10;
            }
            else if (comboBoxBoyut.Text == "Orta")
            {
                ucret = numericUpDownBoyut.Value * 15;
            }
            else if (comboBoxBoyut .Text == "Büyük")
            {
                ucret = numericUpDownBoyut.Value  *20;
            }

            if(comboBoxİçecek.Text == "Kola")
            {
                ucret += numericUpDownİçecek.Value  *5;
            }
            else if(comboBoxİçecek.Text == "Fanta")
            {
                ucret += numericUpDownİçecek.Value * 4;
            }
            else if(comboBoxİçecek.Text == "Ayran")
            {
                ucret += numericUpDownİçecek.Value * 2;
            }
            else if (comboBoxİçecek.Text == "Su")
            {
                ucret += numericUpDownİçecek.Value * 1;
            }


            listBoxAdSoyad.Items.Add (textBoxAdSoyad.Text);
            listBoxTelNo.Items.Add (textBoxTelNo.Text);
            listBoxAdres.Items.Add (textBoxAdres.Text);
            listBoxBoyutAdet.Items.Add (numericUpDownBoyut.Value + "adet" + comboBoxBoyut.Text);
            listBoxEkstra.Items.Add (ekstra);
            listBoxİçecekAdet.Items.Add (numericUpDownİçecek.Value + "adet" + comboBoxİçecek.Text);
            listBoxÜcret.Items.Add (ucret + "TL");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBoxAdSoyad.Items.Clear();
            listBoxTelNo.Items.Clear();
            listBoxAdres.Items.Clear();
            listBoxBoyutAdet.Items.Clear();
            listBoxEkstra.Items.Clear();
            listBoxİçecekAdet.Items.Clear();
            listBoxÜcret.Items.Clear();
        }

        private void listBoxAdres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
