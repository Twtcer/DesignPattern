using System;

namespace Secretary
{
    class Program
    {
        static void Main(string[] args)
        {
            Secretary secretary = new Secretary();
            var stockObserver1 = new StockObserver("User1", secretary);
            var stockObserver2 = new NBAObserver("User2", secretary);

            secretary.Attach(stockObserver1);
            secretary.Attach(stockObserver2);

            secretary.SubjectState = "Boss come in"; 
            secretary.Notify();

            Boss boss = new Boss();
            boss.Attach(stockObserver1);
            boss.Attach(stockObserver2);

            boss.Detach(stockObserver1);

            boss.SubjectState =  "I'm come in";
            boss.Notify();
            
            Console.ReadKey();
        }
    }
}
