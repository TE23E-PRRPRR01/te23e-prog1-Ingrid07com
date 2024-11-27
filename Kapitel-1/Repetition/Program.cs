// Program
Console.Clear();
Console.WriteLine("HejHej");
Console.WriteLine("Vad heter du");
String name = Console.ReadLine();
Console.WriteLine($"Hej,{name}");

Console.WriteLine("Hur gammal är du");
int.TryParse(Console.ReadLine(), out int age);
Console.WriteLine($"Oj du är {age}");

Console.WriteLine("Vad är din favorit färg");
String color = Console.ReadLine();
Console.WriteLine($"Aha, du gillar {color}");