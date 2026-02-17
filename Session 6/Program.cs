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
            
        }
    }
}
