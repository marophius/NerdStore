using EventStore.ClientAPI;
using NerdStore.Core.Data.EventSourcing;
using NerdStore.Core.Messages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing
{
    public class EventSourcingRepository : IEventSourcingRepository
    {
        private readonly IEventStoreService _eventStoreService;

        public EventSourcingRepository(IEventStoreService eventStoreService)
        {
            _eventStoreService = eventStoreService;
        }

        public async Task<IEnumerable<StoredEvent>> ObterEventos(Guid AggregateId)
        {
            var eventos = await _eventStoreService.GetConnection().ReadStreamEventsForwardAsync(
                AggregateId.ToString(), 0, 500, false);

            var listaeventos = new List<StoredEvent>();

            return listaeventos;
        }

        public async Task SalvarEvento<TEvent>(TEvent evento) where TEvent : Event
        {
            await _eventStoreService.GetConnection().AppendToStreamAsync(evento.AggregateId.ToString(), ExpectedVersion.Any, FormatarEvento(evento));
        }

        private static IEnumerable<EventData> FormatarEvento<TEvent>(TEvent evento) where TEvent : Event
        {
            yield return new EventData(Guid.NewGuid(), evento.MessageType, true, Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(evento)), null);
        }
    }
}
