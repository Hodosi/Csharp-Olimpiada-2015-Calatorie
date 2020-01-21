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
    public partial class Turisti : Form
    {
        public Turisti()
        {
            InitializeComponent();
        }
        CROAZIERA croaz = new CROAZIERA();
        private void Turisti_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = croaz.getCroaz(3);
        }

        private void comboBox_tipCroaz_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tip = Convert.ToInt32(this.comboBox_tipCroaz.SelectedItem.ToString());
            this.dataGridView1.DataSource = croaz.getCroaz(tip);
        }

        private void button_Validare_Click(object sender, EventArgs e)
        {
            DateTime dstart = this.dateTimePicker1.Value;
            DateTime dstop = this.dateTimePicker2.Value;
            //MessageBox.Show(dstart.ToString());
            //int id = Convert.ToInt32(this.dataGridView1.SelectedRows.ToString());
            int rowindex = this.dataGridView1.CurrentCell.RowIndex;
            //MessageBox.Show(this.dataGridView1.Rows[rowindex].Cells[0].Value.ToString());
            int id = Convert.ToInt32(this.dataGridView1.Rows[rowindex].Cells[0].Value.ToString());
            croaz.insertCroaDate(dstart, dstop, id);
           // this.textBox1.Text = id.ToString();

            MareaNeagra mn = new MareaNeagra();
            mn.textBox1.Text = id.ToString();
            mn.textBox2.Text = this.dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            mn.ShowDialog();
            

            this.Close();
        }
    }
}
