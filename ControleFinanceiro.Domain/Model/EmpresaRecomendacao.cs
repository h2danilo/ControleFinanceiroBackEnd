using ControleFinanceiro.Domain.Model.Enums;
using ControleFinanceiro.Domain.Model.ValueObjects;
using FluentValidator;

namespace ControleFinanceiro.Domain.Model  {

    public class EmpresaRecomendacao : Notifiable
    {

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
