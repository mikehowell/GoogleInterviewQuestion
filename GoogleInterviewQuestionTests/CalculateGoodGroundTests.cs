using Xunit;
using Assert = Xunit.Assert;
using Theory = Xunit.TheoryAttribute;
using System.Collections;
using static GoogleInterviewQuestion.CalculateGoodGround;

namespace GoogleInterviewQuestionTests;

public class CalculateGoodGroundTests
{
    [Fact]
    public void GivenACheckerBoardField_WhenCallingLargestSquare_ShouldReturnOne()
    {
        var fieldLayout = new List<List<int>>
        {
            new() { 0, 1, 0, 1, 0 },
            new() { 1, 0, 1, 0, 1 },
            new() { 0, 1, 0, 1, 0 },
            new() { 1, 0, 1, 0, 1 },
            new() { 0, 1, 0, 1, 0 },
            new() { 1, 0, 1, 0, 1 }
        };

        var actual = LargestSquare(fieldLayout);
        Assert.Equal(1, actual);
    }

    [Theory]
    [ClassData(typeof(TwoByTwoFieldLayout))]
    [ClassData(typeof(ThreeByThreeFieldLayout))]
    [ClassData(typeof(FourByFourFieldLayout))]
    public void GivenAFieldOfAllGoodLand_WhenCallingLargestSquare_ShouldReturnSizeOfFieldArray(List<List<int>> fieldLayout, int expected)
    {
        var actual = LargestSquare(fieldLayout);
        Assert.Equal(expected, actual);
    }

    #region Test Data For GivenAFieldOfAllGoodLand_WhenCallingLargestSquare_ShouldReturnSizeOfFieldArray
    private class TwoByTwoFieldLayout : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return
            [
                new List<List<int>>
                {
                    new() { 1, 1 },
                    new() { 1, 1 }
                }, 2
            ];
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    private class ThreeByThreeFieldLayout : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return
            [
                new List<List<int>>
                {
                    new() { 1, 1, 1 },
                    new() { 1, 1, 1 },
                    new() { 1, 1, 1 }
                }, 3
            ];
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    private class FourByFourFieldLayout : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return
            [
                new List<List<int>>
                {
                    new() { 1, 1, 1, 1 },
                    new() { 1, 1, 1, 1 },
                    new() { 1, 1, 1, 1 },
                    new() { 1, 1, 1, 1 }
                }, 4
            ];
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    #endregion
}
