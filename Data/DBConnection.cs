using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Activity5.Data
{
    public class DBConnection
    {
        // database details
        private static readonly string ConnString = "server=localhost; database=compstore; UID=root; password=M1styshaine!";
        // create an instance of MySqlConnection to open and close connections to the database
        private readonly MySqlConnection conn = new MySqlConnection(ConnString);

        public MySqlConnection ConnOpen()
        {
            // checks the connection state (if it is closed)
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            return conn;
        }

        public void ConnClose()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }
}