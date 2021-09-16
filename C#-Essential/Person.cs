using System;

namespace SchoolLibrary
{
	public abstact class Person
	{	
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }

		/*This method will be used differently in the subclasses but we can 
		have the same name, then just override right them in their respective subclasses*/
		//So at the moment, this is just a placeholder
		public abstract float ComputerGradeAverage(); 


		//The below is a virtual method, these can be overriden in the sub-classes
		public virtual string SendMessage(string message)
		{
			var sb = new StringBuilder();
			var timeStamp = string.Format("Sent on {0:D} at {0:t}", DateTime.Now);
			sb.AppendLine(timeStamp);
			sb.AppendLine("");
			sb.AppendLine("Dear " + FirstName + ",");
			sb.AppendLine(message);
			return sb.ToString();
		}
	}
}
