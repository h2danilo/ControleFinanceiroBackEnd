namespace ControleFinanceiro.Domain.Model  {
    public class Banco {
        public Banco(string nomeBanco)
        {
            NomeBanco = nomeBanco;
        }
        public string NomeBanco { get; private set; }

        public override string ToString(){
            return NomeBanco;    
        }
    }
}
