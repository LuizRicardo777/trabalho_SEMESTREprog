using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho_SEMESTREprog
{
    internal class ClienteDAO
    {


        public static bool IsCpf(string detectCpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            detectCpf = detectCpf.Trim();
            detectCpf = detectCpf.Replace(".", "").Replace("-", "");
            if (detectCpf.Length != 11)
                return false;
            tempCpf = detectCpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return detectCpf.EndsWith(digito);
        }


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

        public void AtualizarUser(Cliente cliente)
        {
            Conexao connection = new Conexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE cadastro SET
                    Id = @Id,
                  Cpf = @Cpf,
                  Carro =  @Carro,
                  Nome = @Nome
                  WHERE Id = @Id";

            sqlCommand.Parameters.AddWithValue("@Id", cliente.Id);
            sqlCommand.Parameters.AddWithValue("@Nome", cliente.Nome);
            sqlCommand.Parameters.AddWithValue("@Cpf", cliente.Cpf);
            sqlCommand.Parameters.AddWithValue("@Carro", cliente.Carro);

            sqlCommand.ExecuteNonQuery();
        }

        public void SalvarUser(Cliente cliente)
        {
            Conexao connection = new Conexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO cadastro VALUES
            (@Id, @Cpf, @Carro, @Nome)";

            sqlCommand.Parameters.AddWithValue("@Id", cliente.Id);
            sqlCommand.Parameters.AddWithValue("@Nome", cliente.Nome);
            sqlCommand.Parameters.AddWithValue("@Cpf", cliente.Cpf);
            sqlCommand.Parameters.AddWithValue("@Carro", cliente.Carro);

           


            if (IsCpf(cliente.Cpf)) { 
                sqlCommand.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("CPF Invalido");
            }
        }

        public List <Cliente> SelectUser()
        {
            

            Conexao conn = new Conexao();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT Id,Nome, Carro, Cpf FROM cadastro";

            List<Cliente> clientes = new List<Cliente>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    Cliente objeto = new Cliente(
                     (string)dr["Id"],
                     (string)dr["Nome"],
                     (string)dr["Cpf"],
                     (string)dr["Carro"]);

                    clientes.Add(objeto);



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
            return clientes;
        }
    }

 }

