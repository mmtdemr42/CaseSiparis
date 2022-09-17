using CaseSiparis.DataEntity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseSiparis.BusinessLayer.FluentValidation
{
    public class CompanyValidation:AbstractValidator<Company>
    {
        public CompanyValidation()
        {
            RuleFor(c => c.CompanyName).NotEmpty().WithMessage("Firma adı boş geçilemez");
            RuleFor(c => c.CompanyName).MinimumLength(3).WithMessage("Firma adı en az 3 karakterden oluşması gerekmektedir");
            RuleFor(c => c.CompanyName).MaximumLength(20).WithMessage("Firma adı en fazla 20 karakterden oluşması gerekmektedir");
        }
    }
}
