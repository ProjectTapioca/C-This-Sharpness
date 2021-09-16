using System;

class Challenges
{
	public void Run()
	{
		/*var challenge = "  Text processing in C# is really great!   ";

		Console.WriteLine(challenge.Trim().Substring(24, challenge.Trim().Length - 25).ToUpper().Trim());*/

	var city = "Dallas";
	var temperature = 103.4f;
	var currentDt = DateTime.Now;
	Console.WriteLine(string.Format("Welcome to {0}.  The time is {1}. The temperature is {2}.", city,  currentDt, temperature));


	}
}
