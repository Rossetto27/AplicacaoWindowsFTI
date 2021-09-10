using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace DBAlunosForms
{
    class Aluno
    {        
        int matricula = 0;
        string nome = "";
        string cpf = "";
        string email = "";
        string telefone = "";
        string cidade = "";
        string uf = "";
        int idcurso = 0;

        public void SetMatricula(int matricula)
        {
            this.matricula = matricula;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public void SetFone(string fone)
        {
            this.telefone = fone;
        }
        public void SetCidade(string cidade)
        {
            this.cidade = cidade;
        }
        public void SetUf(string uf)
        {
            this.uf = uf;
        }
        public void SetIdcurso(int idcurso)
        {
            this.idcurso = idcurso;
        }

        public (DataTable,string) Pesquisar(SqlConnection cnn)
        {
            DataTable resultado = new DataTable();

            try
            {
                
                SqlCommand command = new SqlCommand($"SELECT * FROM ALUNO WHERE MATRICULA = {matricula}", cnn);

                SqlDataReader info = command.ExecuteReader();
                              

                resultado.Load(info);

                if (resultado.Rows.Count > 0)
                {
                    nome = resultado.Rows[0][1].ToString();
                }                  

                info.Close();
            }
            catch (SystemException ex)
            {
                System.Windows.Forms.MessageBox.Show($"An error occurred {ex}.");
                
            }

            return (resultado, nome);
        }
        public DataTable Iniciar(SqlConnection cnn)
        {
            DataTable resultado = new DataTable();

            try
            {

                SqlCommand command = new SqlCommand($"SELECT * FROM ALUNO", cnn);

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

                SqlCommand command = new SqlCommand("DELETE FROM ALUNO WHERE MATRICULA = " + matricula, cnn);

                int qtd = command.ExecuteNonQuery();


                if (qtd > 0)
                {
                    MessageBox.Show($"{qtd} itens exluidos \nMatricula '{matricula}' excluida com sucesso.");                                       
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

                SqlCommand verificar = new SqlCommand("SELECT * FROM ALUNO WHERE MATRICULA = " + matricula, cnn);

                SqlDataReader read = verificar.ExecuteReader();


                if (read.Read())
                {
                    MessageBox.Show($"Matricula '{matricula}' já existe.");                 
                    read.Close();
                }
                else
                {
                    read.Close();
                
                        SqlCommand command = new SqlCommand($"Insert into ALUNO values({matricula},'{nome}','{cpf}','{email}','{telefone}','{cidade}','{uf}',{idcurso});", cnn);

                        command.ExecuteNonQuery();

                        MessageBox.Show($"Matricula numero '{matricula}' adicionada com sucesso.");
                    
                }

            }
            catch (SystemException ex)
            {
                MessageBox.Show($"An error occurred {ex}.");
            }
        }
        
    }
}
