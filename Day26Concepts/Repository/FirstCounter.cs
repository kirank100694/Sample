namespace Day26Concepts.Repository
{
    public class FirstCounter : IFirstCounter
    {
        private readonly ICount count;

        public FirstCounter(ICount count)
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
