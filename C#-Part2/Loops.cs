namespace EssentialTraining
{
    class ProgrammingLoops
    {
        public string BreakAndContinue()
        {
          var sb = new Stringbuilder();
          var words = new List<string>() {"Bread", "Milk", "Eggs", "Cheese", "Apples"};
          foreach(var word in words)
          {
            //This is saying that if a word in words start with the letter M, then skip everything underneath and go back around the loop one more time
            if(word.Startswith("M")) continue;
            
            if (word.Startswith("C")) break;
            
            sb.AppendLine(word);
          }
          return sb.ToString();
        }
        public int DoWhileLoop()
        {
          var sum = 0;
          var counter = 0;
          do
          {
            sum += counter;
            counter++;
          }while (counter < 100);
          return sum;
        }
        public int WhileLoop()
        {
          var sum = 0;
          var counter = 0;
          while (counter < 100)
          {
            sum += counter;
            counter++;
          }
          return sum;
        }
        public int ForEachLoop()
        {
            var numbers = new List<int>() { 1, 3, 5, 7, 9 };
            var sum = 0;
            foreach (var number in numbers) //It looks at the list called numbers and for each 'number' in 'numbers' it runs it in the code below
            {
                sum += number;
            }

            return sum;
        }
        public void ForLoop()
        {
            var sum = 0;
            for (var i = 0; i < 100; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}
