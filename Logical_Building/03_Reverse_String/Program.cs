namespace _03_Reverse_String
{
    internal class Program
    {

        static void Reverse_String(string s)
        {
            char[] chars = s.ToCharArray();
            string reversed = null;
            for (int i = s.Length - 1; i >= 0; i--)
            {

                reversed += chars[i];

            }
            Console.WriteLine($"Reversed string : {reversed}");

        }
        static void Main(string[] args)
        {
            string str = "abcd1234";
            Console.WriteLine($"Original string {str}");

            Reverse_String(str);
            char[] chars = str.ToCharArray();
            int sum = 0;
            foreach (char c in chars)
            {
                if (c>='0' && c <= '9')
                {
                    sum += c-'0';
                }
            }
            Console.WriteLine($"sum is : {sum}");
        }
    }

    
}
