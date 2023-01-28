int max = 0;
int min = 0;
Console.WriteLine("Enter the first number");
Console.WriteLine("a=");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
Console.WriteLine("b=");
int b = int.Parse(Console.ReadLine());
if(a > b)
{
      min = min + b; 
      max = max + a;
      Console.WriteLine("a > b");
      Console.Write("max=");
      Console.WriteLine(max);
      Console.Write("min=");
      Console.Write(min);
}
else
{
      max = max + b;
      min = min + a;
      Console.WriteLine("a < b");
      Console.Write("max=");
      Console.WriteLine(max);
      Console.Write("min=");
      Console.Write(min);
}