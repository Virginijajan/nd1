using System;

namespace ConsoleNd1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1;
            decimal num2;
            char op;
            decimal rez;
            bool end = false;
  
            do
            {
             Console.WriteLine("Parasykite, ka norite skaiciuoti: ");
            string str = Console.ReadLine();

            Console.WriteLine($"Jus parasete: {str}");
                str = str.Replace(" ", "");


                char[] delimiterChars = { '/', '+', '*', '-'};

                string[] numbers = str.Split(delimiterChars);

                if (numbers.Length == 2)
                {
                    bool result1 = decimal.TryParse(numbers[0], out num1);
                    bool result2 = decimal.TryParse(numbers[1], out num2);

                    if (result1 && result2)
                    {
                        op = str[numbers[0].Length];

                        if (op == '/')
                        {
                            rez = num1 / num2;
                        }
                        else if (op == '*')
                        {
                            rez = num1 * num2;
                        }
                        else if (op == '-')
                        {
                            rez = num1 - num2;
                        }
                        else
                        {
                            rez = num1 + num2;
                        }
                        System.Console.WriteLine($"{num1} {op} {num2} = {rez} ");
                        
                        end = true;
                    }
                    else
                    {
                        System.Console.WriteLine("Neteisingai ivesti skaiciai");

                    }
                }
                else
                {
                    System.Console.WriteLine("Neteisingai ivesti skaiciai");

                }

            } while (end==false);

           
            


        }
    }
}
