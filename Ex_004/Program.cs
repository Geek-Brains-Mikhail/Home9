
int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int Ackerman(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    else if (numberN == 0) return Ackerman(numberM - 1, 1);
    else return Ackerman(numberM - 1, Ackerman(numberM, numberN - 1));
}
int numberM = GetNumber("Введите число M: ");
int numberN = GetNumber("Введите число N: ");
Console.Write($"Вычисление функции Аккермана = {Ackerman(numberM,numberN)}");

