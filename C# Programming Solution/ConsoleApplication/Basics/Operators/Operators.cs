namespace ConsoleApplication.Basics.Operators
{
    public class Operators
    {
        public void PrintValues()
        {
            int age = 23;
            age += 10;
            Console.WriteLine(age);

            age -= 10;
            Console.WriteLine(age);

            age *= 2;
            Console.WriteLine(age);

            age /= 10;
            Console.WriteLine(age);

            age++;
            Console.WriteLine(age);

            age--;
            Console.WriteLine(age);

            string name = "Bala";
            name += " is programming";
            Console.WriteLine(name);

            // this sums up the ascii values and get new char of the ascii value.
            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            int i = 0, j = 0;
            Console.WriteLine(i++); // post-increament -> 0
            Console.WriteLine(++j); // pre-increament -> 1
        }
    }
}
