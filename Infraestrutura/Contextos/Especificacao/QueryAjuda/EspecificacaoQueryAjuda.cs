using System;
using System.Collections.Generic;
using System.Text;

namespace SistemCadastro.Infraestrutura.Contextos.Especificacao.QueryAjuda
{
    public static class EspecificacaoQueryAjuda
    {
        public static string ListarTodos()
        {
            var query = new StringBuilder();
            query.AppendLine("SELECT Id, Marca, Modelo, NumSerie, Observacao, DataCadastro, EstaAtivo");
            query.AppendLine("FROM dbo.Especificacao");

            return query.ToString();
        }
    }
}
