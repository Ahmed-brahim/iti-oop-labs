namespace Lap3._3
{
    internal class Program
    {
        static bool isPrime(int n)
        {
            if(n < 2)
                return false;
            for(int i = 2; i <= (n / 2); i++) // (n/2) for optimization
            {
                if(n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int n = 0;
            char c = 'a';   
            bool flag, flag2 , flag3= false;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("******Welcome To Check Prime Numbers App******");
                Console.ForegroundColor = ConsoleColor.White;
                #region scan num1
                do
                {
                    Console.Write("Enter the Number: ");
                    flag = int.TryParse(Console.ReadLine(), out int temp);
                    if (flag)
                    {
                        n = temp;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                } while (!flag);
                #endregion
                #region show result
                if(isPrime(n))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{n} is Prime");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{n} not Prime");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("Do you want to try another number? (y/n)");
                #endregion
                #region scan choice
                do
                {
                    Console.Write("Enter Your Choice: ");
                    flag2 = char.TryParse(Console.ReadLine(), out c);
                    if (flag2)
                    {
                        switch (c)
                        {
                            case 'Y':
                                flag3 = true;
                                break;
                            case 'y':
                                flag3 = true;
                                break;
                            case 'N':
                                flag3 = false;
                                break;
                            case 'n':
                                flag3 = false;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                } while (!flag2);
                #endregion
            } while (flag3);

        }
    }
}
