internal class Program
{
    class Person
    {
        public string Name { get; set; }
        public string lastName { get; set; }
    }

    private static void Main(string[] args)
    {
        string str = null;
        //int value = null;
        Console.WriteLine(default(string) == null);
        Console.WriteLine(default(int[]) == null);
        Console.WriteLine(default(int));
        Console.WriteLine(default(bool));
        //Console.WriteLine(value);
        /*if(str == null)
        {
            Console.WriteLine("Default text");
        }
        else
        {
            Console.WriteLine(str);
        }*/

        Console.WriteLine();
        // унарний оператор
        //++і
        //!true
        //-і
        //бінарний оператор
        // a + b + c
        // a == b
        // тернариний оператор
        // a ? b : c

        str = "Lorem ipsum";
        Console.WriteLine(str != null ? str : "Default text");
        // ?? 
        Console.WriteLine(str ?? "Default text");

        //Person p = new Person() {Name = null };
        //Person p = new Person() {Name = "Denis" };

        // ?

        //Person p = null;
        //Console.WriteLine(p?.Name ?? "None name");


        Console.WriteLine(str?.Length ?? -1);
        Console.WriteLine(str?.Replace('m', '@') ?? "Error");

        Nullable<int> value = null;
        Console.WriteLine(value.GetValueOrDefault());
        int? number = null;

        int[] arr = null;
        Console.WriteLine(arr?[0] ?? -1);

        arr ??= new int[6] { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine(arr?[0] ?? -1);
    }
}