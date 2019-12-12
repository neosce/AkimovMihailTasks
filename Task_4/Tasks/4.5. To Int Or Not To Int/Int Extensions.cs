using System;

namespace Task_4.Tasks._4._5._To_Int_Or_Not_To_Int
{
    public static class Int_Extensions
    {

        private static int CharToInt(char c)
        {
            return c - '0';
        }

        public static bool ToInt(this string value)
        {
            if (value == null)
            {
                throw new ArgumentException();
            }
            if (value.Length == 0)
            {
                throw new ArgumentException();
            }
            if (value[0] == '0' && value[1] == '0')
            {
                return true;
            }

            int numberConvert = 1;
            bool isPlus = default;
            int i = 0;

            switch (value[0])
            {
                case '-':
                    numberConvert *= -1;
                    isPlus = false;
                    i = 1;
                    break;
                case '+':
                    isPlus = true;
                    break;
            }

            for (; i < value.Length; i++)
            {
                if (isPlus == false)
                {
                    //numberConvert = checked(numberConvert * 10 + CharToInt(value[i]));
                    return false;
                }
                else if (value[i] == ',' || value[i] == '.')
                {
                    return false;
                }
            }
            //Console.WriteLine(numberConvert);
            return true;
        }

    }
}
