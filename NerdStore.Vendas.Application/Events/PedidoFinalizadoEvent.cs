﻿using NerdStore.Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Vendas.Application.Events
{
    public class PedidoFinalizadoEvent : Event
    {
        public PedidoFinalizadoEvent(Guid pedidoId)
        {
            AggregateId = pedidoId;
            PedidoId = pedidoId;
            AggregateId = pedidoId;
        }

        public Guid PedidoId { get; private set; }
    }
}
