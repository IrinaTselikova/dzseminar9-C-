/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29  */

int GetNumber (string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AkkermanFunction (int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    else if (n == 0)
    {
        return AkkermanFunction(m - 1, 1);
    }

    else if (n > 0)
      {
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }

    else
    return n + 1;

}

int m = GetNumber ("Введите значение m: ");
int n = GetNumber ("Введите значение n: ");
int akk = AkkermanFunction(m, n);
Console.WriteLine(akk);

