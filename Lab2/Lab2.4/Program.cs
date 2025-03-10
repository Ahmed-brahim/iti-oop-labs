namespace Lap2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            bool flag = false;
            long sum = 0;
            int max = int.MinValue;
            //print array before inputs
            Console.Write("Array Before inputs: ");
            foreach (int i in num) { 
                Console.Write($"{i}  ");
            }    
            for (int i = 0; i < num.Length; i++)
            {
                flag = false;    
                do
                {
                    Console.Write($"\nPlease Enter number[{i}]: ");
                    flag = int.TryParse(Console.ReadLine(), out int temp);
                    {
                        if (flag)
                        {
                            num[i] = temp;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                    }
                } while (!flag);
            }
            //print array
            Console.Write("\nArray after inputs: ");
            foreach (int i in num)
            {
                Console.Write($"{i}  ");
            }
            //calculate the sum
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            Console.WriteLine($"\n\nSum of array = {sum}");
            //find the max value
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                }
            }
            Console.WriteLine($"\nMAX value = {max}");
        }
    }
}
