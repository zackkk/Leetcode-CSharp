There are n bulbs that are initially off. You first turn on all the bulbs. 
Then, you turn off every second bulb. 
On the third round, you toggle every third bulb (turning on if it's off or turning off if it's on). 
For the nth round, you only toggle the last bulb. Find how many bulbs are on after n rounds.

Example:

Given n = 3. 

At first, the three bulbs are [off, off, off].
After first round, the three bulbs are [on, on, on].
After second round, the three bulbs are [on, off, on].
After third round, the three bulbs are [on, off, off]. 

So you should return 1, because there is only one bulb is on.


public class Solution {
    // A bulb ends up on iff it is switched an odd number of times.
    // Bulb i is switched in round d iff d divides i. So bulb i ends up on iff it has an odd number of divisors.
    // Divisors come in pairs, like i=12 has divisors 1 and 12, 2 and 6, and 3 and 4. 
    // Except if i is a square, like 36 has divisors 1 and 36, 2 and 18, 3 and 12, 4 and 9, 
    //                          and double divisor 6. So bulb i ends up on iff and only if i is a square.
    // so count the number of square numbers
    public int BulbSwitch(int n) {
        return (int)Math.Sqrt(n); 
    }
}