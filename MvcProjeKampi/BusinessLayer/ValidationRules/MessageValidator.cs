using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı Adresi Boş Bırakılamaz!");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Boş Bırakılamaz!");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı Boş Geçemezsiniz!");
            RuleFor(x => x.MessageContent).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Lütfen 100 karakterden fazla değer girişi yapmayın");
        }
    }
}
