using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.IO.Domain.EventoRoot.Events
{
    public class EventoRegistradoEvent : BaseEventoEvent
    {

        public EventoRegistradoEvent(Guid id, string titulo, Guid categoriaId, DateTime dataInicio, TimeSpan horaInicio, string descricao)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Categoria = categoriaId;
            this.DataInicio = dataInicio;
            this.HoraInicio = horaInicio;

            AggregateId = id;
        }


    }
}
