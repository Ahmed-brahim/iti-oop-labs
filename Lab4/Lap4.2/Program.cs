namespace Lap4._2
{
    internal class Program
    {
        static void PrintArea(Shape s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{s}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Main(string[] args)
        {
            
            char ch;
            int choice = 0;
            bool flag2 = false,flag = false;
            do  //for repeating the program
            {
                #region Show Menu
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("********** Welcome to Lap4.2 **********\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Choose the shape you want to calculate its area:\n1. Rectangle\n2. Triangle\n3. Circle");
                #endregion
                
                do
                {
                    Console.Write("Enter your choice: ");
                    flag = int.TryParse(Console.ReadLine(), out choice);
                    if (!flag)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input, please try again!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        switch (choice)
                        {
                            case 1:
                                Rectangle r = new Rectangle();
                                #region set length
                                do
                                {
                                    Console.Write("Enter the lenght:");
                                    flag = float.TryParse(Console.ReadLine(), out float length);
                                    if (!flag || length <= 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Invalid input, please try again!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        flag = false;
                                    }
                                    else
                                    {
                                        r.SetDim1(length);
                                    }
                                } while (!flag);
                                #endregion
                                #region set width
                                do
                                {
                                    Console.Write("Enter the width:");
                                    flag = float.TryParse(Console.ReadLine(), out float width);
                                    if (!flag || width <= 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Invalid input, please try again!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        flag = false;
                                    }
                                    else
                                    {
                                        r.SetDim2(width);
                                    }
                                } while (!flag);
                                #endregion
                                PrintArea(r);
                                break;
                            case 2:
                                Triangle t = new Triangle();
                                #region set base
                                do
                                {
                                    Console.Write("Enter the base:");
                                    flag = float.TryParse(Console.ReadLine(), out float Base);
                                    if (!flag || Base <= 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Invalid input, please try again!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        flag = false;
                                    }
                                    else
                                    {
                                        t.SetDim1(Base);
                                    }
                                } while (!flag);
                                #endregion
                                #region set Height
                                do
                                {
                                    Console.Write("Enter the height:");
                                    flag = float.TryParse(Console.ReadLine(), out float height);
                                    if (!flag || height <= 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Invalid input, please try again!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        flag = false;
                                    }
                                    else
                                    {
                                        t.SetDim2(height);
                                    }
                                } while (!flag);
                                #endregion
                                PrintArea(t);
                                break;
                                case 3:
                                    Circle c = new Circle();
                                    #region set radius
                                    do
                                    {
                                        Console.Write("Enter the radius:");
                                        flag = float.TryParse(Console.ReadLine(), out float radius);
                                        if (!flag || radius <= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Invalid input, please try again!");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            flag = false;
                                        }
                                        else
                                        {
                                            c.SetDim1(radius);
                                        }
                                    } while (!flag);
                                    #endregion
                                PrintArea(c);
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid input, please try again!");
                                Console.ForegroundColor = ConsoleColor.White;
                                flag = false;
                                break;
                        }
                    }
                } while (!flag);

                #region scan choice for repeating the program
                do
                {
                    Console.Write("\nDo you want to continue? (Y/N): ");
                    flag = char.TryParse(Console.ReadLine(), out ch);
                    if (!flag)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input, please try again!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        ch = char.ToUpper(ch);
                        switch (ch)
                        {
                            case 'Y':
                                flag2 = true;
                            break;
                            case 'N':
                                flag2 = false;
                            break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid input, please try again!");
                                Console.ForegroundColor = ConsoleColor.White;
                                flag = false;
                            break;
                        }
                    }
                } while (!flag);
                #endregion
            } while (flag2); //end of repeating the program
        }
    }
}
