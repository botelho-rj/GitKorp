using System;
using Eventos.IO.Domain.CommandHandlers;
using Eventos.IO.Domain.Core.Bus;
using Eventos.IO.Domain.Core.Events;
using Eventos.IO.Domain.Core.Notifications;
using Eventos.IO.Domain.EventoRoot.Events;
using Eventos.IO.Domain.EventoRoot.Repository;
using Eventos.IO.Domain.Interfaces;

namespace Eventos.IO.Domain.EventoRoot.Commands
{
    public class EventoCommandHandler : CommandHandler,
                                        IHandler<RegistrarEventoCommand>,
                                        IHandler<AtualizarEventoCommand>,
                                        IHandler<ExcluirEventoCommand>
    {
        private readonly IEventoRepository _eventoRepository;
        private readonly IBus _bus;
         

        public EventoCommandHandler(IEventoRepository eventoRespository, IUnitOfWork uow, IBus bus, IDomainNotificationHandler<DomainNotification> notifications) : base(uow,bus, notifications)
        {
            _eventoRepository = eventoRespository;
            _bus = bus;
        }

        public void Handle(RegistrarEventoCommand message)
        {
            var evento = new Evento(message.Titulo, message.CategoriaId, message.DataInicio, message.HoraInicio);

            if (!EventoValido(evento)) return;

            //Validações de Negócio
            //Persistência
            _eventoRepository.Adicionar(evento);

            if (Commit())
            {
                Console.WriteLine("Evento Registrado com Sucesso");
                _bus.RaiseEvent(new EventoRegistradoEvent(evento.Id, evento.Titulo, evento.Categoria.Id, evento.DataInicio, evento.HoraInicio, evento.Descricao));
            }
        }

        public void Handle(AtualizarEventoCommand message)
        {
            if(!EventoExistente(message.Id, message.MessageType)) return;

            var evento = Evento.EventoFactory.NovoEventoCompleto(message.Id,message.Titulo, null, message.DataInicio, message.HoraInicio, message.Descricao);

            if (!EventoValido(evento)) return;

            _eventoRepository.Atualizar(evento);
        }

        public void Handle(ExcluirEventoCommand message)
        {
            if(!EventoExistente(message.Id, message.MessageType)) return;

            _eventoRepository.Remover(message.Id);

            if (Commit())
            {
                _bus.RaiseEvent(new EventoExcluidoEvent(message.Id));
            }
        }

        private bool EventoValido(Evento evento)
        {
            if (evento.EhValido()) return true;

            NotificarValidacoesErro(evento.ValidationResult);
            return false;
        }

        private bool EventoExistente(Guid id, string messageType)
        {
            var evento = _eventoRepository.BuscarPorId(id);

            if (evento != null) return true;

            _bus.RaiseEvent(new DomainNotification(messageType, "Evento não encontrado."));
            return false;
        }
    }
}