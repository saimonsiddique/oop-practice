public class Resource
{
    public string Title { get; }
    public string Content { get; private set; }
    public ResourceType Type { get; } // e.g., PDF, Video, Link
}

public enum ResourceType { Pdf, Video, Link }