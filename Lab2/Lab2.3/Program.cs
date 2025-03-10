namespace Lap2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            long Fac = 1;
            bool flag = false;
            do
            {
                Console.WriteLine("Please Enter a number: ");
                flag = int.TryParse(Console.ReadLine(), out int temp);
                {
                    if(flag)
                    {
                        num = temp;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            } while (!flag);
            
            for(int n = num; n > 0; n--)
            {
                //calculate factorial 
                Fac = Fac * n;
            }
            Console.WriteLine($"Factorial for {num}! = {Fac}");
        }
    }
}
