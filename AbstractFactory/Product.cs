using System;

namespace AbstractFactory
{
    public class ProductA1 : AbstractProductA
    {
        public override void Interact(AbstractProductB abstractProductB)
        {
            Console.WriteLine(GetType().Name + " interacts with " + abstractProductB.GetType().Name);
        }
    }

    public class ProductA2 : AbstractProductA
    {
         public override void Interact(AbstractProductB abstractProductB)
        {
            Console.WriteLine(GetType().Name + " interacts with " + abstractProductB.GetType().Name);
        }
    }

    public class ProductB1 : AbstractProductB
    {
         public override void Interact(AbstractProductA abstractProductA)
        {
            Console.WriteLine(GetType().Name + " interacts with " + abstractProductA.GetType().Name);
        }
    }

    public class ProductB2 : AbstractProductB
    {
         public override void Interact(AbstractProductA abstractProductA)
        {
            Console.WriteLine(GetType().Name + " interacts with " + abstractProductA.GetType().Name);
        }
    }
}
