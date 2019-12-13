using System;

namespace Task_4.Tasks._4._5._To_Int_Or_Not_To_Int
{
    public static class Int_Extensions
    {

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
            if (value[0] == '0')
            {
                throw new ArgumentException();
            }
            if (value[0] == 1 && value.Length == 1)
            {
                return true;
            }

            bool isPositive = true;
            int i = 0;

            if (value[0] == '-')
            {
                isPositive = false;
                i = 1;
            }

            for (; i < value.Length; i++)
            {
                if (!char.IsDigit(value[i]))
                {
                    throw new ArgumentException();
                }
            }
            return isPositive;
        }

    }
}
