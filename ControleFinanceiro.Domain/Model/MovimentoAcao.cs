using System;
using ControleFinanceiro.Domain.Model.Enums;

namespace ControleFinanceiro.Domain.Model  {

    public class MovimentoAcao {
        public MovimentoAcao(
            Banco banco,
            Papel papel,
            decimal qtde,
            decimal totalBruto, 
            decimal totalTaxas
        )
        {
            Id = Guid.NewGuid().ToString().Replace("-","").Substring(0,8).ToUpper();
            Papel = papel;
            Qtde = qtde;  
            Banco = banco;
            Operacao = EOperacao.Compra;
            Data = DateTime.Now;
            PrecoBrutoPorPapel = qtde == 0 ? 0 : totalBruto/qtde;
            TotalBruto = totalBruto; 
            TotalTaxas = totalTaxas;         
            TotalFinal = TotalBruto + TotalTaxas;
            PrecoFinalPorPapel = qtde == 0 ? 0 : TotalFinal/qtde;        
            Status = EStatusMovimento.Aberto;
        }

        public string Id { get; set; }
        public Papel Papel { get; private set; }
        public decimal Qtde { get; private set; }
        public Banco Banco { get; private set; }    
        public EOperacao Operacao { get; private set; }
        public DateTime Data { get; private set; }
        public decimal PrecoBrutoPorPapel { get; private set; }
        public decimal TotalBruto { get; private set; }
        public decimal TotalTaxas { get; private set; }
        public decimal PrecoFinalPorPapel { get; private set; }
        public decimal TotalFinal { get; private set; }
        public EStatusMovimento Status { get; private set; }



        //Comprar Acao
        public void CompraAcao(){
            Operacao = EOperacao.Compra;        
        }

        //Vender Acao
        public void VendaAcao(){
            Operacao = EOperacao.Venda;        
        }

        //Cancelar Operacao
        public void Cancela(){
            Status = EStatusMovimento.Cancelado;       
        }
    }
}
