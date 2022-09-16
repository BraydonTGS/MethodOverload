using System;
namespace MethodOverload
{
    public class Overload
    {
        // Add //
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        // Double OverLoad //
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        // String Overload //
        public static string Add(int num1, int num2, bool bool1)
        {
            var answer = (bool1 && num1 + num2 != 1) ? $"{num1 + num2} dollars" : $"{num1 + num2} dollar";
            return answer;
        }
    }
}



