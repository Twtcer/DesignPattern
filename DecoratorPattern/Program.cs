using System;
using System.Collections.Generic;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 修饰模式基本例子

            var cc = new ConcreateComponent();
            var a1 = new ConcreateDecoratorA();
            var b1 = new ConcreateDecoratorB();

            a1.SetComponent(cc);//ConcreateDecoratorA包装cc
            b1.SetComponent(a1);//ConcreateDecoratorB包装a1
            b1.Operation();
             
            #endregion

            #region 服饰修饰例子  
            var tShirt = new TShirt();
            var bigTrouser = new BigTrouser();
            var slippers = new Slippers();
            tShirt.Decorate(new Person("李雷雷"));
            bigTrouser.Decorate(tShirt);
            slippers.Decorate(bigTrouser);
            slippers.Show();

            tShirt = new TShirt();
            var skirt = new Skirt();
            var whiteShoes = new WhiteShoes();
            tShirt.Decorate(new Person("韩梅梅"));
            skirt.Decorate(tShirt);
            whiteShoes.Decorate(skirt);
            whiteShoes.Show();


            //personList.ForEach(user => {
            //    Console.WriteLine($"{user.Name}的装扮如下:");

            //}); 

            #endregion

            Console.ReadLine();
        }
    }
}
