
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
            Console.WriteLine("具体修饰对象A操作");
        }
    }

    public class ConcreateDecoratorB : Decorator {
        public override void Operation()
        {
            base.Operation();
            AddBehavior();
            Console.WriteLine($"具体修饰对象B操作");
        }

        public void AddBehavior()
        {
        }
    }

}