

double formula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int domenator = c + d;

    double rez = numenator / domenator;
    return rez;
}

double rezult = formula(1, 2, 3, 4);
Console.WriteLine(rezult);
