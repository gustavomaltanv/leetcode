public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        int child_i = 0;
        int cookie_j = 0;

        while (child_i < g.Length && cookie_j < s.Length)
        {
            if (s[cookie_j] >= g[child_i])
            {
                child_i++;
            }
            cookie_j++;
        }
        return child_i;
    }
}