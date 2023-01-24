Console.Clear();
;
int [] array = new int[8];
for (int i = 0; i < 8; i++)
{
  Console.Write($"Insert {i + 1} number: ");
  array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"[{string.Join(", ", array)}]");