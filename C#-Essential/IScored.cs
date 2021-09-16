using System;

namespace SchoolLirary
{
	//This is an interface, you define the properties and methods that we want
	//to appear on our objects that implement this interface.
	public interface IScored
	{
		float Score { get; set; }
		float MaximumScore { get; set; }
		
	}
}
