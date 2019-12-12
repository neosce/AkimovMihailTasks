namespace Task_4.Tasks.Methods
{
    public class Bubble_Sort
    {

        public void BubbleSortMain(int[] items)
        {
            int temp;
            for (int i = 0; i < items.Length - 1; i++)
            {
                for (int j = i + 1; j < items.Length; j++)
                {
                    if (items[i] > items[j])
                    {
                        temp = items[i];
                        items[i] = items[j];
                        items[j] = temp;
                    }
                }
            }
        }

    }
}
