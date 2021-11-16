using Dominio.Cargo;
using Dominio.Departamento;
using Dominio.Empresa;
using Dominio.Equipamento;
using Dominio.Especificacao;
using Dominio.Estoque;
using Dominio.Funcionario;
using Dominio.TipoEquipamento;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Dados.Contexto
{
    public class ContextoBanco : IContextoBanco, IDisposable

    {
        public SqlConnection Conexao { get; set; }

        public ContextoBanco() => Conectar();

        public void Conectar()
        {
            Conexao = new SqlConnection();
            
        }

        public void Desconectar()
        {
            Conexao.Close();
        }

        public void Dispose()
        {
            Desconectar();
            Conexao.Dispose();
        }
    }
}