using ControleFinanceiro.Domain.Model.ValueObjects;

namespace ControleFinanceiro.Domain.Model  {
    public class Banco {
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
