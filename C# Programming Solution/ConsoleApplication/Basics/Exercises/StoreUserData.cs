namespace ConsoleApplication.Basics.Exercises
{
    public class StoreUserData
    {
        public void Demo()
        {
            var name = "Bala";
            var mobileNo = "0123456789"; //can't be stored as int because 0 at starting with be truckated.
            var age = 22;

            Console.WriteLine(name);
            Console.WriteLine(mobileNo);
            Console.WriteLine(age);
        }
    }
}
