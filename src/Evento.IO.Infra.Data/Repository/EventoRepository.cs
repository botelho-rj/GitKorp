using System;
using System.Collections.Generic;
using System.Linq;
using Eventos.IO.Domain.EventoRoot;
using Eventos.IO.Domain.EventoRoot.Repository;
using Eventos.IO.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Eventos.IO.Infra.Data.Repository
{
    public class EventoRepository : Repository<Evento>, IEventoRepository
    {
        public EventoRepository(EventosContext context) : base(context)
        {
            
        }

        public IEnumerable<Evento> ObterEventoPorCategoria(Guid categoriaId)
        {
            return Db.Eventos.Where(c => c.CategoriaId == categoriaId);
        }

        public override Evento ObterPorId(Guid id)
        {
            return Db.Eventos.Include(c => c.Categoria).FirstOrDefault(c => c.Id == id);
        }

    }
}