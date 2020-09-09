using ControleFinanceiro.Domain.Model.Enums;
using ControleFinanceiro.Domain.Model.ValueObjects;

namespace ControleFinanceiro.Domain.Model  {

    public class EmpresaRecomendacao {

        public EmpresaRecomendacao(
            Descricao empresa,
            ETipoEmpresa tipo) 
        {
            Empresa = empresa;
            Tipo = tipo;
        }

        public Descricao Empresa { get; private set; }
        public ETipoEmpresa Tipo { get; private set; } 

        public override string ToString() 
        {
            return $"{Empresa.ToString()}";
        } 
    }
}
