using NerdStore.Vendas.Application.Queries.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Vendas.Application.Queries
{
    public interface IPedidoQueries
    {
        Task<CarrinhoDTO> ObterCarrinhoCliente(Guid clienteId);
        Task<IEnumerable<PedidoDTO>> ObterPedidosCliente(Guid clienteId);
    }
}
