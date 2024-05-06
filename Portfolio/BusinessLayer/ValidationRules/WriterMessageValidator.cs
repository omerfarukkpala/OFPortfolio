using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterMessageValidator : AbstractValidator<WriterMessage>
    {
        public WriterMessageValidator()
        {
            RuleFor(x => x.Receiver).NotEmpty().WithMessage("Alıcı mail alanı boş geçilemez.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı boş geçilemez.");
            RuleFor(x => x.Content).NotEmpty().WithMessage("İçerik alanı boş geçilemez.");
        }
    }
}
