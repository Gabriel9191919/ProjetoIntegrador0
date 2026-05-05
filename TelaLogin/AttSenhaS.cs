using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin
{
    internal class AttSenhaS
    {

       
        // Método de exemplo para atualizar a senha
        public void AtualizarSenha(string usuario, string novaSenha)
        {
            conectar conectar = new conectar();
            MySqlConnection con = conectar.conectando();
            // A cláusula WHERE é vital, senão você muda a senha de TODOS os usuários do banco!
            string updateQuery = "UPDATE Login SET senha = @novaSenha WHERE usuario = @usuario";

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                using (MySqlCommand cmdUpdate = new MySqlCommand(updateQuery, con))
                {
                    // Adicionando os parâmetros com os novos valores
                    cmdUpdate.Parameters.AddWithValue("@novaSenha", novaSenha);
                    cmdUpdate.Parameters.AddWithValue("@usuario", usuario);

                    // ExecuteNonQuery é usado para INSERT, UPDATE e DELETE
                    int rowsAffected = cmdUpdate.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Senha atualizada com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado. Nenhuma alteração realizada.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar no banco: " + ex.Message);
            }
            finally
            {
                // Opcional: fechar a conexão se você não for usar mais
                // con.Close();
            }
        }
    }
}
