using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{

    public enum Categories//枚举可以单独放在类外面，这样方便使用；枚举不能加static,其本身有点像常量，即使没有该枚举类型的变量时也可以访问。使用枚举类型名跟着一个点和成员名。EX: Categories.Spending
    {
        Spending = 1,
        Income = 2
    }


    public class AccountItem
    {      
        
        public AccountItem(string name, Categories category, string content, string note, Money amount, DateTime time)
        {
            Name = name;
            Category = category;
            Content = content;
            Note = note;
            Amount = amount;
            OccuredTime = time;

        }

        public Categories Category
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }



        public string Content
        {
            get;
            set;
        }

        public string Note
        {
            get;
            set;
        }

        public Money Amount
        {
            get;
            set;
        }

        public DateTime OccuredTime
        {
            get;set;
        }

        

    }
}
