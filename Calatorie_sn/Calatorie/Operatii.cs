using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calatorie
{
    public partial class Operatii : Form
    {
        public Operatii()
        {
            InitializeComponent();
        }

        private void toolStripButton_Iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_Administrare_Click(object sender, EventArgs e)
        {
            Administrare administrare = new Administrare();
            administrare.ShowDialog();
        }

        private void Operatii_Load(object sender, EventArgs e)
        {

        }
    }
}
