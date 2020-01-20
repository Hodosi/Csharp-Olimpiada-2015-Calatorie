using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Calatorie
{
    class DISTANTA
    {
        CONNECTION conn = new CONNECTION();

        public void insertData(int id_p, int id_p_d, string nume, int dist)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Distante(ID_Port,ID_Port_Destinatie,Nume_Port_Destinatie,Distanta) VALUES(@idp,@idpd,@nm,@dist)";
            command.Connection = conn.GetConnection();
            //@idp,@idpd,@nm,@dist

            command.Parameters.Add("idp", SqlDbType.Int).Value = id_p;
            command.Parameters.Add("idpd", SqlDbType.Int).Value = id_p_d;
            command.Parameters.Add("nm", SqlDbType.VarChar).Value = nume;
            command.Parameters.Add("dist", SqlDbType.Int).Value = dist;

            conn.openConnection();
            command.ExecuteNonQuery();
            conn.closeConnection();
        }

        public void deleteData()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM Distante";
            command.Connection = conn.GetConnection();

            conn.openConnection();
            command.ExecuteNonQuery();
            conn.closeConnection();
        }

        public int getDist(int idp, int idp_d)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT Distanta FROM Distante WHERE ID_Port=@idp and ID_Port_Distanta=@idpd";
            command.Connection = conn.GetConnection();
            //@idp,@idpd,@nm,@dist

            command.Parameters.Add("idp", SqlDbType.Int).Value = idp;
            command.Parameters.Add("idpd", SqlDbType.Int).Value = idp_d;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return Convert.ToInt32(table.Rows[0][0].ToString());
        }
        public string getNume(int idp, int idp_d)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT Nume_Port_Destinatie FROM Distante WHERE ID_Port=@idp and ID_Port_Distanta=@idpd";
            command.Connection = conn.GetConnection();
            //@idp,@idpd,@nm,@dist

            command.Parameters.Add("idp", SqlDbType.Int).Value = idp;
            command.Parameters.Add("idpd", SqlDbType.Int).Value = idp_d;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table.Rows[0][0].ToString();
        }
    }
}
