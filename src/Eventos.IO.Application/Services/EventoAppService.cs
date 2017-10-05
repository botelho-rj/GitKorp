using System;
using System.Collections.Generic;
using Eventos.IO.Application.Interfaces;
using Eventos.IO.Application.ViewModels;
using Eventos.IO.Domain.Core.Bus;
using Eventos.IO.Domain.EventoRoot.Commands;

namespace Eventos.IO.Application.Services
{
    public class EventoAppService : IEventoAppService
    {
        private readonly IBus _bus;

        public void Registrar(EventoViewModel eventoViewModel)
        {
            //var registroCommand = new RegistrarEventoCommand();
            //_bus.SendCommand(registroCommand);
        }

        public IEnumerable<EventoViewModel> ObterEventoPorCategoria(Guid categoriaId)
        {
            throw new NotImplementedException();
        }

        public EventoViewModel ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EventoViewModel> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Atualizar(EventoViewModel eventoViewModel)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Guid id)
        {
            throw new NotImplementedException();
        }
        
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}