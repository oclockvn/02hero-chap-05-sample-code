namespace chap_05_input_output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // write to console
            Console.WriteLine("Hello World");
            Console.WriteLine("I am Quang" + Environment.NewLine + "I love swimming");
            Console.WriteLine("number {0} + number {1} = {2}", 1, 2, 3);

            // read from console
            Console.Write("Enter your name: ");
            var name = Console.ReadLine(); // <- read the value here
            Console.WriteLine("Hi, " + name);

            // 04. get a number from user and convert it to integer
            Console.Write("Enter a number: ");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number} x 2 = {number*2}");

            // 05. get a number from user and convert it to double
            Console.Write("Enter a number: ");
            var number2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{number2} x 2 = {number2*2}");

            // 06. get a number from user, use try-catch to handle if user enter a non-number
            Console.Write("Enter a number: ");
            try
            {
                var number3 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{number3} x 2 = {number3*2}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid number");
            }
            
            // 07. get 2 numbers from user and calculate the sum
            Console.Write("Enter a number: ");
            var number4 = double.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            var number5 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{number4} + {number5} = {number4 + number5}");

            // 08. get name, age, and address from user and display them
            Console.Write("Enter your name: ");
            var name2 = Console.ReadLine();
            Console.Write("Enter your age: ");
            var age = int.Parse(Console.ReadLine());
            Console.Write("Enter your address: ");
            var address = Console.ReadLine();
            Console.WriteLine($"Name: {name2}, Age: {age}, Address: {address}");

            // 09. Prompt the user to enter an integer and check if it is even or odd, then print the corresponding message.
            Console.Write("Enter a number: ");
            var number6 = int.Parse(Console.ReadLine());
            if (number6 % 2 == 0)
            {
                Console.WriteLine($"{number6} is an even number");
            }
            else
            {
                Console.WriteLine($"{number6} is an odd number");
            }

            // 10. Build a simple application that allows users to enter contact information (name, phone number, email)
            // and then displays a list of this information on the screen.
            List<Person> people = [];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter person {i+1}: ");
                var person = GetPersonInfoFromConsole();
                people.Add(person);
            }

            // print people's info to console
            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Phone: {person.Phone}, Email: {person.Email}");
            }
        }

        static Person GetPersonInfoFromConsole()
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter your age: ");
            var age = int.Parse(Console.ReadLine());
            Console.Write("Enter your phone: ");
            var phone = Console.ReadLine();
            Console.Write("Enter your email: ");
            var email = Console.ReadLine();

            return new Person
            {
                Name = name,
                Age = age,
                Phone = phone,
                Email = email
            };
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
