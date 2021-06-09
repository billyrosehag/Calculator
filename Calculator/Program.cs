using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Values used to calculate player input
            double numb1;
            double numb2;
            //What type of calculation 
            int operation = 0;
            //Number used to exit program
            int exitNumber = 7;
            //String that is reused within each calculation
            string resultString = "\nResulted Calculation: ";

            do
            {
                Console.Clear();
                //Program menu
                Console.WriteLine("---- Welcome to the Calculator ---- ");
                
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Power of");
                Console.WriteLine("6. Remainder of");
                Console.WriteLine("7. Exit program");

                Console.Write("\nChoose Type of operator by inputting the corresponding number." +
                            "\n\nWhat type of operator do you want to use: ");


                operation = PlayerInputToInt(1, exitNumber);

                //Exit program if player has inserted the exitNumber number.
                if(operation == exitNumber)
                { 
                    Console.Write("The program will exit. Press any key to continue: ");
                    Console.ReadKey();
                    break;
                };

                Console.Clear();

                // CALCULATIONS BEGIN HERE

                Console.Write(OperationHeadline(operation)+"\nWhat is the first number: ");
                numb1 = PlayerInputToDouble();

                //Checks what will be said as the second value will be inputted.
                Console.Write(OperationType(operation));

                numb2 = PlayerInputToDouble();

                //Result to present decided through a switch
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
                        if (numb1 == 0 || numb2 == 0)
                        {
                            Console.WriteLine("Divided by 0 is not allowed.");
                        }
                        else 
                        {
                            Console.WriteLine(resultString + Division(numb1, numb2));
                        }
                        
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

            } while (operation!=exitNumber);
           
        }// Main method ends here

        //Checks to see that a player input is a double
        static double PlayerInputToDouble() {

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
        
        //Checks to see that a player input is a int
        static int PlayerInputToInt()
        {

            bool isNumber;
            int result = 0;

            do
            {
                isNumber = int.TryParse(Console.ReadLine(), out result);
                if (!isNumber)
                {
                    Console.Write("That is an invalid input, try again: ");
                }
            } while (!isNumber);

            return result;
        }

        //Makes it so a player needs to input a int within a certain range
        static int PlayerInputToInt(int start, int end)
        {

            bool isNumber;
            int result = 0;

            do
            {
                isNumber = int.TryParse(Console.ReadLine(), out result);
                if (!isNumber || result < start || result > end)
                {
                    Console.Write("That is an invalid input, try again: ");
                }
            } while (!isNumber || result < start || result > end);

            return result;
        }

        //Decides the headline shown when performing the calculation
        static string OperationHeadline(int operation)
        {
            string operationHeadline =
                        operation == 1 ? "Addition" : operation == 2 ? "Subtraction"
                       : operation == 3 ? "Multiplication" : operation == 4 ? "Division"
                       : operation == 5 ? "Power of" : operation == 6 ? "Remainder" : "";

            return "---- "+ operationHeadline + " ----";
        }

        //Goes through what operation type the player has inputted, and shows a different message depending on that.
        static string OperationType(int operation)
        {
             string operationAnswer =
                        operation == 1 ? "Added with number: " : operation == 2 ? "Subtracted by: "
                       : operation == 3 ? "Multiplied by: " : operation == 4 ? "Divided by: "
                       : operation == 5 ? "Power of: " : operation == 6 ? "Remainder of: " : "";

            return operationAnswer;

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

}



