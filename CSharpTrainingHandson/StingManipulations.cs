using System;
namespace CSharpTrainingHandson
{
	public class StingManipulations
	{
		public static void Main(string[] args)
		{
			String myName = "Venu Madhav Pendurthi";
			Console.WriteLine("Given Name is: "+ myName);

			//Calculating the length of the string using String.Length

			Console.WriteLine("String Length = " +myName.Length);

			//Converting the entire string to upper case using String.ToUpper()

			Console.WriteLine("Converting string to uppercase: "+myName.ToUpper());

            //Converting the entire string to lower case using String.ToLower()

            Console.WriteLine("Converting string to lowercase: " + myName.ToLower());

			//To find the index of given substring we use IndexOf, this will return the first occurance of given sub-string

			Console.WriteLine("Finding the first occurance of 'u' = " + myName.IndexOf('u'));

            //To find the last index of given substring we use LastIndexOf, this will return the last occurance of given sub-string

            Console.WriteLine("Finding the last occurance of 'a' = " + myName.LastIndexOf('a'));

			//To get the sub string from given string within given range.

			Console.WriteLine("First 4 letters of given name =  "+myName.Substring(0,4));


            //To get the sub string from given string within given range and specific starting position.

            Console.WriteLine("Deriving the middle name from given name =  " + myName.Substring(5, 6));

			// To return the first half of given string that mean this will run till the first space

			Console.WriteLine(myName.Substring(0,myName.IndexOf(' ')));

            //return The last string

            Console.WriteLine(myName.Substring(myName.LastIndexOf(' ')+1));
        }

	
	}
}

