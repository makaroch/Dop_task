namespace HelpNS
{
    class DecToBinCL
    {
        public static char[] DecToBin()
        {
            /*Написать программу преобразования десятичного числа в двоичное*/

            Console.WriteLine("Введи число");
            int x = Convert.ToInt32(Console.ReadLine());

            int y = 0;
            bool bole = true;
            string text = "";
            while (bole)
            {
                if (x / 2 != 0)
                {
                    y = x % 2;
                    x = x / 2;
                    //Console.Write(y+", ");
                    text = text + Convert.ToString(y);
                    //Console.Write(x+", ");
                }
                else
                {
                    y = x % 2;
                    x = x / 2;
                    text = text + Convert.ToString(y);
                    //Console.Write(y+", ");
                    //Console.Write(x+", ");
                    bole = false;
                }

            }
            char[] text2 = new char[text.Length];
            int j = 0;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                text2[j] = text[i];
                j++;
            }
            return text2;
        }
    }
}