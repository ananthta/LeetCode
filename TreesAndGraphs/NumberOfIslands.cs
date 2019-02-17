using System;
using System.Collections.Generic;

namespace LeetCode.TreesAndGraphs
{
    public class NumberOfIslands : INumberOfIslands
    {
        public int NumIsLands(char[,] grid)
        {
            var countOfIslands = 0;
            
            for (var i = 0; i < grid.GetLength(0); i++)
            {
                for (var j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] != '1') continue;
                    Dfs(i, j, grid);
                    countOfIslands++;
                }
            }

            return countOfIslands;
        }

        private static void Dfs(int currentRow, int currentCol, char[,] grid)
        {
            grid[currentRow, currentCol] = '0';
            
            if(IsSafe(currentRow+1, currentCol, grid))
                Dfs(currentRow+1, currentCol, grid);
            
            if(IsSafe(currentRow-1, currentCol, grid))
                Dfs(currentRow-1, currentCol, grid);
            
            if(IsSafe(currentRow, currentCol+1, grid))
                Dfs(currentRow, currentCol+1, grid);
            
            if(IsSafe(currentRow, currentCol-1, grid))
                Dfs(currentRow, currentCol-1, grid);
        }
        
        private static bool IsSafe(int currentRow, int currentCol, char[,] grid)
        {
            return (currentRow >= 0) && (currentRow < grid.GetLength(0)) &&
                   (currentCol >= 0) && (currentCol < grid.GetLength(1)) &&
                   grid[currentRow, currentCol] == '1' ;
        }
    }
}