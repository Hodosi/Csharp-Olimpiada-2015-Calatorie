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
    public partial class ListaCroaziere : Form
    {
        public ListaCroaziere()
        {
            InitializeComponent();
        }

        CROAZIERA croaz = new CROAZIERA();
        private void ListaCroaziere_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = croaz.getCroaz(3);
        }

        private void comboBox_tipCroaz_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tip = Convert.ToInt32(this.comboBox_tipCroaz.SelectedItem.ToString());
            this.dataGridView1.DataSource = croaz.getCroaz(tip);
        }
    }
}
