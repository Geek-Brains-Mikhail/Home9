// Показать натуральные числа от M до N, N и M заданы
int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintNumberFromMtoN(int numberM,int numberN)
{
    Console.WriteLine(numberM);
    if(numberM == numberN) return;
    if(numberM>numberN)
    {
        PrintNumberFromMtoN(numberM-=1,numberN);
    }
    else
    {
        PrintNumberFromMtoN(numberM+=1,numberN);
    }
    
}
int numberM = GetNumber("Введите число M: ");
int numberN = GetNumber("Введите число N: ");
PrintNumberFromMtoN(numberM,numberN);