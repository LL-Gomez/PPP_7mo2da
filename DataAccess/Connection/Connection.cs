using System.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Connection
{
    // Se crea la clase SQLHelper.
    public class SQLHelper
    {
        // Variable con la informacion para la conexion a base de datos.
        private readonly string Parameters = "" +
                    "server=DESKTOP-O9EPAM2;" +
                    "database=DB_EESTN2;" +
                    "Integrated Security=True;" +
                    "TrustServerCertificate=True;";
        // Objetos SQL.
        private SqlConnection ServerConnection;
        private SqlCommand Command;

        // Crea un objeto de tipo diccionario para los resultados
        public DataTable Results { get; set; }

        // Variable booleana que indica exito en la consulta.
        public bool Success { get; set; }

        // Funcion para cargar el procedimiento almacenado.
        public SQLHelper(string sp_name)
        {
            this.Results = new DataTable();
            this.Success = false;

            this.ServerConnection = new SqlConnection(this.Parameters);

            this.Command = new SqlCommand(sp_name, this.ServerConnection);
            this.Command.CommandType = System.Data.CommandType.StoredProcedure;
        }

        public void AddParameter(string name, object value)
        {
            Command.Parameters.AddWithValue(name, value ?? DBNull.Value);
        }

        public void Execute()
        {
            this.ServerConnection.Open();

            using (this.ServerConnection)
            {
                SqlDataReader reader = this.Command.ExecuteReader();
                try
                {
                    this.Results.Load(reader);
                    this.Success = true;
                }
                catch (Exception error)
                {

                }
                finally
                {
                    reader.Close();
                    this.ServerConnection.Close();
                }
            }
        }
    }
}