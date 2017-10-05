using System;

namespace Eventos.IO.Domain.EventoRoot.Events
{
    public class EventoAtualizadoEvent : BaseEventoEvent
    {
        public EventoAtualizadoEvent(Guid id, string titulo, Categoria categoria, DateTime dataInicio, TimeSpan horaInicio, string descricao)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Categoria = categoria;
            this.DataInicio = dataInicio;
            this.HoraInicio = horaInicio;
            this.Descricao = descricao;

            AggregateId = id;
        }
    }
}