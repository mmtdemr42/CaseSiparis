using CaseSiparis.DataEntity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseSiparis.BusinessLayer.FluentValidation
{
    public class ProductValidation : AbstractValidator<Product>
    {
        public ProductValidation()
        {
            RuleFor(c => c.ProductName).NotEmpty().WithMessage("Ürün adı boş geçilemez");
            RuleFor(c => c.ProductAmount).GreaterThan(0).WithMessage("Ürün fiyatı sıfırdan büyük olmalıdır");
            RuleFor(c => c.ProductCount).GreaterThan(-1).WithMessage("Ürün miktarı negatif değer olamaz");
            RuleFor(c => c.ProductCount).NotEmpty().WithMessage("Ürün miktarı boş geçilemez");
            RuleFor(c => c.ProductAmount).NotEmpty().WithMessage("Ürün fiyatı boş geçilemez");
            RuleFor(c => c.ProductName).MinimumLength(3).WithMessage("Ürün adı en az 3 karakterden oluşması gerekmektedir");
            RuleFor(c => c.ProductName).MaximumLength(20).WithMessage("Ürün adı en fazla 20 karakterden oluşması gerekmektedir");
        }
    }
}
