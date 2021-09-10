
namespace DBAlunosForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btExcluirAluno = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btAlunoCadastro = new System.Windows.Forms.Button();
            this.btAlunoPesquisa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btCursoExcluir = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btPesquisaCurso = new System.Windows.Forms.Button();
            this.btAtualizarCurso = new System.Windows.Forms.Button();
            this.btAtualizarAlunos = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(537, 296);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btAtualizarAlunos);
            this.tabPage1.Controls.Add(this.btExcluirAluno);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.btAlunoCadastro);
            this.tabPage1.Controls.Add(this.btAlunoPesquisa);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(529, 268);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alunos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btExcluirAluno
            // 
            this.btExcluirAluno.Enabled = false;
            this.btExcluirAluno.Location = new System.Drawing.Point(87, 56);
            this.btExcluirAluno.Name = "btExcluirAluno";
            this.btExcluirAluno.Size = new System.Drawing.Size(75, 23);
            this.btExcluirAluno.TabIndex = 7;
            this.btExcluirAluno.Text = "Excluir";
            this.btExcluirAluno.UseVisualStyleBackColor = true;
            this.btExcluirAluno.Click += new System.EventHandler(this.btExcluirAluno_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 23);
            this.textBox2.TabIndex = 6;
            // 
            // btAlunoCadastro
            // 
            this.btAlunoCadastro.Location = new System.Drawing.Point(6, 56);
            this.btAlunoCadastro.Name = "btAlunoCadastro";
            this.btAlunoCadastro.Size = new System.Drawing.Size(75, 23);
            this.btAlunoCadastro.TabIndex = 5;
            this.btAlunoCadastro.Text = "Cadastrar";
            this.btAlunoCadastro.UseVisualStyleBackColor = true;
            this.btAlunoCadastro.Click += new System.EventHandler(this.btAlunoCadastro_Click);
            // 
            // btAlunoPesquisa
            // 
            this.btAlunoPesquisa.Enabled = false;
            this.btAlunoPesquisa.Location = new System.Drawing.Point(407, 27);
            this.btAlunoPesquisa.Name = "btAlunoPesquisa";
            this.btAlunoPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btAlunoPesquisa.TabIndex = 4;
            this.btAlunoPesquisa.Text = "Pesquisar";
            this.btAlunoPesquisa.UseVisualStyleBackColor = true;
            this.btAlunoPesquisa.Click += new System.EventHandler(this.btAlunoPesquisa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(112, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aluno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matricula";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(517, 177);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btAtualizarCurso);
            this.tabPage2.Controls.Add(this.btCursoExcluir);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btPesquisaCurso);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(529, 268);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cursos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btCursoExcluir
            // 
            this.btCursoExcluir.Enabled = false;
            this.btCursoExcluir.Location = new System.Drawing.Point(87, 56);
            this.btCursoExcluir.Name = "btCursoExcluir";
            this.btCursoExcluir.Size = new System.Drawing.Size(75, 23);
            this.btCursoExcluir.TabIndex = 7;
            this.btCursoExcluir.Text = "Excluir";
            this.btCursoExcluir.UseVisualStyleBackColor = true;
            this.btCursoExcluir.Click += new System.EventHandler(this.btCursoExcluir_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 85);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(517, 177);
            this.dataGridView2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(112, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome do Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Curso";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(112, 27);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(263, 23);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 27);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btPesquisaCurso
            // 
            this.btPesquisaCurso.Enabled = false;
            this.btPesquisaCurso.Location = new System.Drawing.Point(407, 27);
            this.btPesquisaCurso.Name = "btPesquisaCurso";
            this.btPesquisaCurso.Size = new System.Drawing.Size(75, 23);
            this.btPesquisaCurso.TabIndex = 0;
            this.btPesquisaCurso.Text = "Pesquisar";
            this.btPesquisaCurso.UseVisualStyleBackColor = true;
            this.btPesquisaCurso.Click += new System.EventHandler(this.btPesquisaCurso_Click);
            // 
            // btAtualizarCurso
            // 
            this.btAtualizarCurso.Location = new System.Drawing.Point(168, 56);
            this.btAtualizarCurso.Name = "btAtualizarCurso";
            this.btAtualizarCurso.Size = new System.Drawing.Size(75, 23);
            this.btAtualizarCurso.TabIndex = 8;
            this.btAtualizarCurso.Text = "Atualizar";
            this.btAtualizarCurso.UseVisualStyleBackColor = true;
            this.btAtualizarCurso.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btAtualizarAlunos
            // 
            this.btAtualizarAlunos.Location = new System.Drawing.Point(168, 56);
            this.btAtualizarAlunos.Name = "btAtualizarAlunos";
            this.btAtualizarAlunos.Size = new System.Drawing.Size(75, 23);
            this.btAtualizarAlunos.TabIndex = 8;
            this.btAtualizarAlunos.Text = "Atualizar";
            this.btAtualizarAlunos.UseVisualStyleBackColor = true;
            this.btAtualizarAlunos.Click += new System.EventHandler(this.btAtualizarAlunos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 320);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Data Base Alunos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btAlunoCadastro;
        private System.Windows.Forms.Button btAlunoPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btPesquisaCurso;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btExcluirAluno;
        private System.Windows.Forms.Button btCursoExcluir;
        private System.Windows.Forms.Button btAtualizarCurso;
        private System.Windows.Forms.Button btAtualizarAlunos;
    }
}

