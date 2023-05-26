interface Mappable
{
    public static string JSON_PROPERTY = "properties: ";
    public static void MapIt(Mappable mappable)
    {
        string finalJSON = $$""" "{{JSON_PROPERTY}} {{{mappable.ToJSON()}}}" """;
        Console.WriteLine(finalJSON);
    }
    public string ToJSON()
    {
        return $"""
        "type": "{GetShape()}", "label": "{GetLabel()}", "marker": "{GetMarker()}"
        """;
    }
    string GetLabel();
    Geometry GetShape();
    string GetMarker();
}

class Building : Mappable
{
    private string name;
    private UsageType usage;
    public Building(string name, UsageType usage) { this.name = name; this.usage = usage; }
    public string GetLabel() => $"{name} ({usage})";
    public Geometry GetShape() => Geometry.POINT;
    public string GetMarker()
    {
        string marker = "";
        switch (usage)
        {
            case UsageType.ENTERTAINMENT:
                marker = $"{Color.GREEN} {PointMarker.TRIANGLE}";
                break;
            case UsageType.RESIDENCE:
                marker = $"{Color.BLUE} {PointMarker.SQUARE}";
                break;
            case UsageType.BUSINNES:
                marker = $"{Color.RED} {PointMarker.PUSH_PIN}";
                break;
            case UsageType.EDUCATION:
                marker = $"{Color.ORANGE} {PointMarker.STAR}";
                break;
            case UsageType.GOVERNMENT:
                marker = $"{Color.RED} {PointMarker.STAR}";
                break;
            default:
                marker = $"{Color.BLACK} {PointMarker.CIRCLE}";
                break;
        }
        return marker;
    }
}

class UtilityLine : Mappable
{
    private string name;
    private UtilityType type;
    public UtilityLine(string name, UtilityType type) { this.name = name; this.type = type; }
    public string GetLabel() => $"{name} ({type})";
    public Geometry GetShape() => Geometry.LINE;
    public string GetMarker()
    {
        string marker = "";
        switch (type)
        {
            case UtilityType.WATER:
                marker = $"{Color.BLUE} {LineMarker.SOLID}";
                break;
            case UtilityType.ELECTRICAL:
                marker = $"{Color.ORANGE} {LineMarker.DASHED}";
                break;
            case UtilityType.FIBER_OPTIC:
                marker = $"{Color.BLUE} {LineMarker.DOTTED}";
                break;
            case UtilityType.GAS:
                marker = $"{Color.RED} {LineMarker.SOLID}";
                break;
            default:
                marker = $"{Color.BLACK} {LineMarker.SOLID}";
                break;
        }
        return marker;
    }
}