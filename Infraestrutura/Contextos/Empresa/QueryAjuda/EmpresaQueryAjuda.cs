using System;
using System.Collections.Generic;
using System.Text;

namespace SistemCadastro.Infraestrutura.Contextos.Empresa.QueryAjuda
{
   public static class EmpresaQueryAjuda
    {
        public static string ListarTodos()
        {
            var query = new StringBuilder();
            query.AppendLine("SELECT Id, NomeEmpresa, DataCadastro, EstaAtivo");
            query.AppendLine("FROM dbo.Empresa");
            return query.ToString();
        }
    }
}
