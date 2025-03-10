namespace Lap3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c = 'a';
            int n = 0;
            float amount = 0;
            bool flag, flag1 = false;   
            BankAccount account = new BankAccount("Ahmed Ibrahim",50000);
            do
            {
                #region Show Menu
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("*********Welcome To Bank System*********");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("1.Print\n2.Deposit\n3.WithDraw");
                Console.ForegroundColor = ConsoleColor.White;
                #endregion
                #region scan number for operation
                do
                {
                    Console.Write("enter your choice: ");
                    flag = int.TryParse(Console.ReadLine(), out int temp);
                    if (flag)
                    {
                        if(temp == 1 || temp == 2 || temp == 3)
                            n = temp;
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
                #region operation
                switch (n)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        account.print();
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 2:
                        #region scan number for deposit
                        do
                        {
                            Console.Write("enter your amount to deposit: ");
                            flag = float.TryParse(Console.ReadLine(), out float temp);
                            if (flag)
                            {
                                    amount = temp;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input");
                            }
                        } while (!flag);
                        #endregion

                        account.Deposit(amount);
                        break;
                    case 3:
                        #region scan number for withdraw
                        do
                        {
                            Console.Write("enter your amount to withdraw: ");
                            flag = float.TryParse(Console.ReadLine(), out float temp);
                            if (flag)
                            {
                                amount = temp;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input");
                            }
                        } while (!flag);
                        #endregion

                        account.Withdraw(amount);
                        break;
                }
                #endregion
                Console.WriteLine("Do You want to make another operation? (y/n)"); 
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
