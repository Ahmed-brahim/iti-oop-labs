namespace Lap3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag, flag1 = false;
            char c = 'a';   
            Point p1 = new Point();
            do
            {
               Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("******Welcome To Point App******");
                Console.ForegroundColor = ConsoleColor.White;
                #region scan X
                do
                {
                    Console.Write("enter your X axis: ");
                    flag = int.TryParse(Console.ReadLine(), out int temp);
                    if (flag)
                    {
                       p1.X = temp;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                } while (!flag);
                #endregion
                #region scan y
                do
                {
                    Console.Write("enter your y axis: ");
                    flag = int.TryParse(Console.ReadLine(), out int temp);
                    if (flag)
                    {
                        p1.Y = temp;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                } while (!flag);
                #endregion
                #region print
                Console.ForegroundColor = ConsoleColor.Green;
                p1.Print();
                Console.ForegroundColor= ConsoleColor.White;
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
