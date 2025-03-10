using System.Diagnostics.Metrics;

namespace Lap2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char? choice = null;
            bool flag = false;  
            bool flag2 = true;
            do
            {
                Console.Clear(); //clear console
                //print the menu
                Console.WriteLine("1.New (N/n)\n2.Display (D/d)\n3.Exit (E/e)\n");
                do
                {
                    Console.Write("Please Enter Your Choice: ");
                    flag = char.TryParse(Console.ReadLine(), out char temp);
                    if (flag)
                    {
                        choice = temp;
                        //choice validation
                        if (choice != 'N' && choice != 'n' && choice != 'D' && choice != 'd' && choice != 'E' && choice != 'e')
                        {
                            Console.WriteLine("invalid choice");
                            flag = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("invalid input");
                    }
                } while (!flag);
                switch (choice)
                {
                    case 'N':
                        Console.WriteLine("New selected");
                        break;
                    case 'n':
                        Console.WriteLine("New selected");
                        break;
                    case 'D':
                        Console.WriteLine("Display selected");
                        break;
                    case 'd':
                        Console.WriteLine("Display selected");
                        break;
                    case 'E':
                        Console.WriteLine("Exit selected");
                        flag2 = false;
                        break;
                    case 'e':
                        Console.WriteLine("Exit selected");
                        flag2 = false;
                        break;
                }
                //make delay to notice the message
                Thread.Sleep(2000);

            } while (flag2);
        }
    }
}
