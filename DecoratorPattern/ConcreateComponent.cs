using System;

namespace DecoratorPattern
{
    public class ConcreateComponent:Component
    {
        public override void Operation()
        {
            Console.WriteLine("具体对象操作");
        }
    }
}