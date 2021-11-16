using System;
using System.Collections.Generic;
using System.Text;

namespace SistemCadastro.Infraestrutura.Contextos.Cargo.QueryAjuda
{
    public static class CargoQueryAjuda
    {
        public static string ListarTodos()
        {
            var query = new StringBuilder();
            query.AppendLine("SELECT Id, NomeCargo, DataCadastro, EstaAtivo");
            query.AppendLine("FROM dbo.Cargo");

                return query.ToString();
        }

    }
}
