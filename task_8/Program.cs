 /*решил усложнить задачу на случай если будет введено отрицательное число (в таком случае нам должно показать все отрицательные числа до -1) */
Console.Write("your number = ");
int n = int.Parse(Console.ReadLine());
if ( n > 0)
{
    int i = 2;
    while (i <= n )
    {   
    System.Console.WriteLine(i);
    i = i + 2;
    }
}
if ( n < 0)
{
    int i = -2;
    while (i >= n )
    {   
    System.Console.WriteLine(i);
    i = i - 2;
    }
}