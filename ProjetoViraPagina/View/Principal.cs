using MySql.Data.MySqlClient;
using Projeto_ViraPagina.Model;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.StartPosition = FormStartPosition.CenterScreen;

            textPesquisa.PlaceholderText = "Pesquisar";
        }

        private void labelEmprestimo_Click(object sender, EventArgs e)
        {
            PrincipalEmprestimo form = new PrincipalEmprestimo();
            form.Show();
            this.Hide();
        }

        private void labelAcervos_Click(object sender, EventArgs e)
        {
            MenuAcervos form = new MenuAcervos();
            form.Show();
            this.Hide();
        }

        private void labelReservas_Click(object sender, EventArgs e)
        {
            PrincipalReserva form = new PrincipalReserva();
            form.Show();
            this.Hide();
        }

        private void labelPenalidades_Click(object sender, EventArgs e)
        {
            PrincipalPenalidade form = new PrincipalPenalidade();
            form.Show();
            this.Hide();
        }

        private void pictureBoxLupa_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bd_virapagina;Uid=root;Pwd=";

            string id = textPesquisa.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Tomadores WHERE id = @id";
                    Tomador tomador = new Tomador();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Se encontrou o registro
                            {
                                textNomeTomador.Text = "";
                                textEmail.Text = "";
                                textPenalidades.Text = "";
                                textPenalidades.Text = "";
                                textMatricula.Text = "";
                                textTelefone.Text = "";
                                textVinculo.Text = "";
                                textCodigo.Text = "";

                                tomador.Id = reader["id"].ToString();
                                tomador.Nome = reader["nome"].ToString();
                                tomador.Email = reader["id"].ToString();
                                tomador.NumeroDeLivrosEmprestados = Convert.ToInt32(reader["numeroDeLivrosEmprestados"].ToString());
                                tomador.NumeroDePenalidade = Convert.ToInt32(reader["numeroDePenalidade"].ToString());
                                tomador.ValidadeMatricula = reader["validadeMatricula"].ToString();
                                tomador.NumeroTelefone = reader["numeroTelefone"].ToString();
                                tomador.Vinculo = reader["vinculo"].ToString();

                                textNomeTomador.Text = tomador.Nome;
                                textEmail.Text = tomador.Email;
                                textLivrosEmprestados.Text = tomador.NumeroDeLivrosEmprestados.ToString();
                                textPenalidades.Text = tomador.NumeroDePenalidade.ToString();
                                textMatricula.Text = tomador.exibirValidadeMatricula(tomador.ValidadeMatricula);
                                textTelefone.Text = tomador.NumeroTelefone;
                                textVinculo.Text = tomador.Vinculo;
                                textCodigo.Text = tomador.Id;
                            }
                            else
                            {
                                MessageBox.Show("Tomador inexixtente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                textPesquisa.Text = "";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }

        }

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
