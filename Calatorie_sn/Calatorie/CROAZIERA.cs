using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Calatorie
{
    class CROAZIERA
    {
        CONNECTION conn = new CONNECTION();
        public void insertCroa(int id, int tip, string nume, int pret)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Croaziere(ID_Croaziere,Tip_Croaziere,Lista_Porturi,Pret) VALUES(@id,@tip,@lista,@pret)";
            command.Connection = conn.GetConnection();
            //@idp,@idpd,@nm,@dist
            //@tip,@lista,@pret
            command.Parameters.Add("id", SqlDbType.Int).Value = id;
            command.Parameters.Add("tip", SqlDbType.Int).Value = tip;
            command.Parameters.Add("lista", SqlDbType.VarChar).Value = nume;
            command.Parameters.Add("pret", SqlDbType.Int).Value = pret;

            conn.openConnection();
            command.ExecuteNonQuery();
            conn.closeConnection();
        }

        public void insertCroaDate(DateTime dstart, DateTime dstop,int idcr)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update Croaziere Set Data_Start=@dstart,Data_Stop=@dstop WHERE ID_Croaziere=@id";
            command.Connection = conn.GetConnection();
            //@idp,@idpd,@nm,@dist
            //@tip,@lista,@pret
            command.Parameters.Add("id", SqlDbType.Int).Value =idcr;
            command.Parameters.Add("dstart", SqlDbType.DateTime).Value = dstart;
            command.Parameters.Add("dstop", SqlDbType.DateTime).Value = dstop;

            conn.openConnection();
            command.ExecuteNonQuery();
            conn.closeConnection();
        }

        public void deleteData()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM Croaziere";
            command.Connection = conn.GetConnection();

            conn.openConnection();
            command.ExecuteNonQuery();
            conn.closeConnection();
        }

        public DataTable getCroaz(int tip)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT ID_Croaziere as ID,Lista_Porturi as Circuit,Data_Start,Data_Stop,Pret,Nr_Pasageri as Pasageri FROM Croaziere WHERE Tip_Croaziere=@tip";
            command.Connection = conn.GetConnection();
            //@idp,@idpd,@nm,@dist

            command.Parameters.Add("tip", SqlDbType.Int).Value = tip;
            //command.Parameters.Add("idpd", SqlDbType.Int).Value = idp_d;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
    }
}
