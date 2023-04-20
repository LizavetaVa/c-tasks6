// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
int ackNum = Ack(num, num2);
Console.WriteLine(ackNum);

int Ack(int n, int m)
{
    if (n == 0) return m + 1;
    else if (n != 0 && m == 0) return Ack(n - 1, 1);
    else return Ack(n - 1, Ack(n, m -1));
}
 