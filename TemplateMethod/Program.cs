using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TemplateMothod");

            new ConcreteClassA().TemplateMethod();
            new ConcreteClassB().TemplateMethod();
            Console.ReadKey();
        }
    }
}
