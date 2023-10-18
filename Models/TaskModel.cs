namespace Tasky.Models
{
    public class TaskModel

    { //hiru propietate

        public string TaskName { get; set; }
        public bool IsCompleted { get; set; }
        public string Id { get; set; } = Guid.NewGuid().ToString();

    }
}