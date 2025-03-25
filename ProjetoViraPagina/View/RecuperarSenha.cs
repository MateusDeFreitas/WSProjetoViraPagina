using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_ViraPagina.View
{
    public partial class RecuperarSenha : Form
    {
        public RecuperarSenha()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LoginProjeto form = new LoginProjeto();
            form.Show();
            this.Hide();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bd_virapagina;Uid=root;Pwd=";
            string email = textEmail.Text;
            string novaSenha = textSenha.Text;
            string confirmacaoSenha = textConfirmacao.Text;
            // Validações básicas
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Por favor, informe o e-mail.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                MessageBox.Show("Por favor, informe a nova senha.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (novaSenha != confirmacaoSenha)
            {
                MessageBox.Show("As senhas não coincidem.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // Verificar se o e-mail existe
                    string queryVerificaEmail = "SELECT COUNT(1) FROM Bibliotecario WHERE email = @email";
                    bool emailExistente = false;
                    using (MySqlCommand cmd = new MySqlCommand(queryVerificaEmail, con))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        emailExistente = (count > 0);
                    }
                    if (!emailExistente)
                    {
                        MessageBox.Show("E-mail não cadastrado no sistema.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    // Atualizar a senha
                    string queryAtualizaSenha = "UPDATE Bibliotecario SET senha = @senha WHERE email = @email";
                    using (MySqlCommand cmd = new MySqlCommand(queryAtualizaSenha, con))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@senha", novaSenha);
                        int linhasAfetadas = cmd.ExecuteNonQuery();
                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Principal form = new Principal();
                            form.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível alterar a senha.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao alterar senha: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
