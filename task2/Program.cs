/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M 
до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  */

int GetNumber (string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] CreateArray(int m, int n)
{
    int k = n - m + 1;
    int[] array=new int[k];
    
    for(int i = 0; i < array.Length; i++)
    {
        array[i]= m;
        m++;
    }
    return array;
}


int Sum(int[] array, int i = 0)
{
    if (i >= array.Length)
    return 0;

    return array[i] + Sum(array, i + 1);
}

int m = GetNumber ("Введите значение M: ");
int n = GetNumber ("Введите значение N: ");
int k = n - m;
int[] array = CreateArray(m, n);
int sum = Sum(array);
Console.WriteLine ($"Сумма натуральных элементов в промежутке от {m} до {n} равна {sum}");


