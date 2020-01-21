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
    public partial class MareaNeagra : Form
    {
        PORTURI port = new PORTURI();
        public MareaNeagra()
        {
            InitializeComponent();
            this.Paint += new System.Windows.Forms.PaintEventHandler(MareaNeagra_Paint);
        }

        private void MareaNeagra_Load(object sender, EventArgs e)
        {
            string fn = Application.StartupPath + @"\Resurse_C#\MareaNeagra.jpg";
            this.pictureBox1.Image = Image.FromFile(fn);
            //this.pictureBox1.Hide();
            //Graphics graphics;
            //graphics = this.pictureBox1.CreateGraphics();
            //Pen pen = new Pen(Color.Red);
            //pen.Width = 30;
            //graphics.DrawLine(pen, 100, 100, 200, 220);


        }

        private void button_Inchidere_Click(object sender, EventArgs e)
        {
            Autentificare fr = new Autentificare();
            fr.ShowDialog();

            this.Close();
        }

        private void MareaNeagra_Paint(object sender, PaintEventArgs e)
        {
            //DateTime dstart = this.dateTimePicker1.Value;
            //DateTime dstop = this.dateTimePicker2.Value;
            ////MessageBox.Show(dstart.ToString());
            ////int id = Convert.ToInt32(this.dataGridView1.SelectedRows.ToString());
            //int rowindex = this.dataGridView1.CurrentCell.RowIndex;
            ////MessageBox.Show(this.dataGridView1.Rows[rowindex].Cells[0].Value.ToString());
            //int id = Convert.ToInt32(this.dataGridView1.Rows[rowindex].Cells[0].Value.ToString());
            //croaz.insertCroaDate(dstart, dstop, id);
            // int id=Convert.ToInt32(turisti.textBox1.Text);
            //MessageBox.Show(id.ToString());

            Turisti turisti = new Turisti();
            Graphics graphics;
            graphics = this.pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            pen.Width = 10;

            string[] localitati = this.textBox2.Text.Split(',');
            int x1, x2, y1, y2;
            x1 = port.getXPozitii(localitati[0]);
            y1 = port.getYPozitii(localitati[0]);
            for(int i = 1; i < localitati.Length ; i++)
            {
                x2 = port.getXPozitii(localitati[i]);
                y2 = port.getYPozitii(localitati[i]);
                graphics.DrawLine(pen, x1, y1, x2, y2);

                x1 = x2;
                y1 = y2;
            }
        }
    }
}
