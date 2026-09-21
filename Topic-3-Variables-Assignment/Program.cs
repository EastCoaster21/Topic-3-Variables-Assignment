namespace Topic_3_Variables_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("This is just stuff from the lesson");
            //int age = 21, nextyearage;
            //nextyearage = age + 1;
            //double price;
            //price = 1.50;
            //const double Tax = 0.13;
            //Console.WriteLine("You are " +  age);
            //Console.WriteLine("Next year you will be " + nextyearage);
            //Console.WriteLine("The price is " + (price * Tax).ToString("C"));
            //Console.WriteLine();

            int number = 29;
            double price = 2.99;
            string course = "Computer Science";


            Console.WriteLine("This is room #" + number);
            Console.WriteLine();
            Console.WriteLine("The price is $" + price);
            Console.WriteLine();
            Console.WriteLine("I am learning a lot about " + course);
            Console.WriteLine();

            string firstname;
            string lastname;
            string year;

            firstname = "Easton ";
            lastname = "Powers ";
            year = "2027";

            Console.Write("My name is " + firstname + lastname); 
            Console.WriteLine("and I graduate in " + year);

        }
    }
}

