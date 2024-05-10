using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class Task
    {
        public int TaskId { get; set; }

        [Display(Name = "Task Name")]
        public string? TaskName { get; set; }

        public TaskStatus Status { get; set; }

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "ModifiedDate")]
        public DateTime ModifiedDate { get; set;}

        public enum TaskStatus
        {
            ToDo,
            Done
        }





    }
}
