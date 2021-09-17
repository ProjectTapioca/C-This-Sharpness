using System;
//This file was used in place of a REPL

namespace EssentialTraining
{
	public class Array
	{
		var groceryList = new string [4];
		groceryList[0] = "Milk";
		groceryList[1] = "Cheese";
		groceryList[2] = "Eggs";
		groceryList[3] = "Apples";

		var secondgroceryList = new string[4] { "Milk", "Eggs", "Cheese", "Apples"};

		Array.Resize(ref groceryList, 6); //This method is resizing the array from 4 to 6
		groceryList[4] = "Bread";
		groceryList[5] = "Soda";
		
		//ref keyword is a keyword in C# that allows you to pass in some variable by reference. Whatever you do here is going to effect the variable out of this method, in this case the resize method. This allows us to directly modify the method rather than overriding it outside of the class

		
	}
}