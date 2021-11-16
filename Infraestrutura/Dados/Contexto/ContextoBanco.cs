using Dados.Contexto;
using SistemCadastro.Compartilhado.Configuracoes;
using System.Data.SqlClient;

namespace SistemCadastro.Infraestrutura.Dados.Contexto
{
    public class ContextoBanco : IContextoBanco// IDisposable
    {
       
        public SqlConnection Conexao { get; set; }
               
        public void Conectar()
        {
            try
            {
                Conexao = new SqlConnection();
                Conexao.ConnectionString = ConfiguracaoDaAplicacao.StringDeConexaoBancoSqlServer;
                Conexao.Open();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public void Desconectar()
        {
            Conexao.Close();
        }
        //public void Dispose()
        //{
        //    Desconectar();
            //Conexao.Dispose();
        //}
    }
}
