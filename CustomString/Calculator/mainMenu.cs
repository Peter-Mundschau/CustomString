using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString.Calculator
{
    public class mainMenu
    {
        public Addition add = new Addition();
        public Subtraction sub = new Subtraction();
        public Multiplication mult = new Multiplication();
        public Division div = new Division();
        public Exponential pow = new Exponential();
        public double number1;
        public double number2;
        public double solution;
        public char symbol;


        public int menu()
        {
            Console.WriteLine("Welcome to the calculator");
            Console.WriteLine("Enter the first number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an operator +, -, *, /, ^");
            symbol = char.Parse(Console.ReadLine());
            if (symbol != '+' && symbol != '-' && symbol != '*' && symbol != '/' && symbol != '^')
            {
                Console.WriteLine("ERROR!");
                return menu();
            }
            if (symbol == '+')
            {
                add.doAddition(number1, number2);
            }
            else if (symbol == '-')
            {
                sub.doSubtraction(number1, number2);
            }
            else if (symbol == '*')
            {
                mult.doMultiplication(number1, number2);
            }
            else if (symbol == '/')
            {
                div.doDivision(number1, number2);
            }
            else if (symbol == '^')
            {
                pow.doExponential(number1, number2);
            }

            return 1;
        }
        public int otherMainMenu()
        {
            Console.WriteLine("Welcome to the calculator");
            Console.WriteLine("Enter the first number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an operator +, -, *, /, ^");
            symbol = char.Parse(Console.ReadLine());
            if (symbol != '+' && symbol != '-' && symbol != '*' && symbol != '/' && symbol != '^')
            {
                Console.WriteLine("ERROR!");
                return menu();
            }
            switch (symbol)
            {
                case '+':
                    solution = (number1 + number2);
                    Console.WriteLine(solution);
                    break;
                case '-':
                    solution = (number1 - number2);
                    Console.WriteLine(solution);
                    break;
                case '*':
                    solution = (number1 * number2);
                    Console.WriteLine(solution);
                    break;
                case '/':
                    solution = (number1 / number2);
                    Console.WriteLine(solution);
                    break;
                case '^':
                    solution = Math.Pow(number1, number2);
                    Console.WriteLine(solution);
                    break;
            }
            return 1;
        }
    }
}
