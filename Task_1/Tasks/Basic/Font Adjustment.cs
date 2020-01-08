using System;

namespace Task_1.Tasks.Basic
{
    [Flags]
    enum FontStyle : short
    {
        none = 1,
        bold = 2,
        italic = 4,
        inderline = 8
    }

    public class Font_Adjustment
    {

        public static void font_adjustment()
        {
            format_change();

            Console.WriteLine();
        }

        private static void format_change()
        {

            FontStyle fontStyle = new FontStyle();

            int n;

            do
            {

                if (!fontStyle.HasFlag(FontStyle.none) && !fontStyle.HasFlag(FontStyle.bold) && !fontStyle.HasFlag(FontStyle.inderline) && !fontStyle.HasFlag(FontStyle.italic))
                {
                    fontStyle = FontStyle.none;
                }

                Console.WriteLine($"Параметры надписи: {fontStyle}");
                Console.WriteLine("Введите:\n" + "1: Bold\n2: italic\n3: underline\n0: Exit");

                n = int.Parse(Console.ReadLine());

                if (n == 1)
                {
                    if (fontStyle.HasFlag(FontStyle.none))
                    {
                        fontStyle = FontStyle.bold;
                    }
                    else
                    {
                        fontStyle ^= FontStyle.bold;
                    }
                }
                else if (n == 2)
                {
                    if (fontStyle == FontStyle.none)
                    {
                        fontStyle = FontStyle.italic;
                    }
                    else
                    {
                        fontStyle ^= FontStyle.italic;
                    }
                }
                else if (n == 3)
                {
                    if (fontStyle == FontStyle.none)
                    {
                        fontStyle = FontStyle.inderline;
                    }
                    else
                    {
                        fontStyle ^= FontStyle.inderline;
                    }
                }
                // I don’t understand why if fontstyle resets all values, then it has 0
                // I have to make a crutch
                if (fontStyle == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    Console.WriteLine(fontStyle);
                }
                
            } 
            while (n != 0);

            Console.WriteLine();
        }

    }
}
