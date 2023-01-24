Console.Clear();
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Math.Pow(ЗАПРЕЩЕНО)
// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.Write("Insert number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert number B: ");
int b = Convert.ToInt32(Console.ReadLine());
int pow = 1;
for(int i = 0; i < b; i++)
{
  pow *= a;
}
Console.WriteLine($"{a} to the {b} power equals to {pow}");