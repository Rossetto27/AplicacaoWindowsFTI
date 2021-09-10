using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBAlunosForms
{
    public partial class Form1 : Form
    {
        Aluno aluno = new Aluno();
        Curso curso = new Curso();
        Connection c = new Connection();
        
        CadastroAluno form2 = new CadastroAluno();
        CadastroCurso form3 = new CadastroCurso();
        string nome = "";
        SqlConnection cnn;
        DataTable TabAlunos = new DataTable();
        DataTable TabCursos = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }       
        private void btAlunoPesquisa_Click(object sender, EventArgs e)
        {
            aluno.SetMatricula(int.Parse(textBox1.Text));
            (TabAlunos, nome) = aluno.Pesquisar(cnn);

            dataGridView1.DataSource = TabAlunos;
            textBox2.Text = nome;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnn = c.Conectar();
            form2.setConnection(cnn);
            form3.setConnection(cnn);

            PreencherGrid();
        }
        public void PreencherGrid()
        {
            TabAlunos = aluno.Iniciar(cnn);
            dataGridView1.DataSource = TabAlunos;

            TabCursos = curso.Iniciar(cnn);
            dataGridView2.DataSource = TabCursos;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            cnn.Close();
        }

        private void btPesquisaCurso_Click(object sender, EventArgs e)
        {
            curso.SetIdcurso(int.Parse(textBox3.Text));
            (TabCursos, nome) = curso.Pesquisar(cnn);

            dataGridView2.DataSource = TabCursos;
            textBox4.Text = nome;
        }

        private void btExcluirAluno_Click(object sender, EventArgs e)
        {
            aluno.SetMatricula(int.Parse(textBox1.Text));
            aluno.Excluir(cnn);
            textBox1.Text = "";
            textBox2.Text = "";

            PreencherGrid();
        }

        private void btCursoExcluir_Click(object sender, EventArgs e)
        {
            curso.SetIdcurso(int.Parse(textBox3.Text));
            curso.Excluir(cnn);
            textBox3.Text = "";
            textBox4.Text = "";

            PreencherGrid();
        }

        private void btAlunoCadastro_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form3.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                btAlunoPesquisa.Enabled = true;
                btExcluirAluno.Enabled = true;
            }
            else
            {
                btAlunoPesquisa.Enabled = false;
                btExcluirAluno.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                btPesquisaCurso.Enabled = true;
                btCursoExcluir.Enabled = true;
            }
            else
            {
                btPesquisaCurso.Enabled = false;
                btCursoExcluir.Enabled = false;
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            PreencherGrid();
        }

        private void btAtualizarAlunos_Click(object sender, EventArgs e)
        {
            PreencherGrid();
        }
    }
}
