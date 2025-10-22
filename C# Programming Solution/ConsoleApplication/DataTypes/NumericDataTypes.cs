namespace ConsoleApplication.DataTypes
{
    public class NumericDataTypes
    {
        public void PrintMaxAndMinValues()
        {
            Console.WriteLine("Integer Values: ");
            int age = 22;
            Console.WriteLine("Ex:- " + age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            Console.WriteLine("\nLong Values: ");
            long longNumber = 900000L;
            Console.WriteLine("Ex:- " + longNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            Console.WriteLine("\nDouble Values: ");
            double neagtive = -55.2D;
            Console.WriteLine("Ex:- " + neagtive);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            Console.WriteLine("\nFloat Values: ");
            float precision = 5.000001F;
            Console.WriteLine("Ex:- " + precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            Console.WriteLine("\nDecimal Values: ");
            decimal money = 14.99M;
            Console.WriteLine("Ex:- " + money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
        }
    }
}
