using System;

namespace Payments
{
  public class Pessoa : IEquatable<Pessoa>
  {
    public int Id {get;set;}
    public string Nome {get;set;}

    public Pessoa(){}

    public Pessoa(int id , string nome)
    {
        Nome = nome;
    }

    public bool Equals(Pessoa pessoa)
    {
      return Id == pessoa.Id;
    }
  }
}