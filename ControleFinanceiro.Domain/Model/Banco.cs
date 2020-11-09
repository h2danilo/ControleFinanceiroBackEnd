using ControleFinanceiro.Domain.Model.ValueObjects;
using FluentValidator;

namespace ControleFinanceiro.Domain.Model  {
    public class Banco : Notifiable {

        public Banco(Descricao nomeBanco)
        {
            NomeBanco = nomeBanco;
        }

        public Descricao NomeBanco { get; private set; }

        public override string ToString(){
            return NomeBanco.ToString();    
        }
    }
}
