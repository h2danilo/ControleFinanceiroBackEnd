using System;

namespace ControleFinanceiro.Domain.Model  {

    public class MovimentoAcao {
        public Papel Papel { get; set; }

        public double Qtde { get; set; }

        public Banco Banco { get; set; }    

        public int Operacao { get; set; }

        public DateTime Data { get; set; }

        public double PrecoBrutoPorPapel { get; set; }

        public double TotalBruto { get; set; }

        public double Taxas { get; set; }

        public double PrecoLiquidoPorPapel { get; set; }

        public double TotalLiquido { get; set; }

        public bool Flag_Finalizado { get; set; }


    }
}
