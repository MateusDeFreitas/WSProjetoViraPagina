using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_ViraPagina.DAO
{
    class ConexaoDAO
    {
        private string connectionString = "Server=localhost;Database=bd_virapagina;User=root;Password=;";

        public void ConnectToDatabase()
        {
            // Criação da conexão
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Abrindo a conexão com o banco de dados
                    connection.Open();
                    Console.WriteLine("Conexão bem-sucedida com o banco de dados!");

                    // Aqui você pode executar comandos SQL, como SELECT, INSERT, UPDATE, DELETE
                    // Exemplo: Consultar dados
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
                }
            }
        }
    }
}
