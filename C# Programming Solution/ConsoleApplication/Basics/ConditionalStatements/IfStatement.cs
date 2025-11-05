namespace ConsoleApplication.Basics.ConditionalStatements
{
    public class IfStatement
    {
        public void Demo()
        {
            /*Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            Console.WriteLine();
            Console.WriteLine("Your name is " + name + " and age is " + age);

            //if(ageInput == "18")
            //{
            //    Console.WriteLine("You are 18");
            //}

            // ==, >, <, >=, <=, != are operators used to compare.
            // || is logical OR, && is Logical AND

            if (age < 0 || age > 150)
            {
                Console.WriteLine("Invalid Age");
            }
            else
            {
                if (age >= 18 && age <= 25)
                {
                    Console.WriteLine("You are between 18 and 25");
                }
                else if (age >= 26)
                {
                    Console.WriteLine("Your are 26 or older");
                }
            }*/

            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int answer = num1 * num2;

            Console.Write("Value of " + num1 + " x " + num2 + ": ");
            int actualAnswer = Convert.ToInt32(Console.ReadLine());

            if (answer != actualAnswer)
            {
                Console.WriteLine("Close but it was wrong!");
            }
            else
            {
                Console.WriteLine("Well Done!");
            }
        }
    }
}
