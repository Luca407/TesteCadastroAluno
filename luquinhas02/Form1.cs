using MySql.Data.MySqlClient;
using System.Data;

namespace luquinhas02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarAlunos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string telefone = txtTelefone.Text;
                string curso = txtCurso.Text;
                string nascimento = mtxtNascimento.Text;
                if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(telefone) || string.IsNullOrWhiteSpace(curso))
                {
                    MessageBox.Show("Preencha todos os campos.");
                    return;
                }
                else
                {
                    string conexaoBanco = "Server=localhost; Database=escola; Uid=root; Pwd=''";
                    MySqlConnection conexao = new MySqlConnection(conexaoBanco);
                    conexao.Open();

                    DateTime dataMysqlFormat = Convert.ToDateTime(nascimento);
                    string mtxtNascimentoFormatada = dataMysqlFormat.ToString("yyyy-MM-dd");

                    string cadastro = "INSERT INTO alunos (nome, telefone, curso, nascimento) VALUES (@nome, @telefone, @curso, @nascimento)";
                    MySqlCommand comando = new MySqlCommand(cadastro, conexao);
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@telefone", telefone);
                    comando.Parameters.AddWithValue("@curso", curso);
                    comando.Parameters.AddWithValue("@nascimento", mtxtNascimentoFormatada);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Aluno cadastrado com sucesso!");

                    txtNome.Clear();
                    txtTelefone.Clear();
                    txtCurso.Clear();
                    mtxtNascimento.Clear();


                }

                CarregarAlunos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar aluno: {ex.Message}");
            }
        }

        private void CarregarAlunos()
        {
            string conexaoBanco = "Server=localhost; Database=escola; Uid=root; Pwd=''";
            using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
            {
                conexao.Open();
                string query = "SELECT * FROM alunos";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAlunos.DataSource = dt;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um aluno para editar.");
                return;
            }

            int id = Convert.ToInt32(dgvAlunos.SelectedRows[0].Cells["id"].Value);
            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;
            string curso = txtCurso.Text;
            string nascimento = mtxtNascimento.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(telefone) || string.IsNullOrWhiteSpace(curso))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            try
            {
                string conexaoBanco = "Server=localhost; Database=escola; Uid=root; Pwd=''";
                using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                {
                    conexao.Open();
                    DateTime data = Convert.ToDateTime(nascimento);
                    string dataFormatada = data.ToString("yyyy-MM-dd");

                    string query = "UPDATE alunos SET nome=@nome, telefone=@telefone, curso=@curso, nascimento=@nascimento WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@telefone", telefone);
                    cmd.Parameters.AddWithValue("@curso", curso);
                    cmd.Parameters.AddWithValue("@nascimento", dataFormatada);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Aluno atualizado com sucesso!");
                CarregarAlunos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar aluno: {ex.Message}");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um aluno para excluir.");
                return;
            }

            int id = Convert.ToInt32(dgvAlunos.SelectedRows[0].Cells["id"].Value);

            DialogResult confirm = MessageBox.Show("Tem certeza que deseja excluir este aluno?", "Confirmação", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string conexaoBanco = "Server=localhost; Database=escola; Uid=root; Pwd=''";
                    using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                    {
                        conexao.Open();
                        string query = "DELETE FROM alunos WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conexao);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Aluno excluído com sucesso!");
                    CarregarAlunos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir aluno: {ex.Message}");
                }
            }
        }
    }
}
