using System;

public class Account
{
    class Account
    {
        public Account(int sum)
        {
            Sum = sum;
        }

        public int Sum { get; private set; }

        public void Put(int sum)
        {
            Sum += sum;
        }

        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
            }
        }


    }
