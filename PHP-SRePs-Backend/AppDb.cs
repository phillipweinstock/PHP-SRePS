using System;
using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace PHP_SRePS_Backend
{
    public class AppDb :IDisposable
    {
        public readonly MySqlConnection Connection; 
        public AppDb()
        {
            Connection = new MySqlConnection("server=localhost;user=root;password=password;database=sales");
        }
        public void Dispose() {
            Connection.Close(); 
        }
    }
}
