using ControleFinanceiro.Domain.Model.Enums;

namespace ControleFinanceiro.Domain.Model  {

    public class Papel {

        public Papel(
            string nomePapel, 
            EmpresaRecomendacao empresaRecomendacao, 
            SetorPapel setorPapel,
            ETipoPapel tipoPapel,
            decimal precoMedio)
        {
            NomePapel = nomePapel;
            EmpresaRecomendacao = empresaRecomendacao;
            SetorPapel = setorPapel;
            TipoPapel = tipoPapel;
            PrecoMedio = precoMedio;
        }
        public string NomePapel { get; private set; }
        public EmpresaRecomendacao EmpresaRecomendacao { get; private set; }
        public SetorPapel SetorPapel { get; private set; }
        public ETipoPapel TipoPapel { get; private set; }
        public decimal PrecoMedio { get; private set; }

        public override string ToString(){
            return NomePapel;    
        }
    }
}
