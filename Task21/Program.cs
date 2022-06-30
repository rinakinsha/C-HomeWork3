double Distance3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double x = (x2 - x1)*(x2 - x1);
    double y = (y2 - y1)*(y2 - y1);
    double z = (z2 - z1)*(z2 - z1);

    double distance = Math.Sqrt(x+y+z);
    return distance;
}
Console.Write("Итак, давайте определимся с координатами точки А! Введите значение координаты AХ: ");
double ax = Convert.ToDouble(Console.ReadLine());

Console.Write("                                                  Введите значение координаты AY: ");
double ay = Convert.ToDouble(Console.ReadLine());

Console.Write("                                                  Введите значение координаты AZ: ");
double az = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

Console.Write("Теперь пришла пора определиться с положением точки B! Введите значение координаты BХ: ");
double bx = Convert.ToDouble(Console.ReadLine());

Console.Write("                                                      Введите значение координаты BY: ");
double by = Convert.ToDouble(Console.ReadLine());

Console.Write("                                                      Введите значение координаты BZ: ");
double bz = Convert.ToDouble(Console.ReadLine());

double result = Distance3D(ax, ay, az, bx, by, bz);

Console.Write("Расcтояние между точками A и B составляет " + result);
