namespace Lap1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char x = 'a';
            int ascii = 0;
            bool flag1 = false; 
            bool flag2 = false;
            do
            {
                Console.Write("PlzEnter your Character or equivalent ascii: ");
                string input = Console.ReadLine();
                flag1 = char.TryParse(input, out char temp);
                flag2 = int.TryParse(input, out int num);
                if (flag1 || flag2)
                {
                    if(flag1)
                    {
                        x = temp;
                        if (x < 'A' || (x > 'Z' && x < 'a') || x > 'z')
                        {
                            Console.WriteLine("Only alphabetical characters is allowed");
                            flag1 = false;
                        }
                    }
                    else
                    {
                        ascii = num;
                        if (ascii < 'A' || (ascii > 'Z' && ascii < 'a') || ascii > 'z')
                        {
                            Console.WriteLine($"Only alphabetical ascii is allowed from {(int)'A'} to {(int)'Z'} and from{(int)'a'} to {(int)'z'}");
                            flag1 = false;
                        }
                        else
                        {
                            x = (char)ascii;
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("invalid Input");
                }
            } while (!(flag1 || flag2));
            Console.WriteLine($"input => '{x}'\nAscii code for '{x}' is {(int) x}");
            if(char.IsUpper(x))
            {
                Console.WriteLine($"Your char is uppercase and its lowercase is => '{char.ToLower(x)}'");
            }
            else
            {
                Console.WriteLine($"Your char is lowercase and its uppercase is => '{char.ToUpper(x)}'");
            }
        }
    }
}
