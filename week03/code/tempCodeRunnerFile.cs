   public static Dictionary<string, int> SummarizeDegrees(string filename)
    {
        var degrees = new Dictionary<string, int>();
        foreach (var line in File.ReadLines(filename))
        {
            var fields = line.Split(",");
            // TODO Problem 2 - ADD YOUR CODE HERE

            string degreeU = fields[3];


           int x = Regex.Count(filename, degreeU);
           //int x = Regex.Matches(filename, degreeU).Count;

            degrees[degreeU] = x;


            

        }

        Console.WriteLine(degrees);

        return degrees;
    }