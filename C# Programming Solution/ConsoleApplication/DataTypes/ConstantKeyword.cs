namespace ConsoleApplication.DataTypes
{
    public class ConstantKeyword
    {
        public void Demo()
        {
            const int vat = 20;
            Console.WriteLine(vat);

            //vat = 30; this will throw a compile-time error as the value of constant can't be changed.

            const double percentVAT = vat / 100D;

            int balance = 1000;

            Console.WriteLine(balance * (vat / 100D));
            Console.WriteLine(balance * percentVAT);

            const string version = "v1.0";
            Console.WriteLine(version);
        }
    }
}
