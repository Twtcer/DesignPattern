
using System;

namespace DecoratorPattern
{
    public abstract class Decorator:Component
    {
        protected Component component;
        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if(component!=null)
            {
                component.Operation();
            }
        }
    }

    public class  ConcreateDecoratorA: Decorator    
    {
        private string addedState;
        public override void Operation()
        {
            base.Operation();
            addedState = "State";
            Console.WriteLine("�������ζ���A����");
        }
    }

    public class ConcreateDecoratorB : Decorator {
        public override void Operation()
        {
            base.Operation();
            AddBehavior();
            Console.WriteLine($"�������ζ���B����");
        }

        public void AddBehavior()
        {
        }
    }

}