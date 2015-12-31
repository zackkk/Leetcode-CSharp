You are playing the following Flip Game with your friend: 
Given a string that contains only these two characters: + and -, 
you and your friend take turns to flip two consecutive "++" into "--". 
The game ends when a person can no longer make a move and therefore the other person will be the winner.

Write a function to determine if the starting player can guarantee a win.

For example, given s = "++++", return true. The starting player can guarantee a win by flipping the middle "++" to become "+--+".


public class Solution {
    // tricky recursion
    public bool CanWin(string s) {
        if(s == null || s.Length < 2) return false;
        
        for(int i = 0; i < s.Length - 1; i++){
            if(s[i] == '+' && s[i+1] == '+'){
                StringBuilder sb = new StringBuilder(s);
                sb[i] = '-';
                sb[i+1] = '-';
                if(CanWin(sb.ToString()) == false) return true; // point ! 
            }
        }
        return false;
    }
}