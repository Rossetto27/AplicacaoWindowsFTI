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
    public partial class CadastroCurso : Form
    {
        //Form1 form1 = new Form1();
        Curso curso = new Curso();
        SqlConnection cnn = new SqlConnection();
        int idcurso = 0;
        public CadastroCurso()
        {
            InitializeComponent();
        }
        public void setConnection(SqlConnection cnn)
        {
            this.cnn = cnn;
        }
        private void VerificarBotao()
        {
            if (textBoxID.Text != "" &&
                textBoxValor.Text != "" &&
                textBoxDescricao.Text != "")
            {
                btCadastroCurso.Enabled = true;
            }
        }
        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            VerificarBotao();
        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {
            VerificarBotao();
        }

        private void textBoxDescricao_TextChanged(object sender, EventArgs e)
        {
            VerificarBotao();
        }

        private void btCadastroCurso_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxID.Text, out idcurso))
            {
                curso.SetIdcurso(int.Parse(textBoxID.Text));
                curso.SetDescricao(textBoxDescricao.Text);
                curso.SetValor(int.Parse(textBoxValor.Text));
                curso.SetPeriodo(int.Parse(textBoxPeriodo.Text));
                
                curso.Inserir(cnn);

                textBoxID.Text="";
                textBoxDescricao.Text="";
                textBoxValor.Text="";
                textBoxPeriodo.Text="";
            }
            else
            {
                MessageBox.Show("Matricula ou ID de curso invalidos");
            }
        }

        private void CadastroCurso_FormClosed(object sender, FormClosedEventArgs e)
        {
            //form1.PreencherGrid();
        }
    }
}
