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

        //David (la base de datos fue creada por Juan)
        public Boolean checkUser(string DNI,string password)
        {
            try
            {
                _connection.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM usuarios where DNI = @DNI or Name =@DNI" , _connection);
                consulta.Parameters.AddWithValue("@DNI", DNI);
                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read()) 
                {
                    string _password = resultado.GetString("password");
                    if(BCrypt.Net.BCrypt.Verify(password, _password))
                    {
                        return true;
                    }
                }
                _connection.Close();
                return false;

            }
            catch (MySqlException e)
            {
                return false;
            }
        }
        public String newUser(string name, string DNI, string password)
        {
            try
            {
                _connection.Open();
                MySqlCommand consulta = new MySqlCommand
                    ("INSERT INTO `usuarios` (`DNI`, `Name`, `password`) VALUES('" +DNI+ "', '"+name+ "', '" + password + "')", _connection);
                consulta.Parameters.AddWithValue("@DNI", DNI);
                consulta.Parameters.AddWithValue("@Name", name);
                consulta.Parameters.AddWithValue("@password", password);
                consulta.ExecuteNonQuery();
                _connection.Close();
                return "La operacion se ha relaizado mde forma correcta";
                
            }
            catch (MySqlException e)
            {
                return "ERROR";
            }
        }

        //Juan
        public DataTable getPets()
        {
            try
            {
                _connection.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT NumeroHistorialClinico NHC, Nombre_Mascota 'Nombre Mascota', Nombre_Dueño 'Dueño', DNI_Dueño DNI ,ID_Mascota 'ID' FROM pacientes", _connection);
                MySqlDataReader result = consulta.ExecuteReader();
                DataTable pets = new DataTable();
                pets.Load(result);
                _connection.Close();
                return pets;
            }
            catch(MySqlException e)
            {
                throw e;
            }
        }
        public DataTable getAllPets(string nombre)
        {
            try
            {
                _connection.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM pacientes WHERE Nombre_Mascota like @nombre", _connection);
                consulta.Parameters.AddWithValue("@nombre", nombre);
                MySqlDataReader result = consulta.ExecuteReader();
                DataTable pets = new DataTable();
                pets.Load(result);
                _connection.Close();
                return pets;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        

    }
}
