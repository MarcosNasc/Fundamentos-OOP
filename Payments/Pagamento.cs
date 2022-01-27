using System;

namespace Payments{
  public  class Pagamento : IPagamento
  {
    public DateTime Vencimento { get; set; }

    public virtual void Pagar(Double valor){
      
    }

    // public delegate void Pagar(double valor);

  }
}