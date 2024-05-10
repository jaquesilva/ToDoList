using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class TaskItem
    {
        public int TaskId { get; set; }

        [Display(Name = "Task Name")]
        public string? TaskName { get; set; }
        
        public TaskStatus Status { get; set; }

        [Display(Name = "Created Date")]
        public DateTime TaskCreatedDate { get; set; } = DateTime.Now;

        [Display(Name = "Completed Date")]
        public DateTime TaskCompletedDate { get; set;} 

        public enum TaskStatus
        {
            ToDo,
            Done
        }
    }
}
