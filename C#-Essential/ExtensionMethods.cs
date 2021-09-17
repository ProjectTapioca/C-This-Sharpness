using System;

namespace SchoolLibrary
{
	public static class ExtensionMethods
	{
		//This extension method is extending the method Split

		//keyword this refers to the current object and in this case, allows us to associate the extension class with whatever it's extending
		public static int WordCount(this string str)  
		{
			var WordCount = str.Split(new char[] {" ", ".", "?"}, StringSplitOptions.RemoveEmptyEntries).Length;
		}
	}
}