namespace Loops;
class Program
{
    static void Main(string[] args)
    {
        // Exercise A
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(i);
        }

        // Exercise B
        for (int i = 0; i < 100; i++)
        {
            if (i < 50)
            {
                Console.WriteLine(i);
            }
        }

        // Exercise C
        int iterator = 0;
        while (iterator < 100)
        {
            Console.WriteLine(iterator);
            iterator++;
        }

        // Exercise D
        for (int i = 100; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
    }
}