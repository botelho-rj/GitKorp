using System;
using System.Collections;
using Eventos.IO.Domain.Interfaces;
using System.Collections.Generic;

namespace Eventos.IO.Domain.EventoRoot.Repository
{
    public interface IEventoRepository : IRepository<Evento>
    {
        IEnumerable<Evento> ObterEventoPorCategoria(Guid categoriaId);
        
    }
}