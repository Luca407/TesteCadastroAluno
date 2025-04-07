namespace luquinhas02
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtCurso = new TextBox();
            mtxtNascimento = new MaskedTextBox();
            groupBox1 = new GroupBox();
            btnListar = new Button();
            btnCadastrar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(5, 24);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(5, 66);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 1;
            label2.Text = "Nascimento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(5, 106);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 2;
            label3.Text = "Curso:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(5, 145);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 3;
            label4.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(70, 22);
            txtNome.MaxLength = 50;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(161, 23);
            txtNome.TabIndex = 4;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(88, 143);
            txtTelefone.MaxLength = 14;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(143, 23);
            txtTelefone.TabIndex = 6;
            // 
            // txtCurso
            // 
            txtCurso.Location = new Point(70, 104);
            txtCurso.MaxLength = 50;
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(161, 23);
            txtCurso.TabIndex = 7;
            // 
            // mtxtNascimento
            // 
            mtxtNascimento.Location = new Point(112, 64);
            mtxtNascimento.Mask = "00/00/0000";
            mtxtNascimento.Name = "mtxtNascimento";
            mtxtNascimento.Size = new Size(119, 23);
            mtxtNascimento.TabIndex = 8;
            mtxtNascimento.ValidatingType = typeof(DateTime);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(txtCurso);
            groupBox1.Controls.Add(mtxtNascimento);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(265, 192);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // btnListar
            // 
            btnListar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListar.Location = new Point(308, 109);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(107, 36);
            btnListar.TabIndex = 13;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(308, 36);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(107, 36);
            btnCadastrar.TabIndex = 15;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(463, 36);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(107, 36);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(463, 109);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(107, 36);
            btnExcluir.TabIndex = 17;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(63, 257);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(531, 241);
            dataGridView1.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 541);
            Controls.Add(dataGridView1);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnCadastrar);
            Controls.Add(btnListar);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtCurso;
        private MaskedTextBox mtxtNascimento;
        private GroupBox groupBox1;
        private Button btnListar;
        private Button btnCadastrar;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dataGridView1;
    }
}
