public class Solution {
    public int Fib(int n) {
        if(n <= 1) return n;
        int n1 = 0, n2 = 1;
        while (n > 1) {
            int sum = n1 + n2;
            n1 = n2;
            n2 = sum;
            n--;
        }
        return n2;

        /* Resposta com recursão
        if(n <= 1) return n;
        return Fib(n-1) + Fib(n-2);
        */
    }
}