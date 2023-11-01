using RoniroSteam;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaCash
{
    internal class Cadcafe
    {
        public class Usuario
        {
            public int Id;
            public string nome;
            public string email;
            public string numerocell;
            public string senha;
            public Usuario(int id, string nome, string email, string numerocell, string senha)
            {
                Id = id;
                this.nome = nome;
                this.email = email;
                this.numerocell = numerocell;
                this.senha = senha;
            }
        }
        public class CadastroSteam
        {
            private string Nome;
            private string Email;
            private string Numero;
            private string Senha;

            public CadastroSteam(string nome, string email, string numeroCell, string senha)
            {
                Nome = nome;
                Email = email;
                Numero = numeroCell;
                Senha = senha;
            }

            public void Cadastrar()
            {
                Conecte conecte = new Conecte();
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = conecte.ReturnConnection();
                sqlCommand.CommandText = @"INSERT INTO Cadestro VALUES (@Nome, @Email, @Numero, @Senha)";

                sqlCommand.Parameters.AddWithValue("@Nome", Nome);
                sqlCommand.Parameters.AddWithValue("@Email", Email);
                sqlCommand.Parameters.AddWithValue("@Numero", Numero);
                sqlCommand.Parameters.AddWithValue("@Senha", Senha);

                if (IsValidPhoneNumber(Numero))
                {
                if (IsValidEmail(Email))
                {
                    if (string.IsNullOrWhiteSpace(Nome))
                    {
                        MessageBox.Show("Digite o Nome");
                        Nome = string.Empty;
                        if (string.IsNullOrWhiteSpace(Senha))
                        {
                            MessageBox.Show("Digite a senha");
                            Senha = string.Empty;
                        }
                    }
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Cadastrar com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                Nome = string.Empty;
                Email = string.Empty;
                Senha = string.Empty;
                Numero = string.Empty;
                Login Login = new Login();
                Login.Show();

                    }
                    else
                    {
                        MessageBox.Show("O endereço de E-mail é inválido");
                        Email = string.Empty;
                    }

                }
                else
                {
                    MessageBox.Show("O Numero de telefone é inválido");
                    Numero = string.Empty;
                }
            }

            private bool IsValidPhoneNumber(string telefone)
            {
                // Define a expressão regular para validar um número de telefone no formato (99) 99999-9999
                string pattern = @"^\(\d{2}\)\d{5}-\d{4}$";

                // Cria um objeto Regex com a expressão regular
                Regex regex = new Regex(pattern);

                // Usa o método Match para verificar se o telefone corresponde ao padrão
                return regex.IsMatch(telefone);
            }
            public void Atualizar(int id, string txt1, string txt2, string txtm, string txt4)
            {
                Conecte connection = new Conecte();
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = @"UPDATE CadastroSteam SET 
                Nome       = @Nome, 
                Email = @Email,
                NumeroCell        = @NumeroCell, 
                Senha  = @Senha 
                WHERE Id   = @id";

                sqlCommand.Parameters.AddWithValue("@Nome", txt1);
                sqlCommand.Parameters.AddWithValue("@Email", txt2);
                sqlCommand.Parameters.AddWithValue("@NumeroCell", txtm);
                sqlCommand.Parameters.AddWithValue("@Senha", txt4);
                sqlCommand.Parameters.AddWithValue("@id", id);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Editado com sucesso",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            public void Excluir(int id)
            {
                Conecte connection = new Conecte();
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = @"DELETE FROM CadastroSteam WHERE Id = @id";
                sqlCommand.Parameters.AddWithValue("@id", id);
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

            private bool IsValidEmail(string email)
            {
                // Define a expressão regular para validar um endereço de e-mail
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                // Cria um objeto Regex com a expressão regular
                Regex regex = new Regex(pattern);

                // Usa o método Match para verificar se o email corresponde ao padrão
                return regex.IsMatch(email);
            }
        }

    }
}
