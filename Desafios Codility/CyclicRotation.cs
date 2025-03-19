public class Solution
{
    public int[] solution(int[] A, int K)
    {
        int N = A.Length;
        if (N == 0) return A;

        K = K % N; // In case K is greater than N
        if (K == 0) return A;

        int[] rotatedArray = new int[N];
        for (int i = 0; i < N; i++)
        {
            rotatedArray[(i + K) % N] = A[i];
        }

        return rotatedArray;
    }
}
