using System;
using System.Collections.Generic;
using System.Text;

namespace SistemCadastro.Infraestrutura.Contextos.Funcionario.QueryAjuda
{
    public static class FuncionarioQueryAjuda
    {
        public static string ListarTodos()
        {
            var query = new StringBuilder();
            query.AppendLine("SELECT Id, NomeFuncionario, DataCadastro, EstaAtivo");
            query.AppendLine("FROM dbo.Funcionario");

            return query.ToString();
        }
    }
}
