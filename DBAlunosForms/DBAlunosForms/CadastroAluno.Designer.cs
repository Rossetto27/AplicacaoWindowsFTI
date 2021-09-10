
namespace DBAlunosForms
{
    partial class CadastroAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.textBoxEMAIL = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.textBoxFone = new System.Windows.Forms.TextBox();
            this.Cidade = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUF = new System.Windows.Forms.TextBox();
            this.textBoxCurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btCadastroAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefone";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(14, 97);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(28, 15);
            this.labelCPF.TabIndex = 1;
            this.labelCPF.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Matricula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail";
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(12, 27);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(100, 23);
            this.textBoxMatricula.TabIndex = 5;
            this.textBoxMatricula.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(12, 115);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(100, 23);
            this.textBoxCPF.TabIndex = 6;
            this.textBoxCPF.TextChanged += new System.EventHandler(this.textBoxCPF_TextChanged);
            // 
            // textBoxEMAIL
            // 
            this.textBoxEMAIL.Location = new System.Drawing.Point(12, 159);
            this.textBoxEMAIL.Name = "textBoxEMAIL";
            this.textBoxEMAIL.Size = new System.Drawing.Size(100, 23);
            this.textBoxEMAIL.TabIndex = 7;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 71);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 23);
            this.textBoxNome.TabIndex = 8;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(143, 71);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(100, 23);
            this.textBoxCidade.TabIndex = 9;
            // 
            // textBoxFone
            // 
            this.textBoxFone.Location = new System.Drawing.Point(143, 27);
            this.textBoxFone.Name = "textBoxFone";
            this.textBoxFone.Size = new System.Drawing.Size(100, 23);
            this.textBoxFone.TabIndex = 11;
            // 
            // Cidade
            // 
            this.Cidade.AutoSize = true;
            this.Cidade.Location = new System.Drawing.Point(143, 53);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(44, 15);
            this.Cidade.TabIndex = 12;
            this.Cidade.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "UF";
            // 
            // textBoxUF
            // 
            this.textBoxUF.Location = new System.Drawing.Point(143, 115);
            this.textBoxUF.Name = "textBoxUF";
            this.textBoxUF.Size = new System.Drawing.Size(100, 23);
            this.textBoxUF.TabIndex = 14;
            // 
            // textBoxCurso
            // 
            this.textBoxCurso.Location = new System.Drawing.Point(143, 159);
            this.textBoxCurso.Name = "textBoxCurso";
            this.textBoxCurso.Size = new System.Drawing.Size(100, 23);
            this.textBoxCurso.TabIndex = 15;
            this.textBoxCurso.TextChanged += new System.EventHandler(this.textBoxCurso_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID Curso";
            // 
            // btCadastroAluno
            // 
            this.btCadastroAluno.Enabled = false;
            this.btCadastroAluno.Location = new System.Drawing.Point(89, 219);
            this.btCadastroAluno.Name = "btCadastroAluno";
            this.btCadastroAluno.Size = new System.Drawing.Size(75, 23);
            this.btCadastroAluno.TabIndex = 17;
            this.btCadastroAluno.Text = "Cadastrar";
            this.btCadastroAluno.UseVisualStyleBackColor = true;
            this.btCadastroAluno.Click += new System.EventHandler(this.btCadastroAluno_Click);
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 254);
            this.Controls.Add(this.btCadastroAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCurso);
            this.Controls.Add(this.textBoxUF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cidade);
            this.Controls.Add(this.textBoxFone);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxEMAIL);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.textBoxMatricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CadastroAluno";
            this.Text = "Cadastro Aluno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroAluno_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.TextBox textBoxEMAIL;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.TextBox textBoxFone;
        private System.Windows.Forms.Label Cidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUF;
        private System.Windows.Forms.TextBox textBoxCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCadastroAluno;
    }
}