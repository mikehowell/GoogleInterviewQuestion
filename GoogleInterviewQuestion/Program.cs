namespace GoogleInterviewQuestion;

class Program
{
    static void Main(string[] args)
    {
        var fieldLayout = new List<List<int>>
        {
            new() { 0, 1, 1, 0, 1 },
            new() { 1, 1, 0, 1, 0 },
            new() { 0, 1, 1, 1, 0 },
            new() { 1, 1, 1, 1, 0 },
            new() { 1, 1, 1, 1, 1 },
            new() { 0, 0, 0, 0, 0 }
        };

        Console.WriteLine(CalculateGoodGround.LargestSquare(fieldLayout));
    }
}
