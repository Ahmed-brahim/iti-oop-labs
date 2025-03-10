namespace lap1._4
{
    internal class Program
    {
        //operator search
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Console.WriteLine($"We have 2 numbers x = {x}& y = {y}");
            Console.WriteLine("***arithmetic operators like {+, -, *, /, %, ++, --}***");
            Console.WriteLine($"x + y = {x + y}\nx - y = {x - y}\nx * y = {x * y}");
            Console.WriteLine($"x / y = {(float)x / y}\nx % y = {x % y}\nx++ = {x++}\ny-- = {y--}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("***Comparison operators like{>, <, >=, <=, ==, !=}***");
            Console.WriteLine($"x > y = {x > y}\nx < y = {x < y}\nx == y = {x == y}\nx != y = {x != y}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("***Assignment operators like{= , +=, -=, *=, /*, etc}");
            Console.WriteLine($"x += 10  => x = x + 10\nx *= 10  => x = x * 10");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Logical operators like {&&, ||, !}");
            Console.WriteLine($"true && false = {true && false}\ntrue && true = {true && true}");
            Console.WriteLine($"true || false = {true || false}\nfalse || false = {false || false}\n!true = {!true}");



        }
    }
}
