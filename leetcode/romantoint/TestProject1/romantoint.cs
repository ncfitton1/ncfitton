public class Solution {
    public int RomanToInt(string s) {
        if(s == null || s.Length<1 || s.Length>15) return -1;
        if(!s.Contains("I") && !s.Contains("V") && !s.Contains("X") && !s.Contains("L") && !s.Contains("C") && !s.Contains("D") && !s.Contains("M")) return -1;

        int result = 0;

        while(s.Length > 0) {
           if(s.EndsWith("IV")) {
                result +=4;
                s = s.Remove(s.Length-2);
                continue;
            }
          if(s.EndsWith("IX")) {
                result +=9;
                s = s.Remove(s.Length-2);
                continue;
            }
            if(s.EndsWith("I")) {
                result +=1;
                s = s.Remove(s.Length-1);
                continue;
            }
            if(s.EndsWith("V")) {
                result +=5;
                s = s.Remove(s.Length-1);
                continue;
            }
            if(s.EndsWith("XL")) {
                result +=40;
                s = s.Remove(s.Length-2);
                continue;
            }
            if(s.EndsWith("XC")) {
                result +=90;
                s = s.Remove(s.Length-2);
                continue;
            }
            if(s.EndsWith("X")) {
                result +=10;
                s = s.Remove(s.Length-1);
                continue;
            }
            if(s.EndsWith("L")) {
                result +=50;
                s = s.Remove(s.Length-1);
                continue;
            }
            if(s.EndsWith("C")) {
                result +=100;
                s = s.Remove(s.Length-1);
                continue;
            }
            if(s.EndsWith("CD")) {
                result +=400;
                s = s.Remove(s.Length-2);
                continue;
            }
            if(s.EndsWith("CM")) {
                result +=900;
                s = s.Remove(s.Length-2);
                continue;
            }
            if(s.EndsWith("D")) {
                result +=500;
                s = s.Remove(s.Length-1);
                continue;
            }
            if(s.EndsWith("M")) {
                result +=1000;
                s = s.Remove(s.Length-1);
                continue;
            }
        }
        
        return result;
    }
}