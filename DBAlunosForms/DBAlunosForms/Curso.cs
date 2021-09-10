using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace DBAlunosForms
{
    class Curso
    {
        int idcurso = 0;
        string descricao = "";
        int periodo = 0;
        double valor = 0;

        public void SetIdcurso(int idcurso)
        {
            this.idcurso = idcurso;
        }
        public void SetDescricao(string descricao)
        {
            this.descricao = descricao;
        }
        public void SetPeriodo(int periodo)
        {
            this.periodo = periodo;
        }
        public void SetValor(double valor)
        {
            this.valor = valor;
        }
        public (DataTable, string) Pesquisar(SqlConnection cnn)
        {
            DataTable resultado = new DataTable();

            try
            {

                SqlCommand command = new SqlCommand($"SELECT * FROM CURSO WHERE IDCURSO = {idcurso}", cnn);

                SqlDataReader info = command.ExecuteReader();


                resultado.Load(info);

                if (resultado.Rows.Count > 0) 
                { 
                    descricao = resultado.Rows[0][1].ToString();
                }

                info.Close();
            }
            catch (SystemException ex)
            {
                System.Windows.Forms.MessageBox.Show($"An error occurred {ex}.");


            }

            return (resultado, descricao);
        }
        public DataTable Iniciar(SqlConnection cnn)
        {
            DataTable resultado = new DataTable();

            try
            {

                SqlCommand command = new SqlCommand($"SELECT * FROM CURSO", cnn);

                SqlDataReader info = command.ExecuteReader();


                resultado.Load(info);


                info.Close();
            }
            catch (SystemException ex)
            {
                System.Windows.Forms.MessageBox.Show($"An error occurred {ex}.");

            }

            return resultado;
        }
        public void Excluir(SqlConnection cnn)
        {
            try
            {

                SqlCommand command = new SqlCommand("DELETE FROM CURSO WHERE IDCURSO = " + idcurso, cnn);

                int qtd = command.ExecuteNonQuery();


                if (qtd > 0)
                {
                    MessageBox.Show($"{qtd} itens exluidos \nID Curso '{idcurso}' excluido com sucesso.");
                }
                else
                {
                    MessageBox.Show("Nenhum item encontrado");
                }

            }
            catch (SystemException ex)
            {
                MessageBox.Show($"An error occurred {ex}.");

            }

        }
        public void Inserir(SqlConnection cnn)
        {

            try
            {

                SqlCommand verificar = new SqlCommand("SELECT * FROM CURSO WHERE IDCURSO = " + idcurso, cnn);

                SqlDataReader read = verificar.ExecuteReader();


                if (read.Read())
                {
                    MessageBox.Show($"ID de curso '{idcurso}' já existe.");

                    read.Close();
                }
                else
                {
                    read.Close();

                    SqlCommand command = new SqlCommand($"Insert into CURSO values({idcurso},'{descricao}',{periodo},{valor});", cnn);

                    command.ExecuteNonQuery();

                    MessageBox.Show($"Curso numero '{idcurso}' adicionado com sucesso.");

                }

            }
            catch (SystemException ex)
            {
                MessageBox.Show($"An error occurred {ex}.");              
            }
        }
    }
}
