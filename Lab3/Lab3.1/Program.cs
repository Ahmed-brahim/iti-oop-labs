namespace Lap3._1
{
    internal class Program
    {
        static long Fac(int n) 
        { 
            if(n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * Fac(n - 1);
            }
        }
        static void Main(string[] args)
        {
            int n = 0;
            char c = 'a';   
            bool flag, flag2, flag3 = false;
            
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Welcome To Factorial Calculator");
                Console.ForegroundColor = ConsoleColor.White;
                #region scan num
                do
                {
                    Console.Write("Enter a Positive Number: ");
                    flag = int.TryParse(Console.ReadLine(), out int temp);
                    if (flag)
                    {
                        if (temp >= 0)
                        {
                            n = temp;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                } while (!flag);
                #endregion
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"the Factorial for {n}! = {Fac(n)}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Do you want to try another number? (y/n)");
                #region scan choice
                do
                {
                    Console.Write("Enter Your Choice: ");
                    flag2 = char.TryParse(Console.ReadLine(),out c);
                    if(flag2)
                    {
                        switch(c)
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
                }while (!flag2);
                #endregion

            } while (flag3);

        }
    }
}
