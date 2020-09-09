namespace ControleFinanceiro.Domain.Model  {

    public class SetorPapel {
        public SetorPapel(string nomeSetor)
        {
            NomeSetor = nomeSetor;
        }
        public string NomeSetor { get; set; }

        public override string ToString(){
            return NomeSetor;    
        }
    }
}
