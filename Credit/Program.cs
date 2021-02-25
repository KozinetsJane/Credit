using System;

namespace Credit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму кредита:");
            string input = Console.ReadLine();
            var SumCredit = double.Parse(input);
            Console.WriteLine("Введите проценты кредита:");
            string input2 = Console.ReadLine();
            var InterestRate = double.Parse(input2);
            double MainPayment = SumCredit / 12;
            Console.WriteLine("Выплаты по месяцам:");

            double MonthPay1 = MainPayment + SumCredit * (InterestRate / 100) / 12;
            Console.WriteLine("1-й месяц:" + MonthPay1 + ";");
            Console.WriteLine();
            double MonthPay2 = MainPayment + (SumCredit - MainPayment) * (InterestRate / 100) / 12;
            Console.WriteLine("2-й месяц:" + MonthPay2 + ";");
            Console.WriteLine();
            double MonthPay3 = MainPayment + (SumCredit - MainPayment * 2) * (InterestRate / 100) / 12;
            Console.WriteLine("3-й месяц:" + MonthPay3 + ";");
            Console.WriteLine();
            double MonthPay4 = MainPayment + (SumCredit - MainPayment * 3) * (InterestRate / 100) / 12;
            Console.WriteLine("4-й месяц:" + MonthPay4 + ";");
            Console.WriteLine();
            double MonthPay5 = MainPayment + (SumCredit - MainPayment * 4) * (InterestRate / 100) / 12;
            Console.WriteLine("5-й месяц:" + MonthPay5 + ";");
            Console.WriteLine();
            double MonthPay6 = MainPayment + (SumCredit - MainPayment * 5) * (InterestRate / 100) / 12;
            Console.WriteLine("6-й месяц:" + MonthPay6 + ";");
            Console.WriteLine();
            double MonthPay7 = MainPayment + (SumCredit - MainPayment * 6) * (InterestRate / 100) / 12;
            Console.WriteLine("7-й месяц:" + MonthPay7 + ";");
            Console.WriteLine();
            double MonthPay8 = MainPayment + (SumCredit - MainPayment * 7) * (InterestRate / 100) / 12;
            Console.WriteLine("8-й месяц:" + MonthPay8 + ":");
            Console.WriteLine();
            double MonthPay9 = MainPayment + (SumCredit - MainPayment * 8) * (InterestRate / 100) / 12;
            Console.WriteLine("9-й месяц:" + MonthPay9 + ";");
            Console.WriteLine();
            double MonthPay10 = MainPayment + (SumCredit - MainPayment * 9) * (InterestRate / 100) / 12;
            Console.WriteLine("10-й месяц:" + MonthPay10 + ";");
            Console.WriteLine();
            double MonthPay11 = MainPayment + (SumCredit - MainPayment * 10) * (InterestRate / 100) / 12;
            Console.WriteLine("11-й месяц:"+ MonthPay11 + ";");
            Console.WriteLine();
            double MonthPay12 = MainPayment + (SumCredit - MainPayment * 11) * (InterestRate / 100) / 12;
            Console.WriteLine("12-й месяц:" + MonthPay12 + ";");
            Console.WriteLine();
            double ResultCreditPayment = MonthPay1 + MonthPay2 + MonthPay3 + MonthPay4 + MonthPay5 + MonthPay6 + MonthPay7 + MonthPay8 + MonthPay9 + MonthPay10 + MonthPay11 + MonthPay12;

            Console.WriteLine("Общая сумма выплат за год составит:" + ResultCreditPayment);
            double OverPaymentCredit = ResultCreditPayment - SumCredit;
            Console.WriteLine("Проценты по кредиту составили:" + OverPaymentCredit);
            Console.ReadLine();




        }
    }
}
