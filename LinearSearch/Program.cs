namespace LinearSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount of numbers in teh array: ");
            int amount=int.Parse(Console.ReadLine());
            int[] array = new int[amount];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter a number: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter a number you are seeking: ");
            int target=int.Parse(Console.ReadLine());   
            Search(array, target);
        }
        static void Search(int[] array, int target)
        {
            int count=0;
            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    count++;
                    list.Add(i);
                }
            }
            Console.WriteLine("The number is seen "+count+ " amount of times int the list");
            Console.WriteLine($"In the positions: {string.Join(", ", list)}");
        }
    }
}
