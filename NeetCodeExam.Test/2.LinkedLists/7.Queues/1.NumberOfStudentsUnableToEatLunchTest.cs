using NeetCodeExam.LinkedLists.Queues;

namespace NeetCodeExam.Test.LinkedLists.Queues;

public class NumberOfStudentsUnableToEatLunchTest
{
    public NumberOfStudentsUnableToEatLunch program;
    public NumberOfStudentsUnableToEatLunchTest()
    {
        program = new();
    }

    [Fact]
    public async Task Test()
    {
        int[] students = [1, 0, 0, 1];
        int[] sandwiches = [0, 1, 0, 1];

        int result = program.CountStudents(students, sandwiches);
        Assert.Equal(0, result);
    }

    [Fact]
    public async Task Test2()
    {
        int[] students = [1, 1, 1, 0, 0, 1];
        int[] sandwiches = [1, 0, 0, 0, 1, 1];

        int result = program.CountStudents(students, sandwiches);
        Assert.Equal(3, result);
    }
}
