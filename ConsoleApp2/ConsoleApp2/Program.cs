using System.Collections.Concurrent;
using System.Globalization;
using System.Reflection.Metadata;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //long a=0;
            //float ab=3.45555555555555555555555555555555555555655555555555F;
            //char b = '1';
            //string c = "my name is sadique",d="i can do any thing in it";
            ////string 
            ////Program program = new Program();
            //Console.WriteLine(a);
            //Console.WriteLine(c + "    " + d);
            //string condition=a > 0 ? "positive" :a<0 ? "negative":"zero";
            //Console.WriteLine(condition);


            //double x = 9.19;
            //int y =(int)x;
            ////Console.WriteLine(y);
            //int myInt = 10;
            //double myDouble = 5482;
            //bool myBool = true;
            //Console.WriteLine(Convert.ToBoolean(myDouble));

            //Console.WriteLine("enter your username :");
            //string name= Console.ReadLine();
            //Console.WriteLine("username :"+ name);



            //long myLong = 1234567890;
            //Console.WriteLine(Convert.ToBoolean(myLong));

            //int myDouble = 9;
            //float myInt = myDouble;
            //Console.WriteLine(myDouble);


            //string a = "34";
            //Console.WriteLine(int.Parse(a));
            //int result;
            //Console.WriteLine(int.TryParse(a,out result));
            //Console.WriteLine(a +34);

            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age > 18)
            //{
            //    Console.WriteLine("18 plus");
            //}
            //else
            //{
            //    Console.WriteLine("under 18");
            //}

            //string name =Console.ReadLine();
            //Console.WriteLine(name);


            //void sum()
            //{
            //    Console.WriteLine("read a number");
            //}
            //sum();
            //int a = 5;
            //int b = 10;
            //Console.WriteLine(a);
            //student(ref a);
            //Console.WriteLine(a);
            //int result =add(5.5, b);
            //Console.WriteLine(result);



            //int[] numbers = { 100, 200, 300, 400 };
            //Console.WriteLine(numbers[numbers.Length-1]);
            //Console.WriteLine(numbers.Min());
            //Console.WriteLine(numbers);
            //ConcurrentBag<int> bag = new ConcurrentBag<int>();
            //Parallel.ForEach(numbers, x =>
            //{
            //    bag.Add(x + 1);
            //});
            //HashSet<int> set = new HashSet<int>(bag);
            //string result =String.Join(", ",set);
            //Console.WriteLine(result);
            //foreach (int x in set)
            //{
            //    Console.WriteLine(x);
            //}

            // static void student(ref int num)
            //{
            //     num = 7;
            //    Console.WriteLine($"my name is sadsique {num}");
            //}
            //static int add(double a,int b)
            //{
            //    return a + b;
            //}

            //Console.WriteLine(Days.Monday +" hdjdjdjd "+(int)Days.Tuesday);


            //int width = 5;
            //int height = 10;
            //Console.WriteLine("The area is {0}*{1}={2}.",width, height,width*height);




            //int[,] a = { { 1, 2, 3, 4, 5 } , { 23,46,33,65,5 } };
            //Console.WriteLine(a.Rank);//is also to row
            //Console.WriteLine(a.GetLength(0)); //to get no.od dimention in an array
            //Console.WriteLine(a.GetLength(1));//to get no.of columns in an array


            //var arr = new[]{ 100, 200, 300, 400, 700, 50 };
            //int[] copy =new int[arr.Length];
            //Array.Copy(arr, copy, arr.Length-1);   //to assign no.of element into an array
            //Array.Sort(arr);                        //for sort an array
            //Array.Reverse(copy);                   //reverse an array
            //Array.Resize(ref arr, 5);              // to resize an array
            ////Array.Clear(arr);                    //clear an array with specified index number
            //Console.WriteLine(Array.IndexOf(arr,700));
            //int[] x=Array.FindAll(arr,value =>value<200);
            //Console.WriteLine(x);


            //foreach (var i in arr)
            //{
            //    Console.WriteLine(i);
            //}



            //string str = "    hello world     ";
            //Console.WriteLine(str.Substring(2,5));// sub string a string with parameter of ,(start,no.elements)
            //Console.WriteLine(str.IndexOf('e')); // to find find
            //Console.WriteLine(str.Replace("world","c#"));
            //Console.WriteLine(str.Trim());
            //Console.WriteLine(str.Split(""));

            // ToLower()    ToUpper()













            //Animal animal = new Dog();
            //Animal animal1 = new Animal();
            Ithings w = new Whatsapp();
            w.Sending();
            w.Reciving();
            //animal.Sound();
            //animal1.Sound();

        }

        interface Ithings
        {
            void Sending();
            void Reciving();
        }

        class Whatsapp() : Ithings
        {
            public void Sending()
            {
                Console.WriteLine("sending message");
            }
            public void Reciving()
            {
                Console.WriteLine("Reciving message");
            }
        }

        //public class Animal()
        //{

        //    public virtual void Sound()
        //    {
        //        Console.WriteLine("animals makeing sound");
        //    }
        //}
        //public class Dog : Animal
        //{
        //    public override void Sound()
        //    {
        //        Console.WriteLine("dog makeing sound");
        //    }
        //}
    }
}
