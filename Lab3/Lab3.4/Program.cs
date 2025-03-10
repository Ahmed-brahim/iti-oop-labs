namespace Lap3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp e1 = new Emp();
            char c = 'a';   
            bool flag , flag1= false;

            do 
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("******Welcome To Employee system App******");
                Console.ForegroundColor = ConsoleColor.White;
                #region Scan Name
                Console.Write("Enter Employee Name: ");
                Console.ReadLine();
                #endregion
                #region scan Age
                do
                {
                    Console.Write("Enter Employee Age: ");
                    flag = int.TryParse(Console.ReadLine(), out int temp);
                    if (flag)
                    {
                        e1.Age = temp;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                } while (!flag);
                #endregion
                #region scan Salary
                do
                {
                    Console.Write("Enter Employee Salary: ");
                    flag = float.TryParse(Console.ReadLine(), out float temp);
                    if (flag)
                    {
                        e1.Salary = temp;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                } while (!flag);
                #endregion
                #region print
                Console.ForegroundColor = ConsoleColor.Green;
                e1.print();
                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine("Do you want to try add another employee");
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
