using System;

namespace VisualProgrammingAssignment
{
    // 1. Even or Odd Checker
    class EvenOddChecker
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine($"{num} is Even.");
            else
                Console.WriteLine($"{num} is Odd.");
        }
    }

    // 2. Simple Calculator
    class SimpleCalculator
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose operation: +, -, *, /");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine($"Result: {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"Result: {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"Result: {num1 * num2}");
                    break;
                case '/':
                    if (num2 != 0)
                        Console.WriteLine($"Result: {num1 / num2}");
                    else
                        Console.WriteLine("Error: Division by zero!");
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    break;
            }
        }
    }

    // 3. Grade Evaluator
    class GradeEvaluator
    {
        public static void Run()
        {
            Console.Write("Enter your marks (0–100): ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 85)
                Console.WriteLine("Grade: A");
            else if (marks >= 70)
                Console.WriteLine("Grade: B");
            else if (marks >= 55)
                Console.WriteLine("Grade: C");
            else if (marks >= 40)
                Console.WriteLine("Grade: D");
            else
                Console.WriteLine("Grade: F");
        }
    }

    // 4. Sum of Natural Numbers (Loop)
    class SumOfNaturalNumbers
    {
        public static void Run()
        {
            Console.Write("Enter a number (n): ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
                sum += i;

            Console.WriteLine($"Sum of numbers from 1 to {n} = {sum}");
        }
    }

    // 5. Multiplication Table
    class MultiplicationTable
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Multiplication Table of {num}:");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }

    // 6. Factorial Calculator
    class FactorialCalculator
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            int i = 1;

            while (i <= n)
            {
                fact *= i;
                i++;
            }

            Console.WriteLine($"Factorial of {n} = {fact}");
        }
    }

    // 7. Reverse a Number
    class ReverseNumber
    {
        public static void Run()
        {
            Console.Write("Enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int reversed = 0;

            while (num != 0)
            {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num /= 10;
            }

            Console.WriteLine($"Reversed number: {reversed}");
        }
    }

    // 8. Array - Find Maximum and Minimum
    class ArrayMaxMin
    {
        public static void Run()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < 10; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            int max = arr[0], min = arr[0];
            for (int i = 1; i < 10; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }

            Console.WriteLine($"Maximum: {max}");
            Console.WriteLine($"Minimum: {min}");
        }
    }

    // 9. Array - Count Even and Odd Numbers
    class ArrayEvenOddCount
    {
        public static void Run()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < 10; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            int evenCount = 0, oddCount = 0;

            foreach (int num in arr)
            {
                if (num % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            Console.WriteLine($"Even numbers: {evenCount}");
            Console.WriteLine($"Odd numbers: {oddCount}");
        }
    }

    // 10. Array - Search Element
    class ArraySearchElement
    {
        public static void Run()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < 10; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] == search)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine($"{search} exists in the array.");
            else
                Console.WriteLine($"{search} does not exist in the array.");
        }
    }

    // MAIN PROGRAM to run any exercise
    class Program
    {
        static void Main()
        {
            Console.WriteLine("C# Visual Programming Assignment");
            Console.WriteLine("Select a program to run (1–10): ");
            Console.WriteLine("1. Even or Odd Checker");
            Console.WriteLine("2. Simple Calculator");
            Console.WriteLine("3. Grade Evaluator");
            Console.WriteLine("4. Sum of Natural Numbers");
            Console.WriteLine("5. Multiplication Table");
            Console.WriteLine("6. Factorial Calculator");
            Console.WriteLine("7. Reverse a Number");
            Console.WriteLine("8. Array - Max & Min");
            Console.WriteLine("9. Array - Count Even & Odd");
            Console.WriteLine("10. Array - Search Element");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1: EvenOddChecker.Run(); break;
                case 2: SimpleCalculator.Run(); break;
                case 3: GradeEvaluator.Run(); break;
                case 4: SumOfNaturalNumbers.Run(); break;
                case 5: MultiplicationTable.Run(); break;
                case 6: FactorialCalculator.Run(); break;
                case 7: ReverseNumber.Run(); break;
                case 8: ArrayMaxMin.Run(); break;
                case 9: ArrayEvenOddCount.Run(); break;
                case 10: ArraySearchElement.Run(); break;
                default: Console.WriteLine("Invalid choice!"); break;
            }

            Console.WriteLine("\nProgram finished. Press any key to exit.");
            Console.ReadKey();
        }
    }
}using System;

namespace VisualProgrammingAssignment
{
    // 1. Even or Odd Checker
    class EvenOddChecker
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine($"{num} is Even.");
            else
                Console.WriteLine($"{num} is Odd.");
        }
    }

    // 2. Simple Calculator
    class SimpleCalculator
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose operation: +, -, *, /");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine($"Result: {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"Result: {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"Result: {num1 * num2}");
                    break;
                case '/':
                    if (num2 != 0)
                        Console.WriteLine($"Result: {num1 / num2}");
                    else
                        Console.WriteLine("Error: Division by zero!");
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    break;
            }
        }
    }

    // 3. Grade Evaluator
    class GradeEvaluator
    {
        public static void Run()
        {
            Console.Write("Enter your marks (0–100): ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 85)
                Console.WriteLine("Grade: A");
            else if (marks >= 70)
                Console.WriteLine("Grade: B");
            else if (marks >= 55)
                Console.WriteLine("Grade: C");
            else if (marks >= 40)
                Console.WriteLine("Grade: D");
            else
                Console.WriteLine("Grade: F");
        }
    }

    // 4. Sum of Natural Numbers (Loop)
    class SumOfNaturalNumbers
    {
        public static void Run()
        {
            Console.Write("Enter a number (n): ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
                sum += i;

            Console.WriteLine($"Sum of numbers from 1 to {n} = {sum}");
        }
    }

    // 5. Multiplication Table
    class MultiplicationTable
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Multiplication Table of {num}:");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }

    // 6. Factorial Calculator
    class FactorialCalculator
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            int i = 1;

            while (i <= n)
            {
                fact *= i;
                i++;
            }

            Console.WriteLine($"Factorial of {n} = {fact}");
        }
    }

    // 7. Reverse a Number
    class ReverseNumber
    {
        public static void Run()
        {
            Console.Write("Enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int reversed = 0;

            while (num != 0)
            {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num /= 10;
            }

            Console.WriteLine($"Reversed number: {reversed}");
        }
    }

    // 8. Array - Find Maximum and Minimum
    class ArrayMaxMin
    {
        public static void Run()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < 10; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            int max = arr[0], min = arr[0];
            for (int i = 1; i < 10; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }

            Console.WriteLine($"Maximum: {max}");
            Console.WriteLine($"Minimum: {min}");
        }
    }

    // 9. Array - Count Even and Odd Numbers
    class ArrayEvenOddCount
    {
        public static void Run()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < 10; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            int evenCount = 0, oddCount = 0;

            foreach (int num in arr)
            {
                if (num % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            Console.WriteLine($"Even numbers: {evenCount}");
            Console.WriteLine($"Odd numbers: {oddCount}");
        }
    }

    // 10. Array - Search Element
    class ArraySearchElement
    {
        public static void Run()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < 10; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] == search)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine($"{search} exists in the array.");
            else
                Console.WriteLine($"{search} does not exist in the array.");
        }
    }

    // MAIN PROGRAM to run any exercise
    class Program
    {
        static void Main()
        {
            Console.WriteLine("C# Visual Programming Assignment");
            Console.WriteLine("Select a program to run (1–10): ");
            Console.WriteLine("1. Even or Odd Checker");
            Console.WriteLine("2. Simple Calculator");
            Console.WriteLine("3. Grade Evaluator");
            Console.WriteLine("4. Sum of Natural Numbers");
            Console.WriteLine("5. Multiplication Table");
            Console.WriteLine("6. Factorial Calculator");
            Console.WriteLine("7. Reverse a Number");
            Console.WriteLine("8. Array - Max & Min");
            Console.WriteLine("9. Array - Count Even & Odd");
            Console.WriteLine("10. Array - Search Element");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1: EvenOddChecker.Run(); break;
                case 2: SimpleCalculator.Run(); break;
                case 3: GradeEvaluator.Run(); break;
                case 4: SumOfNaturalNumbers.Run(); break;
                case 5: MultiplicationTable.Run(); break;
                case 6: FactorialCalculator.Run(); break;
                case 7: ReverseNumber.Run(); break;
                case 8: ArrayMaxMin.Run(); break;
                case 9: ArrayEvenOddCount.Run(); break;
                case 10: ArraySearchElement.Run(); break;
                default: Console.WriteLine("Invalid choice!"); break;
            }

            Console.WriteLine("\nProgram finished. Press any key to exit.");
            Console.ReadKey();
        }
    }
}using System;

namespace VisualProgrammingAssignment
{
    // 1. Even or Odd Checker
    class EvenOddChecker
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine($"{num} is Even.");
            else
                Console.WriteLine($"{num} is Odd.");
        }
    }

    // 2. Simple Calculator
    class SimpleCalculator
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose operation: +, -, *, /");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine($"Result: {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"Result: {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"Result: {num1 * num2}");
                    break;
                case '/':
                    if (num2 != 0)
                        Console.WriteLine($"Result: {num1 / num2}");
                    else
                        Console.WriteLine("Error: Division by zero!");
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    break;
            }
        }
    }

    // 3. Grade Evaluator
    class GradeEvaluator
    {
        public static void Run()
        {
            Console.Write("Enter your marks (0–100): ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 85)
                Console.WriteLine("Grade: A");
            else if (marks >= 70)
                Console.WriteLine("Grade: B");
            else if (marks >= 55)
                Console.WriteLine("Grade: C");
            else if (marks >= 40)
                Console.WriteLine("Grade: D");
            else
                Console.WriteLine("Grade: F");
        }
    }

    // 4. Sum of Natural Numbers (Loop)
    class SumOfNaturalNumbers
    {
        public static void Run()
        {
            Console.Write("Enter a number (n): ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
                sum += i;

            Console.WriteLine($"Sum of numbers from 1 to {n} = {sum}");
        }
    }

    // 5. Multiplication Table
    class MultiplicationTable
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Multiplication Table of {num}:");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }

    // 6. Factorial Calculator
    class FactorialCalculator
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            int i = 1;

            while (i <= n)
            {
                fact *= i;
                i++;
            }

            Console.WriteLine($"Factorial of {n} = {fact}");
        }
    }

    // 7. Reverse a Number
    class ReverseNumber
    {
        public static void Run()
        {
            Console.Write("Enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int reversed = 0;

            while (num != 0)
            {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num /= 10;
            }

            Console.WriteLine($"Reversed number: {reversed}");
        }
    }

    // 8. Array - Find Maximum and Minimum
    class ArrayMaxMin
    {
        public static void Run()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < 10; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            int max = arr[0], min = arr[0];
            for (int i = 1; i < 10; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }

            Console.WriteLine($"Maximum: {max}");
            Console.WriteLine($"Minimum: {min}");
        }
    }

    // 9. Array - Count Even and Odd Numbers
    class ArrayEvenOddCount
    {
        public static void Run()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < 10; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            int evenCount = 0, oddCount = 0;

            foreach (int num in arr)
            {
                if (num % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            Console.WriteLine($"Even numbers: {evenCount}");
            Console.WriteLine($"Odd numbers: {oddCount}");
        }
    }

    // 10. Array - Search Element
    class ArraySearchElement
    {
        public static void Run()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < 10; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] == search)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine($"{search} exists in the array.");
            else
                Console.WriteLine($"{search} does not exist in the array.");
        }
    }

    // MAIN PROGRAM to run any exercise
    class Program
    {
        static void Main()
        {
            Console.WriteLine("C# Visual Programming Assignment");
            Console.WriteLine("Select a program to run (1–10): ");
            Console.WriteLine("1. Even or Odd Checker");
            Console.WriteLine("2. Simple Calculator");
            Console.WriteLine("3. Grade Evaluator");
            Console.WriteLine("4. Sum of Natural Numbers");
            Console.WriteLine("5. Multiplication Table");
            Console.WriteLine("6. Factorial Calculator");
            Console.WriteLine("7. Reverse a Number");
            Console.WriteLine("8. Array - Max & Min");
            Console.WriteLine("9. Array - Count Even & Odd");
            Console.WriteLine("10. Array - Search Element");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1: EvenOddChecker.Run(); break;
                case 2: SimpleCalculator.Run(); break;
                case 3: GradeEvaluator.Run(); break;
                case 4: SumOfNaturalNumbers.Run(); break;
                case 5: MultiplicationTable.Run(); break;
                case 6: FactorialCalculator.Run(); break;
                case 7: ReverseNumber.Run(); break;
                case 8: ArrayMaxMin.Run(); break;
                case 9: ArrayEvenOddCount.Run(); break;
                case 10: ArraySearchElement.Run(); break;
                default: Console.WriteLine("Invalid choice!"); break;
            }

            Console.WriteLine("\nProgram finished. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
