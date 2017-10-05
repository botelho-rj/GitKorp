using Eventos.IO.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace Eventos.IO.Application.Interfaces
{
    public interface IEventoAppService : IDisposable
    {
        void Registrar(EventoViewModel eventoViewModel);

        IEnumerable<EventoViewModel> ObterTodos();

        IEnumerable<EventoViewModel> ObterEventoPorCategoria(Guid categoriaId);

        EventoViewModel ObterPorId(Guid id);

        void Atualizar(EventoViewModel eventoViewModel);

        void Excluir(Guid id);

        
    }
}