namespace NeetCodeExam.Problems;

public class ValidSudokuTest
{
    ValidSudoku app = new();

    [Fact]
    public void TestValidSudoku_Success_Case1()
    {
        char[][] board =
        [['1','2','.','.','3','.','.','.','.'],
        ['4','.','.','5','.','.','.','.','.'],
        ['.','9','8','.','.','.','.','.','3'],
        ['5','.','.','.','6','.','.','.','4'],
        ['.','.','.','8','.','3','.','.','5'],
        ['7','.','.','.','2','.','.','.','6'],
        ['.','.','.','.','.','.','2','.','.'],
        ['.','.','.','4','1','9','.','.','8'],
        ['.','.','.','.','8','.','.','7','9']];

        bool result = app.IsValidSudoku(board);
        Assert.True(result);
    }

    [Fact]
    public void TestValidSudoku_Success_Case2()
    {
        char[][] board =
        [['1', '2', '.', '.', '3', '.', '.', '.', '.'],
        ['4', '.', '.', '5', '.', '.', '.', '.', '.'],
        ['.', '9', '8', '.', '.', '.', '.', '.', '3'],
        ['5', '.', '.', '.', '6', '.', '.', '.', '4'],
        ['.', '.', '.', '8', '.', '3', '.', '.', '5'],
        ['7', '.', '.', '.', '2', '.', '.', '.', '6'],
        ['.', '.', '.', '.', '.', '.', '2', '.', '.'],
        ['.', '.', '.', '4', '1', '9', '.', '.', '8'],
        ['.', '.', '.', '.', '8', '.', '.', '7', '9']];

        bool result = app.IsValidSudoku(board);
        Assert.True(result);
    }

    [Fact]
    public void TestValidSudoku_Fail_Case1()
    {
        char[][] board =
        [['1','2','.','.','3','.','.','.','.'],
        ['4','.','.','5','.','.','.','.','.'],
        ['.','9','1','.','.','.','.','.','3'],
        ['5','.','.','.','6','.','.','.','4'],
        ['.','.','.','8','.','3','.','.','5'],
        ['7','.','.','.','2','.','.','.','6'],
        ['.','.','.','.','.','.','2','.','.'],
        ['.','.','.','4','1','9','.','.','8'],
        ['.','.','.','.','8','.','.','7','9']];

        bool result = app.IsValidSudoku(board);
        Assert.False(result);
    }

    [Fact]
    public void TestValidSudoku_Fail_Case2()
    {
        char[][] board =
        [['1','2','1','.','3','.','.','.','.'],
        ['4','.','.','5','.','.','.','.','.'],
        ['.','9','.','.','.','.','.','.','3'],
        ['5','.','.','.','6','.','.','.','4'],
        ['.','.','.','8','.','3','.','.','5'],
        ['7','.','.','.','2','.','.','.','6'],
        ['.','.','.','.','.','.','2','.','.'],
        ['.','.','.','4','1','9','.','.','8'],
        ['.','.','.','.','8','.','.','7','9']];

        bool result = app.IsValidSudoku(board);
        Assert.False(result);
    }

    [Fact]
    public void TestValidSudoku_Fail_Case3()
    {
        char[][] board =
        [['.', '.', '4', '.', '.', '.', '6', '3', '.'],
        ['.', '.', '.', '.', '.', '.', '.', '.', '.'],
        ['5', '.', '.', '.', '.', '.', '.', '9', '.'],
        ['.', '.', '.', '5', '6', '.', '.', '.', '.'],
        ['4', '.', '3', '.', '.', '.', '.', '.', '1'],
        ['.', '.', '.', '7', '.', '.', '.', '.', '.'],
        ['.', '.', '.', '5', '.', '.', '.', '.', '.'],
        ['.', '.', '.', '.', '.', '.', '.', '.', '.'],
        ['.', '.', '.', '.', '.', '.', '.', '.', '.']];

        bool result = app.IsValidSudoku(board);
        Assert.False(result);
    }
}
