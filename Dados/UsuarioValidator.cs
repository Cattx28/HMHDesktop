using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class UsuarioValidator: AbstractValidator<Usuario>
    {
        public UsuarioValidator() {
            RuleFor(usuario => usuario.nome).NotEmpty().WithMessage("O campo NOME é obrigatório!");
            RuleFor(usuario => usuario.idade).NotEmpty().WithMessage("O campo IDADE é obrigatório!");
            RuleFor(usuario => usuario.email).NotEmpty().WithMessage("O campo EMAIL é obrigatório!").EmailAddress().WithMessage("Email inválido!");
        }
    }
}
