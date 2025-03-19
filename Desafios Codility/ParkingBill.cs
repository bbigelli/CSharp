using System;

class Solution
{
    public int solution(string E, string L)
    {
        // Parse the entry and exit times
        TimeSpan entryTime = TimeSpan.Parse(E);
        TimeSpan exitTime = TimeSpan.Parse(L);

        // Calculate the total parking duration
        TimeSpan duration = exitTime - entryTime;

        // Calculate the total hours, rounding up for partial hours
        int totalHours = (int)Math.Ceiling(duration.TotalHours);

        // Calculate the total cost
        int cost = 2; // Entrance fee
        if (totalHours > 0)
        {
            cost += 3; // First hour cost
            if (totalHours > 1)
            {
                cost += (totalHours - 1) * 4; // Successive hours cost
            }
        }

        return cost;
    }
}
