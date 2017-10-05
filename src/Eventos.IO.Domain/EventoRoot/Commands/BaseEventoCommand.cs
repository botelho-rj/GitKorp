using System;
using System.Collections.Generic;
using System.Text;
using Eventos.IO.Domain.Core.Commands;

namespace Eventos.IO.Domain.EventoRoot.Commands
{
    public abstract class BaseEventoCommand : Command
    {
        public Guid Id { get; protected set; }
        public string Titulo { get; protected set; }
        public Guid CategoriaId { get; protected set; }
        public DateTime DataInicio { get; protected set; }
        public TimeSpan HoraInicio { get; protected set; }
        public string Descricao { get; protected set; }
        

    }

}
