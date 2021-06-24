using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;
using LanguageExt.ClassInstances;

namespace BussinesLayer.ValidationRules_Fluent_Validation
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz.");
            RuleFor(x => x.WriterSurname ).NotEmpty().WithMessage("Yazar Soy Adını Boş Geçemezsiniz.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında Kısmını Boş Geçemezsiniz.");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Ünvan Kısmını Boş Geçemezsiniz.");
            RuleFor(x => x.WriterAbout).Must(MustBea).WithMessage("Hakkında Kısmında Mutlaka a Harfi Bulunmalıdır.");
            RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("İsim En Az 3 Karakter Olmalıdır.");
            RuleFor(x => x.WriterSurname).MinimumLength(3).WithMessage("Soy İsim En Az 3 Karakter Olmalıdır.");

        }

        private bool MustBea(string arg)
        {
            return arg.Contains("a");
        }
    }
}
