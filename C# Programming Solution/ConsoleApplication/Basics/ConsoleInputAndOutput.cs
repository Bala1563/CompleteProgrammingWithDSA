namespace ConsoleApplication.Basics
{
    public class ConsoleInputAndOutput
    {
        public void Demo()
        {
            //Console.WriteLine("Hello, My name is Bala");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            //string age = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Your name is ");
            //Console.Write(name);
            //Console.Write("and age is ");
            //Console.Write(age);

            Console.WriteLine();

            Console.WriteLine("Your name is " + name + " and age is " + age);
        }
    }
}
