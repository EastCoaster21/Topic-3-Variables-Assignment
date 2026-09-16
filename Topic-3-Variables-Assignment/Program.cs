namespace Topic_3_Variables_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String firstname;
            int age = 21, nextyearage;
            nextyearage = age + 1;
            double price;
            price = 1.50;
            const double Tax = 0.13;

            firstname = "Bob";
            Console.WriteLine("Hello " + firstname);
            Console.WriteLine("You are " +  age);
            Console.WriteLine("Next year you will be " + nextyearage);
            Console.WriteLine("The price is " + (price * Tax).ToString("C"));
        }
    }
}
