public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        Queue<int> studentsQueue = new Queue<int>(students);
        int i = 0, j = 0, current;
        while( studentsQueue.Count != 0 )
        {
            current = studentsQueue.Dequeue();
            if( sandwiches[i] == current ) {
                i++;
                j = 0;
            } else {
                studentsQueue.Enqueue(current);
                j++;
            }
            if( studentsQueue.Count == j) {
                break;
            }
        }
        return sandwiches.Length - i;
    }
}