using System;

namespace Task_1.Tasks.Basic
{
    public class X_mass_tree
    {

        private void x_mass_treeInput(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    string branch = new string('*', j);
                    Console.WriteLine(branch.PadLeft(n) + "*" + branch);
                }
            }
        }

        public static void x_mass_tree()
        {
            X_mass_tree x_mass_tree = new X_mass_tree();

            Console.WriteLine("X mass tree:\n" + "Input N:");

            var n = int.Parse(Console.ReadLine());

            x_mass_tree.x_mass_treeInput(n);
        }

    }
}
