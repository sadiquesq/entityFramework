namespace prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Enter a number:");
            //   int n=Convert.ToInt32(Console.ReadLine());


            //    void prime(int n)
            //    {
            //        if (n < 2)
            //        {
            //            Console.WriteLine($"{n} is a not prime number");
            //        }
            //        int Count = 0; 
            //        for(int i=2;i<=n/2 ;i++)
            //        {
            //            if (n % i == 0)
            //            {
            //                Count++;
            //            }
            //        }
            //        if (Count == 0)
            //        {
            //            Console.WriteLine($"{n} is prime number");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{n} is not a prime number");
            //        }
            //    }
            //    prime(n);
            //}


            MergeAlternately("ab","wsas");






             void MergeAlternately(string word1, string word2)
            {
                string s = "";
                int min = Math.Min(word1.Length, word2.Length);
                for (int i = 0; i < min; i++)
                {
                    s += word1[i];
                    s += word2[i];
                }
                if (word1.Length > word2.Length)
                {
                    Console.WriteLine(s += word1.Substring(min, word1.Length - min));
                }
                else
                {
                    Console.WriteLine(s + word2.Substring(min, word2.Length - min));
                }

            }
        }

    }
}
