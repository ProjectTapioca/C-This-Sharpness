using System;

namespace EssentialTraining
{
	public class DictionaryWords
	{
		//Dicitonary consisting of a key value pair 
		var dictionaryWords = new Dictionary<string, string>();
		dictionaryWords.Add("Var", "shorthand for variable");
		dictionaryWords["var"];

		//Output will be "shorthand for variable"

		dictionaryWords.Add("function", "something thta does work on data");
		dictionaryWords.Add("variable", "a container for data");
		
	}
}