using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            double numb1;
            double numb2;
            double operation = 0;
            string resultString = "\nResulted Calculation: ";

            do
            {
                Console.Clear();
                
                Console.WriteLine("---- Welcome to the Calculator ---- ");
                
                
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Power of");
                Console.WriteLine("6. Remainder");
                Console.WriteLine("10. Exit program");

                Console.Write("Choose Type of operation by inputting the corresponding number. " +
                            "\nWhat type of operation do you want to use: ");

                operation = PlayerNumberInput();

                if(operation == 10)
                { 
                    Console.Write("The program will quit. Press any key to continue: ");
                    Console.ReadKey();
                    break;
                };

                Console.Write("\nWhat is the first number: ");
                numb1 = PlayerNumberInput();

                //Checks what will be said as the second value will be inputted.
                string operationType = 
                        operation == 1 ? "Added with number: " : operation == 2 ? "Subtracted by: " 
                       :operation == 3 ? "Multiplied by: " : operation == 4 ? "Divided by: " : operation == 5 ? "Power of: " 
                       :operation == 6 ? "Remainder of: " :"";

                Console.Write(operationType);
                numb2 = PlayerNumberInput();

                switch (operation)
                {
                    case 1:
                        Console.WriteLine(resultString + Addition(numb1, numb2));
                        break;

                    case 2:
                        Console.WriteLine(resultString + Subtraction(numb1, numb2));
                        break;

                    case 3:
                        Console.WriteLine(resultString + Multiplication(numb1, numb2));
                        break;

                    case 4:
                        Console.WriteLine(resultString + Division(numb1, numb2));
                        break;

                    case 5:
                        Console.WriteLine(resultString + PowerOf(numb1, numb2));
                        break;

                    case 6:
                        Console.WriteLine(resultString + Remainder(numb1, numb2));
                        break;

                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        break;
                }
                Console.Write("Press any key to continue: ");
                Console.ReadKey();

            } while (operation!=10);



            
        }

        //Checks to see that a player input is a number
        static double PlayerNumberInput() {

            bool isNumber;
            double result = 0;

            do
            {
                isNumber = double.TryParse(Console.ReadLine(), out result);
                if(!isNumber)
                {
                    Console.Write("That is an invalid input, try again: ");
                }
            } while (!isNumber);

            return result;
        }

        //Method for addition
        static double Addition(double input1, double input2)
        {

            double result = input1 + input2;

            return result;

        }
        //Method for subtraction
        static double Subtraction(double input1, double input2)
        {

            double result = input1 - input2;

            return result;

        }
        //Method for multiplication
        static double Multiplication(double input1, double input2)
        {

            double result = input1 * input2;

            return result;

        }
        //Method for Division
        static double Division(double input1, double input2)
        {

            double result = input1 / input2;

            return result;

        }
        //Method for PowerOf
        static double PowerOf(double input1, double input2)
        {

            double result = Math.Pow(input1, input2);

            return result;

        }
        //Method for Remainder
        static double Remainder(double input1, double input2)
        {

            double result = input1 % input2;

            return result;

        }




    }







    /*
     Required Features:
    -The Program should be able to perform a basic mathematical operations 
    (Math has methods for mor advanced operations if you include them).
    - Addition, subtraction, division, multiplication, etc...
    - The program should keep running until the user chooses to end it.


     */

}



