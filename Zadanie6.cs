// Задание 6
Console.WriteLine("Вводим x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим x2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим y2");
int y2 = Convert.ToInt32(Console.ReadLine());
double a1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
Console.WriteLine("Выводим a1");
Console.WriteLine(a1);
