using System;
using System.Collections.Generic;
using System.Text;

namespace SistemCadastro.Infraestrutura.Contextos.Equipamento.QueryAjuda
{
    public static class EquipamentoQueryAjuda
    {
        public static string ListarTodos()
        {
            var query = new StringBuilder();
            query.AppendLine("SELECT Id, NomeEquipamento, DataGarantia, DataCadastro, EstaAtivo, DataCompra");
            query.AppendLine("FROM dbo.Equipamento");

            return query.ToString();
        }
    }
}
