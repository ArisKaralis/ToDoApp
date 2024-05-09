namespace ToDoApp
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category {get; set; }
        public string Priority { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem(int id, string title, string priority, string category)
        {
            Id = id;
            Title = title;
            Category = category;
            Priority = priority;
            IsCompleted = false;
        }

        public override string ToString()
        {
            return $"[{(IsCompleted ? "X" : " ")}] {Id}: {Title} ({Category}, {Priority})";
        }
    }
}