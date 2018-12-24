using System;

namespace DecoratorPattern
{
    public class Person
    {
        private string name;
        public Person()
        { }
        public Person(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }

        public virtual void Show()
        {
            Console.WriteLine($"装扮：{Name}");
        }
    }

    /// <summary>
    /// 服饰抽象
    /// </summary>
    public   class Finery:Person
    {
        protected Person component;

        public void Decorate(Person component)
        {
            this.component = component;
        }
        public override void Show()
        {
            if (component != null)
            {
                component.Show();
            }
        }
    }

    public class TShirt:Finery
    {
        public override void Show()
        {
            Console.WriteLine("大T恤");
            base.Show();
        }
    }

    public class BigTrouser:Finery
    {
        public override void Show()
        {
               Console.WriteLine("大裤子");
            base.Show();
        }
    }

    public class Slippers : Finery
    {
        public override void Show()
        {
            Console.WriteLine("人字拖");
            base.Show();    
        }
    }

    public class Skirt : Finery
    {
        public override void Show()
        {
            Console.WriteLine("A字裙");
            base.Show();
        }
    }

    public class WhiteShoes : Finery
    {
        public override void Show()
        {
            Console.WriteLine("小白鞋");
            base.Show();
        }
    }

}