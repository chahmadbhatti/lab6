using System;

public class WorkItem
{
    public static void Main(string[] args)
    {
        // Example usage in the Main method
        WorkItem workItem = new WorkItem("Sample Work", "Description of the work", TimeSpan.FromHours(2));
        Console.WriteLine(workItem.ToString());
    }

    private static int currentId = 0;

    protected int Id { get; set; }
    protected string Title { get; set; }
    protected string Description { get; set; }
    protected TimeSpan JobLength { get; set; }

    public WorkItem()
    {
        Id = GetNextId();
        Title = "Default Title";
        Description = "Default Description";
        JobLength = TimeSpan.Zero;
    }

    public WorkItem(string title, string desc, TimeSpan jobLen)
    {
        Id = GetNextId();
        Title = title;
        Description = desc;
        JobLength = jobLen;
    }

    static WorkItem()
    {
        currentId = 0;
    }

    protected int GetNextId()
    {
        return ++currentId;
    }

    public void Update(string title, TimeSpan jobLen)
    {
        Title = title;
        JobLength = jobLen;
    }

    public override string ToString()
    {
        return string.Format("{0} - {1}", Id, Title);
    }
}
