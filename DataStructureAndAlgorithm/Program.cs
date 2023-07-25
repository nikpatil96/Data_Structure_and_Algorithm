class Program
{

    //Wealth prob

    //public int MaximumWealth(int[][] accounts)
    //{
    //    int sum = 0;
    //    int max = 0;
    //    for (int i = 0; i < accounts.Length; i++)
    //    {
    //        for (int j = 0; i < accounts[i].Length; j++)
    //        {
    //            sum += accounts[i][j];
    //        }

    //        if (max == 0)
    //        {
    //            max = sum;
    //        }
    //        if (max != 0)
    //        {
    //            if (max < sum)
    //            {
    //                max = sum;
    //            }
    //        }
    //    }

    //    return max;
    //}

    //public static void Main()
    //{
     
    //    Console.WriteLine("Enter array Length \n");
    //    int len=Convert.ToInt32(Console.ReadLine());
    //    int[] nums = new int[len];
    //    Console.WriteLine("Enter array elements \n");
    //    for (int i = 0; i < nums.Length; i++)
    //    {           
    //        nums[i] = Convert.ToInt32(Console.ReadLine());
    //    }
    //    Console.WriteLine("Enter Partition number \n");
    //    int n = Convert.ToInt32(Console.ReadLine());
    //    int[] ans = Shuffle(nums, n);
    //    foreach (int answer in ans)
    //    {
    //        Console.WriteLine(answer);
    //    }
    //    Console.ReadLine();
    //}
    static int[] Shuffle(int[] nums, int n)
    {
        int[] ans = new int[nums.Length];
        int index = 0, index1 = 0;
    
        
        while (index<n && index1<nums.Length-1)
        {

            Console.WriteLine("Index " + index + "\t" + index1);
            ans[index1] = nums[index];
            ans[index1+1] = nums[index + n];
            index++;
            index1=index1+2;
        }
        return ans;
    }
}