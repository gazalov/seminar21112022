// Console.Write("Enter the number: ");
// int n = int.Parse(Console.ReadLine());
// int n1 = % 10;

// Console.WriteLine(n1);

Console.Write("Enter 3 digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int length = number.ToString().Length;
int result = 0;

if (length == 3)
{
    result = number % 10;
    Console.WriteLine(result);
}
else 
{
    Console.WriteLine("Please enter 3 digit number!!!");
}