namespace lap1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int choice = 0;
            Console.WriteLine("Welcome To Calculator App");
            bool flag1 = false;
            bool flag2 = false;
            bool flag3 = false;
            do
            {
                Console.Write("Plz enter the first number: ");
                flag1 = int.TryParse(Console.ReadLine(), out int temp1);
                if (flag1)
                {
                    x = temp1;
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }while (!flag1);
            do
            {
                Console.Write("Plz enter the second number: ");
                flag2 = int.TryParse(Console.ReadLine(), out int temp2);
                if (flag2)
                {
                    y = temp2;
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }while (!flag2);
            
            Console.WriteLine("choose operation:\n1.Add(+)\n2.Sub(-)\n3.Multiply(*)\n4.Division(/)\n5.All Operations");
            do
            {
                Console.Write("enter your choice :");
                flag3 = int.TryParse(Console.ReadLine(), out int temp3);
                if (flag3)
                {
                    choice = temp3;
                    if(choice > 5 || choice < 1)
                    {
                        Console.WriteLine("plz enter number from 1 to 5");
                        flag3 = false;
                    }
                }
                else
                {
                    Console.WriteLine("invalid Choice");
                }
            } while (!flag3);
            if(choice == 1 || choice == 5)
            {
                Console.WriteLine($"{x} + {y} = {x + y}");
            }
            if (choice == 2 || choice == 5)
            {
                Console.WriteLine($"{x} - {y} = {x - y}");
            }
            if (choice == 3 || choice == 5)
            {
                Console.WriteLine($"{x} * {y} = {x * y}");
            }
            if (choice == 4 || choice == 5)
            {
                if(y == 0)
                {
                    Console.WriteLine("invalid operation => \"Cant divide by zero\"");
                }
                else
                {
                    Console.WriteLine($"{x} / {y} = {(float)x / y}");
                }
            }
        }
    }
}
