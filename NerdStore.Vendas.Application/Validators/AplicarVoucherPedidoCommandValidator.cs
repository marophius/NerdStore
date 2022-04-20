using FluentValidation;
using NerdStore.Vendas.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Vendas.Application.Validators
{
    public class AplicarVoucherPedidoCommandValidator : AbstractValidator<AplicarVoucherPedidoCommand>
    {
        public AplicarVoucherPedidoCommandValidator()
        {
            RuleFor(c => c.ClienteId)
                .NotEqual(Guid.Empty)
                .WithMessage("Id do cliente inválido");

            RuleFor(c => c.CodigoVoucher)
                .NotEmpty()
                .WithMessage("O código do voucher não pode ser vazio");
        }
    }
}
