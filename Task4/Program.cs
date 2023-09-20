namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 1_000_000;
            Random random = new Random();
            int[] array = new int[size];
            Parallel.For(0, size, (i) => array[i] = random.Next(1, 10));

            ParallelQuery<int> odds = from elem in array.AsParallel()
                                      where elem % 2 != 0
                                      select elem;

            foreach (int element in odds)
                Console.Write(element + " ");
        }
    }
}