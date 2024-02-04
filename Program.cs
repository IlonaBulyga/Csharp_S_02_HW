// Задача 1: Напишите программу, которая принимает на вход число
//и проверяет, кратно ли оно одновременно 7 и 23.
Console.Clear();
Console.Write("Input a number: ");
int n = int.Parse(Console.ReadLine()!);
if (n % 7 == 0 && n % 23 == 0)
    Console.WriteLine("Yes, the number is a multiple of both 7 and 23"); 
    else Console.WriteLine("No, the number isn't a multiple of both 7 and 23");
// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0
// и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
Console.Write("Enter the X coordinate of the point: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Enter the Y coordinate of the point: ");
int y = int.Parse(Console.ReadLine()!);
if (x > 0 && y > 0)
    Console.WriteLine("I quarter");
    else if (x < 0 && y > 0)
            Console.WriteLine("II quarter");
            else if (x < 0 && y < 0)
                    Console.WriteLine("III quarter");
                    else if (x > 0 && y < 0)
                            Console.WriteLine("IV quarter");
                            else Console.WriteLine("The point is on the coordinate axis");
// Задача 3: Напишите программу, которая принимает на вход целое число
// из отрезка [10, 99] и показывает наибольшую цифру числа.  
Console.Write("Input an integer number from the interval [10, 99]: ");
int num = int.Parse(Console.ReadLine()!);
while (num < 10 || num > 99)
{
    Console.Write("You make a mistake!\nInput a two-digit number: ");
    num = int.Parse(Console.ReadLine()!);
}
int first = num / 10;
int second = num % 10;
if (first > second)
    Console.WriteLine($"The highest digit is {first}");
    else Console.WriteLine($"The highest digit is {second}");
// Задача 4: Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.
Console.Write("Input a natural number: ");
int number = int.Parse(Console.ReadLine()!);
if (number < 10)
    Console.WriteLine(number);
    else 
    {
        while (number > 9)
        {
            int Digit = number % 10;
            Console.Write(Digit + ",");
            number = number / 10;
        }
        Console.Write(number);
    }