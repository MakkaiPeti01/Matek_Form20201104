using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Matek_Form20201104
{
    public partial class foForm : Form
    {
        private List<int> lista = new List<int>();
        public foForm()
        {
            InitializeComponent();
            try
            {
                StreamReader olvas = new StreamReader("adatok.txt");
                while (!olvas.EndOfStream)
                {
                    lista.Add(int.Parse(olvas.ReadLine()));
                }
                    olvas.Close();
                lblStatus.Text = "Nem volt hiba a beolvasásban";               
            }
            catch (Exception e)
            {
                lblStatus.Text = "Volt hiba a beolvasásban, a hibás adatot figyelmen kívül hagytam";
            }       
        }

        private void btnAtlag_Click(object sender, EventArgs e)
        {
            double atlag = 0;
            int sum = 0;
            foreach (var i in lista)
            {
                sum = sum + i;
            }
            atlag = sum / lista.Count;
            lbEredmenyek.Items.Add(atlag);
            btnAtlag.Enabled = false;
        }

        private void btnHanyadik_Click(object sender, EventArgs e)
        {
            int s = 1;
            while (s < lista.Count && lista[s] != 7143)
            {
                s++;
            }
            if (s <= lista.Count)
            {
                lbEredmenyek.Items.Add($"A keresett elem a {s} a listában");
            }
            btnHanyadik.Enabled = false;
        }

        private void btnHanyszor_Click(object sender, EventArgs e)
        {
            int db = 0;
            foreach (var i in lista)
            {
                if (i==1170)
                {
                    db++;
                }
            }
            lbEredmenyek.Items.Add($"Az 1170 ({db}) szer fordul elő a listában.");
            btnHanyszor.Enabled = false;
        }

        private void btnVanE_Click(object sender, EventArgs e)
        {
            bool benne = false;
            foreach (var i in lista)
            {
                if (i==8876)
                {
                    benne = true;
                }
            }
            if (benne)
            {
                lbEredmenyek.Items.Add($"Van benne");
            }
            else
            {
                lbEredmenyek.Items.Add($"Nincs benne");
            }
            btnVanE.Enabled = false;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int min = lista[0];
            foreach (var i in lista)
            {
                if (min > i)
                {
                    min = i;
                }
            }
            lbEredmenyek.Items.Add($"A listában a minimum: {min}");
            btnMin.Enabled = false;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            int max = lista[0];
            foreach (var i in lista)
            {
                if (max < i)
                {
                    max = i;
                }
            }
            lbEredmenyek.Items.Add($"A listában a minimum: {max}");
            btnMax.Enabled = false;
        }
    }
}
