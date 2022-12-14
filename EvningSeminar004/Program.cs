// Напишите программу, которая принимает на вход число (А)
//  и выдаёт сумму чисел от 1 до А.

// int GetSum(int num)
// {
//     int sum = 0;

//     for(int current = 1; current <= num; current++)
//     {
//         sum = sum + current;
//     }
//     return sum;
// }

// Console.Write("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = GetSum(a);
// Console.WriteLine($"Sum of number from 1 to {a} is {result}");

// Напишите программу, которая принимает на вход число
//  и выдаёт количество цифр в числе.

// int SumNum(int num)
// {
//     int count = 0;
//     while(num > 0)
//     {
//         num = num / 10;
//         count++;
//     }
//     return count;
// }

// Console.Write("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = SumNum(a);
// Console.WriteLine($"This number {a} has {result} digits");

// Напишите программу, которая принимает на вход число N
//  и выдаёт произведение чисел от 1 до N.

// int Factorial(int num)
// {  
//     int sum = 1;

//     for(int a = 1; a <= num; a++)
//     {
//         sum = sum * a;
//     }
//     return sum;
// }

// Console.Write("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = Factorial(a);
// Console.WriteLine($"Factorial numbers {a} is a {result}");

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Input number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("input min posibal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max posibal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);