using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using proyecto_refaccionaria.clases;

namespace proyecto_refaccionaria.BD
{
    public class basedatos
    {
      MySqlConnection Conexion;

        public bool Conectar()
        {
            bool conectado = true;
            Conexion = new MySqlConnection(
                "Server=localhost;" +
                "Database=refa;" +
                "Uid=root;" +
                "Pwd=;");
            try
            {
                Conexion.Open();
            }
            catch
            {
                conectado = false;
            }
            return conectado;
        }
        public bool ejecutarActualizacion(String SQL)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(SQL, Conexion);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Desconectar()
        {
            if (Conexion.State == System.Data.ConnectionState.Open)
            {
                Conexion.Close();
            }
        }

        /*public bool Guardarproducto(producto mproducto)
        {
            bool guardado = true;
            MySqlCommand mConsulta;
            string cadSQL = "insert into producto values (" +
                "\"" + mproducto.Nombre + "\"," +
                "\"" + mproducto.descripcion + "\"," +
                mproducto.tipo + "\"," +
                mproducto.precio + "\"," +
                "\"" + mproducto.marca + "\");";

            mConsulta = Conexion.CreateCommand();
            mConsulta.CommandText = cadSQL;

            try
            {
                mConsulta.ExecuteNonQuery();
            }
            catch
            {
                guardado = false;
            }

            return guardado;
        
            */
        public DataSet ejecutarConsulta(String SQL)
        {
            try
            
            {
                MySqlDataAdapter adaptador = new MySqlDataAdapter(SQL, Conexion);
                DataSet resultado = new DataSet();
                adaptador.Fill(resultado);
                return resultado;
            }
            catch
            {
                return null;
            }
        }

    }
}
