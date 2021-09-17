using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining

namespace EssentialTrainingTests
{
	[TestClass]
	public class SimpleArrayTest
	{
		[TestMethod]
		public void TestInstantiation()
		{
			var testInstance = new SimpleArray();
			Assert.AreEqual(testInstace.GroceryList.Length, 4);
			Assert.AreEqual(testInstace.GroceryList[1], "Milk");

		}
		[TestMethod]
		public void TestToString()
		{
			var testInstance = new SimpleArray();
			Assert.IsTrue(testInstance.ToString().StartsWith("There are"));
		}
	}
}