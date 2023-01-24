Console.Clear();
Console.Write("Insert the length of array: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int[n];
int [] newarray = new int[n];
for (int i = 0; i <n; i++) // вводим массив
{
  Console.Write($"Insert {i + 1} number: ");
  array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Your array: [{string.Join(", ", array)}]");
Console.Write("Insert the shift: ");
int shift = Convert.ToInt32(Console.ReadLine());
while (shift >= n)
{
  shift -= n;
}
while (shift <= -n)
{
  shift += n;
}

for (int i = 0; i < n; i++)
{
  if (i + shift < n && i + shift >= 0)
  {
    newarray[i + shift] = array[i];
  }
  else if(i + shift >= n)
  {
    newarray[i + shift - n] = array[i];
  }
  else
  {
    newarray[i + shift + n] = array[i];
  }
}
Console.WriteLine($"Changed array is :[{string.Join(", ", newarray)}]");

