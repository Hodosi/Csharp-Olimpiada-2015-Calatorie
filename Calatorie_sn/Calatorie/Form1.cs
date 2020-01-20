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
    public partial class Autentificare : Form
    {
        public Autentificare()
        {
            InitializeComponent();
        }

        CONNECTION conn = new CONNECTION();
        DISTANTA DISTANTA = new DISTANTA();
        USERS USER = new USERS();
        private void Autentificare_Load(object sender, EventArgs e)
        {
            DISTANTA.deleteData();
            populateDistante();
        }

        public void populateDistante()
        {
            string[] numeDestinatii = { "Constanta", "Varna", "Burgas", "Istambul", "Kozlu", "Samsun", "Batumi", "Sokhumi", "Soci", "Anapa", "Yalta", "Sevastopol", "Odessa" };

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

        private void button_log_Click(object sender, EventArgs e)
        {
            string nume = this.textBox_nume.Text;
            string parola = this.textBox_parola.Text;

            if (nume.Trim().Equals("") || parola.Trim().Equals(""))
            {
                MessageBox.Show("Empty Fields");
            }
            else
            {
                if (USER.existsUser(nume, parola))
                {
                    Operatii operatii = new Operatii();
                    if (nume == "Administrator")
                    {
                        operatii.toolStripButton_Turisti.Enabled = false;
                    }
                    else
                    {
                        operatii.toolStripButton_Administrare.Enabled = false;
                    }
                    //Operatii operatii = new Operatii();
                    operatii.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid User");
                }
            }
        }
    }
}
