﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Core.Messages.CommonMessages.IntegrationsEvents
{
    public class PedidoEstoqueRejeitadoEvent : IntegrationEvent
    {
        public PedidoEstoqueRejeitadoEvent(Guid pedidoId, Guid clienteId)
        {
            AggregateId = pedidoId;
            PedidoId = pedidoId;
            ClienteId = clienteId;
        }

        public Guid PedidoId { get; private set; }
        public Guid ClienteId { get; private set; }
    }
}
