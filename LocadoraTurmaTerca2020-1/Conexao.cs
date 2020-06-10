using System.Data.SqlClient; // adicionadas dependências relacionadas ao SQL

namespace LocadoraTurmaTerca2020_1
{
    public class Conexao
    {
        // Criando o método que proverá uma conexão com a base de dados
        public static SqlConnection GetConnection()
        {
            // retornando a conexão criada
            // passando como parâmetro a string de conexão do banco
            return new SqlConnection(
                @"Data Source=.\SQLEXPRESS;Initial Catalog=DB_RENTALCAR_terca;Integrated Security=True;Pooling=False");
        }
    }
}