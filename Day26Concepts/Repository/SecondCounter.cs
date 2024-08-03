namespace Day26Concepts.Repository
{
    public class SecondCounter : ISecondCounter
    {
        private readonly ICount count;

        public SecondCounter(ICount count)
        {
            this.count = count;
        }

        public int IncrementAndGet()
        {
            count.Increment();
            return count.Get();
        }
    }
}
