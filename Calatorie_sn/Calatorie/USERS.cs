using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Calatorie
{
    class USERS
    {
        CONNECTION conn = new CONNECTION();

        public bool existsUser(string name, string parola)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Users Where Nume=@nm and Parola=@parol";
            command.Connection = conn.GetConnection();
            //@nm,@parol
            command.Parameters.Add("nm", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("parol", SqlDbType.VarChar).Value = parola;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
