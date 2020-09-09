using ControleFinanceiro.Domain.Model.Enums;

namespace ControleFinanceiro.Domain.Model  {

    public class EmpresaRecomendacao {

        public EmpresaRecomendacao(
            string empresa,
            ETipoEmpresa tipo) 
        {
            Empresa = empresa;
            Tipo = tipo;
        }

        public string Empresa { get; private set; }
        public ETipoEmpresa Tipo { get; private set; } 

        public override string ToString() 
        {
            return $"{Empresa}";
        } 
    }
}
