using System.Collections;

namespace NeetCodeExam.Problems;

public class ValidSudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        Dictionary<int, Dictionary<char, byte>> row = new();
        Dictionary<int, Dictionary<char, byte>> col = new();
        Dictionary<Tuple<int, int>, Dictionary<char, byte>> sqr = new();

        for (int c = 0; c < board[0].Length; c++)
        {
            row.Add(c, new());

        }

        for (int r = 0; r < board.Length; r++)
        {
            col.Add(r, new());
        }

        for (int r = 0; r < board.Length; r++)
        {
            for (int c = 0; c < board[0].Length; c++)
            {
                var tuple = new Tuple<int, int>(r / 3, c / 3);
                if (sqr.ContainsKey(tuple) == false)
                {
                    sqr.Add(tuple, new());
                }
            }
        }

        for (int r = 0; r < board.Length; r++)
        {
            for (int c = 0; c < board[0].Length; c++)
            {
                if (board[r][c] == '.')
                {
                    continue;
                }

                if (row[c].ContainsKey(board[r][c]) ||
                col[r].ContainsKey(board[r][c]) ||
                sqr[new Tuple<int, int>(r / 3, c / 3)].ContainsKey(board[r][c]))
                {
                    return false;
                }

                row[c].Add(board[r][c], 1);
                col[r].Add(board[r][c], 1);
                sqr[new Tuple<int, int>(r / 3, c / 3)].Add(board[r][c], 1);
            }
        }

        return true;
    }
}
