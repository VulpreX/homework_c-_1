int max = 0;
Console.WriteLine("Enter the first number");
Console.WriteLine("a=");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
Console.WriteLine("b=");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
Console.WriteLine("c=");
int c = int.Parse(Console.ReadLine());
if(a > b && a > c)
{  
      max = max + a;
      Console.Write("max=");
      Console.WriteLine(max);      
}
if(a > b && a < c)
{
      max = max + c;
      Console.Write("max=");
      Console.WriteLine(max);
}
if(a < b && b > c)
{      
      max = max + b;
      Console.Write("max=");
      Console.WriteLine(max);
}
if(a < b && b < c)
{      
      max = max + c;
      Console.Write("max=");
      Console.WriteLine(max);
}