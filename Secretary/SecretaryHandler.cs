using System;

namespace SecretaryHandler
{
    public interface Subject
    {
        void Notify();
        string SubjectState { get; set; }
    }

    public delegate void EventHandler();
    public class Boss : Subject
    {
        public event EventHandler Update;
        private string action;

        public void Notify()
        {
            Update();
        }

        public string SubjectState
        {
            get { return action; }
            set { action = value; }
        }
    }

    public class Secretary : Subject
    {
        public event EventHandler Update;
        private string action;

        public void Notify()
        {
            Update();
        }

        public string SubjectState
        {
            get { return action; }
            set { action = value; }
        }
    }

    public class StockObserver  
    {
        private string name;
        private Subject sub;
        public StockObserver(string name, Subject sub)  
        {
            this.name = name;
            this.sub= sub;
        }

        public   void CloseStockMarket()
        {
            Console.WriteLine($"{sub.SubjectState}，{name} 关闭股票行情，继续工作!");
        }
    } 

     public class NBAObserver  
    {
        private string name;
        private Subject sub;
        public NBAObserver(string name, Subject sub)  
        {
            this.name = name;
            this.sub= sub;
        }

        public   void CloseNBAOnline()
        {
            Console.WriteLine($"{sub.SubjectState}，{name} 关闭NBA直播，继续工作!");
        }
    }


}