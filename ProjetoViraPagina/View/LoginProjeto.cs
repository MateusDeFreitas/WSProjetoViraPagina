using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_ViraPagina.View
{
    public partial class LoginProjeto : Form
    {
        public LoginProjeto()
        {
            InitializeComponent();
            //string email = textEmail.Text;
            //string senha = textSenha.Text;
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bd_virapagina;Uid=root;Pwd=";

            string email = textEmail.Text;
            string senha = textSenha.Text;
            bool emailExistente = false;

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query1 = "SELECT COUNT(1) FROM Bibliotecario WHERE email = @email";
                    using (MySqlCommand cmd = new MySqlCommand(query1, con))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        emailExistente = (count > 0); // Se existir algum registro com esse email
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao verificar email: " + ex.Message);
                }

                if (emailExistente)
                {
                    string query = "SELECT senha FROM Bibliotecario WHERE email = @email";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@email", email);

                        // Obtém a senha armazenada no banco
                        object resultado = cmd.ExecuteScalar();
                        if (resultado != null)
                        {
                            string senhaArmazenada = resultado.ToString();
                            if (senha == senhaArmazenada)
                            {
                                Principal form = new Principal();
                                form.Show();
                                this.Hide();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Email inexixtente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void linkSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarSenha form = new RecuperarSenha();
            form.Show();
            this.Hide();
        }
    }
}


    
