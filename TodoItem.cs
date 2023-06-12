public class TodoItem
{
    public string? Title { get; set; }
    public bool IsDone { get; set; } = false; 
    public int? Priority { get; set; } = -1; // 0 to 10
    public double Duration { get; set; } // in minutes
    public int Parent { get; set; } = -1; // the id of the parent item
    public DateTime CreationDate { get; } = DateTime.Now;
    public DateTime? CompletionDate { get; set; }
}