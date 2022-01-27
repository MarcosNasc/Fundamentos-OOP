using System;

namespace Payments
{
  public interface IPagamento
  {
    DateTime Vencimento {get;set;}

    void Pagar(double valor);

  }
}