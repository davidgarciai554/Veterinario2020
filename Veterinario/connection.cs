using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Veterinario
{
    class connection
    {
        public MySqlConnection _connection;

        public connection()
        {
            _connection = new MySqlConnection("Server = 127.0.0.1; Database = veterinario; Uid = root;Pwd=;Port=3306");
        }
        public Boolean checkUser(string name,string password)
        {
            try
            {
                _connection.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM usuarios where Name = '" + name + "' AND `password`=" + password, _connection);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable user = new DataTable();
                user.Load(resultado);
                if(user.Rows.Count > 0)
                {
                    return true;
                }
                consulta= new MySqlCommand("SELECT * FROM usuarios where DNI = '" + name + "' AND `password`=" + password, _connection);
                resultado = consulta.ExecuteReader();
                user = new DataTable();
                user.Load(resultado);
                if (user.Rows.Count > 0)
                {
                    return true;
                }
                _connection.Close();
                return false;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
    }
}
