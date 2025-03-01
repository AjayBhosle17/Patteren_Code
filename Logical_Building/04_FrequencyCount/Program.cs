using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace _04_FrequencyCount
{
    internal class Program
    {
        public static void SimpleFrequencyCount(string name)
        {
            char[] chars = name.ToCharArray();

            for (int i = 0; i < name.Length; i++)
            {
                if (chars[i] == ' ')
                {
                    continue;
                }
                int count = 1;

                for (int j = i + 1; j < name.Length; j++)
                {

                    if (chars[i] == chars[j])
                    {
                        count++;
                        chars[j] = '0';

                    }
                }
                if (chars[i] != '0')
                {
                    Console.WriteLine($"charcter {chars[i]} = {count}");

                }
            }
        }

        public static void MediumFrequencyCount(string name)
        {
            Dictionary<char, int> ch = new Dictionary<char, int>();

            foreach (char c in name.ToCharArray())
            {

                if (c != ' ')
                {
                    if (ch.ContainsKey(c))
                    {
                        ch[c]++;
                    }
                    else
                    {
                        ch[c] = 1;
                    }
                }
            }

            foreach (var c in ch)
            {
                Console.WriteLine($"charcters {c.Key} appears {c.Value}");
            }
        }

        public static void HardFrequencyCount(String name)
        {
            var data = name.GroupBy(s => s).
                       Select(s => new { charcter = s.Key, count = s.Count() });

            foreach (var item in data)
            {
                Console.WriteLine($"Character '{item.charcter}' appears {item.count} times.");
            }
        }

        static void Main(string[] args)
        {
            string name = "MynameisAbhishekabhishek";

            Console.WriteLine("1St way to find Frequency");
            SimpleFrequencyCount(name);
            Console.WriteLine();
            Console.WriteLine("2nd way to find Frequency");
            MediumFrequencyCount(name);

            Console.WriteLine();
            Console.WriteLine("3rd way to find Frequency");
            HardFrequencyCount(name);


        }
    }
}
