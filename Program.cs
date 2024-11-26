using System;
using System.Globalization;

namespace ConsoleApp3
{
    internal class Program
    {
        class Box
        {
            public int width;
        }
        static void Main(string[] args)
        {
            #region problem1
            int x = 10;//declare variable and its data type integer and its name x and assign value to it = 10
            int y = 20;//declare variable and its data type integer and its name y and assign value to it = 20
            int sum = x + y;//declare variable and its data type integer and its name sum assign and its value=x+y
            Console.WriteLine(sum);//print the output for the program
            #endregion

            #region question1
            //select the code you want to comment, then press ctrl+K AND ctrl+c to comment and for uncomment press ctr+k and ctrl+u
            #endregion

            #region problem 2
            int z = int.Parse("10");//the error here that we assign string value to an int variable so this not possible we must parse it
            int m = 4;
            Console.WriteLine(z + m);//here we must write the first letter cap as its the syntax rules of c# lang
            #endregion

            #region Question 2
            //runtime error: happens at the execution of the program ... example:devide by zero , or make an infinty loop , acess null refernce
            //logic error: it happens when the output of the program doesn't meet the expectations ... examples: x=7 and y=3 and u want to make an add operation but u put and / instead so the output will be diff
            #endregion

            #region problem 3
            String myName = "Ziad Gamal";
            int age = 21;
            int monthly_salary = 100;
            bool Is_student = true;
            #endregion

            #region Question 3
            //Improves Readability, Enhances Maintainability,Conforms to C# Standards,Facilitates Collaboration,Prevents Naming Conflicts
            #endregion

            #region problem 4
            Box box1 = new Box();
            box1.width = 10;
            Box box2 = box1;
            Console.WriteLine($"Box1 Width: {box1.width}");
            Console.WriteLine($"Box2 Width: {box2.width}");

            box1.width = 20;

            Console.WriteLine($"Box1 Width: {box1.width}");// the values after changing the refernce value
            Console.WriteLine($"Box2 Width: {box2.width}");
            #endregion

            #region Question 4
            //value types:stores>>the actual data, memory allocation>>stack, copy behavior>>changes the one doesn't affect the other, examples>>struct,bool,int
            //refernce types:stores>>The adress (a refernce of the object), memory allocation>>Heap, copy behavior>>changes made through one refernce affects the other 
            #endregion

            #region Problem 5
            int num1 = 15;
            int num2 = 4;


            int sum1 = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            double division = (double)num1 / num2;
            int remainder = num1 % num2;

            Console.WriteLine(sum1);
            Console.WriteLine(difference);
            Console.WriteLine(product);
            Console.WriteLine(division);
            Console.WriteLine(remainder);
            #endregion

            #region question 5
            int a = 2, b = 7;
            Console.WriteLine(a % b);
            // the output will be 2 because b>a so a have zero 7 in it so the ans will be 2
            #endregion

            #region problem 6

            string input = Console.ReadLine();
            int n = int.Parse(input);
            if (n > 10 && n % 2 == 0)
            {
                Console.WriteLine("program runs successfully");
            }
            else { Console.WriteLine("error"); }

            #endregion

            #region Question 7
            //The && (logical AND) operator evaluates conditions and short-circuits if the first condition is false.
            //(bitwise AND) operates at the binary level and evaluates all conditions regardless of the result.
            #endregion

            #region Problem 8
            int v = 10;
            long l;
            l = v;
            int v1;
            long l1 = 1000;
            v1 = (int)l1;
            #endregion

            #region Question 8
            //When you convert a double to an int, the fractional part is truncated (not rounded).
            //A double can represent much larger numbers (both positive and negative) than an int.
            #endregion

            #region Problem 9
            String age1 = Console.ReadLine();
            int age2 = int.Parse(age1);
            if (age2 > 0) { Console.WriteLine("valid"); }
            else { Console.WriteLine("Non valid"); }
            #endregion

            #region question 9
            //FormatException may occur, to handle it we can use try-catch to handle the exception.
            #endregion

            #region Problem 10
            int value = 5;

            // Postfix increment: x++ (use the value, then increment)
            Console.WriteLine("Postfix Increment:");
            Console.WriteLine($"Initial value of x: {x}");
            Console.WriteLine($"Value of x++: {x++} (x is used, then incremented)");
            Console.WriteLine($"Value of x after x++: {x}");

            // Reset x for prefix demonstration
            value = 5;

            // Prefix increment: ++x (increment first, then use the value)
            Console.WriteLine("\nPrefix Increment:");
            Console.WriteLine($"Initial value of x: {x}");
            Console.WriteLine($"Value of ++x: {++x} (x is incremented, then used)");
            Console.WriteLine($"Value of x after ++x: {x}");
            #endregion

            #region Question 10
            
            int j = 5;
            int h = ++j + j++;// h = 12 because ++j increment the j value and then we use it but j++ we use the j value which is 6 and after passing the value to y=6+6 j increments to 7
            #endregion
        }
    }
}
