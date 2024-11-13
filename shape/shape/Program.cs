using System.Collections.Generic;
using System.Runtime.ExceptionServices;


namespace shape
{

   
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(5);
            IShape rectangle = new Rectangle(4, 6);
            Console.WriteLine(circle.getArea());
            Console.WriteLine(rectangle.getArea());


            //Solution solution = new Solution();
            //Console.WriteLine(solution.AreSentencesSimilar("c h p Ny", "c BDQ r h p Ny"));

            //List<int> x = new List<int> { 1, 2, 3, 4, 5, 6 };

            //var y = from num in x
            //        where num % 3 == 0
            //        select num;

            //var z = x.Where(num => num % 2 == 0);

            //foreach (int i in z)
            //{
            //    Console.WriteLine(i);
            //}
        }
       



        public interface IShape
        {
            double getArea();
        }
        public class Circle : IShape
        {

            private double radius { get; set; }

            public Circle(double radius)
            {
                this.radius = radius;
            }
            public double getArea()
            {
                return Math.PI * radius * radius;
            }
        }

        public class Rectangle : IShape
        {
            private double length;
            private double width;
            public Rectangle(double length,double width)
            {
                this.length=length;
                this.width = width;
            }
            public double getArea()
            {
                return length * width;
            }
        }







        public class Solution
        {
            public bool AreSentencesSimilar(string sentence1, string sentence2)
            {
                var s1 = sentence1.Split(" ");
                var s2 = sentence2.Split(" ");

                if (s2.Length == 2 || s1.Length == 2)
                {
                    if (s1[0] == s2[0] && s1[s1.Length - 1] == s2[s2.Length - 1])
                    {
                        return true;
                    }
                }

                if (s1.Length > s2.Length)
                {
                    if(s1[0] == s2[0] )
                    {
                        int count1 = 0;
                        for (int i = 0; i < s2.Length; i++)
                        {
                            if (s2[i] == s1[i] )
                            {
                                count1++;
                            }
                        }
                        return count1 == s2.Length;
                    }
                    else
                    {
                        int count1 = 0;
                        for (int i = 0; i < s2.Length; i++)
                        {
                            if ( s2[s2.Length - 1 - i] == s1[s1.Length - 1 - i])
                            {
                                count1++;
                            }
                        }
                        return count1 == s2.Length;
                    }
                }
                else
                {
                    if (s1[0] == s2[0])
                    {
                        int count2 = 0;
                        for (int i = 0; i < s1.Length; i++)
                        {
                            if (s1[i] == s2[i])
                            {
                                count2++;

                            }
                        }
                        return count2 == s1.Length;
                    }
                    else
                    {
                        int count2 = 0;
                        for (int i = 0; i < s1.Length; i++)
                        {
                            if ( s1[s1.Length - 1 - i] == s2[s2.Length - 1 - i])
                            {
                                count2++;
                            }
                        }
                        return count2 == s1.Length;
                    }
                }
            }
        }

    }
}
