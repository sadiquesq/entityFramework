using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System;
using System.ComponentModel.Design;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Person> people = new List<Person>
            //    {
            //        new Person {name="manu",age=25,city="mumbai"},
            //        new Person {name="hashir",age=30,city="kochi"},
            //        new Person {name="minu",age=27,city="mumbai"},
            //        new Person {name="nani",age=25,city="mumbai"}
            //    };


            //    var thing = people.Where(a => a.age > 25 && a.city == "kochi");

            //    foreach(var x in thing)
            //    {
            //        Console.WriteLine($"name:{x.name},age:{x.age}");
            //    }

            List<Username> user = new List<Username>
            {
                new Username{User="manu",Password=123 },
                 new Username{User="ranu",Password=000},
                 new Username{User="lan",Password=111}

            };
            Console.WriteLine("enter  user username");
            string x = Convert.ToString(Console.ReadLine());


            Console.WriteLine("enter user password :");
            int y = Convert.ToInt32(Console.ReadLine());

            //var result = from a in people
            //             join b in user
            //             on a.name equals b.User
            //             select new
            //             {
            //                 b.User,
            //                 a.city

            //             };

            //foreach ( var a in result )
            //{
            //    Console.WriteLine($"{a.User} and {a.city}");
            //}



            var result = user.FirstOrDefault(n => n.User == x && n.Password == y);
            if (result != null)
            {
                Console.WriteLine($"{x} is succesfully loging");
            }
            else
            {
                Console.WriteLine("user is not found");
            }

        }



        public class Username
        {
            public string User { get; set; }
            public int Password { get; set; }
        }





        //public class Person
        //{
        //    public string name { get; set; }
        //    public int age { get; set; }
        //    public string city { get; set; }
        //}

    }
}
