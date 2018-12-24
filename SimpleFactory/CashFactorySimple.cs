using System;


/// <summary>
/// 收银打折简单工厂模式例子
/// </summary>
namespace CashFactorySimple
{
    public class CashFactory
    {
        public static CashSuper CreateCashAccept(string type)
        {
            CashSuper ca = null;
            switch (type)
            {
                case "正常收费":
                    {
                        ca = new CashNormal();
                        break;
                    }
                case "打8折销售":
                    {
                        ca = new CashRate(0.8);
                        break;
                    }
                case "满300减100":
                    {
                        ca = new CashReturn(300, 100);
                        break;
                    }
            }
            return ca;
        }
    }


    public abstract class CashSuper
    {
        public abstract double AcceptCash(double money);
    }

    /// <summary>
    /// 正常销售
    /// </summary>
    public class CashNormal : CashSuper
    {
        public override double AcceptCash(double money)
        {
            return money;
        }
    }

    /// <summary>
    /// 折扣销售
    /// 初始化折扣
    /// </summary>
    public class CashRate : CashSuper
    {
        private double moneyRate = 1d;
        public CashRate(double moneyRate)
        {
            this.moneyRate = moneyRate;
        }
        public override double AcceptCash(double money)
        {
            return money * moneyRate;
        }
    }

    /// <summary>
    /// 返利销售
    /// 返利条件和返利值
    /// </summary>
    public class CashReturn : CashSuper
    {
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;

        public CashReturn(double moneyCondition, double moneyReturn)
        {
            this.moneyCondition = moneyCondition;
            this.moneyReturn = moneyReturn;
        }

        public override double AcceptCash(double money)
        {
            var result = money;
            if (money >= moneyCondition)
            {
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;
            }
            return result;
        }
    }
}