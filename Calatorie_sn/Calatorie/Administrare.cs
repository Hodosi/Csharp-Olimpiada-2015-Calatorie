using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Calatorie
{
    public partial class Administrare : Form
    {
        public Administrare()
        {
            InitializeComponent();
        }
        CONNECTION conn = new CONNECTION();
        DISTANTA DISTANTA = new DISTANTA();
        USERS USER = new USERS();
        PORTURI PORT = new PORTURI();
        string[] numeDestinatii = { "Constanta", "Varna", "Burgas", "Istambul", "Kozlu", "Samsun", "Batumi", "Sokhumi", "Soci", "Anapa", "Yalta", "Sevastopol", "Odessa" };
        List<int> coordonate = new List<int>();

        private void Administrare_Load(object sender, EventArgs e)
        {
            PORT.deletePorturi();
            this.pictureBox1.Enabled = false;
            string fn = Application.StartupPath + @"\Resurse_C#\MareaNeagra.jpg";
            this.pictureBox1.Image = Image.FromFile(fn);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            coordonate.Add(x);
            coordonate.Add(y);

            //for(int i=0;i<26;i++)
            //{
            //    MessageBox.Show( coordonate[i].ToString());
            //}
        }

        private void button_Save_Cord_Click(object sender, EventArgs e)
        {
            PORT.deletePorturi();
            int coord_index = 0;
            for (int i = 0; i < 13; i++)
            {
                PORT.insertPort(numeDestinatii[i], coordonate[coord_index], coordonate[coord_index + 1]);
                coord_index += 2;
            }
        }

        private void button_Init_Cord_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Enabled = true;
        }

        private void button_Actualizare_Cord_Click(object sender, EventArgs e)
        {
            DISTANTA.deleteData();
            populateDistante();
        }

        public void populateDistante()
        {
            //string[] numeDestinatii = { "Constanta", "Varna", "Burgas", "Istambul", "Kozlu", "Samsun", "Batumi", "Sokhumi", "Soci", "Anapa", "Yalta", "Sevastopol", "Odessa" };

            string path = Application.StartupPath + @"\Resurse_C#\Harta_Distantelor.txt";
            StreamReader sr = new StreamReader(path);

            for (int i = 0; i < 13; i++)
            {
                string distante = sr.ReadLine();
                string[] distanta = distante.Split();
                for (int j = 0; j < 13; j++)
                {
                    DISTANTA.insertData(i + 1, j + 1, numeDestinatii[j], Convert.ToInt32(distanta[j]));
                }
            }
        }

        private void button_Generare_Click(object sender, EventArgs e)
        {
            // ------------------ tip = 3; ---------------------------
            string lista_porturi = "";
            string nm = "";
            for (int i = 2; i <=11; i++)
            {
                lista_porturi = "Constanta,";
                int dist = DISTANTA.getDist(1,i); ;
                nm = DISTANTA.getNume(1, i);
                lista_porturi = lista_porturi+ nm + ",";
                for (int j = i + 1; j <= i + 2; j++)
                {
                    dist += DISTANTA.getDist(j - 1, j);
                    nm = DISTANTA.getNume(j - 1, j);
                    lista_porturi = lista_porturi + nm + ",";
                }
                if(dist >= 800 && dist <= 1100)
                {
                    lista_porturi += "Constanta";
                    int pret = dist * 2;
                    //insert croaziere
                }
            }
        }
    }
}
