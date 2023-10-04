using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_SEMESTREprog
{
    internal class ClienteDAO
    {
     public void DeleteUser(string placa)
        {
            Conexao connection = new Conexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM cadastro WHERE Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", placa);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();

            }

        }

        public void AtualizarUser()
        {

        }





    }
}
