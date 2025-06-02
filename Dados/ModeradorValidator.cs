using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ModeradorValidator: AbstractValidator<Moderador>
    {
        public ModeradorValidator() { 
            RuleFor(moderador => moderador.nome).NotEmpty().WithMessage("O campo NOME é obrigatório!");
            RuleFor(moderador => moderador.email).NotEmpty().WithMessage("O campo EMAIL é obrigatório!").Matches(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$").WithMessage("Email Inválido!");
            RuleFor(moderador => moderador.senha).NotEmpty().WithMessage("O campo SENHA é obrigatório!");
        }
    }
}
