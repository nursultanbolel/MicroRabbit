using MicroRabbit.Domain.Core.Commands;
using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventBus
    {
        //It's going to be using our mediator library to send commands to various places through the bus.
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        //T:Event Type
        //TH:Event Handler
        void Subscribe<T, TH>() where T : Event where TH : IEventHandler<T>;

    }
}
