using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Calatorie
{
    class PORTURI
    {
        CONNECTION conn = new CONNECTION();

        public void insertPort( string nm, int x, int y)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Porturi(Nume_Port,Pozitie_X,Pozitie_Y) VALUES(@nmp,@xp,@yp)";
            command.Connection = conn.GetConnection();
            //@idp,@nmp,@xp,@yp
           // command.Parameters.Add("idp", SqlDbType.Int).Value = idp;
            command.Parameters.Add("nmp", SqlDbType.VarChar).Value = nm;
            command.Parameters.Add("xp", SqlDbType.Int).Value = x;
            command.Parameters.Add("yp", SqlDbType.Int).Value = y;

            conn.openConnection();
            command.ExecuteNonQuery();
            conn.closeConnection();
        }

        public void deletePorturi()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM Porturi";
            command.Connection = conn.GetConnection();

            conn.openConnection();
            command.ExecuteNonQuery();
            conn.closeConnection();
        }
    }
}
