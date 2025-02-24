namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount of numbers in the array: ");
            int amount = int.Parse(Console.ReadLine());
            int[] array = new int[amount];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter a number: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter a number you are seeking: ");
            int target = int.Parse(Console.ReadLine());
            Search(array, target);
        }
        static void Search(int[] array, int target)
        {
            int left = 0, count=0;
            List<int> list = new List<int>();
            int right = array.Length-1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (array[mid] == target)
                {
                    count++;
                    list.Add(mid);
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            Console.WriteLine($"The number is seen {count} amount of times");
            Console.WriteLine($"It is seen in positions: {string.Join(", ", list)}");
        }
    }
}
