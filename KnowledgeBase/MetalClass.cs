namespace KnowledgeBase;

/// <summary>
/// Класс металл
/// </summary>
class MetalClass
{
    public string Name;
    public List<Sign> ValuesForSigns;
    public int Rating;

    /// <summary>
    /// .ctor
    /// </summary>
    /// <param name="s"></param>
    public MetalClass(string s)
    {
        Name = s;
        ValuesForSigns = new List<Sign>();
        Rating = 0;
    }

    /// <summary>
    /// .ctor
    /// </summary>
    public MetalClass()
    {
        ValuesForSigns = new List<Sign>();
        Rating = 0;
    }
}
