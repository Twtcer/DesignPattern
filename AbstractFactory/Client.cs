using System;

namespace AbstractFactory
{ 
    public class Client
    {
        public AbstractProductA abstractProductA { get; }

        public AbstractProductB abstractProductB { get; }
        public Client(AbstractFactory abstractFactory)
        {
            abstractProductA = abstractFactory.CreateProductA();
            abstractProductB = abstractFactory.CreateProductB();
        }

        public void Run()
        {
            abstractProductB.Interact(abstractProductA);
        }

    }

}
