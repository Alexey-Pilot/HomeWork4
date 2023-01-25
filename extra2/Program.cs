Console.Clear();
Console.Write("Введиле четное число от 4 до 998: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num % 2 == 1 || num < 4 || num > 998) // вводим число подходящее под условия задачи
{ 
  Console.Write("Введиле четное число от 4 до 998: ");
  num = Convert.ToInt32(Console.ReadLine());
}
bool isSimple(int n) // определяем простое число или нет
{
  for (int i = 2; i < n; i++)
  {
    if (n % i == 0) return false;
  }
  return true;
}

int s = new Random().Next(4, num);
do
{
  s = new Random().Next(4, num);
}while(isSimple(s) == false || isSimple(num - s) == false);


Console.WriteLine($"{s}, {num - s}");