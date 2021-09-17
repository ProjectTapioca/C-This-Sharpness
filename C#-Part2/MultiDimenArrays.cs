using System;

namespace EssentialTraining
{
	public class MultiDimenArrays
	{
		//This is a multdimensional array set to equal a new array
		//This is saying to create an array of 3 rows each row containing 4 values
		var multi = new int[3,4]
		{
			{0,1,2,3},
			{4,5,6,7},
			{8,9,10,11}
		};
		//The above is now a multidimensional array

		//To call a position:
		//multi[2, 3]
	}
}