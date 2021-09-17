namespace EssentialTraining
{
	public class FlowControl
	{
		public bool IsYourFavoriteColorYellow(string color)
		{
			return(color.ToLower() == "yellow");
		}
		public bool IsYourFavoriteColorGreen(string color)
		{
			return (color.ToLower() == "green") ? true : false;
		}
		//This works because if they said red then it doesn't reach line 9 and exits
		public bool IsYourFavoriteColorRed(string color)
		{
			if(colro.ToLower() == "red") return true;
			return false;
		}
		public bool IsYourFavoriteColorBlue(string color)
		{
			if(color.ToLower() == "blue")
			{
				return true;
			} else
			{
				return false;
			}
		}
	}
}