using System;
using System.Collections.Generic;
using System.Text;

namespace Compartilhado.Entidade
{
    public interface IEntidade
    {
        int Id { get; set; }
        DateTime DataCadastro { get; set; }
        bool EstaAtivo { get; set; }

        //void setId(int id);
        //void setDataCadastro(DateTime dataCadastro);
        //void setEstaAtivo(bool estaAtivo);

        void Validar();
    }
}
