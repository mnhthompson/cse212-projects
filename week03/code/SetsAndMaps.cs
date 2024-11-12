using System.Text.Json;
using System.Text.RegularExpressions;

public static class SetsAndMaps
{
    /// <summary>
    /// The words parameter contains a list of two character 
    /// words (lower case, no duplicates). Using sets, find an O(n) 
    /// solution for returning all symmetric pairs of words.  
    ///
    /// For example, if words was: [am, at, ma, if, fi], we would return :
    ///
    /// ["am & ma", "if & fi"]
    ///
    /// The order of the array does not matter, nor does the order of the specific words in each string in the array.
    /// at would not be returned because ta is not in the list of words.
    ///
    /// As a special case, if the letters are the same (example: 'aa') then
    /// it would not match anything else (remember the assumption above
    /// that there were no duplicates) and therefore should not be returned.
    /// </summary>
    /// <param name="words">An array of 2-character words (lowercase, no duplicates)</param>
    /// 

//--------------------------------problem 1-------------------------------------------------------complete-----------------------------------------------------------------
    public static string[] FindPairs(string[] words)
    {
        // TODO Problem 1 - ADD YOUR CODE HERE
        var wordstorage = new HashSet<String>();
        var wordstorage2 = new HashSet<String>();
        var filterlist = new HashSet<String>();
         string y = "";
            foreach (var x in words)
            {wordstorage.Add(x);}     
        foreach (var x in words)
            {
            if (wordstorage.Contains(x))
                y = Reverse(x);
                if (wordstorage.Contains(y))
                {
                    if (filterlist.Contains(x))
                    continue;
                    else
                        if (y == x)
                        continue;
                        else
                        filterlist.Add(x);
                        filterlist.Add(y);
                        wordstorage2.Add($"{x} & {y}");
                }

        }
           String[] stringArray = new String[wordstorage2.Count];
            wordstorage2.CopyTo(stringArray);
            words = stringArray;
        return words;
    }
public static string Reverse( string s )
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}













    /// <summary>
    /// Read a census file and summarize the degrees (education)
    /// earned by those contained in the file.  The summary
    /// should be stored in a dictionary where the key is the
    /// degree earned and the value is the number of people that 
    /// have earned that degree.  The degree information is in
    /// the 4th column of the file.  There is no header row in the
    /// file.
    /// </summary>
    /// <param name="filename">The name of the file to read</param>
    /// <returns>fixed array of divisors</returns>
    /// 

    //  {"Bachelors", 5355},    {"HS-grad", 10501},{"11th", 1175},"Masters", 1723},   {"9th", 514},    {"Some-college", 7291}, {"Assoc-acdm", 1067}, {"Assoc-voc", 1382},{"7th-8th", 646},{"Doctorate", 413}, {"Prof-school", 576}, {"5th-6th", 333},{"10th", 933}, {"1st-4th", 168},{"Preschool", 51}, {"12th", 433},

    //--------------------------------problem 2-------------------------------------------Needs fixed---------------------------------------------------------------------------
    public static Dictionary<string, int> SummarizeDegrees(string filename)
    {
        var degrees = new Dictionary<string, int>();
        int count = 0;
        foreach (var line in File.ReadLines(filename))
        {
            count+=1;
            var fields = line.Split(",");
            // TODO Problem 2 - ADD YOUR CODE HERE

            string degreeU = fields[3];


            if (!degrees.ContainsKey(degreeU))
                {
              
                    degrees[degreeU] = 1;
                }

               
            else
                {
                   
                    degrees[degreeU] += 1;}            

        }

        if (count == 32561)

            return degrees;
        return degrees;
    }
















    /// <summary>
    /// Determine if 'word1' and 'word2' are anagrams.  An anagram
    /// is when the same letters in a word are re-organized into a 
    /// new word.  A dictionary is used to solve the problem.
    /// 
    /// Examples:
    /// is_anagram("CAT","ACT") would return true
    /// is_anagram("DOG","GOOD") would return false because GOOD has 2 O's
    /// 
    /// Important Note: When determining if two words are anagrams, you
    /// should ignore any spaces.  You should also ignore cases.  For 
    /// example, 'Ab' and 'Ba' should be considered anagrams
    /// 
    /// Reminder: You can access a letter by index in a string by 
    /// using the [] notation.
    /// </summary>
    /// 

    //--------------------------------problem 3--------------------------------Complete----------------------------------------------------------------------------
    public static bool IsAnagram(string word1, string word2)
    {
        // TODO Problem 3 - ADD YOUR CODE HERE

        word1 = word1.ToUpper();
        word2 = word2.ToUpper();

       word1 = Regex.Replace(word1," ", "");
       word2 = Regex.Replace(word2," ", "");

       int x = word1.Length;
       int y = word2.Length;



        if (x == y)
        {

            string aa = String.Concat(word1.OrderBy(c => c));
            string bb = String.Concat(word2.OrderBy(c => c));
                if (aa == bb)
                    return true;

                else
                    return false;
        }
        
        else
        {
            return false;
        }
    }






















    /// <summary>
    /// This function will read JSON (Javascript Object Notation) data from the 
    /// United States Geological Service (USGS) consisting of earthquake data.
    /// The data will include all earthquakes in the current day.
    /// 
    /// JSON data is organized into a dictionary. After reading the data using
    /// the built-in HTTP client library, this function will return a list of all
    /// earthquake locations ('place' attribute) and magnitudes ('mag' attribute).
    /// Additional information about the format of the JSON data can be found 
    /// at this website:  
    /// 
    /// https://earthquake.usgs.gov/earthquakes/feed/v1.0/geojson.php
    /// 
    /// </summary>
    /// 

    //--------------------------------problem 5-------------------------------------------------------------------------------------------------------------------------------------
    public static string[] EarthquakeDailySummary()
    {
        const string uri = "https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/all_day.geojson";
        using var client = new HttpClient();
        using var getRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);
        using var jsonStream = client.Send(getRequestMessage).Content.ReadAsStream();
        using var reader = new StreamReader(jsonStream);
        var json = reader.ReadToEnd();
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        var featureCollection = JsonSerializer.Deserialize<FeatureCollection>(json, options);

        // TODO Problem 5:
        // 1. Add code in FeatureCollection.cs to describe the JSON using classes and properties 
        // on those classes so that the call to Deserialize above works properly.
        // 2. Add code below to create a string out each place a earthquake has happened today and its magitude.
        // 3. Return an array of these string descriptions.
        return [];
    }
}