using System;
using System.Collections.Generic;
using System.Text;
using CashFactorySimple;

namespace Strategy
{
    public class CashContext
    {
          CashSuper cashSuper;
        public CashContext(CashSuper cashSuper)
        {
            this.cashSuper = cashSuper;
        }

        public double GetResult(double money)
        { 
            return cashSuper.AcceptCash(money);
        }
    }
}
