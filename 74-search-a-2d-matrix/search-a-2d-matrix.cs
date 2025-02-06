public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int n = matrix[0].Length - 1;
        int left = 0, right = matrix.Length - 1;
        while(left <= right) {
            int mid = (right + left) / 2;

            if( target > matrix[mid][n] ) left = mid + 1;
            else if( target < matrix[mid][0] ) right = mid - 1;
            else return SearchLine(matrix[mid], target);   
        }
        return false;
         
    }

    public bool SearchLine(int[] line, int target) {
        int left = 0, right = line.Length - 1;
        while(left <= right) {
            int midLine = (right + left) / 2;

            if(target > line[midLine]) left = midLine + 1;
            else if(target < line[midLine]) right = midLine - 1;
            else return true;
        }
        return false;
    }
}