using System;
using Eventos.IO.Domain.Core.Events;

namespace Eventos.IO.Domain.EventoRoot.Events
{
    public abstract class BaseEventoEvent : Event
    {
        public Guid Id { get; set; }
        public string Titulo { get; protected set; }
        public Categoria Categoria { get; protected set; }
        public DateTime DataInicio { get; protected set; }
        public TimeSpan HoraInicio { get; protected set; }
        public string Descricao { get; protected set; }

    }
}