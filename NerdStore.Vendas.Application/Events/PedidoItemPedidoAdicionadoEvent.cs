using NerdStore.Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Vendas.Application.Events
{
    public  class PedidoItemPedidoAdicionadoEvent : Event
    {
        public PedidoItemPedidoAdicionadoEvent(
            Guid clienteId, 
            Guid pedidoId, 
            Guid produtoId, 
            decimal valorUnitario, 
            int quantidade, 
            string nomeProduto
            )
        {
            AggregateId = pedidoId;
            ClienteId = clienteId;
            PedidoId = pedidoId;
            ProdutoId = produtoId;
            ValorUnitario = valorUnitario;
            Quantidade = quantidade;
            NomeProduto = nomeProduto;
        }

        public Guid ClienteId { get; private set; }
        public Guid PedidoId { get; private set; }
        public Guid ProdutoId { get; private set; }
        public string NomeProduto { get; private set; }
        public decimal ValorUnitario { get; private set; }
        public int Quantidade { get; private set; }
    }
}
