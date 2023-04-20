// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите натуральное число: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int m = int.Parse(Console.ReadLine());
int sum = SumOfNum(n, m);
Console.WriteLine(sum);

int SumOfNum(int num, int num2)
{
    if(num == num2)
    {
        return num;
    }
    else if (num2 > num && num >= 0)
    {
        return num2 + SumOfNum(num2 -1, num);
    }
    else if (num > num2 && num2 >= 0)
    {
        return  num + SumOfNum(num - 1, num2);
    }
    else
    {
        Console.WriteLine("Введено неверное значение!");
        return 0;
    }
}