namespace CSharpTrainingHandson
{
    public class MyFirstClass2
    {
        public static void Main(String[] args)
        {
            int a_number = 33;
            Console.WriteLine("a_number = "+ a_number + "--> DataType of a_number is " + a_number.GetType());

            double d_double = 33.5;
            Console.WriteLine("d_double = " + d_double + "--> DataType of d_double is " + d_double.GetType());

            char c_char = 't';
            Console.WriteLine("c_char = " + c_char + "--> DataType of c_char is " + c_char.GetType());

            String s_string = "CShaerp";
            Console.WriteLine("s_string = " + s_string + "--> DataType of s_string is " + s_string.GetType());

            bool b_bool = true;
            Console.WriteLine("b_bool = " + b_bool + "--> DataType of b_bool is " + b_bool.GetType());
        }
    }
}
