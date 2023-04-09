 Console.Write("Введите 2 числа: ");
 int[] Numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
 Console.Write( GapNumberSum (Numbers[0], Numbers[1]));

void GapNumberSum(int Number1, int Number2, int sum)
{
     if (Number1 > Number2) 
     {
         Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 

     }
       GapNumberSum(Number1, Number2, sum);
      + = = + (Number1++);

}
 GapNumberSum(Number1, Number2, 0);

 
