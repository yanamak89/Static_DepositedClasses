namespace Task6;

public static class Calculator
{
    public static double Add(double num1, double num2)
    {
        double result = num1 + num2;
        return result;
    }

    public static double Subtraction(double num1, double num2)
    {
        double result = num1 - num2;
        return result;
    }
    
    public static double Multiplication(double num1, double num2)
    {
        double result = num1 * num2;
        return result;
    }
    
    public static double Division(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: You cant divide by zero!");
            return double.NaN; // повернути значення, яке вказує на помилку
        }
        double result = num1 / num2;
        return result;
        
    }
    
    public static double ReminderOfTheDivision(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero.");
            return double.NaN; // повернути значення, яке вказує на помилку
        }
        double result = num1 % num2;
        return result;
    }

    public static void showCalculation(string operation, double num1, double num2)
    {
        double result = 0;
        switch (operation)
        {
            case "add":
                result = Add(num1, num2);
                Console.WriteLine($"{num1} + {num2} = {result}");
                break;
            case "subtract":
                result = Subtraction(num1, num2);
                Console.WriteLine($"{num1} - {num2} = {result}");
                break;
            case "multiply":
                result = Multiplication(num1, num2);
                Console.WriteLine($"{num1} * {num2} = {result}");
                break;
            case "divide":
                result = Division(num1, num2);
                Console.WriteLine($"{num1} / {num2} = {result}");
                break;
            case "reminder":
                result = ReminderOfTheDivision(num1, num2);
                Console.WriteLine($"{num1} % {num2} = {result}");
                break;
            default:
                Console.WriteLine("Invalid operation.");
                break;
        }
    }
}