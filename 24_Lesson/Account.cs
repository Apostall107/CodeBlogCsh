using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Lesson
{


    public class Account
    {


        public delegate void AccountHandler(string message);
        public  event AccountHandler Notify;



        public Account(int sum)
        {
            Sum = sum;
        }

        public int Sum { get; private set; }

        public void Deposit(int sum)
        {
            Sum += sum;
            Notify?.Invoke($"Deposit {sum}");

        }

        public void Withdraw(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke($"Withdraw {sum}");
            }
            else
            {
                Notify?.Invoke($"Withdraw not possible not enough $ on your account. Account $ : {Sum}"); ;
            }
        }


    }
}
