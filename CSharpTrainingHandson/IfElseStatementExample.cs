using System;
namespace CSharpTrainingHandson
{
	public class IfElseStatementExample
	{
		public static void Main(string[] args)
		{
			int hour = DateTime.Now.Hour;

			if (hour < 12)
			{
				Console.WriteLine("Good Morning!");
			}
			else if (hour < 16)
			{
				Console.WriteLine("Good Afternoon");
			}
			else
			{
				Console.WriteLine("Good Evening");
			}

			String day = DateTime.Now.DayOfWeek.ToString();
			Console.WriteLine("Today is: " + day);

			String day_s = day.Substring(0, 3).ToLower();

			if (day_s == "sum" || day_s == "sat")
			{
				Console.WriteLine("Today is a weekend");
			}
			else { Console.WriteLine(day + " is a weekday"); }

		}
	}
}

