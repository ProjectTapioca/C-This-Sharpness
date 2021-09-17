using System;

namespace SchoolLibrary
{
	public class School
	{
		//These are Auto Properties that does not require logic
		public string Name { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string PhoneNumber { get; set; }

		//This is a backing variable
		private string _twitterAddress;
		//Auto property have logic
		public string TwitterAddress

		{	//property declaration that manipulates the backing variable
			//make sure the twitter address starts with @
			get { return _twitterAddress; } //getter that returns the backing variable
			set //checking and making sure the backing variable starts with an @
			{
				if(value.StartsWith("@"))//value is a variable that just exists in the language and works within
				//the context of getters and setters when you are creating your Properties
				{
					_twitterAddress = value;
				}	else
				{
						throw new Exception("The twitter address must begin with @");
				}
			}
		}//The following is a constructor, it gives the properties a placeholder value
		public School()
		{
			Name = "Untitle School";
			PhoneNumber = "555-1234";

		}

		public School(string SchoolName, string SchoolPhoneNumber)
		{
			Name = SchoolName;
			PhoneNumber = SchoolPhoneNumber;
		}
		//Below are methods, paranthesese you are calling a method on an object rather than dealing with a property

		public static float AverageThreeScores( float a, float b, float c)
		{
			var result = (a +  + c) / 3;
			return result;
		}

		public static int AverageThreeScores(int a, int b, int c)
		{
			var result = (a + b + c) / 3;
			return result;
		}

		//This is a different way of writing methods called Function Bodied Expression
		//Not recommended for complicated methods, only meant for simple logic
		/*
		public float AverageThreeScores(float a, float b, float c) => (a + b + c) /3;
		*/

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine(Name);
			sb.AppendLine(Address);
			sb.AppendLine(City);
			sb.Append(", ");
			sb.Append(State);
			sb.Append(" ");
			sb.Append(Zip);

			return base.ToString();
		}
	}
}
