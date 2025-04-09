using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Function
{
    internal class Program
    {
        //Main method ...
        static void Main(string[] args)
        {
            char choice;
            double balance = 1000;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to program menu:" +
                               "\n 1. Even or Odd" +
                               "\n 2. Largest of Three Numbers" +
                               "\n 3. Temperature Converter" +
                               "\n 4. Simple Discount Calculator" +
                               "\n 5. Grading System" +
                               "\n 6. Swap Two Numbers" +
                               "\n 7. Days to Weeks and Days Converter" +
                               "\n 8. Electricity Bill Calculator" +
                               "\n 9. Simple Calculator");
            int choice2 = int.Parse(Console.ReadLine());

            switch (choice2)
            {
                case 1:

                    int number;
                    Console.WriteLine("\n Enter your number:");
                    number = int.Parse(Console.ReadLine());

                    string printResult = EvenOrOdd(number);
                    printValue(printResult);

                    break;
                    case 2:

                        int number1, number2, number3;
                        Console.WriteLine("Enter your first number:");
                        number1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your second number:");
                        number2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your thired number:");
                        number3 = int.Parse(Console.ReadLine());

                        int printResult2 = LargestOfThreeNumbers(number1, number2, number3);
                        printValue(printResult2);

                        break;
                    case 3:

                        double Celsius;
                        Console.WriteLine("Enter your temperature in Celsius:");
                        Celsius = double.Parse(Console.ReadLine());

                        double printResult3 = TemperatureConverter(Celsius);
                        printValue(printResult3);

                        break;
                    case 4:

                        double price;
                        Console.WriteLine("Enter your item price:");
                        price = double.Parse(Console.ReadLine());

                        double printResult4 = SimpleDiscountCalculator(price);
                        printValue(printResult4);

                        break;
                    case 5:

                        double score;
                        Console.WriteLine("Enter your score:");
                        score = double.Parse(Console.ReadLine());

                        char printResult5 = GradingSystem(score);
                        printValue(printResult5);

                        break;
                    case 6:

                        int f_number, s_number;
                        Console.WriteLine("Enter your first number:");
                        f_number = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your second number:");
                        s_number = int.Parse(Console.ReadLine());

                        string printResult6 = SwapTwoNumbers(f_number, s_number);
                        printValue(printResult6);

                        break;
                    case 7:

                        int numberTocheck;
                        Console.WriteLine("Enter your the number of days:");
                        numberTocheck = int.Parse(Console.ReadLine());

                        string printResult7 = DaysToWeeksAndDaysConverter(numberTocheck);
                        printValue(printResult7);

                        break;
                    case 8:

                        double units;
                        Console.WriteLine("Enter the number of your units:");
                        units = double.Parse(Console.ReadLine());

                        double printResult8 = ElectricityBillCalculator(units);
                        printValue(printResult8);

                        break;
                    case 9:

                        double number_1, number_2;
                        char signal;

                        Console.WriteLine("Enter your first number:");
                        number_1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your second number:");
                        number_2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("\n Enter your operator (+, -, *, /):");
                        signal = char.Parse(Console.ReadLine());

                        string printResult9 = SimpleCalculator(number_1, number_2, signal);
                        printValue(printResult9);

                        break;
                    default:
                    Console.WriteLine("Wrong Choice!");
                    break;
            }

            Console.WriteLine("Do you want another operation ? y / n");
            choice = Console.ReadKey().KeyChar;

        } while (choice == 'y' || choice == 'Y');
            Console.WriteLine("Have a nice day!");
        }

        //1. Even or Odd ..
        public static string EvenOrOdd(int input)
        {
            int process = input % 2;
            string result;

            if (process == 0)
            {
                result = "Your number is even";
            }
            else
            {
                result = "Your number is odd";
            }
            return result;
        }
        //2. Largest of Three Numbers  ...
        public static int LargestOfThreeNumbers(int num1, int num2, int num3)
        {
            int largest = num1;
            if (largest > num2)
            {
                if (largest > num3)
                {
                    largest = num1;
                }
                else
                {
                    largest = num3;
                }
            }
            else
            {
                largest = num2;
                if (largest > num3)
                {
                    largest = num2;
                }
                else
                {
                    largest = num3;
                }
            }

            return largest;
        }
        //3. Temperature Converter  ...
        public static double TemperatureConverter(double input)
        {
            double Fahrenheit;
            Fahrenheit = (input * 9 / 5) + 32;
            return Fahrenheit;
        }
        //4. Simple Discount Calculator ...
        public static double SimpleDiscountCalculator(double input)
        {
            double discount, final_price;

            if (input > 100)
            {
                discount = 0.10 * input;
                final_price = input - discount;
            }
            else
            {
                final_price = input;
            }

            return final_price;
        }
        //5. Grading System ...
        public static char GradingSystem(double input)
        {
            char grade;
            if (input >= 90)
            {
                grade = 'A';
            }
            else if (input >= 80)
            {
                grade = 'B';
            }
            else if (input >= 70)
            {
                grade = 'C';
            }
            else if (input >= 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }

            return grade;
        }
        //6. Swap Two Numbers ...
        public static string SwapTwoNumbers(int num1, int num2)
        {
            int number1, number2, number_hold;
            string message;

            number_hold = num1;
            number1 = num2;
            number2 = number_hold;

            message = "Your numbers after swap: \n" +
                      "first number:\n" + number1 +
                      "second number:\n" + number2;
            return message;
        }
        //7. Days to Weeks and Days Converter ...
        public static string DaysToWeeksAndDaysConverter(int input)
        {
            int weeks, days;
            string message;
            weeks = input / 7;
            days = input % 7;

            message = "Then number of weeks you have is:" + weeks +
                      "\n Then number of days you have is:" + days;
            return message;
        }
        //8. Electricity Bill Calculator ...
        public static double ElectricityBillCalculator(double input)
        {
            double bill;

            if (input <= 100)
            {
                bill = 0.5 * input;
            }
            else if (input <= 300)
            {
                bill = 0.75 * input;
            }
            else
            {
                bill = 1 * input;
            }

            return bill;
        }
        //9. Simple Calculator ...
        public static string SimpleCalculator(double input1, double input2, char signal)
        {
            double result;
            string message;

            if (signal == '+')
            {
                result = input1 + input2;
                message = "\n Your result is:" + result;
            }
            else if (signal == '-')
            {
                result = input1 - input2;
                message = "\n Your result is:" + result;
            }
            else if (signal == '/')
            {
                if (input2 == 0)
                {
                    message = "\n You can not divide by ZERO";
                }
                else
                {
                    result = input1 / input2;
                    message = "\n Your result is:" + result;
                }
            }
            else if (signal == '*')
            {
                result = input1 * input2;
                message = "\n Your result is:" + result;
            }
            else
            {
                message = "\n You enter unaccepted operator!";
            }

            return message;
        }


        //Additional methods (Overloaded) ...
        //to print int ...
        public static void printValue(int input)
        {
            Console.WriteLine("the result of this operation is: " + input);
        }
        //to print string ...
        public static void printValue(string input)
        {
            Console.WriteLine("the result of this operation is: " + input);
        }
        //to print double ...
        public static void printValue(double input)
        {
            Console.WriteLine("the result of this operation is: " + input);
        }
        //to print char ...
        public static void printValue(char input)
        {
            Console.WriteLine("the result of this operation is: " + input);
        }
    }
}
