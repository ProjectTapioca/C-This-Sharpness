using System;

namespace EssentialTraining
{
	public class UseLINQ
	{
		var listOfNumbers = new int[5] { 1, 3, 5, 7, 9 };
		listOfNumbers.Sum();

		listOfNumbers.Average();

		//This gives us all the elements that are greater than 3
		listOfNumbers.Where(item => item >= 3);

	}
}