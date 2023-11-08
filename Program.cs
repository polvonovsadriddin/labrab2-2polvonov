//высокий уровень 13
Console.WriteLine("введите A1:x1,y1");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите A2: x2,y2");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите A3:x3,y3");
int x3 = int.Parse(Console.ReadLine());
int y3 = int.Parse(Console.ReadLine());
double k = x1 / y1;
if (k == x2 / y2 && x3 / y3 == k) Console.WriteLine("Можно провести прямой через точку A1");
else if (x1 == x2 && x3 == x1) Console.WriteLine(" Можно провести прямой через точку A1");
else if (y1 == y2 && y3 == y1) Console.WriteLine("можно провести  через  точку A1");
else Console.WriteLine("нельзя провести прямой через точку A1");