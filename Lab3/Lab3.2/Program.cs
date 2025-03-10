namespace Lap3._2
{
    internal class Program
    {
        static double power(int x, int y)   //can calculate if power is positive or negative
        {
            if (y == 0)
                return 0;
            double result = 1;
            if(y > 0)
            {
                for (int i = 0; i < y; i++)
                {
                    result *= x;
                }
            }
            else
            {
                result = 1 / (power(x, y * -1));
            } 
            return result;
        }

        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0; 
            char c = 'a';
            bool flag, flag2, flag3 = false;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Welcome To Power Calculator");
                Console.ForegroundColor = ConsoleColor.White;

                #region scan num1
                do
                {
                    Console.Write("Enter the base Value: ");
                    flag = int.TryParse(Console.ReadLine(), out int temp);
                    if (flag)
                    {
                        n1 = temp;  
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                } while (!flag);
                #endregion

                #region scan num2
                do
                {
                    Console.Write("Enter the Power Value: ");
                    flag = int.TryParse(Console.ReadLine(), out int temp);
                    if (flag)
                    {
                        n2 = temp;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                } while (!flag);
                #endregion

                #region show result
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"the Result for {n1}^{n2} = {power(n1,n2)}");
                Console.ForegroundColor = ConsoleColor.White;
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
