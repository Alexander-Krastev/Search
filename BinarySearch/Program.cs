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
            List<int> list = Search(array, target);
            Console.WriteLine($"The number you were after is seen {list.Count} amount of times in positions: {string.Join(", ", list)}");
        }
        static List<int> Search(int[] array, int target)
        {
            int left = 0, count=0;
            List<int> list = new List<int>();
            int right = array.Length-1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (array[mid] == target)
                {
                    
                    list.Add(mid);
                    break;
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
            if (list.Count > 0)
            {
                int i = list[0];
                list.Clear();
                while (i >= 0 && array[i] == target)
                {
                    --i;
                }
                i++;
                while (i < array.Length && array[i] == target)
                {
                    list.Add(i);
                    i++;
                }
            }
            return list.Count != 0 ? list : null;
            
            
            
        }
    }
}
