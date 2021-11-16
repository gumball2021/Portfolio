using System;
using System.Collections.Generic;
using System.Text;

namespace SistemCadastro.Infraestrutura.Contextos.TipoEquipamento.QueryAjuda
{
    public static class TipoEquipamentoQueryAjuda
    {                                              
        public static string ListarTodos()
        {
            var query = new StringBuilder();
            query.Append("SELECT Id, NomeTipo, DataCadastro, EstaAtivo ");
            query.Append("FROM dbo.TipoDeEquipamento ");

            return query.ToString();
        }
    }
}
