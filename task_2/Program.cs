var max = 0;
Console.WriteLine("Enter the first number");
Console.WriteLine("a=");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
Console.WriteLine("b=");
int b = int.Parse(Console.ReadLine());
if(a > b)
{
      max = max + a;
      Console.WriteLine("a > b");
      Console.Write("max=");
      Console.Write(max);
}
else
{
       max = max + b;
      Console.WriteLine("a < b");
      Console.Write("max=");
      Console.Write(max);
}
