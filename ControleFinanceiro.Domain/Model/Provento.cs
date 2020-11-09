using FluentValidator;
using System;

namespace ControleFinanceiro.Domain.Model  {

    public class Provento : Notifiable
    {
        
        public string TipoProvento { get; private set; }

        public Banco Banco { get; private set; }

        public DateTime Data { get; private set; }

        public Papel Papel { get; private set; }

        public decimal Total { get; private set; }

        public decimal QtdePapel { get; private set; }
            
    }
}
