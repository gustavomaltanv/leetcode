public class Solution {
    public int TwoEggDrop(int n) {
        int moves = 0;
        int floors = 0;
        while(floors < n) {
            moves++;
            floors += moves;
        }
        return moves;
    }
}