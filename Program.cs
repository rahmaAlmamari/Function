using System.Security.Cryptography;

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
                    //case 6:
                    //    break;
                    //case 7:
                    //    break;
                    //case 8:
                    //    break;
                    //case 9:
                    //    break;
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
        //7. Days to Weeks and Days Converter ...
        //8. Electricity Bill Calculator ...
        //9. Simple Calculator ...



        //Additional methods (Overloaded) ...
        //to print int ...
        public static void printValue(int input)
        {
            Console.WriteLine("the result of this operation is: " + input);
        }
        //to print string ...
        public static void printValue(String input)
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
