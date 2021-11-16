using System;
using System.Collections.Generic;
using System.Text;

namespace SistemCadastro.Infraestrutura.Contextos.Departamento.QueryAjuda
{
    public static class DepartamentoQueryAjuda
    {
        public static string ListarTodos()
        {
            var query = new StringBuilder();
            query.AppendLine("SELECT Id, NomeDep, DataCadastro, EstaAtivo");
            query.AppendLine("FROM dbo.Departamento");

            return query.ToString();
        }
    }
}
