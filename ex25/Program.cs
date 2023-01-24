Console.Clear();
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