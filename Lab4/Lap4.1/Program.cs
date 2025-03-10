namespace Lap4._1
{
    internal class Program
    {
        static void myFun(Person p)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(p);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Main(string[] args)
        {
            int choice = 0;
            char ch;
            bool flag = false,flag1= false,flag2 = false;
            
            do
            {
                #region Show Menu
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("********** Welcome to Lap4.1 **********\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Choose the type of object you want to create:\n1. Person\n2. Employee\n3. Student");
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
                                Person p = new Person();
                                Console.Write("Enter the name of the person:");
                                p.SetName(Console.ReadLine());
                                #region set age
                                do
                                {
                                    Console.Write("Enter the age of the person:");
                                    flag1 = int.TryParse(Console.ReadLine(), out int age);
                                    if (!flag1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Invalid input, please try again!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    else
                                    {
                                        p.SetAge(age);
                                    }
                                } while (!flag1);
                                #endregion
                                myFun(p);
                                break;
                            case 2:
                                Employee e = new Employee();
                                Console.Write("Enter the name of the employee:");
                                e.SetName(Console.ReadLine());
                                #region set age
                                do
                                {
                                    Console.Write("Enter the age of the employee:");
                                    flag1 = int.TryParse(Console.ReadLine(), out int age);
                                    if (!flag1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Invalid input, please try again!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    else
                                    {
                                        e.SetAge(age);
                                    }
                                } while (!flag1);
                                #endregion

                                #region set salary
                                do
                                {
                                    Console.Write("Enter the salary of the employee:");
                                    flag1 = float.TryParse(Console.ReadLine(), out float salary);
                                    if (!flag1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Invalid input, please try again!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    else
                                    {
                                        e.SetSalary(salary);
                                    }
                                } while (!flag1);
                                #endregion

                                myFun(e);
                                break;
                            case 3:
                                Student s = new Student();
                                Console.Write("Enter the name of the student:");
                                s.SetName(Console.ReadLine());
                                #region set age
                                do
                                {
                                    Console.Write("Enter the age of the student:");
                                    flag1 = int.TryParse(Console.ReadLine(), out int age);
                                    if (!flag1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Invalid input, please try again!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    else
                                    {
                                        s.SetAge(age);
                                    }
                                } while (!flag1);
                                #endregion

                                #region set grade
                                do
                                {
                                    Console.Write("Enter the grade of the student:");
                                    flag1 = int.TryParse(Console.ReadLine(), out int grade);
                                    if (!flag1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Invalid input, please try again!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    else
                                    {
                                        s.SetGrade(grade);
                                    }
                                } while (!flag1);
                                #endregion

                                myFun(s);
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
                        switch (ch)
                        {
                            case 'Y':
                            case 'y':
                                flag2 = true;
                                break;
                            case 'N':
                            case 'n':
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
                
            } while (flag2);
            
        }
    }
}
