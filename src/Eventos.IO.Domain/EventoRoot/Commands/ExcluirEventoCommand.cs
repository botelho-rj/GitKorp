using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.IO.Domain.EventoRoot.Commands
{
    public class ExcluirEventoCommand : BaseEventoCommand
    {
        public ExcluirEventoCommand(Guid id)
        {
            this.Id = id;
            this.AggregateId = Id;
        }
    }
}
