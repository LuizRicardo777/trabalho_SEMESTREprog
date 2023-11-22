using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_SEMESTREprog
{
    internal class UsuarioDAO
    {
        public void SalvarUser(Usuario usuario)
        {
            Conexao connection = new Conexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO Usuario VALUES
            (@Nome, @Senha)";

            
            sqlCommand.Parameters.AddWithValue("@Nome", usuario.Nome);
            sqlCommand.Parameters.AddWithValue("@Senha", usuario.Senha);
          

            sqlCommand.ExecuteNonQuery();
        }
        public bool LoginUser(Usuario usuario)
        {
            Conexao connection = new Conexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"SELECT * FROM Usuario WHERE Nome = @Nome and Senha = @Senha";
            


            sqlCommand.Parameters.AddWithValue("@Nome", usuario.Nome);
            sqlCommand.Parameters.AddWithValue("@Senha", usuario.Senha);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;   
            }
        }

    }
}
