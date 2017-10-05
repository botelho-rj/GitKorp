using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.IO.Domain.EventoRoot.Commands
{
    public class RegistrarEventoCommand : BaseEventoCommand
    {
        public RegistrarEventoCommand(string titulo, Guid categoriaId, DateTime dataInicio, TimeSpan horaInicio)
        {
            this.Titulo = titulo;
            this.CategoriaId = categoriaId;
            this.DataInicio = dataInicio;
            this.HoraInicio = horaInicio;
        }  
    }
}
