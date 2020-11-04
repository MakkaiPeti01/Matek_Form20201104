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
        public List<int> lista = new List<int>();
        public foForm()
        {
            InitializeComponent();
            StreamReader olvas = new StreamReader("adatok.txt");
            while (!olvas.EndOfStream)
            {
                lista.Add(int.Parse(olvas.ReadLine()));
            }
            olvas.Close();
        }

        private void btnAtlag_Click(object sender, EventArgs e)
        {

        }
    }
}
