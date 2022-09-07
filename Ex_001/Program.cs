// Показать натуральные числа от N до 1, N задано

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNumber(number);
void PrintNumber(int number)
{
    Console.WriteLine(number);
    if (number == 1) return;
    PrintNumber(number -= 1);
}
