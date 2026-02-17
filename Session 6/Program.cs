namespace Session_6
{
    internal class Program
    {
        class Person
        {

            private string Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public Person()
            {
                Name = "Unknown";
                Age = 0;
            }
            public override string ToString()
            {
                return $"Name: {Name}, Age: {Age}";
            }

        }
        struct Person2
        {
            public string Name { get; set; }
            public int Age { get; set; }


            public Person2(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public Person2()
            {
                Name = "Unknown";
                Age = 0;
            }
            override public string ToString()
            {
                return $"Name: {Name}, Age: {Age}";
            }
        }
        static void Main(string[] args)
        {
            #region P1 Q1
            Person p1c = new Person("Ahmed", 25);
            Person p2c = p1c;
            Person2 p1s = new Person2("Ahmed", 25);
            Person2 p2s = p1s;

            Console.WriteLine($"Person 1 class -> {p1c}");
            Console.WriteLine($"Person 2 class -> {p2c}");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Person 1 struct -> {p1s}");
            Console.WriteLine($"Person 2 struct -> {p2s}");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");

            // Modifying p1c and p1s
            p1c.Name = "Mohamed";
            p1c.Age = 30;
            p1s.Name = "Mohamed";
            p1s.Age = 30;

            Console.WriteLine($"Person 1 class -> {p1c}");
            Console.WriteLine($"Person 2 class -> {p2c}");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Person 1 struct -> {p1s}");
            Console.WriteLine($"Person 2 struct -> {p2s}");

            /* Explanation:
             * So the Class is reference type, when we assign p1c to p2c, both variables point to the same object in memory.
             * while the Struct is value type, when we assign p1s to p2s, a copy of the data is created.
             */

            #endregion
            #region P1 Q2
            /* Person p = new Person("Ahmed", 25);
             * p.Id = "12345"; // This will cause a compile error
             * p.Name = "Ahmed"; // This is fine
            */
            /* When we try to access the Id property of the Person class
             * we will get a compile-time error because it is private and cannot be accessed from outside the class
             * while the Name and Age properties are public and can be accessed without any issues
             */
            #endregion
            #region P1 Q3
            /*
             * Create Class Library project
             * Make sure the class library is public
             * Build the Class Library project to generate the DLL file
             * Add the reference of the Class Library project to the Main project
             * add the Using namespace of the class Library project to the Main project
             * 
             */
            #endregion
            #region P1 Q4
            /*
             * Class Library is a project that contains reusable code that can be shared across multiple projects
             * we use it to organize the code and to make it more maintainable and reusable
             */
            #endregion
        }
    }
}
