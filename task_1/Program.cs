double Pow(double arg1, double arg2)
{
    double result = 0;
    result = Math.Pow(arg1, arg2);
    return result;
}




try
{
    Console.WriteLine("---This programe is designed for ");
    Console.Write("Insert the first number = ");
    double num = Convert.ToDouble(Console.ReadLine());
    Console.Write("Insert the second number = ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write($"{num} in the power of {num1} is equal to ");
    Console.WriteLine($"{Pow(num, num1)}");
}
catch
{
    Console.WriteLine("You may insert only numbers");
}