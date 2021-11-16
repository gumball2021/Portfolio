using SistemCadastro.Dominio.Cargos.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SistemCadastro.Compartilhado.Comandoss
{
   public interface IComandoFluxo<T> where T:IComando
    {
        Task<IComandoResultado> Fluxo(T comando);
    }
}
