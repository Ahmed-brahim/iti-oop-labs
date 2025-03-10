namespace Lap2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int sum = 0;
            bool flag = false;
            //input the five numbers
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    Console.Write($"input number {i + 1} => ");
                    flag = int.TryParse(Console.ReadLine(), out int temp);
                    if (flag)
                    {
                        num = temp;
                        sum += num;  //calculate the sum
                    }
                    else
                    {
                        Console.WriteLine("invalid input");
                    }

                } while (!flag);
            }
            Console.WriteLine($"Sum of the 5 numbers = {sum}"); //print the sum
        }
    }
}
