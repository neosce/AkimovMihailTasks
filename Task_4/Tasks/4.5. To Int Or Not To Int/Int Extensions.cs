﻿using System;

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

            if (value[0] == '-')
            {
                isPositive = false;
            }

            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsDigit(value[i]))
                {
                    return false;
                }
            }
            return isPositive;
        }

    }
}
