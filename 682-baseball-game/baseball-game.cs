public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> score = new Stack<int>();
        for(int i = 0; i < operations.Length; i++) {
            if( operations[i] == "C" ) {
                score.Pop();
            }
            else if( operations[i] == "D" ) {
                score.Push(score.Peek() * 2);
            }
            else if( operations[i] == "+" ) {
                int aux1 = score.Pop();
                int aux2 = score.Peek();
                score.Push(aux1);
                score.Push(aux1 + aux2); 
            }
            else {
                score.Push(int.Parse(operations[i]));
            }
        }
        return StackSum(score);
    }

    public int StackSum(Stack<int> stack) {
        int sum = 0;
        while (stack.Count != 0)
        {
            sum += stack.Pop();
        }
        return sum;
    }
}