// int CutNumber(int num)
// {
//     int des = num / 10;
//     int ed = num % 1;

//     int result = sot * 10 + ed * 1;
//     return result;
// }

// int randNum = new Random().Next(10, 100);

// int newNum = CutNumber(randNum);
// Console.WriteLine($"New version of a number {randNum} is {newNum}");


// Напишите программу, которая выводит случайное число из отрезка [10, 99]
//  и показывает наибольшую цифру числа.

// int MaxNum(int num)
// {
//     int des = num / 10;
//     int ed = num % 10;
//     int maxnum = des;
//     if(des < ed) maxnum = ed;
//     int result = maxnum;
//     return result;
// }
// int randNum = new Random().Next(10, 100);
// int newNum = MaxNum(randNum);
// Console.WriteLine(randNum);
// Console.WriteLine(newNum);

// Напишите программу, которая будет принимать на вход два числа и выводить,
//  является ли второе число кратным первому.

// bool del(int num1, int num2)
// {
//     if(num1 % num2 == 0)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// bool summa = del(num1, num2);
// Console.WriteLine(summa);


// Напишите программу, которая принимает на вход число и проверяет,
//  кратно ли оно одновременно a и b.


bool Met(int n1, int n2, int n3)
{
    if(n1 % n2 == 0 && n1 % n3 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }

}

Console.Write("Введите первое проверяемое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первый делитель: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй делитель: ");
int num3 = Convert.ToInt32(Console.ReadLine());
bool result = Met(num1, num2, num3);
Console.WriteLine(result);