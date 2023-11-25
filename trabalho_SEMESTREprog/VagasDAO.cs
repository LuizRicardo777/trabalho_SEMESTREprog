using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_SEMESTREprog
{
    internal class VagasDAO
    {
        public void SalvarUser(Vagas vagas)
        {
            Conexao connection = new Conexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO Vagas VALUES
            (@Vaga, @Placa, @Status)";

            sqlCommand.Parameters.AddWithValue("@Vaga", vagas.Vaga);
            sqlCommand.Parameters.AddWithValue("@Placa", vagas.Placa);
            sqlCommand.Parameters.AddWithValue("@Status", vagas.Status);

            sqlCommand.ExecuteNonQuery();
        }

        public List<Vagas> SelectVagas()
        {


            Conexao conn = new Conexao();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT Vaga, Placa, Status FROM Vagas";

            List<Vagas> vagas = new List<Vagas>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    Vagas objet = new Vagas(
                     (string)dr["Vaga"],
                     (string)dr["Placa"],
                     (string)dr["Status"]);


                    vagas.Add(objet);



                }
                dr.Close();


            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return vagas;
        }


        public void AtualizarVagas(Vagas vagas)
        {
            Conexao connection = new Conexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE Vagas SET
                    Vaga = @Vaga,
                  Placa = @Placa,
                  Status =  @Status
                  WHERE Vaga = @Vaga";

            sqlCommand.Parameters.AddWithValue("@Vaga", vagas.Vaga);
            sqlCommand.Parameters.AddWithValue("@Placa", vagas.Placa);
            sqlCommand.Parameters.AddWithValue("@Status", vagas.Status);

            sqlCommand.ExecuteNonQuery();
        }

        public void DeleteVagas(string vaga)
        {
            Conexao connection = new Conexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM Vagas WHERE Vaga = @Vaga";
            sqlCommand.Parameters.AddWithValue("@Vaga", vaga);
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


    }
}
