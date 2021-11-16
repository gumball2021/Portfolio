using System;
using System.Collections.Generic;
using System.Text;

namespace SistemCadastro.Infraestrutura.Contextos.Estoque.QueryAjuda
{
   public static class EstoqueQueryAjuda
    {
        public static string ListarTodos()
        {
            var query = new StringBuilder();
            query.AppendLine("SELECT Id, Quantidade, Status, DataCadastro, EstaAtivo");
            query.AppendLine("FROM dbo.Estoque");

            return query.ToString();
        }

    }
}
