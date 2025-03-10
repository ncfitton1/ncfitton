public class Solution {
    public bool IsPalindrome(int x) {
        if ( x<0 )
            return false;

        int temp = x;
        int reverse=0;
        while ( temp >= 1 ){
            reverse = (reverse*10) + temp%10;
            temp /= 10;
        }
        return x==reverse;
    }
}