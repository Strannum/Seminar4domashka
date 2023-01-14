Console.Clear();

int [] mass = new int[8];
for(int i = 0; i < mass.Length; i++)
{
    mass [i] = new Random().Next(9999);
} 
Console.WriteLine($"Массив {String.Join(", ", mass)}");
