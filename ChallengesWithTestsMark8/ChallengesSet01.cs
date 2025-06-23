using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            var difference = minuend - subtrahend;
            return difference;
        }

        public int Add(int number1, int number2)
        {
            var solution = number1 + number2;
            return solution;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            var mininum = number1 < number2 ? number1 : number2;
            return mininum;
        }

        public long Multiply(long factor1, long factor2)
        {
            var product = factor1 * factor2;
            return product;
        }

        public string GetGreeting(string nameOfPerson)
        {
            nameOfPerson = Console.ReadLine();
            var greeting = "Hello " + nameOfPerson;
            return greeting;
        }

        public string GetHey()
        {
            return "Hey";
        }
    }
}
