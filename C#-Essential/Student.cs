using System;

namespace SchoolLibrary
{
	public class Student : Person
	{
		public enum GradeLevels { Freshman, Sophmore, Junior, Senior }
		public GradeLevels GradeLevel { get; set; }

		public override float ComputeGradeAverage()
		{
			return 4.0f; //testing purposes for now
		}

		//This is what virtual methods are for, we're still using the original message but we're just adding something this time
		public override SendMessage(string message)
		{
			var original = base.SendMessage(message);
			var sb = new StringBuilder(original);
			sb.AppendLine("This message is private and confidential.");
			return sb.ToString();
		}
	}
}
