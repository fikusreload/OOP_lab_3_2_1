using System;

namespace OOP_lab_3_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int k = 0;

            foreach (char c in text)
            {
                if (Char.IsDigit(c))
                {
                    ++k;
                }
            }

            string[] words = text.Split(new char[] { '\n', '\r', ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*', '/', '|' }, StringSplitOptions.RemoveEmptyEntries);

            string tempStr = "бвгґджзйклмнпрстфхцчшщьbcdfghjklmnpqrstvwxz";

            char[] ch = tempStr.ToCharArray();

            Console.Write("\nCлова, що починаються з приголосних лiтер: ");

            foreach (string word in words)
            {
                for (int i = 0; i < ch.Length; ++i)
                {
                    if (word[0] == ch[i])
                    {
                        Console.Write("{0} ", word);

                        break;
                    }
                }
            }

            Console.WriteLine("\nKiлькiсть цифр у текстi: {0}", k);
        }
    }
}