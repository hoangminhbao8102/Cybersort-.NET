namespace Models;

public class Task
{
    public int id { get; set; }
    public string taskName { get; set; } = string.Empty;
    public bool status { get; set; }
}