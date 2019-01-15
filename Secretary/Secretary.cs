using System;
using System.Collections.Generic;

namespace Secretary
{
    public interface Subject
    {
        void Attach(Observer observer);
        void Detach(Observer observer);
        void Notify();
        string SubjectState { get; set; }
    }


    public abstract class Observer
    {
        protected string name;
        protected Subject sub;

        public Observer(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }
        public abstract void Update();
    }

    public class Boss : Subject
    {
        public List<Observer> observers = new List<Observer>();
        private string action;

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

        public string SubjectState
        {
            get { return action; }
            set { action = value; }
        }

    }

    public class Secretary : Subject
    {
        public List<Observer> observers = new List<Observer>();
        private string action;

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

        public string SubjectState
        {
            get { return action; }
            set { action = value; }
        }

    }

    public class StockObserver : Observer
    {
        public StockObserver(string name, Subject sub) : base(name, sub)
        {
        }

        public override void Update()
        {
            Console.WriteLine($"{sub.SubjectState}，{name} 关闭股票行情，继续工作!");
        }
    }

    public class NBAObserver : Observer
    {
        public NBAObserver(string name, Subject sub) : base(name, sub)
        { }

        public override void Update()
        {
            Console.WriteLine($"{sub.SubjectState}，{name} 关闭NBA直播，继续工作!");
        }
    }

}