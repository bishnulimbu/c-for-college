namespace TodoApp.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public bool IsComplete { get; set; }

        public TodoItem()
        {
            Task = string.Empty;
        }
    }
}
