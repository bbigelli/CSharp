using System;

class Solution
{
    public int solution(int N)
    {
        string binaryRepresentation = Convert.ToString(N, 2);
        int maxGap = 0;
        int currentGap = 0;
        bool counting = false;

        foreach (char c in binaryRepresentation)
        {
            if (c == '1')
            {
                if (counting)
                {
                    maxGap = Math.Max(maxGap, currentGap);
                    currentGap = 0;
                }
                counting = true;
            }
            else if (counting)
            {
                currentGap++;
            }
        }

        return maxGap;
    }
}
