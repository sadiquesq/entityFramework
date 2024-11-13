namespace daimend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number :");
            int n=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= (n * 2)-1; i++)
            {
                if (i <= n)
                {
                    for (int k = i; k <= n-1; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < (i * 2) - 1; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                { 
                    for (int k = 0; k <=(i - n)-1; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int j =(((n * 2) - i)*2)-1;j>0;j--)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
