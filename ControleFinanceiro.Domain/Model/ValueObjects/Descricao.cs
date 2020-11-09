using FluentValidator;
using FluentValidator.Validation;

namespace ControleFinanceiro.Domain.Model.ValueObjects
{
    public class Descricao : Notifiable
    {
        public Descricao(string nome)
        {
            Nome = nome;

            AddNotifications(new ValidationContract()
                .Requires()
                .HasMinLen(Nome, 3, "Nome", "O nome deve conter pelo menos 3 caracteres.")
                );
        }

        public string Nome { get; private set; }

        public override string ToString()
        {
            return $"{Nome}";
        }
    }

}
