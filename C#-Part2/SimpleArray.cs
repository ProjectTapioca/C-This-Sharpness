using System;

namespace EssentialTraining
{
	class SimpleArray
	{
		//Instance variable called grocery list and it's a string array
		public string[] GroceryList; //property that consist a list of strings
		

		//Constructor for Grocery
		public SimpleArray()
		{
			GroceryList = new string[4] {"Bread", "Milk", "Eggs", "Cheese" };
		}

		public override string ToString()
		{
			return "There are " + GroceryList.Length + " and they are: " + GroceryList.ToString();
		}

	}
}