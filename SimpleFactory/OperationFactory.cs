
using System;


namespace SimpleFactory
{
    public class  SimpleOperationFactory
    {
        public static Operation CreateOperate(string operate)
        {
            Operation operation = null;
            switch (operate)
            {
                case "+":{
                    operation = new OperationAdd();
                    break;
                } 
                  case "-":{
                    operation = new OperationSub();
                    break;
                }
                  case "*":{
                    operation = new OperationMul();
                    break;
                }
                  case "/":{
                    operation = new OperationDiv();
                    break;
                } 
            }
            return operation;
        }
    }
}