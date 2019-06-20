using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Money
    {
        //decimal to represent FaceValue
        public Money(Currencies currency, decimal faceValue)
        {
           Currency = currency;
           FaceValue = faceValue;

        }
        public enum Currencies
        {
            RMB,
            USD,
            EUR
        }

        public Currencies Currency
        {
            get;
            set;
        }
        public decimal FaceValue
        {
            get;
            set;
        }
        //运算符重载；只能用于类和结构；
        public static Money operator + (Money m1, Money m2)
        {
            return new Money(m1.Currency, m1.FaceValue + m2.FaceValue);
        }

        public static Money operator - (Money m1, Money m2)
        {
            return new Money(m1.Currency, m1.FaceValue - m2.FaceValue);
        }

    }
}
