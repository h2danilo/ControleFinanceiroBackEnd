using FluentValidator;

namespace ControleFinanceiro.Domain.Model  {

    public class SetorPapel : Notifiable
    {
        public SetorPapel(string nomeSetor)
        {
            NomeSetor = nomeSetor;
        }
        public string NomeSetor { get; private set; }

        public override string ToString(){
            return NomeSetor;    
        }
    }
}
