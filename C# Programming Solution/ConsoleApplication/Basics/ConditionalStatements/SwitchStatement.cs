namespace ConsoleApplication.Basics.ConditionalStatements
{
    public class SwitchStatement
    {
        public void Demo()
        {
            Console.Write("Enter a day of the week (1 to 7): ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Corresponding Day for the given input is ");
            switch (day)
            {
                case 1:
                    Console.WriteLine("Sun");
                    break;
                case 2:
                    Console.WriteLine("Mon");
                    break;
                case 3:
                    Console.WriteLine("Tue");
                    break;
                case 4:
                    Console.WriteLine("Wed");
                    break;
                case 5:
                    Console.WriteLine("Thu");
                    break;
                case 6:
                    Console.WriteLine("Fri");
                    break;
                case 7:
                    Console.WriteLine("Sat");
                    break;
                default:
                    Console.WriteLine("Invalid Input, Enter a value between 1 and 7");
                    break;
            }
        }
    }
}
