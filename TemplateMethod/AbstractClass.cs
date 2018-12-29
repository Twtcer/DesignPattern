
using System;

namespace TemplateMethod
{
    public abstract class AbstractClass
    {
        //抽象定义
        protected abstract void PrimitiveOperation1();
        protected abstract void PrimitiveOperation2();

        /// <summary>
        /// 模板方法
        /// </summary>
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("success");
        }
    }
}