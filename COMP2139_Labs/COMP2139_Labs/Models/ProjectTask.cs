using System.ComponentModel.DataAnnotations;

namespace COMP2139_Labs.Models
{
    public class ProjectTask
    {
        [Key]
        public int ProjectTaskId { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        //fk for project
        public int ProjectId { get; set; }
        //Navigation Property
        // This property will alllow access to the related Project entity from task!
        public Project? Project { get; set; }
    }
}
