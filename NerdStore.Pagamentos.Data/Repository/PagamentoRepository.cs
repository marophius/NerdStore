﻿using NerdStore.Core.Data;
using NerdStore.Pagamentos.Business;
using NerdStore.Pagamentos.Business.Interfaces;
using NerdStore.Pagamentos.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Pagamentos.Data.Repository
{
    public class PagamentoRepository : IPagamentoRepository
    {
        private readonly PagamentoContext _context;
        public IUnitOfWork UnitOfWork => (IUnitOfWork) _context;

        public PagamentoRepository(PagamentoContext context)
        {
            _context = context;
        }

        public void Adicionar(Pagamento pagamento)
        {
            _context.Pagamentos.Add(pagamento);
        }

        public void AdicionarTransacao(Transacao transacao)
        {
            _context.Transacoes.Add(transacao);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
