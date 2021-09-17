using System;
using System.Collections.Generic;

namespace EssentialTraining
{
	public class AwesomeSauce
	{
		//Remember that get set is just another way of getting the value and setting it to the declared variable, in this cause it is getting the value after AwesomeSauce() is ran and setting it into Sauces
		public List<string> Sauces { get; set; }

		public AwesomeSauce()
		{
			Sauces = new List<string>();
		}

		public bool IsSauceAwesome(string sauce)
		{
			return Sauces.Contains(sauce);
		}
	}
}