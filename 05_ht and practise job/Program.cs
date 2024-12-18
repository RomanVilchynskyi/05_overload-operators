namespace _05_ht_and_practise_job;

internal class Program
{
    private static void Main(string[] args)
    {
        Vector v1 = new Vector(3, 4);
        Vector v2 = new Vector(1, 2);

        Vector sum = v1 + v2;
        Vector diff = v1 - v2;
        Vector scaled = v1 * 2;
        double product = v1 * v2;

        Console.WriteLine($"v1: {v1}");
        Console.WriteLine($"v2: {v2}");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {diff}");
        Console.WriteLine($"Scaled v1 * 2: {scaled}");
        Console.WriteLine($"Dot product: {product}");

        Console.WriteLine($"-v1: {-v1}");

        double length = (double)v1; 
        Vector fromDouble = 5.0;    
        Console.WriteLine($"Length of v1: {length}");
        Console.WriteLine($"Vector from double 5.0: {fromDouble}");

        Vector zeroVector = new Vector();
        Console.WriteLine($"Is v1 true? {(v1 ? "Yes" : "No")}");
        //Console.WriteLine($"Is zeroVector false? {(!zeroVector ? "Yes" : "No")}");

        Console.WriteLine($"v1++: {++v1}");
        Console.WriteLine($"v2--: {--v2}");
    }
}