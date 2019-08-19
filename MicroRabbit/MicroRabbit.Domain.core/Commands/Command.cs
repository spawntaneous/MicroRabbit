using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbit.Domain.core.Events;

namespace MicroRabbit.Domain.core.Commands
{
   public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
