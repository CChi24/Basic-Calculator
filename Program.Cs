using System;

namespace C__Calculator
{
    class Program
    {
        static int final_answer = 0;
        static int digit_1, digit_2;
        static string math_number_1, math_number_2, cancel_calculator = "", operator_choice = "";
        static bool continuous_calculator = true, proper_math_equation = true;
        static void Main(string[] args)
        {     
            Console.WriteLine("Hello! Welcome to Chris' Basic Calculator!");
            Console.WriteLine("Please enter whole numbers and operation when prompted.");
            while(continuous_calculator){
                Console.WriteLine("\nBegin entering the first number of your math problem: ");
                math_number_1 = Console.ReadLine();
                
                Console.WriteLine("\nNow what type of operation will you be doing?");
                Console.WriteLine("Enter the letter of the operation you wish to do.");
                Console.WriteLine("a. Addition");
                Console.WriteLine("b. Subtraction");
                Console.WriteLine("c. Multiplicaton");
                Console.WriteLine("d. Divide");
                operator_choice = Console.ReadLine();

                Console.WriteLine("\nBegin entering the second number of your math problem:");
                math_number_2 = Console.ReadLine();

    
                if(Verify_Calculator_Input(math_number_1, math_number_2, operator_choice)){
                    Do_The_Math_Please(operator_choice);
                } else {
                    if(proper_math_equation == false){
                        Console.WriteLine("I can't solve that math equation! Please try again.");
                    } else{
                        Console.WriteLine("Invalid math problem for me to solve!");
                    }                       
                }

                Console.WriteLine("\nAnother math problem for your liking? Enter \'x\' if you want to get out of here or hit Enter to do another problem.");
                cancel_calculator = Console.ReadLine();
                if(cancel_calculator == "x"){
                    continuous_calculator = false;
                }
            }
        }

        static bool Verify_Calculator_Input(string num1, string num2, string operation){
            if(Int32.TryParse(num1, out digit_1) && Int32.TryParse(num2, out digit_2)){
                if(operation != "a" && operation != "b" && operation != "c" && operation != "d" ){
                    proper_math_equation = false;
                }
            } else {
                proper_math_equation = false;
                return false;
            }
            return proper_math_equation;
        }

        static void Do_The_Math_Please(string operation){
            if(operation == "a"){
                Console.WriteLine("\nYou entered: "  + digit_1 + "+" + digit_2 + "\n");
                final_answer  = digit_1 + digit_2;
                Console.WriteLine("The answer to your problem is: " + final_answer);
            } else if(operation == "b"){
                Console.WriteLine("You entered: "  + digit_1 + "-" + digit_2 + "\n");
                final_answer  = digit_1 - digit_2;
                Console.WriteLine("The answer to your problem is: " + final_answer);
            } else if(operation == "c"){
                Console.WriteLine("You entered: "  + digit_1 + "*" + digit_2 + "\n");
                final_answer  = digit_1 * digit_2;
                Console.WriteLine("The answer to your problem is: " + final_answer);
            } else if(operation == "d"){
                Console.WriteLine("You entered: "  + digit_1 + "/" + digit_2 + "\n");
                final_answer  = digit_1 / digit_2;
                Console.WriteLine("The answer to your problem is: " + final_answer);
            } else{
                Console.WriteLine("No math was done here.");
            }
        }
    }
}