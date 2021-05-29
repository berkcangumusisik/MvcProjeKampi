using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BussinesLayer.ValidationRules_Fluent_Validation
{
     public class ContactValidator: AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail adresini boş geçemezsiniz.");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adını boş geçemezsiniz.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Konu adı en az 3 karakterden oluşmalıdır.");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Kullanıcı adı en az 3 karakterden oluşmalıdır.");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Konu adına en fazla 50 karakter girişi yapabilirsiniz.");
        }
    }
}
