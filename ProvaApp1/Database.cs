using MySql.Data.MySqlClient;
using ProvaApp1;
using System;

namespace ProvaApp1
{
    public static class Database
    {
        public static bool SalvarUsuario(Usuario usuario)
        {
            string connectionString = "Server=localhost;Port=3306;User Id=root;database=ti_113_windowsforms;";

            try
            {
               
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open(); 

                 
                    string query = "INSERT INTO Usuarios (Nome, Telefone) VALUES (@Nome, @Telefone)";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);

                    cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
                    cmd.Parameters.AddWithValue("@Telefone", usuario.Telefone);

                  
                    int quantidade = cmd.ExecuteNonQuery();
                    Console.WriteLine($"Linhas afetadas: {quantidade}");

               
                    return quantidade > 0;
                }
            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Erro no MySQL: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                return false;
            }

        }
        public static bool ExisteTelefone(string telefone)
        {
            string stringDeConexao = "Server=localhost;Port=3306;User Id=root;database=ti_113_windowsforms;";
            using (var connection = new MySqlConnection(stringDeConexao))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM usuarios WHERE telefone = @telefone";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@telefone", telefone);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }

}


