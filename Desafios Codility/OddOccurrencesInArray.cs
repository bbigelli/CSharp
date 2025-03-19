public class Solution
{
    public int solution(int[] A)
    {
        int unpaired = 0;
        foreach (int number in A)
        {
            unpaired ^= number;
        }
        return unpaired;
    }
}
