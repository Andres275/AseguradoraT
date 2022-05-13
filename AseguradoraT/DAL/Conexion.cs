using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AseguradoraT.DAL
{
    public class Conexion
    {
        private SqlConnection _oSqlConnection;
        private SqlCommand _oSqlCommand;
        public Conexion()
        {
            _oSqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Atlanticqi"].ConnectionString);
            _oSqlCommand = new SqlCommand();
        }
        public void Save(Models.Aseguradora oAseguradora)
        {
            _oSqlConnection.Open();
            _oSqlCommand = new SqlCommand("SPInsertprueba", _oSqlConnection);
            _oSqlCommand.CommandType = CommandType.StoredProcedure;
            _oSqlCommand.Parameters.AddWithValue("@ID", oAseguradora.Id);
            _oSqlCommand.Parameters.AddWithValue("@Primernombre", oAseguradora.Primernombre);
            _oSqlCommand.Parameters.AddWithValue("@Segundonombre", oAseguradora.Segundonombre);
            _oSqlCommand.Parameters.AddWithValue("@Primerapellido", oAseguradora.Primerapellido);
            _oSqlCommand.Parameters.AddWithValue("@Segundoapellido", oAseguradora.Segundoapellido);
            _oSqlCommand.Parameters.AddWithValue("@Telefono", oAseguradora.Telefono);
            _oSqlCommand.Parameters.AddWithValue("@Email", oAseguradora.Email);
            _oSqlCommand.Parameters.AddWithValue("@Fnacimiento", oAseguradora.Fnacimiento);
            _oSqlCommand.Parameters.AddWithValue("@Estimado", oAseguradora.Moneda);
            _oSqlCommand.ExecuteNonQuery();
            _oSqlConnection.Close();
              

        }
        

        }
    }
