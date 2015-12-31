You are playing the following Nim Game with your friend: There is a heap of stones on the table, 
each time one of you take turns to remove 1 to 3 stones. 
The one who removes the last stone will be the winner. You will take the first turn to remove the stones.

Both of you are very clever and have optimal strategies for the game. 
Write a function to determine whether you can win the game given the number of stones in the heap.

For example, if there are 4 stones in the heap, then you will never win the game: 
no matter 1, 2, or 3 stones you remove, the last stone will always be removed by your friend.


public class Solution {
    
    // strategy: the one with 4 remaining must lose
    // A, B players
    // if n == 4k, then at each round B can make A+B both take 4, eventually leave 4 to A, A lose
    // if n == 4k + i (i <= 3), then A can always take i first and B will, finanly lose as he faces above scenario like A
    public bool CanWinNim(int n) {
        return n % 4 != 0;
    }
}