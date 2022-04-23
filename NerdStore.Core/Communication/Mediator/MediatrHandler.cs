using MediatR;
using NerdStore.Core.Communication.Mediator;
using NerdStore.Core.Data.EventSourcing;
using NerdStore.Core.Messages;
using NerdStore.Core.Messages.CommonMessages.Notifications;

namespace NerdStore.Core
{
    public class MediatrHandler : IMediatrHandler
    {
        private readonly IMediator _mediator;
        private readonly IEventSourcingRepository _repository;

        public MediatrHandler(IMediator mediator, IEventSourcingRepository repos)
        {
            _mediator = mediator;
            _repository = repos;
        }

        public async Task<bool> EnviarComando<T>(T comando) where T : Command
        {
            return await _mediator.Send(comando);
        }

        public async Task PublicarEvento<T>(T evento) where T : Event
        {
            await _mediator.Publish(evento);
            if(!evento.GetType().BaseType.Name.Equals("DomainEvent"))
            {
                await _repository.SalvarEvento(evento);
            }
        }

        public async Task PublicarNotificacao<T>(T notificacao) where T : DomainNotification
        {
            await _mediator.Publish(notificacao);
        }
    }
}