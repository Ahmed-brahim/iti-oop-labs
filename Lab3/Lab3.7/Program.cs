namespace Lap3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int imag = 0, real = 0;
            char c = 'a';   
            Complex complex = new Complex();
            bool flag, flag1 = false;
            do
            {
                Console.Clear();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("******Welcome To  Complex numbers App******");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("enter imaginary part: ");
                #region scan real
                do
                {
                    Console.Write("enter real part: ");
                    flag = int.TryParse(Console.ReadLine(), out int temp);
                    if (flag)
                    {
                        real = temp;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                } while (!flag);
                #endregion
                #region scan imaginary
                do
                {
                    flag = int.TryParse(Console.ReadLine(), out int temp);
                    if (flag)
                    {
                        imag = temp;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                } while (!flag);
                #endregion
                complex.Real = real;    
                complex.Imag = imag;
                #region print
                Console.ForegroundColor = ConsoleColor.Green;
                complex.Print();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("do you want to try it again? (y/n)");
                #endregion
                #region scan choice
                do
                {
                    Console.Write("Enter Your Choice: ");
                    flag = char.TryParse(Console.ReadLine(), out c);
                    if (flag)
                    {
                        switch (c)
                        {
                            case 'Y':
                                flag1 = true;
                                break;
                            case 'y':
                                flag1 = true;
                                break;
                            case 'N':
                                flag1 = false;
                                break;
                            case 'n':
                                flag1 = false;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                } while (!flag);
                #endregion

            } while (flag1);
        }
    }
}
