﻿Console.Clear();
Console.WriteLine("Введите число");
string num = Console.ReadLine();
int sum = 0;

for (int i = 0; i < num.Length; i++)
{
    sum = sum + Convert.ToInt32(Convert.ToString(num[i]));
}
Console.WriteLine(sum);
