using System;

namespace KnowledgeCheck1_Calculator
{
    public class Processor 
    {
        Calculator calculator = new Calculator();
        public char Operator;
        public int Number1;
        public int Number2;
        public string Answer;

        //Prompt the user to enter two integers and save them to the class variables Number1 and Number2
        //Returns true if user input is validated
        public bool SelectOperands()
        {
            Console.WriteLine("Enter 2 integers");

            var Num1 = Console.ReadLine();
            var Num2 = Console.ReadLine();

            //Validate user  input
            if (int.TryParse(Num1, out int operand1) && int.TryParse(Num2, out int operand2))
            {
                Number1 = operand1;
                Number2 = operand2;
                return true;
            }
            else
            {
                Number1 = Number2 = 0;
                Console.WriteLine("One or more of the numbers is not an int");
                return false;
            }
        }

        //Promt the user to select an operator
        //Returns true if user input is valid
        public bool SelectOperator()
        {
            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");
            string input = Console.ReadLine();

            //Validate user input
            if (int.TryParse(input, out int Num))
            {
                switch(Num)
                {
                    case 1: Operator = '+'; break;
                    case 2: Operator = '-'; break;
                    case 3: Operator = '*'; break;
                    case 4: Operator = '/'; break;
                    default: 
                        Operator = '?';
                        Console.WriteLine("Invalid.");
                        return false;
                }
                return true;
            }
            else
            {
                Operator = '?';
                Console.WriteLine("Invalid.");
                return false;
            }
        }

        //Perform operation and assign outcome, using class variables
        //Requires that Number1, Number2, and Operator has been assigned  
        public void Operate()
        {
            switch(Operator)
            {
                case '+': Answer = calculator.Add(Number1, Number2).ToString(); break;
                case '-': Answer = calculator.Subtract(Number1, Number2).ToString(); break;
                case '*': Answer = calculator.Multiply(Number1, Number2).ToString(); break;
                case '/': Answer = Math.Round(calculator.Divide(Number1, Number2), 2).ToString(); break;
                default:
                    Console.WriteLine("Something went wrong.");
                    Answer = "";
                    break;
            }
        }

        //Reset class variables
        public void Reset()
        {
            Number1 = Number2 = 0;
            Operator = '?';
            Answer = "";
        }

        //Display the problem in the console
        public void DisplayProblem()
        {
            Console.Write($"{Number1} {Operator} {Number2} = ");
        }

        //Display the answer in the console
        public void DisplayAnswer()
        {
            Console.WriteLine(Answer);
        }
    }
}