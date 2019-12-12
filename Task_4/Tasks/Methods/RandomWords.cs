using System;

namespace Task_4.Tasks.Methods
{
    public class RandomWords
    {
        public void ArrayRand(string[] items)
        {
            Random rnd = new Random();
            string[] strRnd = new string[25]
            {
                "создать",
                "неявно",
                "экземпляр",
                "правила",
                "коллекций",
                "демонстрируется",
                "массива",
                "которых",
                "слово",
                "внимание",
                "внутри",
                "объектов",
                "анонимного",
                "типа",
                "содержит",
                "методы",
                "условие",
                "выражения",
                "размер",
                "отсортировать",
                "убыванию",
                "результаты",
                "cобытие",
                "произвольного",
                "упорядочивать"
            };

            Console.Write("Random array: ");
            Console.Write("{ ");
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = strRnd[rnd.Next(0, strRnd.Length)];
                Console.Write(items[i]);
                Console.Write(",");
            }
            Console.Write("}");
        }

    }
}
