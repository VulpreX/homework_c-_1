Console.WriteLine("Enter number");
int n = int.Parse(Console.ReadLine());
switch (n % 2)
{
    case 0:
        Console.WriteLine("true");
        break;
    default:
        Console.WriteLine("false");
        break;
}