using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)

        {
            Accounts acct = new Accounts();
            acct.Add(new AccountItem("a", Categories.Income, "test", "test", new Money(Money.Currencies.RMB, 200m), new DateTime(2018, 5, 1, 8, 30, 52)));
            acct.Add(new AccountItem("b", Categories.Spending, "test", "test", new Money(Money.Currencies.RMB, 200m), new DateTime(2018, 5, 2, 8, 30, 52)));
            acct.Add(new AccountItem("c", Categories.Spending, "test", "test", new Money(Money.Currencies.RMB, 200m), new DateTime(2018, 5, 3, 8, 30, 52)));
            acct.Add(new AccountItem("d", Categories.Income, "test", "test", new Money(Money.Currencies.RMB, 200m), new DateTime(2018, 5, 4, 8, 30, 52)));
            acct.Add(new AccountItem("e", Categories.Income, "test", "test", new Money(Money.Currencies.RMB, 200m), new DateTime(2018, 6, 1, 8, 30, 52)));
            acct.Add(new AccountItem("f", Categories.Income, "test", "test", new Money(Money.Currencies.RMB, 200m), new DateTime(2018, 6, 2, 8, 30, 52)));
            acct.Add(new AccountItem("g", Categories.Income, "test", "test", new Money(Money.Currencies.RMB, 200m), new DateTime(2018, 7, 1, 8, 30, 52)));
            acct.Add(new AccountItem("h", Categories.Income, "test", "test", new Money(Money.Currencies.RMB, 200m), new DateTime(2018, 8, 1, 8, 30, 52)));
            acct.Add(new AccountItem("i", Categories.Income, "test", "test", new Money(Money.Currencies.RMB, 200m), new DateTime(2018, 9, 1, 8, 30, 52)));
            acct.Add(new AccountItem("j", Categories.Income, "test", "test", new Money(Money.Currencies.RMB, 200m), new DateTime(2018, 10, 1, 8, 30, 52)));
            acct.Add(new AccountItem("k", Categories.Income, "test", "test", new Money(Money.Currencies.RMB, 200m), new DateTime(2018, 11, 1, 8, 30, 52)));
            acct.Add(new AccountItem("l", Categories.Income, "test", "test", new Money(Money.Currencies.RMB, 200m), new DateTime(2018, 11, 2, 8, 30, 52)));
            acct.Add(new AccountItem("m", Categories.Spending, "test", "test", new Money(Money.Currencies.RMB, 200m), new DateTime(2018, 11, 3, 8, 30, 52)));
            acct.Add(new AccountItem("n", Categories.Income, "test", "test", new Money(Money.Currencies.RMB, 200m), new DateTime(2018, 11, 4, 8, 30, 52)));
            acct.Add(new AccountItem("o", Categories.Income, "test", "test", new Money(Money.Currencies.RMB, 200m), new DateTime(2018, 11, 5, 8, 30, 52)));

            Console.WriteLine($"Monthly Expenditure: {acct.TotalExpenditure(new DateTime(2018, 5, 5, 8, 30, 52)).FaceValue}");//控制台编码要调试一些东西后才能打印中文；
            Console.WriteLine($"Monthly Income: {acct.TotalIncome(new DateTime(2018, 5, 5, 8, 30, 52)).FaceValue}");
            Console.WriteLine($"Monthly Revenue: {acct.TotalRevenue(new DateTime(2018, 5, 5, 8, 30, 52)).FaceValue}");
            acct.Display(new DateTime(2018, 5, 5, 8, 30, 52));

            foreach(var element in acct.Display1(new DateTime(2018, 5, 5, 8, 30, 52)))//常见迭代器模式:如果我们在类中实现迭代器返回可枚举类型，我们可以让类实现GetEnumerator来让类本身可以被枚举，或不实现GetEnumerator,让类本身不可枚举，用迭代器返回的可枚举类，直接调用迭代器方法，如这里。
            {
                Console.WriteLine(element.Name);
            }

            /*foreach(var element in acct){

            }这个为什么不行？*/
        }
    }
}
