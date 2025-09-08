namespace NeetCodeExam.Exercise
{
    public class LeetCode286WallsAndGates
    {
        public void islandsAndTreasure(int[][] grid)
        {
            //int maxInt = 2_147_483_647;
            int row = grid.Length;
            int col = grid[0].Length;
            Queue<int[]> q = new Queue<int[]>();
            HashSet<string> visited = new HashSet<string>();

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (grid[r][c] == 0)
                    {
                        visited.Add($"{r}{c}");
                        int[] chrest = new int[] { r, c };
                        q.Enqueue(chrest);
                    }
                }
            }

            if (q.Count == 0)
            {
                return;
            }

            int[][] directions = new int[][]
            {
                new int[] { 1, 0 },
                new int[] { -1, 0 },
                new int[] { 0, 1 },
                new int[] { 0, -1 }
            };


            while (q.Count > 0)
            {
                var queue = q.Dequeue();
                foreach(var d in directions)
                {
                    var dr = queue[0] + d[0];
                    var dc = queue[1] + d[1];
                    if (
                        //existing path
                        dr < 0 ||
                        dc < 0 ||
                        dr >= row ||
                        dc >= col ||
                        //can't walk path
                        grid[dr][dc] == -1 ||
                        //visited
                        visited.Contains($"{dr}{dc}")
                        )
                    {
                        continue;
                    }

                    q.Enqueue(new int[] { dr, dc });
                    visited.Add($"{dr}{dc}");
                    grid[dr][dc] = grid[queue[0]][queue[1]] + 1;
                }
            };
        }
    }
}
