int Factorial(int n)
{
    if (n == 1) return 1;
 
    return n * Factorial(n - 1);
}
 
int factorial4 = Factorial(4);  // 24
int factorial5 = Factorial(5);  // 120
int factorial6 = Factorial(6);  // 720
 
Console.WriteLine($"Factorial 4 = {factorial4}");
Console.WriteLine($"Factorial 5 = {factorial5}");
Console.WriteLine($"Factorial 6 = {factorial6}");
