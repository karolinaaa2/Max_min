Console.WriteLine("Введіть три числа:");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int max = Math.Max(a, Math.Max(b, c));
int min = Math.Min(a, Math.Min(b, c));

Console.WriteLine($"Max: {max}, Min: {min}");
