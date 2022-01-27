namespace Payments
{
    public class DataContext<P , PA , S>
    where P  : Pessoa
    where PA : IPagamento
    where S  : Subscription
    {
        public void Save(P entity){
            Console.WriteLine("Saving Person");
        }

        public void Save(PA entity){
            Console.WriteLine("Saving Payment");
        }

        public void Save(S entity){
            Console.WriteLine("Saving Subscription");
        }
    }
}