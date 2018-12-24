using System;

namespace StrategySimple
{
    public abstract class Strategy
    {
        public abstract void SomeThingDo();
    }

    public class ConcreateStrategyA : Strategy
    {
        public override void SomeThingDo()
        {
            Console.WriteLine("Method A Run");
        }
    }
    public class ConcreateStrategyB : Strategy
    {
        public override void SomeThingDo()
        {
            Console.WriteLine("Method B Run");
        }
    }
    public class ConcreateStrategyC : Strategy
    {
        public override void SomeThingDo()
        {
            Console.WriteLine("Method C Run");
        }
    }

    public class  StrategyContext
    {
        Strategy strategy ;
        public StrategyContext(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void StrategyInterface()
        {
            strategy.SomeThingDo();
        }
    }
}