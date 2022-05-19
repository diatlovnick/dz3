double GetNumber(string msg)
{
    while(true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (double.TryParse(valueFromConsole, out double number))
        {
            return number;    
        }
        else
        {
             Console.WriteLine("Вы ввели не число. Нужно ввести число.");
        }
    }
}

double GetLengthVector(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double difx =  Math.Pow((x1 - x2), 2);
    double dify =  Math.Pow((y1 - y2), 2);
    double difz =  Math.Pow((z1 - z2), 2);
    double length = Math.Sqrt(difx + dify + difz);
    return length;

}


double x1 = GetNumber("введите координату первой точки по x");
double y1 = GetNumber("введите координату первой точки по y");
double z1 = GetNumber("введите координату первой точки по z");
double x2 = GetNumber("введите координату второй точки по x");
double y2 = GetNumber("введите координату второй точки по y");
double z2 = GetNumber("введите координату второй точки по z");


double resault = GetLengthVector(x1, x2, y1, y2, z1, z2);
Console.WriteLine(resault);