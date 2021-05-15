using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode.medium
{
    class Solution_36
    {
        //var s = new Solution_36();
        //char[][] shit = new char[9][] {new char[]{'5','3','.','.','7','.','.','.','.'},
        //                                   new char[]{'6','.','.','1','9','5','.','.','.'},
        //                                   new char[]{'.','9','8','.','.','.','.','6','.'},
        //                                   new char[]{'8','.','.','.','6','.','.','.','3'},
        //                                   new char[]{'4','.','.','8','.','3','.','.','1'},
        //                                   new char[]{'7','.','.','.','2','.','.','.','6'},
        //                                   new char[]{'.','6','.','.','.','.','2','8','.'},
        //                                   new char[]{'.','.','.','4','1','9','.','.','5'},
        //                                   new char[]{'.','.','.','.','8','.','.','7','9'}};

        //char[][] shit1 = { new char[9] { '.', '.', '5', '.', '.', '.', '.', '.', '6' }, new char[9] { '.', '.', '.', '.', '1', '4', '.', '.', '.' }, new char[9] { '.', '.', '.', '.', '.', '.', '.', '.', '.' }, new char[9] { '.', '.', '.', '.', '.', '9', '2', '.', '.' }, new char[9] { '5', '.', '.', '.', '.', '2', '.', '.', '.' }, new char[9] { '.', '.', '.', '.', '.', '.', '.', '3', '.' }, new char[9] { '.', '.', '.', '5', '4', '.', '.', '.', '.' }, new char[9] { '3', '.', '.', '.', '.', '.', '4', '2', '.' }, new char[9] { '.', '.', '.', '2', '7', '.', '6', '.', '.' } };

        public bool IsValidSudoku(char[][] board)
        {
            bool[,] row_flags = new bool[9, 9]; 
            bool[,] col_flags = new bool[9, 9];
            for (int i=0;i<board.Length;i++)
            {
                for (int j=0;j<board[i].Length;j++)
                {
                    if (board[i][j] =='.') continue;
                    var position = board[i][j] - '1';
                    if (row_flags[i,position]) 
                        return false; // 判断横向
                    else row_flags[i, position] = true;
                    if (col_flags[position, j] ) 
                        return false; //判断竖向
                    else col_flags[position, j] = true;
                }
            }

            for(int k=0;k<=board.Length-3;k+=3)
            {
                for (int l = 0; l <= board[k].Length-3;l+=3)
                {
                    bool[] flag = new bool[9];
                    
                    for (int i = k; i < k+3; i++)
                    {
                        for (int j = l; j <l+ 3; j++)
                        {
                            if (board[i][j] =='.') continue;
                            var position = board[i][j] - '1';
                            if (flag[position]) 
                                return false; // 判断小九宫格
                            else flag[position] = true;
                        }
                    }
                }
            }
            return true;
           
        }
    }
}
