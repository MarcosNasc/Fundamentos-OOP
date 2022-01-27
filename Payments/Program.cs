using System;

namespace Payments
{
    class Program
    {

        static void realizarPagamento(double valor)
        {
            Console.WriteLine($"Pago o valor de {valor}");
        }

        static void OnRoomSoldOut(object sender, EventArgs e)
        {
            Console.WriteLine("Sala Lotada!");
        }

        static void Main(string[] args)
        {

            // var pessoa = new Pessoa();
            // var pessoaFisica = new PessoaFisica();
            // var pessoaJuridica = new PessoaJuridica();

            // //upcast
            // pessoa = pessoaFisica;
            // pessoa = pessoaJuridica;

            // //downcast
            // pessoaFisica = (PessoaFisica) pessoa;
            // pessoaJuridica = (PessoaJuridica) pessoa;

            // var pessoaA = new Pessoa(1, "Marcos");
            // var pessoaB = new Pessoa(1, "Marcos");

            // Console.WriteLine(pessoaA.Equals(pessoaB));

            //Delegates
            // var pagar = new Pagamento.Pagar(realizarPagamento);
            // pagar(25);

            //Events
            // var room = new Room(3);
            // room.RoomSoldOutEvent += OnRoomSoldOut;
            // room.ReservedSeat();
            // room.ReservedSeat();
            // room.ReservedSeat();
            // room.ReservedSeat();

            //Genrics
            // var context = new DataContext<Pessoa,IPagamento,Subscription>();
            // var pessoa = new Pessoa();
            // var Pagamento = new Pagamento();
            // var subscription = new Subscription();
            // context.Save(pessoa);
            // context.Save(Pagamento);
            // context.Save(subscription);

            // Lists
            IList<Pagamento> pagamentos = new List<Pagamento>();


        }
    }
}

