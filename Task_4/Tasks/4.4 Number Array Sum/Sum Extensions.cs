namespace Task_4.Tasks._4._4_Number_Array_Sum
{
    public static class Sum_Extensions
    {
        public static int IsSum(this int[] items)
        {
            int sum = 0;
            for (int i = 0; i < items.Length; i++)
            {
                sum += items[i];
            }
            return sum;
        }
    }
}
