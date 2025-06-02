using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class PsicologoValidator: AbstractValidator<Psicologo>
    {
        public PsicologoValidator() {
            RuleFor(psicologo => psicologo.nome).NotEmpty().WithMessage("O campo NOME é origatório!");
            RuleFor(psicologo => psicologo.regiao).NotEmpty().WithMessage("O campo REGIÂO é origatório!");
            RuleFor(psicologo => psicologo.email).NotEmpty().WithMessage("O campo EMAIL é origatório!").Matches(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$").WithMessage("Email inválido!");

            RuleFor(psicologo => psicologo.cpf)
                .NotEmpty().WithMessage("O campo CPF é obrigatório.")
                .Must(ValidarCpf).WithMessage("CPF inválido.");
        }

        private static bool ValidarCpf(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                return false;

            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            if (cpf.Length != 11)
                return false;

            // Verifica dígitos repetidos (ex: 111.111.111-11)
            if (cpf.Distinct().Count() == 1)
                return false;

            // Cálculo dos dígitos verificadores
            int[] multiplicadores1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadores2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicadores1[i];

            int resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;

            string digito = resto.ToString();
            tempCpf += digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicadores2[i];

            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;

            digito += resto.ToString();

            return cpf.EndsWith(digito);
        }
    }
}
