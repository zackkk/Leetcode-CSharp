Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. 
An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. 
You may assume all four edges of the grid are all surrounded by water.

Example 1:
11110
11010
11000
00000
Answer: 1

Example 2:
11000
11000
00100
00011
Answer: 3


public class Solution {
    // dfs + mark visited nodes
    public int NumIslands(char[,] grid) {
        int m = grid.GetLength(0), n = grid.GetLength(1);
        int count = 0;
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i,j] == '1'){
                    dfs(grid, i, j, m, n);
                    count++;
                }
            }
        }
        return count;
    }
    
    void dfs(char[,] grid, int i, int j, int m, int n){
        if(i < 0 || i >= m || j < 0 || j >= n || grid[i,j] != '1') return;
        grid[i,j] = '0';
        dfs(grid, i-1, j, m, n);
        dfs(grid, i+1, j, m, n);
        dfs(grid, i, j-1, m, n);
        dfs(grid, i, j+1, m, n);
    }
}