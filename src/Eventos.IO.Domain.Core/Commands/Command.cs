using System;
using System.Collections.Generic;
using System.Text;
using Eventos.IO.Domain.Core.Events;

namespace Eventos.IO.Domain.Core.Commands
{
    public class Command : Message
    {
        public DateTime TimeStamp { get; private set; }

        public Command()
        {
            TimeStamp = DateTime.Now;
        }


    }   
}
