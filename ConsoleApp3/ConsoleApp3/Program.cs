namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //List<int> list = new List<int> { 1,2,3,4,5,6,7,8,9,10};

            //var result=list.Max(x => x);

            //Console.WriteLine(result);

            //foreach(var i  in result)
            //{
            //    Console.WriteLine(i);
            //}

            List<Student> students = new List<Student>
            {
                new Student{name="sanu",salary=15000},
                new Student{name="manu",salary=20000},
                new Student{name="mani",salary=25000 },
                new Student{name="rani",salary=21000},
                new Student{name="raj",salary=27000}
            };

            var avg=students.Average(student => student.salary);
            var result=students.Where(n=>n.salary>avg).ToList();

            foreach(var i in result)
            {
                Console.WriteLine(i.name);
            }
        }

        public class Student
        {
            public string name {  get; set; }
            public int salary {  get; set; }
        }

    }
}
