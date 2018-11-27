public class Solution {
    public int MaxArea(int[] height) {
            int max = 0;
            for(int i = 0; i < height.Length; i++)
            {
                for(int j = i; j < height.Length; j++)
                {
                    int curBucketVol = ((j - i) * Math.Min(height[i], height[j]));
                    max = curBucketVol > max ? curBucketVol : max;
                }
            }
            return max;        
    }
}
