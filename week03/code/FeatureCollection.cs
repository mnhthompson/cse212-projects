public class FeatureCollection
{

    public string Type { get; set; }
    public Feature[] features { get; set; }
}

public class Feature
{
    public Properties Properties { get; set; }
}

public class Properties
{
    public double Mag { get; set; }
    public string Place { get; set; }
}