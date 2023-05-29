// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int arg1)
{
    int remainder = 0;
    int result = 0;
    while (arg1 > 0)
    {
        remainder = arg1 % 10;
        result = result + remainder; 
        arg1 = arg1 / 10; 
    }
    return result;
}




try 
{
    Console.WriteLine("This programme is designed for counting the sum of digits in the number");
    Console.Write("Insert any number = ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Sum(num));  
}
catch 
{
    Console.WriteLine("You may insert only numbers");
}