int N = 10;
int[] arr = {1,34,5,6,7,8,9,33,9,10};
int i = 0;
int max = arr[0];
while (i < N)
{
   
    if (max<arr[i])
    {
        max = arr[i];
    }
    i = i + 1;
}
Console.WriteLine(max);
max = arr[0];
for(int j=0;j<N;j++)
{

     if (max<arr[j])
    {
        max = arr[j];
    }

}
Console.WriteLine(max);

max = arr[0];
foreach(int e in arr)
{
    if (e>max)
    {
        max = e;
    }
}
Console.WriteLine(max);