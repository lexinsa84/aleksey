
void squareOfNumbers(int number)
{
    int i = 1;
    while (i <= number)
    {
        Console.Write($"{i * i} ");
        i++;
    }
}

squareOfNumbers(5);
squareOfNumbers(10);
squareOfNumbers(15);