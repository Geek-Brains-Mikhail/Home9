// Найти сумму элементов от M до N, N и M заданы
int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int CountingNumberFrommToN(int numberM, int numberN, int sum)
{
    sum += numberM;
    if (numberM > numberN)
    {
        return CountingNumberFrommToN(numberM -= 1, numberN, sum);
    }
    else if (numberM < numberN)
    {
        return CountingNumberFrommToN(numberM += 1, numberN, sum);
    }
    return sum;
}
int numberM = GetNumber("Введите число M: ");
int numberN = GetNumber("Введите число N: ");
int sum = 0;
Console.WriteLine("Сумма = " + CountingNumberFrommToN(numberM, numberN, sum));
