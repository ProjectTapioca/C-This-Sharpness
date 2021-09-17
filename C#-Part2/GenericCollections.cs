using System;

namespace EssentialTraining
{
	public class EssentialTraining
	{
		//The angle brackets tell us this is a generic which means that this is a class inside of C# that can accept a type as part of its declaration
		//The one below is a list that will contain a list of strings
		var awesomeSauces = new List<string>();
		//Notice how did not have to explicity declare the size of the array. It is dynamically resizing as we add or remove
		awesomeSauces.Add("Tobasco");
		awesomeSauces.Add("Cholula");
		awesomeSauces[0]; 
		awesomeSauces.Sort();
	}
}