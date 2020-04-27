public class Solution {
    public int[] TwoSum(int[] nums, int S) {
            Dictionary<int, int> lookup =new Dictionary<int, int>();

            for(int i = nums.Length - 1; i >= 0; i--)
            {

                int otherInt;
                if(lookup.TryGetValue(S - nums[i], out otherInt))
                {
                    return new int[]{i, otherInt};

                }else if(!lookup.TryGetValue(nums[i], out otherInt))
                {
                    lookup.Add(nums[i], i);
                }
                
                
            }        
        
        return new int[] {0,0};
    }
}