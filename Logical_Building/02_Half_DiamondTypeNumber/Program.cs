namespace _02_Half_DiamondTypeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 4;

            for (int i = 1; i <= rows; i++)
            {
                int count = 1;

                for (int j = 1; j <= 2 * rows - 1; j++)
                {

                    if (rows - i + 1 > j)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        if (j < rows && count != 0)
                        {
                            Console.Write($"{count++} ");
                        }
                        else if (count != 0)
                        {
                            Console.Write($"{count--} ");
                        }
                        else
                        {
                            break;
                        }

                    }

                }
                Console.WriteLine();
            }

        }
    }
}
