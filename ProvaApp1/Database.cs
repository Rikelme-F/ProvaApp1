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
    }
}


