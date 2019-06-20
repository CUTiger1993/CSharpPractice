using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    //类的访问一致性很重要
    public class Accounts 
    {
        public Accounts()
        {
            AccountItemStore = new List<AccountItem>();//list只要new 出来了就不为null;必须给AccountItemStore new 一个list初始化,不然 属性AccountItemStore一开始为null,这样AccountItemStore.Add will be no references.

        }
        public List<AccountItem> AccountItemStore
        {
            get;
            set;
        }

        public void Add(AccountItem accountItem)
        {
            AccountItemStore.Add(accountItem); 
        }
        public Money TotalRevenue(DateTime time)
        {
            
            Money totalRevenue = TotalIncome(time) - TotalExpenditure(time);
            return totalRevenue;
        }

        public Money TotalExpenditure(DateTime time)
        {
            Money totalExpenditure = new Money(Money.Currencies.RMB, 0.0m);//decimal 用数字后加m表示；
            foreach (var element in AccountItemStore)
            {
                
                if ((time.Year == element.OccuredTime.Year) && (time.Month == element.OccuredTime.Month) &&  element.Category == Categories.Spending)
                {
                    totalExpenditure.Currency = element.Amount.Currency;
                    totalExpenditure = totalExpenditure + element.Amount;
                }
                    
            }

            return totalExpenditure;


        }

        public Money TotalIncome(DateTime time)
        {
            Money totalIncome = new Money(Money.Currencies.RMB, 0.0m);
            foreach (var element in AccountItemStore)
            {

                if ((time.Year == element.OccuredTime.Year) && (time.Month == element.OccuredTime.Month) && element.Category == Categories.Income)
                {
                    totalIncome.Currency = element.Amount.Currency;
                    totalIncome = totalIncome + element.Amount;
                }

            }

            return totalIncome;
        }

        public void Display(DateTime time)
        {
            foreach(var element in AccountItemStore)
            {
                if((element.OccuredTime.Month == time.Month) && (element.OccuredTime.Year == time.Year))
                {
                    Console.WriteLine($"Name: {element.Name}");
                    Console.WriteLine($"Category: {element.Category}");
                    Console.WriteLine($"Content: {element.Content}");
                    Console.WriteLine($"Note: {element.Note}");
                    Console.WriteLine($"FaceValue: {element.Amount.FaceValue}");
                    Console.WriteLine($"Occured Time: {element.OccuredTime}");
                }
            }

        }

        public IEnumerable<AccountItem> Display1(DateTime time)
        {
            foreach (var element in AccountItemStore)
            {
                if ((element.OccuredTime.Month == time.Month) && (element.OccuredTime.Year == time.Year))
                {
                    yield return element; 
                }
            }
        }


        /*public IEnumerator<AccountItem> GetEnumerator(DateTime time)这个不能有参数？
        {
            IEnumerable<AccountItem> acctItm = Display1(time);
            return acctItm.GetEnumerator()
        }*/
        
    }
}
