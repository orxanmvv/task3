namespace ConsoleApp12
{
     internal class Program
    {
        static void Main()
        {
            double num1 = 9;
            double num2 = 5;
            char operatorlar = '/';
            double result = Calculator(num1, num2, operatorlar);
            Console.WriteLine(result);
        }

        static double Calculator(double num1, double num2, char operatorlar)
        {
            double cavab = 0;
            if (operatorlar == '+')
            {
                cavab = num1 + num2;
            }
            else if (operatorlar == '-')
            {
                cavab = num1 - num2;
            }
            else if (operatorlar == '*')
            {
                cavab = num1 * num2;
            }
            else if (operatorlar == '/')
            {
                cavab = num1 / num2;
            }
            return cavab;
        }
    }
}
