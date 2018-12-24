using System;
using StrategySimple;
namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region normal strategy
            StrategyContext context;

            context = new StrategyContext(new ConcreateStrategyA());
            context.StrategyInterface();

            context = new StrategyContext(new ConcreateStrategyB());
            context.StrategyInterface();

            context = new StrategyContext(new ConcreateStrategyC());
            context.StrategyInterface();
            #endregion 

            #region  cash strategy 
            var money = 300;
            CashContext cashContext;
            cashContext = new CashContext(new CashFactorySimple.CashNormal());
            LogInfo("原价销售", money, cashContext.GetResult(money));

            cashContext = new CashContext(new CashFactorySimple.CashRate(0.8));
            LogInfo("打八折销售", money, cashContext.GetResult(money));

            cashContext = new CashContext(new CashFactorySimple.CashReturn(300,100));
            LogInfo("满300减100销售", money, cashContext.GetResult(money));
            #endregion


            Console.ReadLine();
        }

        public static void LogInfo(string type,double originalPrice, double money)
        {
            Console.WriteLine($"策略:{type},原价:{originalPrice},收取费用:{money}");
        }
    }
}
