namespace TaskManagementAPI.Models
{

    public enum TaskStatus
    {
        Unassigned,
        Assigned,
        Completed
    }
    public class TaskItem
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public TaskStatus Status { get; set; }
        public DateTime TaskDue { get; set; }
    }
}
