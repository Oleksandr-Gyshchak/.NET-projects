using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class Program
    {



        static void Main(string[] args)
        {

            Task1();

            pressAnyButtonToContinue();

            Task2();
        }

        static void Task1()
        {
            double amount = 0;
            double rate = 0;
            int years = 1;
            double totalAmountSimplePercent = 0;
            double totalAmountCompoundPercent = 0;

            string compoundPercentTotalMsg = "";


            Console.Write("Введите размер вклада: ");
            amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите годовую процентную ставку(%) : ");
            rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите срок размшения вклада:(Лет) ");
            years = Convert.ToInt32(Console.ReadLine());


            totalAmountSimplePercent = CalculateSimplePercent(amount, rate, years);

            totalAmountCompoundPercent = CalculateCompoundPercent(amount, rate, years, out compoundPercentTotalMsg);

            Console.WriteLine(
                "При вкладе {0:#.##} и {1} % годовых сумма вклада составит {2:#.##} через {3} лет (Простой процент)",
                amount, rate, totalAmountSimplePercent, years
            );

            Console.Write("------------");
            Console.Write($"\n Сложный процент \n{compoundPercentTotalMsg}");
            Console.WriteLine($"\n Через {years} лет будет {totalAmountCompoundPercent:#.##}");
        }


        private static double CalculateSimplePercent(double amount, double rate, int years)
        {
            double percentsAmount = 0;
            for (int i = 0; i < years; i++)
            {
                percentsAmount += amount * (rate / 100);
            }
            return amount + percentsAmount;
        }

        private static double CalculateCompoundPercent(double amount, double rate, int years, out string compoundPercentTotalMsg)
        {
            string totalByYears = "";
            double totalAmount = amount;

            for (int i = 0; i < years; i++)
            {
                totalAmount = totalAmount + (totalAmount * (rate / 100));

                totalByYears += $"Год {i + 1} : {totalAmount:#.##} \n";
            }

            compoundPercentTotalMsg = totalByYears;
            return totalAmount;
        }

        public static void Task2()
        {
            bool flag = false;

            while (flag == false)
            {

                double operand1 = 0;
                double operand2 = 0;
                double result = 0;


                string inputNumberMsg = "Введите число";
                string inputOperator = "Введите оператор";
                string calculatorOperator = "";

                for (int i = 1; i <= 2; i++)
                {
                    inputNumberMsg = inputNumberMsg + " " + i;
                    if (i == 1)
                    {
                        operand1 = IsDouble(inputNumberMsg, ref flag);
                    }
                    else
                    {
                        operand2 = IsDouble(inputNumberMsg, ref flag);
                    }
                }

                Console.WriteLine(inputOperator);
                calculatorOperator = Console.ReadLine();

                bool isValidOperator = TryCalculate(operand1, operand2, calculatorOperator, out result);

                if (isValidOperator == true)
                {
                    Console.WriteLine("Результат {0:#.##}", result);
                    Console.Write("------------");
                }
                else
                {
                    Console.WriteLine("Inlavid operator");
                }

            }


            Console.ReadKey();
        }

        static bool TryCalculate(double operand1, double operand2, string calculatorOperator, out Double result)
        {
            bool isValidOperator = false;

            result = 0;

            switch (calculatorOperator)
            {

                case "+":
                    result = operand1 + operand2;
                    isValidOperator = true;
                    break;
                case "-":
                    result = operand1 - operand2;
                    isValidOperator = true;
                    break;
                case "*":
                    result = operand1 * operand2;
                    isValidOperator = true;
                    break;
                case "/":
                    if (operand2 != 0)
                    {
                        result = operand1 / operand2;
                        isValidOperator = true;
                    }
                    else
                    {
                        isValidOperator = false;
                    }
                    break;
                default:
                    isValidOperator = false;
                    break;
            }

            return true;
        }

        static void pressAnyButtonToContinue()
        {
            string msg = "Нажмите любую клавишу, что бы перейти к следующему заданию";

            Console.WriteLine(msg);
            Console.ReadKey();
            Console.Clear();
        }
        static void IsClickedExit(string inputValue, ref bool flag)
        {
            if (inputValue == "exit")
            {
                Console.WriteLine("Exit");
                flag = true;
            }
        }

        static double IsDouble(string msg, ref bool flag)
        {
            string msgNotDouble = "Вы ввели не число !!";

            double result = 0;

            while (result == 0)
            {
                try
                {
                    Console.WriteLine(msg);

                    string inputValue = Console.ReadLine();
                    IsClickedExit(inputValue, ref flag);

                    result = double.Parse(inputValue);
                }
                catch
                {
                    Console.WriteLine(msgNotDouble);
                }
            }
            return result;
        }

    }

}
