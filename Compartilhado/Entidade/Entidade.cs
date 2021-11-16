using Flunt.Notifications;
using SistemCadastro.Compartilhado.NotifiableFakeAntiBug;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Compartilhado.Entidade
{
    public abstract class Entidade : NotifiableDapper
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool EstaAtivo { get; set; }

        public Entidade()
        {
            
            DataCadastro = DateTime.UtcNow.AddHours(-3);
            EstaAtivo = true;
        }

        //public void setid(int id) => id = id;

        //public void setdatacadastro(DateTime datacadastro) => datacadastro = datacadastro;

        //public void setestaativo(bool estaativo) => estaativo = estaativo;


    }
}
