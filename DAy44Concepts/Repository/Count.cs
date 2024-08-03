namespace DAy44Concepts.Repository
{
    public class Count : ICount
    {
        private int count;

        public void Increment() => count++;

        public int Get() => count;
    }
}
