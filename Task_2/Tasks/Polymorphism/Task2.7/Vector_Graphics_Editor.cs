using System;

namespace Task_2.Tasks.Polymorphism.Task2._7
{

    // Интерфейс графического редактора.
    public class Vector_Graphics_Editor
    {

        public static void MainVGE()
        {

            int n;
            // Это и есть полиморфизм когды мы можем рабоать используя базовый класс с наследником
            Shape[] shapes = new Shape[4];

            //shapes[0] = new Rectangle(5, 10);
            //shapes[1] = new Line(15);
            //shapes[2] = new Circle(15);
            //shapes[3] = new Ring(15,16);
            //foreach (Shape item in shapes)
            //{
            //    item.Draw(5, 10);
            //    item.Area();
            //}

            do
            {

                Console.WriteLine("1 - Line\n2 - Rectangle\n3 - Circle\n4 - Ring\n0 - EXIT");

                var number_list = Console.ReadLine();
                
                if (int.TryParse(number_list, out n) && n < 5)
                {

                    if (n == 0)
                    {
                        break;
                    }

                    Console.WriteLine("Enter coordinates for draw your shape");
                    Console.Write("\nEnter x: ");
                    var x = int.Parse(Console.ReadLine());
                    Console.Write("\nEnter y: ");
                    var y = int.Parse(Console.ReadLine());

                    switch (n)
                    {
                        case 1:
                            //Line

                            Console.WriteLine("\nEnter length: ");
                            var length = double.Parse(Console.ReadLine());

                            shapes[0] = new Line(length);
                            shapes[0].Draw(x, y);
                            break;
                        case 2:
                            //Rectangle

                            Console.Write("\nEnter width: ");
                            var width = double.Parse(Console.ReadLine());
                            Console.Write("\nEnter height: ");
                            var height = double.Parse(Console.ReadLine());

                            shapes[1] = new Rectangle(width, height);
                            shapes[1].Draw(x, y);
                            shapes[1].Area();
                            break;
                        case 3:
                            //Circle

                            Console.Write("\nEnter radius: ");
                            var radius = double.Parse(Console.ReadLine());

                            shapes[2] = new Circle(radius);
                            shapes[2].Draw(x, y);
                            shapes[2].Area();
                            break;
                        case 4:
                            //Ring

                            Console.Write("\nEnter radius: ");
                            var radiusR = double.Parse(Console.ReadLine());
                            Console.Write("\nEnter innerRadius: ");
                            var innerRadius = double.Parse(Console.ReadLine());

                            shapes[3] = new Ring(radiusR, innerRadius);
                            shapes[3].Draw(x, y);
                            shapes[3].Area();
                            break;
                        default:
                            n = 0;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Try once more...");
                }

            } while (n != 0);

        }

    }
}
