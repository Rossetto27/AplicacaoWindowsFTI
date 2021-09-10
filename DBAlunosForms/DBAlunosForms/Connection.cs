using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DBAlunosForms
{
    class Connection
    {
        string ConnectionString = "Data Source=DESKTOP-Q8OO5QQ;Initial Catalog=DataBaseAlunos;Integrated Security=SSPI";

        SqlConnection cnn;

        public SqlConnection Conectar()
        {

            try
            {
                cnn = new SqlConnection(ConnectionString);
                cnn.Open();

                Console.WriteLine("Conexão bem sucedida");

            }
            catch (SqlException erro)
            {
                Console.WriteLine($"Erro ao conectar com o Banco de dados: {erro}");
            }


            return cnn;

        }

    }
}
