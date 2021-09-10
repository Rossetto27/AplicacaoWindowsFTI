using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBAlunosForms
{
    public partial class CadastroAluno : Form
    {
        //Form1 form1 = new Form1();
        SqlConnection cnn = new SqlConnection();
        Aluno aluno = new Aluno();
        int matricula = 0;
        int idcurso = 0;
        public CadastroAluno()
        {
            InitializeComponent();
        }
        public void setConnection(SqlConnection cnn)
        {
            this.cnn = cnn;
        }
        private void VerificarBotao()
        {
            if (textBoxMatricula.Text != "" &&
                textBoxNome.Text != "" &&
                textBoxCPF.Text != "" &&
                textBoxCurso.Text != "")
            {
                btCadastroAluno.Enabled = true;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            VerificarBotao();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            VerificarBotao();
        }

        private void textBoxCPF_TextChanged(object sender, EventArgs e)
        {
            VerificarBotao();
        }

        private void textBoxCurso_TextChanged(object sender, EventArgs e)
        {
            VerificarBotao();
        }

        private void btCadastroAluno_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBoxMatricula.Text, out matricula ) && int.TryParse(textBoxCurso.Text, out idcurso))
            {
                aluno.SetMatricula(int.Parse(textBoxMatricula.Text));
                aluno.SetNome(textBoxNome.Text);
                aluno.SetCpf(textBoxCPF.Text);
                aluno.SetCidade(textBoxCidade.Text);
                aluno.SetUf(textBoxUF.Text);
                aluno.SetEmail(textBoxEMAIL.Text);
                aluno.SetFone(textBoxFone.Text);
                aluno.SetIdcurso(int.Parse(textBoxCurso.Text));

                aluno.Inserir(cnn);

                textBoxMatricula.Text = "";
                textBoxNome.Text="";
                textBoxCPF.Text="";
                textBoxCidade.Text="";
                textBoxUF.Text="";
                textBoxEMAIL.Text="";
                textBoxFone.Text="";
                textBoxCurso.Text="";
            }
            else
            {
                MessageBox.Show("Matricula ou ID de curso invalidos");
            }
        }

        private void CadastroAluno_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form1.instance.PreencherGrid();
        }
    }
}
