using System;

namespace SchoolLibrary
{
	//IScored is the interface that this class is inheriting
	public class ScienceExperiment : IScored
	{
		public string Hypothesis { get; set; }
		public string Materials { get; set; }
		public string Method { get; set; } //how you conduct the experiment 
		public string Conclusion { get; set; }
		public float Score { get; set; }
		public float MaximumScore { get; set; }
	}
}
