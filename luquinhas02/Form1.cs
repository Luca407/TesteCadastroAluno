using MySql.Data.MySqlClient;

namespace luquinhas02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
           

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar aluno: {ex.Message}");
            }
        }
    }
}
