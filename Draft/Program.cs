Console.Write("Введите числа через запятую: ");
string numbers  = Console.ReadLine();

int[] array = numbers.Split(',').Select(int.Parse).ToArray();
Console.WriteLine($"[{string.Join(",",array)}]");