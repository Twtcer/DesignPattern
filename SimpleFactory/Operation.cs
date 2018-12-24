using System;

namespace SimpleFactory
{
    public class Operation
    {
        public double NumA => 0;
        public double NumB => 0;

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }

    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return NumA + NumB;
        }
    }

    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            return NumA - NumB;
        }
    }

    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            return NumA * NumB;
        }
    }

    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if(NumB==0)
                throw new Exception("除数不能为0");
            return NumA / NumB;
        }
    }
}