namespace GoogleInterviewQuestion;

public static class CalculateGoodGround
{
    public static int LargestSquare(List<List<int>> fieldLayout)
    {
        var rowCount = fieldLayout.Count;
        var columnCount = fieldLayout[0].Count;
        var largestSquareMatrix = new int[rowCount, columnCount];
        var maxFieldSize = int.MinValue;

        for (var row = 0; row < rowCount; row++)
        {
            for (var col = 0; col < columnCount; col++)
            {
                if (fieldLayout[row][col] == 0) { continue; }

                largestSquareMatrix[row, col] = CalculateCellValue(row, col, largestSquareMatrix);
                maxFieldSize = Math.Max(maxFieldSize, largestSquareMatrix[row, col]);
            }
        }

        return maxFieldSize;
    }

    private static int CalculateCellValue(int row, int col, int[,] largestSquareMatrix)
    {
        var above = row > 0 ? largestSquareMatrix[row - 1, col] : 0;
        var left = col > 0 ? largestSquareMatrix[row, col - 1] : 0;
        var aboveLeft = row > 0 && col > 0 ? largestSquareMatrix[row - 1, col - 1] : 0;

        return Math.Min(above, Math.Min(left, aboveLeft)) + 1; // the +1 here effectively represents the current cell value from the fieldLayout passed into the LargestSquare method
    }
}
