using MySql.Data.MySqlClient;

namespace funcionario
{
    internal class Cadastro
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Genero { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }

        public bool cadastrarFuncionarios()
        {
            try
            {
                string insert = $"insert into funcionarios (nome,email,cpf,genero,endereco)" +
                    $"values('{Nome}','{Email}','{Cpf}','{Genero}','{Endereco}')";

                SqlService(insert);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro no banco de dados no {ex.Message}");
                return false;
            }
        }

        public MySqlDataReader PesquisarFuncionario()
        {
            try
            { 
                string select = $"select id, nome, cpf, email, genero, endereco from funcionarios where cpf={Cpf} ";

                var comandoSql = SqlService(select);

                return comandoSql;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar no banco de dados {ex.Message}");
                return null;

            }

            
            
            }

            public bool AtualizarInformacoes()
            {
            try { 
                string update = $"update funcionarios set nome='{Nome}', email='{Email}', endereco='{Endereco}', genero = '{Genero}' where cpf='{Cpf}';";

                SqlService(update);

                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao conectar no banco de dados {ex.Message}");
                return false;
            }           
            }
        public bool DeletarFuncionario()
        {

            try
            {
                string delete = $"delete from funcionarios where cpf='{Cpf}';";

                SqlService(delete);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar usuario {ex.Message}");
                return false;
            }
        }

        private MySqlDataReader SqlService(string query)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(ConexaoBanco.conexaoServidor);
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlCommand.CommandText = query;
                mySqlCommand.ExecuteNonQuery();
                return mySqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
