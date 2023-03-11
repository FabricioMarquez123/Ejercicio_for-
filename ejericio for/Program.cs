class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número entero:");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}