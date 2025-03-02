namespace GoogleInterviewQuestion;

public static class CalculateGoodGround
{
    public static int LargestSquare(List<List<int>> fieldLayout)
    {
        var rowCount = fieldLayout.Count;
        var columnCount = fieldLayout[0].Count;
        var largestSquareMatrix = new int[rowCount, columnCount];

        for (var row = 0; row < rowCount; row++)
        {
            for (var col = 0; col < columnCount; col++)
            {
                if (fieldLayout[row][col] == 0) { continue; }

                int above = 0, left = 0, aboveLeft = 0;

                if (row > 0) { above = largestSquareMatrix[row - 1, col]; }

                if (col > 0) { left = largestSquareMatrix[row, col - 1]; }

                if (row > 0 && col > 0) { aboveLeft = largestSquareMatrix[row - 1, col - 1]; }

                largestSquareMatrix[row, col] = Math.Min(above, Math.Min(left, aboveLeft)) + 1;
            }
        }

        return GetMaxValue(largestSquareMatrix);
    }

    private static int GetMaxValue(int[,] largestSquareMatrix)
    {
        var maxValue = int.MinValue;
        var rows = largestSquareMatrix.GetLength(0);
        var cols = largestSquareMatrix.GetLength(1);

        for (var row = 0; row < rows; row++)
        {
            for (var col = 0; col < cols; col++)
            {
                if (largestSquareMatrix[row, col] > maxValue)
                {
                    maxValue = largestSquareMatrix[row, col];
                }
            }
        }

        return maxValue;
    }
}
