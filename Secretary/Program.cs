using System;

namespace Secretary
{
    class Program
    {
        static void Main(string[] args)
        {
            #region   basic  
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

            boss.SubjectState = "I'm come in";
            boss.Notify();

            #endregion

            #region   event handler  
            var boss1 = new SecretaryHandler.Boss();
            var stockUser = new SecretaryHandler.StockObserver("张三", boss1);
            var nbaUser = new SecretaryHandler.NBAObserver("李四", boss1);

            boss1.Update += new SecretaryHandler.EventHandler(stockUser.CloseStockMarket);
            boss1.Update += new SecretaryHandler.EventHandler(nbaUser.CloseNBAOnline);

            boss1.SubjectState = "I'm Come in 23333!";
            boss1.Notify();
            #endregion

            Console.ReadKey();
        }
    }
}
