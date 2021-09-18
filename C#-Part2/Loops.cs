namespace EssentialTraining
{
    class ProgrammingLoops
    {
        public in WhileLoop
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