using System;
using System.Collections.Generic;
using Eventos.IO.Domain.Core.Models;

namespace Eventos.IO.Domain.EventoRoot
{
    public class Categoria : Entity<Categoria> 
    {

        public String Nome { get; private set; }
        public virtual ICollection<Evento> Eventos { get; set; }


        public Categoria(Guid id)
        {
            Id = id;
        }


        //Construtor para o EF
        protected Categoria() { }
        

        public override bool EhValido()
        {
            return true;
        }

        public static implicit operator Categoria(Guid v)
        {
            throw new NotImplementedException();
        }
    }
}