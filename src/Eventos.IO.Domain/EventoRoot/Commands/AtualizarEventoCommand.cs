using System;

namespace Eventos.IO.Domain.EventoRoot.Commands
{
    public class AtualizarEventoCommand : BaseEventoCommand
    {
        public AtualizarEventoCommand(Guid id, string titulo, Guid categoriaId, DateTime dataInicio, TimeSpan horaInicio)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.CategoriaId = categoriaId;
            this.DataInicio = dataInicio;
            this.HoraInicio = horaInicio;
        }
    }
}
