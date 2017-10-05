using Eventos.IO.Domain.Core.Events;

namespace Eventos.IO.Domain.EventoRoot.Events
{
    public class EventoEventHandler : IHandler<EventoRegistradoEvent>,
                                            IHandler<EventoAtualizadoEvent>,
                                            IHandler<EventoExcluidoEvent>
    {
        public void Handle(EventoRegistradoEvent message)
        {
            //enviar um email
        }

        public void Handle(EventoAtualizadoEvent message)
        {
            //enviar um email
        }

        public void Handle(EventoExcluidoEvent message)
        {
            //enviar um email
        }
    }
}