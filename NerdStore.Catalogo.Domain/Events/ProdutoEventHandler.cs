using MediatR;
using NerdStore.Catalogo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Domain.Events
{
    public class ProdutoEventHandler : INotificationHandler<ProdutoAbaixoEstoqueEvent>
    {
        private readonly IProdutoRepository _repository;

        public ProdutoEventHandler(IProdutoRepository repository)
        {
            _repository = repository;
        }
        public async Task Handle(ProdutoAbaixoEstoqueEvent notification, CancellationToken cancellationToken)
        {
            var produto = await _repository.ObterPorId(notification.AggregateId);

        }
    }
}
