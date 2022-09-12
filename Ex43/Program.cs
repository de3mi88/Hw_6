//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1 ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2 ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2 ");
double k2 = Convert.ToDouble(Console.ReadLine());


if (k2 == k1 && b2 == b1)
{
    Console.WriteLine("Прямые одинаковы");
}
else if (k2 == k1)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    double[] result = CalculationPointIntersectionLines(k1, b1, k2, b2);
    Console.WriteLine($"Точка пересечения заданных прямых: ({result[1]};{result[0]})");
}

double[] CalculationPointIntersectionLines(double k1, double b1, double k2, double b2)
{
    double[] spot = new double[2];
    spot[0] = (b2 - b1) / (k1 - k2);
    spot[1] = spot[0] * k1 + b1;
    return spot;
}