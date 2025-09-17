namespace NeetCodeExam.Exercise;

public class LeetCode994RottingOranges
{
    public int OrangesRotting(int[][] grid)
    {
        var ROW = grid.Length;
        var COL = grid[0].Length;
        int fresh = 0;
        Queue<int[]> rots = new Queue<int[]>();

        for(int r = 0; r < ROW; r++)
        {
            for(int c = 0;  c < COL; c++)
            {
                if (grid[r][c] == 2)
                {
                    rots.Enqueue(new int[] { r, c });
                }
                else if(grid[r][c] == 1)
                {
                    fresh++; 
                }
            }
        }

        if (rots.Count == 0) {
            return 0;
        }

        int[][] directions = new int[][]
        {
            new int[] {1, 0},
            new int[] {-1, 0},
            new int[] {0, 1},
            new int[] {0, -1},
        };

        int minute = 0;
        while (rots.Count > 0 && fresh > 0)
        {
            var size = rots.Count;
            for (int i = 0; i < size; i++)
            {
                var rot = rots.Dequeue();
                foreach (var d in directions)
                {
                    var r = rot[0] + d[0];
                    var c = rot[1] + d[1];

                    if (
                        //check out of rangr
                        r < 0 || c < 0 || r >= ROW || c >= COL ||
                        //check empty
                        grid[r][c] == 0 ||
                        //check is rotten
                        grid[r][c] == 2
                        )
                    {
                        continue;
                    }

                    grid[r][c] = 2;
                    fresh--;
                    rots.Enqueue(new int[] { r, c });
                }
            }

            minute++;
        }

        return fresh != 0 ? -1 : minute;
    }
}
