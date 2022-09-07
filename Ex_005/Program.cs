// Написать программу показывающие первые N чисел, для которых каждое следующее равно
//  сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintNumber(int numberFirst, int numberSecond, int score)
{
    int temporary = 0;
    if (score > 0)
    {
        Console.Write(numberFirst + numberSecond + " ");
        temporary = numberFirst;
        numberFirst =numberSecond;
        numberSecond += temporary;
        PrintNumber(numberFirst, numberSecond, score -= 1);
    }
}
int numberFirst = GetNumber("Введите число M: ");
int numberSecond = GetNumber("Введите число N: ");
int score = GetNumber("Введите количество раз, сколько раз мы выведем число: ");
PrintNumber(numberFirst, numberSecond, score);