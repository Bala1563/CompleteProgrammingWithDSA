namespace ConsoleApplication.DataTypes
{
    public class TextToNumericConversion
    {
        // Here this Convert class will throw runtime exception when instead of numbers any other values are passed in the text.
        public void ConvertTextToNumericValues()
        {
            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textLongNumber = "-900000000";
            long longNumber = Convert.ToInt64(textLongNumber);
            Console.WriteLine(longNumber);

            string textNegative = "-55.2";
            double doubleNumber = Convert.ToDouble(textNegative);
            Console.WriteLine(doubleNumber);

            string textPrecision = "5.0000001";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);

            string textMoney = "14.99";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);
        }
    }
}
