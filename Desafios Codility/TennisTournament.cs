using System;

class Solution
{
    public int solution(int P, int C)
    {
        int maxGamesPLayers = P / 2;
        int maxGamesCourts = C;

        return Math.Min(maxGamesPLayers, maxGamesCourts);
    }
}

