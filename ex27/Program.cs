Console.Clear();
Console.Write("Insert the number: ");
int num = Convert.ToInt32(Console.ReadLine());
int summ = 0;
while (num > 0)
{
  summ += num%10;
  num /= 10;
}
Console.WriteLine($"Summ of the digits equals to {summ}");