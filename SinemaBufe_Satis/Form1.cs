using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBufe_Satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutari = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet,toplam;
            misir = Convert.ToInt32(txtmisir.Text);
            su = Convert.ToInt32(txtsu.Text);
            cay = Convert.ToInt32(txtcay.Text);
            bilet = Convert.ToInt32(txtbilet.Text);

            toplam = misir * 40 + su * 5 + cay * 10 + bilet * 75;
            lbltoplam.Text= toplam.ToString()+"TL";

            kasatutari += toplam;
            lblkasa.Text=kasatutari.ToString()+"TL";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtmisir.Text = "";
            txtsu.Text = "";
            txtcay.Text = "";
            txtbilet.Text = "";
            txtmisir.Focus();
        }
    }
}
