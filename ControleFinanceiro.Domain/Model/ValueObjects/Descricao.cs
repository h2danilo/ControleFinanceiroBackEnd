namespace ControleFinanceiro.Domain.Model.ValueObjects {
    public class Descricao 
    {
        public Descricao(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }

        public override string ToString() {
            return $"{Nome}";
        }
    }

}
