class Program
{
    static void Main(string[] args)
    {
        double m, n;
        double z1, z2;
        
        Console.Write("Enter the value of m: ");
        m = double.Parse(Console.ReadLine());
        Console.Write("Enter the value of n: ");
        n = double.Parse(Console.ReadLine());
        
        z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m,3) * n) + n * m + Math.Pow(m,2) - m);
        z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
        
        Console.WriteLine($"z1 = {z1}");
        Console.WriteLine($"z2 = {z2}");
    }
}