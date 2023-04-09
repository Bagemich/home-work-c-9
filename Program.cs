string OutPutNumber(int Number)
{
    if(Number == 1)
    return 1.ToString();
    string Empty = String.Empty;
    return Empty + OutPutNumber(Number - 1) + ", " + Number.ToString();
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.Write(OutPutNumber(number));