int N = 10;
int[] arr = new int[N];
int i = 0;

while (i < N)
{
    arr[i] = i + 1;
    if (arr[i] % 2 ==0)
    {
        Console.Write($"{arr[i]} ");
    }
    i = i + 1;
}