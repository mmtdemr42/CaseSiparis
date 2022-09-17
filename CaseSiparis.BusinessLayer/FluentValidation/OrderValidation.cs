using CaseSiparis.DataEntity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseSiparis.BusinessLayer.FluentValidation
{
    class OrderValidation : AbstractValidator<Order>
    {
        public OrderValidation()
        {
            RuleFor(c => c.OrderDate).NotEmpty().WithMessage("Tarih  alanı boş geçilemez");
        }
    }
}
