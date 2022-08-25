// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1 * x + b1
// y = k2 * x + b2;
// y-y = k1 * x + b1 - k2 * x - b2  > b2 - b1 = k1 * x - k2* x      >     x = (b2-b1)/(k1-k2)
// y = k2 * x + b2;  > 

Console.WriteLine("Введите значение k1: \t");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2: \t");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b1: \t");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2: \t");
double b2 = Convert.ToInt32(Console.ReadLine());

string FindPoint(double k1, double k2, double b1, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    string point = ($"({x}; {y})");
    return point;
}
string result = FindPoint(k1, k2, b1, b2);

Console.WriteLine(result);
