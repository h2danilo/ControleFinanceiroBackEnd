using System;

namespace ControleFinanceiro.Domain.Model  {

    public class Provento {
        
        public string TipoProvento { get; set; }

        public Banco Banco { get; set; }

        public DateTime Data { get; set; }

        public Papel Papel { get; set; }

        public double Total { get; set; }

        public int QtdePapel { get; set; }
            
    }
}
