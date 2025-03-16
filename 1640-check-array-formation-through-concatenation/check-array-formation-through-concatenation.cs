public class Solution {
    public bool CanFormArray(int[] arr, int[][] pieces) {
        foreach(var piece in pieces) {
            if(piece.Length == 1) {
                if(!arr.Contains(piece[0])) {
                    return false;
                }
            }
            else if(!ContainsPiece(arr, piece)) {
                return false;
            } 
        }
        return true;
    }

    private bool ContainsPiece(int[] arr, int[] piece) {
        int index = Array.IndexOf(arr, piece[0]);
        if(index + piece.Length > arr.Length) return false;

        for(int i = 1; i < piece.Length; i++) {
            if( arr[index + i] != piece[i] ) return false;
        } 

        return true;
    }
}